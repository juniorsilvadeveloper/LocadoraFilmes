using ObjetoTransferencia;
using RegraNegocio;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmLogin : Form
    {
        string focus = string.Empty;

        private void FrmLogin_Activated(object sender, EventArgs e)
        {
            lblLogin.Focus();
        }

        #region Método para arrastar arrastar formulário

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MoverTela_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Fadein, FadeOut

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            /*for (double cont = 0; cont <= 1; cont += 0.1)
            {

                this.Opacity = cont;
                this.Refresh();
                System.Threading.Thread.Sleep(15);
            }
            this.Opacity = 0.90;
            timerFadeIn.Stop();*/
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*for (double cont = 1; cont >= 0; cont -= 0.1)
            {
                this.Opacity = cont;
                this.Refresh();
                System.Threading.Thread.Sleep(15);
            }*/
        }
        #endregion

        #region Minimixar, Maximizar e Fechar

        private void btnFechar_Click(object sender, System.EventArgs e)
        {
            if (lblMessageError.Text == "     Error Message" && txtUsuario.Text != "" && txtUsuario.Text != "Usuário"
                || lblMessageError.Text == "     Error Message" && txtSenha.Text != "" && txtSenha.Text != "Senha")
            {
                var caixaDialogo = new FrmCaixaDialogo("question", "Abortar login?", "Abortar").ShowDialog();

                if (caixaDialogo == DialogResult.Yes)
                    Application.Exit();
                else
                    campoFocus();
            }
            else
                Application.Exit();
        }
        #endregion

        #region Sair e voltar para a tela de login

        private void Fechar(object sender, FormClosedEventArgs e)
        {
            txtUsuario.CharacterCasing = CharacterCasing.Normal;
            txtUsuario.ForeColor = Color.LightSlateGray;
            txtUsuario.Text = "Usuário";

            txtSenha.PasswordChar = '\0';
            txtSenha.ForeColor = Color.LightSlateGray;
            txtSenha.Text = "Senha";

            lblMessageError.Visible = false;
            lblInformacaoPG.Visible = false;
            linkLabelCliqueAqui.Visible = false;

            progressBarLogin.Value = 0;
        }
        #endregion

        #region Placeholder

        private void txtUsuario_Enter(object sender, System.EventArgs e)
        {
            focus = "usuario";

            if (txtUsuario.Text == "Usuário")
            {
                txtUsuario.Text = string.Empty;
                txtUsuario.CharacterCasing = CharacterCasing.Upper;
                txtUsuario.ForeColor = Color.LightGray;
            }           
        }

        private void txtUsuario_Leave(object sender, System.EventArgs e)
        {           
            if (txtUsuario.Text == string.Empty)
            {
                txtUsuario.CharacterCasing = CharacterCasing.Normal;
                txtUsuario.Text = "Usuário";
                txtUsuario.ForeColor = Color.LightSlateGray;
                txtSenha.Focus();
            }
        }

        private void txtSenha_Enter(object sender, System.EventArgs e)
        {
            focus = "senha";

            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = string.Empty;
                txtSenha.ForeColor = Color.LightGray;
                txtSenha.PasswordChar = '*';
            }
        }

        private void txtSenha_Leave(object sender, System.EventArgs e)
        {
            if (txtSenha.Text == string.Empty)
            {
                txtSenha.PasswordChar = '\0';
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.LightSlateGray;
                pictureBoxBloqueioSenha.Visible = true;
                pictureBoxVerSenha.Visible = false;
            }
        }
        #endregion

        #region Foco dos campos

        private void campoFocus()
        {
            if (focus == "usuario")
                txtUsuario.Focus();
            if (focus == "senha")
                txtSenha.Focus();
        }
        #endregion

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void MessageError(string msg)
        {
            lblMessageError.Text = "     " + msg;
            lblMessageError.Visible = true;
        }

        private void btnEntrar_Click(object sender, System.EventArgs e)
        {
            if (txtUsuario.Text == "Usuário")
            {
                txtUsuario.Focus();
                MessageError("Digite o nome de usuário.");
                lblInformacaoPG.Visible = false;
                linkLabelCliqueAqui.Visible = false;
            }
            else if (txtSenha.Text == "Senha")
            {
                txtSenha.Focus();
                MessageError("Digite a senha.");
                lblInformacaoPG.Visible = false;
                linkLabelCliqueAqui.Visible = false;
            }
            else
                backgroundWorkerLogin.RunWorkerAsync();
        }

        private void backgroundWorkerLogin_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            backgroundWorkerLogin.ReportProgress(0);

            var usuario = new Usuario();
            usuario.UsuarioLogin = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;

            backgroundWorkerLogin.ReportProgress(50);

            var usuarioRegraNegocio = new UsuarioRegraNegocio();
            string retornoLogin = usuarioRegraNegocio.validarLogin(usuario);


            if (retornoLogin == "0")
            {
                e.Cancel = true;
                this.DialogResult = DialogResult.Cancel;
            }
            else if (retornoLogin == "-1")
            {
                var caixaDialogo = new FrmCaixaDialogo("error", "Usuário bloqueado.", null).ShowDialog();

                e.Cancel = true;
                this.DialogResult = DialogResult.No;
            }
            else
            {
                usuario = usuarioRegraNegocio.ConsultarCodigoUnico(retornoLogin);
                LoginSistema.UsuarioLogin = usuario;
                backgroundWorkerLogin.ReportProgress(50);
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void backgroundWorkerLogin_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                progressBarLogin.Value = 0;
                MessageError("Usuário ou senha inválida.");
            }

            else if (DialogResult == DialogResult.No)
            {
                progressBarLogin.Value = 0;
                MessageError("Login não permitido. Há mensalidade(s) pendente(s) para este usuário.");
                lblInformacaoPG.Visible = true;
                linkLabelCliqueAqui.Visible = true;
            }
            else
            {
                this.Hide();
                var frmMenuPrincipal = new FrmMenuPrincipal();
                frmMenuPrincipal.Show();
            }
        }

        private void backgroundWorkerLogin_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBarLogin.Increment(e.ProgressPercentage);
        }

        private void lblCadastrese_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frmUsuario = new FrmUsuario(AcaoNaTela.Visitante, null, 0);
            frmUsuario.ShowDialog();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!#$%&()-@_{}.";

            if (!(caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper()) || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void pictureBoxBloqueioSenha_Click(object sender, EventArgs e)
        {
            if(txtSenha.Text != "Senha")
            {
                txtSenha.PasswordChar = '\0';
                pictureBoxBloqueioSenha.Visible = false;
                pictureBoxVerSenha.Visible = true;
            }
        }

        private void pictureBoxVerSenha_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
            pictureBoxBloqueioSenha.Visible = true;
            pictureBoxVerSenha.Visible = false;
        }
    }
}