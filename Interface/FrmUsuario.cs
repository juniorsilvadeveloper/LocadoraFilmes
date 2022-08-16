using ObjetoTransferencia;
using RegraNegocio;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmUsuario : Form
    {
        #region Variável Glogal

        string caminhoFoto = null;
        string focus = string.Empty;
        string email = string.Empty; string telefone = string.Empty; string nome = string.Empty;
        string usuarioLogin = string.Empty; string senha = string.Empty; string imagem = string.Empty;
        string semImagem = string.Empty; Boolean situacao;
        int iConfiguracao = 0;
        #endregion

        private void FrmMarca_Activated(object sender, EventArgs e)
        {
            if(txtEmail.Text == string.Empty && txtTelefoneMovel.Text == string.Empty &&
                txtNome.Text == string.Empty && txtUsuario.Text == string.Empty && txtSenha.Text == string.Empty)
            {
                txtEmail.Focus();
            }
        }

        #region MÉTODO PARA ARRASTAR A TELA PRESSIONANDO A BARRA DE TÍTULO

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

        #region Limpar dados, Enviar dados e Preencher dados

        private void LimparDados()
        {
            txtEmail.Clear();
            txtTelefoneMovel.Clear();
            txtNome.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            checkBoxAdministrador.Checked = false;
            checkBoxColaborador.Checked = false;
            checkBoxSituacao.Checked = true;
            pictureBoxUsuario.Image = null;
        }

        private Usuario Dados()
        {
            Usuario usuario = new Usuario();
            TipoUsuario tipoUsuario = new TipoUsuario();

            if (checkBoxAdministrador.Checked == true)
                tipoUsuario.IDTipoUsuario = 1;
            else if (checkBoxColaborador.Checked == true)
                tipoUsuario.IDTipoUsuario = 2;
            else
                tipoUsuario.IDTipoUsuario = 3;

            try
            {
                usuario.ID = Convert.ToInt32(lblIDResult.Text);
                usuario.Email = txtEmail.Text;
                usuario.Telefone = txtTelefoneMovel.Text;
                usuario.Nome = txtNome.Text;
                usuario.UsuarioLogin = txtUsuario.Text;
                usuario.Senha = txtSenha.Text;

                if (caminhoFoto != null)
                {
                    byte[] imageArray = System.IO.File.ReadAllBytes(caminhoFoto);
                    usuario.Imagem = Convert.ToBase64String(imageArray);
                }
                else if (semImagem == "vazio")
                    usuario.Imagem = string.Empty;
                else
                    usuario.Imagem = imagem;

                usuario.IDTipoUsuario = tipoUsuario;
                usuario.Situacao = checkBoxSituacao.Checked ? true : false;
                usuario.IDUsuarioCadastrou = LoginSistema.UsuarioLogin;
                usuario.IDUsuarioAlterou = LoginSistema.UsuarioLogin;


                if (LoginSistema.UsuarioLogin != null && this.iConfiguracao == 1)
                {
                    LoginSistema.UsuarioLogin.Email = usuario.Email;
                    LoginSistema.UsuarioLogin.Telefone = usuario.Telefone;
                    LoginSistema.UsuarioLogin.Nome = usuario.Nome;
                    LoginSistema.UsuarioLogin.UsuarioLogin = usuario.UsuarioLogin;
                    LoginSistema.UsuarioLogin.Senha = usuario.Senha;                   

                    if (caminhoFoto != null)
                    {
                        byte[] imageArray = System.IO.File.ReadAllBytes(caminhoFoto);
                        LoginSistema.UsuarioLogin.Imagem = Convert.ToBase64String(imageArray);
                    }
                    else if (semImagem == "vazio")
                        LoginSistema.UsuarioLogin.Imagem = string.Empty;                   
                    else
                        LoginSistema.UsuarioLogin.Imagem = imagem;

                    LoginSistema.UsuarioLogin.Situacao = usuario.Situacao;
                    LoginSistema.UsuarioLogin.IDTipoUsuario = usuario.IDTipoUsuario;
                    LoginSistema.UsuarioLogin.IDUsuarioCadastrou = usuario.IDUsuarioCadastrou;
                    LoginSistema.UsuarioLogin.IDUsuarioAlterou = usuario.IDUsuarioAlterou;
                }

                return usuario;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void PreencherDados(Usuario usuario)
        {
            if (usuario.IDTipoUsuario.IDTipoUsuario == 1)
                checkBoxAdministrador.Checked = true;
            else if (usuario.IDTipoUsuario.IDTipoUsuario == 2)
                checkBoxColaborador.Checked = true;
            else
                checkBoxVisitante.Checked = true;

            lblIDResult.Text = usuario.ID.ToString();
            txtEmail.Text = usuario.Email;
            txtTelefoneMovel.Text = usuario.Telefone;
            txtNome.Text = usuario.Nome;
            txtUsuario.Text = usuario.UsuarioLogin;
            txtSenha.Text = usuario.Senha;

            if (usuario.Imagem != string.Empty)
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(usuario.Imagem)));
                pictureBoxUsuario.Image = img;
            }

            checkBoxSituacao.Checked = usuario.Situacao;

            lblIDUsuarioCadastrouResult.Text = usuario.IDUsuarioCadastrou.ID.ToString();
            lblUsuarioCadastrouResult.Text = usuario.IDUsuarioCadastrou.UsuarioLogin;
            lblNomeCadastrouResult.Text = usuario.IDUsuarioCadastrou.Nome;
            lblDataCadastroResult.Text = usuario.DataCadastro.ToString();

            if (usuario.IDUsuarioCadastrou.Imagem != string.Empty)
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(usuario.IDUsuarioCadastrou.Imagem)));
                pictureBoxUsuarioCadastrou.Image = img;
            }

            lblFuncaoCadastrou.Text = usuario.IDUsuarioCadastrou.IDTipoUsuario.Descricao;

            lblIDUsuarioAlterouResult.Text = usuario.IDUsuarioAlterou.ID == 0 ? "NENHUM" : usuario.IDUsuarioAlterou.ID.ToString();
            lblUsuarioAlterouResult.Text = usuario.IDUsuarioAlterou.UsuarioLogin;
            lblNomeAlterouResult.Text = usuario.IDUsuarioAlterou.Nome;
            lblDataAlteracaoResult.Text = usuario.DataAlteracao.ToString() == "01/01/0001 00:00:00" ? "NENHUM" : usuario.DataAlteracao.ToString();

            if (usuario.IDUsuarioAlterou.Imagem != string.Empty)
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(usuario.IDUsuarioAlterou.Imagem)));
                pictureBoxUsuarioAlterou.Image = img;
            }

            lblFuncaoAlterou.Text = usuario.IDUsuarioAlterou.IDTipoUsuario.Descricao;

            email = usuario.Email;
            telefone = usuario.Telefone;
            nome = usuario.Nome;
            usuarioLogin = usuario.UsuarioLogin;
            senha = usuario.Senha;
            imagem = usuario.Imagem;
            situacao = usuario.Situacao;
        }
        #endregion

        public FrmUsuario(AcaoNaTela acaoNaTela, Usuario usuario, int iConfiguracao)
        {
            InitializeComponent();

            #region Eliminar oscilação do formulário ou controles da interface
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            #endregion

            #region Ação na tela

            this.iConfiguracao = iConfiguracao;

            if (acaoNaTela == AcaoNaTela.Novo)
            {
                checkBoxSituacao.Visible = false;
                lblAtivo.Visible = false;
                checkBoxVisitante.Visible = false;
                lblVisitante.Visible = false;
                checkBoxVisitante.Checked = false;

                lblIDUsuarioCadastrouResult.Text = LoginSistema.UsuarioLogin.ID.ToString();
                lblUsuarioCadastrouResult.Text = LoginSistema.UsuarioLogin.UsuarioLogin;
                lblNomeCadastrouResult.Text = LoginSistema.UsuarioLogin.Nome;      

                lblFuncaoCadastrou.Text = "USUÁRIO LOGADO " + "(" + LoginSistema.UsuarioLogin.IDTipoUsuario.Descricao + ")";

                if (LoginSistema.UsuarioLogin.Imagem != string.Empty)
                {
                    var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(LoginSistema.UsuarioLogin.Imagem)));
                    pictureBoxUsuarioCadastrou.Image = img;
                }
            }
            else if (acaoNaTela == AcaoNaTela.Editar)
            {
                PreencherDados(usuario);

                lblID.Visible = true;
                lblIDResult.Visible = true;

                if (usuario.IDTipoUsuario.IDTipoUsuario == 1 || usuario.IDTipoUsuario.IDTipoUsuario == 2)
                {
                    checkBoxVisitante.Visible = false;
                    lblVisitante.Visible = false;
                }
                else
                {
                    checkBoxAdministrador.Visible = false;
                    lblAdministrador.Visible = false;
                    checkBoxColaborador.Visible = false;
                    lblColaborador.Visible = false;
                    checkBoxVisitante.Enabled = false;
                }

                if(LoginSistema.UsuarioLogin.ID != usuario.ID)
                {
                    txtEmail.ReadOnly = true;
                    if (txtTelefoneMovel.PlaceholderText == "(35) 0000-0000")
                        txtTelefoneMovel.PlaceholderText = string.Empty;
                    txtTelefoneMovel.ReadOnly = true;
                    txtNome.ReadOnly = true;
                    txtUsuario.ReadOnly = true;
                    txtSenha.ReadOnly = true;
                    pictureBoxBloqueioSenha.Visible = false;
                    pictureBoxVerSenha.Visible = false;
                    btnCarregar.Visible = false;
                    btnEditar.Visible = false;
                    btnLimpar.Visible = false;
                }
                else
                {
                    checkBoxAdministrador.Visible = false;
                    lblAdministrador.Visible = false;
                    checkBoxColaborador.Visible = false;
                    lblColaborador.Visible = false;
                    checkBoxVisitante.Visible = false;
                    lblVisitante.Visible = false;
                    checkBoxSituacao.Visible = false;
                    lblAtivo.Visible = false;
                }

                btn_Salvar_Atualizar.Text = "ATUALIZAR";
                lblNovoCadastro_Usuario.Text = "EDITAR - (USUÁRIO)";
            }
            else if (acaoNaTela == AcaoNaTela.Exibir)
            {
                PreencherDados(usuario);

                if(checkBoxAdministrador.Checked == true)
                {
                    checkBoxAdministrador.Enabled = false;
                    checkBoxColaborador.Visible = false;
                    lblColaborador.Visible = false;
                    checkBoxVisitante.Visible = false;
                    lblVisitante.Visible = false;
                }
                else if (checkBoxColaborador.Checked == true)
                {
                    checkBoxColaborador.Enabled = false;
                    checkBoxAdministrador.Visible = false;
                    lblAdministrador.Visible = false;
                    checkBoxVisitante.Visible = false;
                    lblVisitante.Visible = false;
                }
                else
                {
                    checkBoxVisitante.Enabled = false;
                    checkBoxAdministrador.Visible = false;
                    lblAdministrador.Visible = false;
                    checkBoxColaborador.Visible = false;
                    lblColaborador.Visible = false;
                }
                checkBoxSituacao.Enabled = false;
                lblID.Visible = true;
                lblIDResult.Visible = true;
                txtEmail.ReadOnly = true;
                if (txtTelefoneMovel.PlaceholderText == "35 0000-0000")
                    txtTelefoneMovel.PlaceholderText = string.Empty;
                    txtTelefoneMovel.ReadOnly = true;
                txtNome.ReadOnly = true;
                txtUsuario.ReadOnly = true;
                txtSenha.ReadOnly = true;
                pictureBoxBloqueioSenha.Visible = false;
                pictureBoxVerSenha.Visible = false;
                btnCarregar.Visible = false;
                btnEditar.Visible = false;
                btnLimpar.Visible = false;
                btn_Salvar_Atualizar.Visible = false;

                lblNovoCadastro_Usuario.Text = "EXIBIR - (USUÁRIO)";
                btn_Salvar_Atualizar.Text = string.Empty;
            }
            else if(acaoNaTela == AcaoNaTela.Visitante)
            {
                checkBoxVisitante.Checked = true;
                checkBoxAdministrador.Visible = false;
                lblAdministrador.Visible = false;
                checkBoxColaborador.Visible = false;
                lblColaborador.Visible = false;
                checkBoxVisitante.Visible = false;
                lblVisitante.Visible = false;
                checkBoxSituacao.Visible = false;
                lblAtivo.Visible = false;
                btnSetaEsquerda.Visible = false;
                btnSetaDireita.Visible = false;
            }
            #endregion
        }

        #region Evento Changed

        private void checkBoxAdministrador_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdministrador.Checked == true)
            {
                lblAdministrador.ForeColor = Color.LightGray;
                lblColaborador.ForeColor = Color.LightGray;
                checkBoxColaborador.Checked = false;
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text + "*";
            }
        }

        private void checkBoxColaborador_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxColaborador.Checked == true)
            {
                lblAdministrador.ForeColor = Color.LightGray;
                lblColaborador.ForeColor = Color.LightGray;
                checkBoxAdministrador.Checked = false;
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text + "*";
            }
        }

        private void TextChanged_TextChanged(object sender, EventArgs e)
        {
            txtEmail.MaxLength = 100;
            if(txtTelefoneMovel.TextLength == 12)
                txtTelefoneMovel.MaxLength = 12;
            txtNome.MaxLength = 100;
            txtUsuario.MaxLength = 100;
            txtSenha.MaxLength = 16;
 
            if (txtEmail.Text != email || txtTelefoneMovel.Text != telefone ||
                txtNome.Text != nome || txtUsuario.Text != usuarioLogin ||
                txtSenha.Text != senha || checkBoxSituacao.Checked != situacao)
            {
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text + "*";
            }
        }

        #endregion

        #region Time Data Hora, FadeIn, FadeOut e Forming Closing

        private void timerDataHora_Tick(object sender, EventArgs e)
        {
            if (btn_Salvar_Atualizar.Text == "SALVAR")
                lblDataCadastroResult.Text = DateTime.Now.ToString("d/MM/yyyy HH:mm:ssss");
        }

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            /*for (double cont = 0; cont <= 1; cont += 0.1)
            {
                this.Opacity = cont;
                this.Refresh();
                System.Threading.Thread.Sleep(1);
            }
            this.Opacity = 0.95;
            timerFadeIn.Stop();*/
        }

        private void FadeOut()
        {
            /*for (double cont = 1; cont >= 0; cont -= 0.1)
            {
                this.Opacity = cont;
                this.Refresh();
                System.Threading.Thread.Sleep(1);
            }*/
        }

        private void FrmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (lblNovoCadastro_Usuario.Text != lblNovoCadastro_Usuario.Text.Replace("*", ""))
            {
                var DialogoFormClosing = new FrmCaixaDialogo("question", 
                    "Algum campo foi prêenchido ou alterado. Deseja cancelar esta operação?", "Cancelar").ShowDialog();

                if (DialogoFormClosing == DialogResult.No)
                {
                    e.Cancel = true;
                    CampoFocus();
                }
                else
                {
                    FadeOut();
                }
            }
            else
            {
                FadeOut();
            }
        }
        #endregion

        #region Evento Enter

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            focus = "email";
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            focus = "telefone";
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            focus = "nome";
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            focus = "usuario";
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            focus = "senha";
        }

        private void CampoFocus()
        {
            if (focus == "email")
                txtEmail.Focus();
            if (focus == "telefone")
                txtTelefoneMovel.Focus();
            if (focus == "nome")
                txtNome.Focus();
            if (focus == "usuario")
                txtUsuario.Focus();
            if (focus == "senha")
                txtSenha.Focus();
        }
        #endregion

        #region Evento Leave

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            lblEmail.ForeColor = Color.LightGray;
        }

        private void txtTelefoneMovel_Leave(object sender, EventArgs e)
        {
            lblTelefoneMovel.ForeColor = Color.LightGray;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            lblNome.ForeColor = Color.LightGray;
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            lblUsuario.ForeColor = Color.LightGray;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            lblSenha.ForeColor = Color.LightGray;
        }

        #endregion

        #region Evento KeyPress

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtTelefoneMovel.TextLength)
                {
                    case 0:
                        txtTelefoneMovel.Text = string.Empty;
                        txtTelefoneMovel.Text = txtTelefoneMovel.Text;
                        txtTelefoneMovel.SelectionStart = 1;
                        break;

                    case 2:
                        txtTelefoneMovel.Text = txtTelefoneMovel.Text + " ";
                        txtTelefoneMovel.SelectionStart = 3;
                        break;

                    case 7:
                        txtTelefoneMovel.Text = txtTelefoneMovel.Text + "-";
                        txtTelefoneMovel.SelectionStart = 8;
                        break;
                }               
            }               
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            string caracteresPermitidos = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!#$%&()-@_{}.";

            if (!(caracteresPermitidos.Contains(e.KeyChar.ToString().ToUpper()) || e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Evento Click

        private void pictureBoxBloqueioSenha_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '\0';
            pictureBoxBloqueioSenha.Visible = false;
            pictureBoxVerSenha.Visible = true;
        }

        private void pictureBoxVerSenha_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
            pictureBoxBloqueioSenha.Visible = true;
            pictureBoxVerSenha.Visible = false;
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                var openFile = new OpenFileDialog();
                openFile.Filter = "Arquivos de imagens JPG e PNG|*.jpg; *.png";
                openFile.Multiselect = false;

                if (openFile.ShowDialog() == DialogResult.OK)
                    caminhoFoto = openFile.FileName;
                else { return; }

                if (caminhoFoto != string.Empty)
                    pictureBoxUsuario.Load(caminhoFoto);

                if (lblIDUsuarioCadastrouResult.Text == lblIDResult.Text)
                    pictureBoxUsuarioCadastrou.Load(caminhoFoto);

                if (lblIDUsuarioAlterouResult.Text == lblIDResult.Text)
                    pictureBoxUsuarioAlterou.Load(caminhoFoto);

                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text + "*";
            }
            catch (Exception exception)
            {
                MessageBox.Show("Não foi possível carregar a imagem. Detalhes: " + exception, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            semImagem = "vazio";

            if (pictureBoxUsuario.Image != null)
            {
                pictureBoxUsuario.Image = null;
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text + "*";

                if (lblIDUsuarioCadastrouResult.Text == lblIDResult.Text)
                    pictureBoxUsuarioCadastrou.Image = null;

                if (lblIDUsuarioAlterouResult.Text == lblIDResult.Text)
                    pictureBoxUsuarioAlterou.Image = null;
            }
        }

        private void btn_Salvar_Atualizar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string nomeReal = nome.Replace(" ", "").RemoverAcentos();
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#D63D5C");

            if (checkBoxAdministrador.Checked == false && checkBoxColaborador.Checked == false
                && checkBoxVisitante.Checked == false)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Escolha a função do usuário para administrador ou colaborador.", null).ShowDialog();
                lblAdministrador.ForeColor = col;
                lblColaborador.ForeColor = col;
                return;
            }
            else if (txtEmail.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Adicione um email.", null).ShowDialog();
                lblEmail.ForeColor = col;
                txtEmail.Focus();
                return;
            }
            else if (txtTelefoneMovel.TextLength > 0 && txtTelefoneMovel.TextLength < 12)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite corretamente o número do seu telefone.", null).ShowDialog();
                lblTelefoneMovel.ForeColor = col;
                txtTelefoneMovel.Focus();
                return;
            }
            else if (txtNome.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite o seu nome.", null).ShowDialog();
                lblNome.ForeColor = col;
                txtNome.Focus();
                return;
            }
            else if (txtUsuario.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Crie um nome de usuário login.", null).ShowDialog();
                lblUsuario.ForeColor = col;
                txtUsuario.Focus();
                return;
            }
            else if (txtSenha.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Crie uma senha.", null).ShowDialog();
                lblSenha.ForeColor = col;
                txtSenha.Focus();
                return;
            }
            /*else if (txtSenha.TextLength > 0 && txtSenha.TextLength < 8)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "A senha deve conter entre 8 a 16 caracteres.").ShowDialog();
                lblSenha.ForeColor = col;
                txtSenha.Focus();
                return;
            }*/
            else if (nomeReal == txtUsuario.Text)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "O nome de usuário não pode ser igual ao nome próprio.", null).ShowDialog();
                lblUsuario.ForeColor = col;
                txtUsuario.Focus();
                return;
            }

            if (btn_Salvar_Atualizar.Text == "SALVAR")
            {
                var question = new FrmCaixaDialogo("question", "Deseja salvar?", "Salvar").ShowDialog();

                if (question == DialogResult.Yes)
                {                    
                    Usuario usuario = Dados();
                    var usuarioRegraNegocio = new UsuarioRegraNegocio();
                    string retorno = usuarioRegraNegocio.Manipulacoes("1", usuario);

                    try
                    {
                        int idUsuario = Convert.ToInt32(retorno);
                        lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");

                        if(!checkBoxVisitante.Checked)
                        {
                            var caixaDialogo = new FrmCaixaDialogo("sucesso", "Usuário " + txtUsuario.Text + " cadastrado com sucesso.", null).ShowDialog();
                            var caixaDialogoNovo = new FrmCaixaDialogo("question", "Deseja cadastrar novo usuário?", "Novo usuário").ShowDialog();

                            if (caixaDialogoNovo == DialogResult.No)
                            {
                                this.Close();
                            }
                            else
                            {
                                LimparDados();
                                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");
                                txtEmail.Focus();
                                return;
                            }
                            this.DialogResult = DialogResult.Yes;
                        }
                        else
                        {
                            var caixaDialogo = new FrmCaixaDialogo("sucesso", "Usuário " + txtUsuario.Text + " cadastrado com sucesso.", null).ShowDialog();
                            this.Close();
                        }
                    }
                    catch (FormatException)
                    {
                        var caixaDialogo = new FrmCaixaDialogo("error", retorno, null).ShowDialog();
                        CampoFocus();
                    }
                }
                else
                {
                    CampoFocus();
                }
            }
            else
            {
                if (lblNovoCadastro_Usuario.Text != lblNovoCadastro_Usuario.Text.Replace("*", ""))
                {
                    var question = new FrmCaixaDialogo("question", "Deseja atualizar as informações?", "Atualizar").ShowDialog();

                    if (question == DialogResult.Yes)
                    {
                        Usuario usuario = Dados();
                        var usuarioRegraNegocio = new UsuarioRegraNegocio();
                        string retorno = usuarioRegraNegocio.Manipulacoes("2", usuario);

                        try
                        {
                            int idUsuario = Convert.ToInt32(retorno);
                            lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");
                            var caixaDialogo = new FrmCaixaDialogo("sucesso", "Usuário " + txtUsuario.Text + " atualizado com sucesso.", null).ShowDialog();
                            this.Close();
                            this.DialogResult = DialogResult.Yes;
                        }
                        catch (FormatException)
                        {
                            var caixaDialogo = new FrmCaixaDialogo("error", retorno, null).ShowDialog();
                            CampoFocus();
                        }
                    }
                    else
                    {
                        CampoFocus();
                    }
                }
                else
                {
                    var question = new FrmCaixaDialogo("warning", "Nenhuma alteração foi feita.", null).ShowDialog();
                }
            }
        }

        private void btnSetaEsquerda_Click(object sender, EventArgs e)
        {
            panelCenter.Visible = true;
            CampoFocus();
        }

        private void btnSetaDireita_Click(object sender, EventArgs e)
        {
            panelCenter.Visible = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
