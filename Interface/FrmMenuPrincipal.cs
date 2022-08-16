using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegraNegocio;

namespace Interface
{
    public partial class FrmMenuPrincipal : Form
    {
        #region Método para redimensionar / alterar tempo de execução do formulário

        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        #endregion

        #region Desenhar retângulo / excluir canto do panel 

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContainerPrincipal.Region = region;
            this.Invalidate();
        }
        #endregion

        #region Cor e retângulo inferior aberto

        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }
        #endregion

        #region Método para mover a tela

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

        #region Diminuir ou expandir Side

        private void PictureBoxMenu_Click(object sender, EventArgs e)
        {
            if (panelSideMenu.Width == 230)
            {
                panelSideMenu.Width = 68;

                btnMenuCadastro.Text = string.Empty;
                btnUsuarioCadastro.Text = string.Empty;
                btnFilmeSerieCadastro.Text = string.Empty;
                btnTemporadaCadastro.Text = string.Empty;
                btnEpsodioCadastro.Text = string.Empty;

                btnMenuConsulta.Text = string.Empty;
                btnUsuarioConsulta.Text = string.Empty;
                btnFilmeSerieConsulta.Text = string.Empty;
                btnTemporadaConsulta.Text = string.Empty;
                btnEpsodiosConsulta.Text = string.Empty;

                btnConfiguracoes.Text = string.Empty;
                btnEditarPerfil.Text = string.Empty;
                btnExcluirConta.Text = string.Empty;
                btnFilmes.Text = string.Empty;
                btnSeries.Text = string.Empty;
            }
            else if (panelSideMenu.Width == 68)
            {
                panelSideMenu.Width = 230;

                btnMenuCadastro.Text = "Cadastros";
                btnUsuarioCadastro.Text = "Usuário";
                btnFilmeSerieCadastro.Text = "Filme | Série";
                btnTemporadaCadastro.Text = "Temporada";
                btnEpsodioCadastro.Text = "Epsódio";

                btnMenuConsulta.Text = "Consultas";
                btnUsuarioConsulta.Text = "Usuário";
                btnFilmeSerieConsulta.Text = "Filme | Série";
                btnTemporadaConsulta.Text = "Temporada";
                btnEpsodiosConsulta.Text = "Epsódios";

                btnConfiguracoes.Text = "Configurações";
                btnEditarPerfil.Text = "Editar Perfil";
                btnExcluirConta.Text = "Excluir Conta";
                btnFilmes.Text = "Filmes";
                btnSeries.Text = "Séries";
            }
        }
        #endregion

        #region Método para abrir Form filho

        private void AbrirFormEmPanel(object formFilho)
        {
            if (this.panelRecipiente.Controls.Count > 0)
                this.panelRecipiente.Controls.RemoveAt(0);
            Form filho = formFilho as Form;
            filho.TopLevel = false;
            filho.Dock = DockStyle.Fill;
            this.panelRecipiente.Controls.Add(filho);
            this.panelRecipiente.Tag = filho;
            filho.Show();
        }
        #endregion

        #region FadeIn, FadeOut

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            /*for (double cont = 0; cont <= 1; cont += 0.1)
            {
                this.Opacity = cont;
                this.Refresh();
                System.Threading.Thread.Sleep(1);
            }
            this.Opacity = 0.96;
            timerFadeIn.Stop();*/
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*for (double cont = 1; cont >= 0; cont -= 0.1)
            {
                this.Opacity = cont;
                this.Refresh();
                System.Threading.Thread.Sleep(15);
            }*/
        }
        #endregion

        public FrmMenuPrincipal()
        {
            InitializeComponent();

            #region Eliminar oscilação do formulário ou controles da interface
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            #endregion

            lblVersao.Text = Application.ProductVersion;

            lblIDResult.Text = LoginSistema.UsuarioLogin.ID.ToString();
            lblNomeResult.Text = LoginSistema.UsuarioLogin.Nome;
            lblUsuarioResult.Text = LoginSistema.UsuarioLogin.UsuarioLogin;

            if (LoginSistema.UsuarioLogin.IDTipoUsuario.IDTipoUsuario == 1)
            {
                lblFuncaoResult.Text = "ADMINISTRADOR";
                btnUsuarioCadastro.Visible = true;
            }
            else if (LoginSistema.UsuarioLogin.IDTipoUsuario.IDTipoUsuario == 2)
            {
                lblFuncaoResult.Text = "COLABORADOR";
                panelSubMenuCadastro.Height = 120;
            }
            else if (LoginSistema.UsuarioLogin.IDTipoUsuario.IDTipoUsuario == 3)
            {
                lblFuncaoResult.Text = "VISITANTE";
                btnMenuCadastro.Visible = false;
                btnMenuConsulta.Visible = false;
                panelSubMenuFilmes_Series.Visible = true;
            }

            if (LoginSistema.UsuarioLogin.Imagem != string.Empty && LoginSistema.UsuarioLogin.Imagem != null)
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(LoginSistema.UsuarioLogin.Imagem)));
                pictureBoxUsuario.Image = img;
            }
        }

        private void tmDataHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void btnMenuCadastro_Click(object sender, EventArgs e)
        {
            if(panelSubMenuCadastro.Visible == false)
                panelSubMenuCadastro.Visible = true;
            else
                panelSubMenuCadastro.Visible = false;
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (panelSubMenuConsulta.Visible == false)
                panelSubMenuConsulta.Visible = true;
            else
                panelSubMenuConsulta.Visible = false;
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            if (panelSubMenuConfiguracoes.Visible == false)
                panelSubMenuConfiguracoes.Visible = true;
            else
                panelSubMenuConfiguracoes.Visible = false;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            var frmUsuario = new FrmUsuario(AcaoNaTela.Novo, null, 0);
            frmUsuario.ShowDialog();
        }

        private void btnUsuarioConsulta_Click(object sender, EventArgs e)
        {
            AbrirFormEmPanel(new FrmUsuarioConsultar());
        }

        private void btnFilmeSerieCadastro_Click(object sender, EventArgs e)
        {
            var frmFilmeSerie = new FrmFilme_Serie(AcaoNaTela.Novo, null);
            frmFilmeSerie.ShowDialog();
        }

        private void btnFilmeSerieConsulta_Click(object sender, EventArgs e)
        {
            AbrirFormEmPanel(new FrmFilme_Serie_Consultar());
        }

        private void btnTemporadaCadastro_Click(object sender, EventArgs e)
        {
            var FrmTemporada = new FrmTemporada(AcaoNaTela.Novo, null);
            FrmTemporada.ShowDialog();
        }

        private void btnTemporadaConsulta_Click(object sender, EventArgs e)
        {
            AbrirFormEmPanel(new FrmTemporadaConsultar());
        }

        private void btnEpsodioCadastro_Click(object sender, EventArgs e)
        {
            var frmEpisodio = new FrmEpisodio(AcaoNaTela.Novo, null);
            frmEpisodio.ShowDialog();
        }

        private void btnEpsodioConsulta_Click(object sender, EventArgs e)
        {
            AbrirFormEmPanel(new FrmEpisodioConsultar());
        }

        private void btnFilmes_Click(object sender, EventArgs e)
        {
            AbrirFormEmPanel(new FrmFilmes());
        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
            AbrirFormEmPanel(new FrmSeries());
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            AbrirFormEmPanel(new FrmFavoritosConsultar());
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            var frmUsuario = new FrmUsuario(AcaoNaTela.Editar, LoginSistema.UsuarioLogin, 1);
            frmUsuario.ShowDialog();
        }

        private void btnExcluirConta_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir sua conta definitivamente?", "Sucesso", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                    return;

                var usuarioRegraNegocio = new UsuarioRegraNegocio();
                string retorno = usuarioRegraNegocio.Manipulacoes("3", LoginSistema.UsuarioLogin);

                int idUsuario = Convert.ToInt32(retorno);

                MessageBox.Show("Usuário excluído com sucesso.", "Sucesso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();

                var frmLogin = new FrmLogin();
                frmLogin.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível realizar a exclusão. Detalhes: " + exception.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var caixaDialogo = new FrmCaixaDialogo("question", "Fazer logoff?", "Logoff").ShowDialog();

            if (caixaDialogo == DialogResult.Yes)
            {
                this.Hide();

                var frmLogin = new FrmLogin();
                frmLogin.Show();
            }
        }

        private void ControlBoxFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
