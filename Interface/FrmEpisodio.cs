using ObjetoTransferencia;
using RegraNegocio;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmEpisodio : Form
    {
        #region Variável global

        string caminhoImagem = null;
        string focus = string.Empty;
        string titulo = string.Empty; string duracao = string.Empty; string link = string.Empty;
        string sinopse = string.Empty; string imagem = string.Empty; string semImagem = string.Empty;
        Boolean situacao; string numeroEpisodio = string.Empty;
        #endregion

        private void FrmEpisodio_Activated(object sender, EventArgs e)
        {
            if (txtNumeroEpisodio.Text == string.Empty && txtTitulo.Text == string.Empty &&
                txtDuracao.Text == string.Empty && txtLink.Text == string.Empty &&
                txtSinopse.Text == string.Empty && ComboBoxTemporada.Text == string.Empty)
            {
                txtNumeroEpisodio.Focus();
            }
        }

        private void FrmEpisodio_Load(object sender, EventArgs e)
        {
            lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");
        }

        private void CarregarComboBoxTemporada()
        {
            try
            {
                var temporadaRegraNegocio = new TemporadaRegraNegocio();
                var dataTable = temporadaRegraNegocio.CarregarComboBox();
                ComboBoxTemporada.DataSource = dataTable;
                ComboBoxTemporada.ValueMember = "ID";
                ComboBoxTemporada.DisplayMember = "Titulo";
                ComboBoxTemporada.SelectedIndex = -1;
                ComboBoxTemporada.Update();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro.Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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

        #region Limpar dados, enviar dados e preencher dados.

        private void LimparDados()
        {
            CarregarComboBoxTemporada();
            txtNumeroEpisodio.Clear();
            txtTitulo.Clear();
            txtDuracao.Clear();
            txtLink.Clear();
            txtSinopse.Clear();
            pictureBoxEpisodio.Image = null;
        }

        private Episodio Dados()
        {
            try
            {
                var episodio = new Episodio();
                var temporada = new Temporada();

                episodio.ID = Convert.ToInt32(lblIDResult.Text);
                temporada.ID = Convert.ToInt32(ComboBoxTemporada.SelectedValue);
                episodio.IDTemporada = temporada;
                episodio.NumeroEpisodio = txtNumeroEpisodio.Text;
                episodio.Titulo = txtTitulo.Text;
                episodio.Duracao = txtDuracao.Text;
                episodio.Link = txtLink.Text;
                episodio.Sinopse = txtSinopse.Text;

                if (caminhoImagem != null)
                {
                    byte[] imageArray = System.IO.File.ReadAllBytes(caminhoImagem);
                    episodio.Imagem = Convert.ToBase64String(imageArray);
                }
                else if (semImagem == "vazio")
                    episodio.Imagem = string.Empty;
                else
                    episodio.Imagem = imagem;

                episodio.Situacao = checkBoxSituacao.Checked ? true : false;
                episodio.IDUsuarioCadastrou = LoginSistema.UsuarioLogin;
                episodio.IDUsuarioAlterou = LoginSistema.UsuarioLogin;

                return episodio;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void PreencherDados(Episodio episodio)
        {
            lblIDResult.Text = episodio.ID.ToString();
            ComboBoxTemporada.SelectedValue = Convert.ToInt32(episodio.IDTemporada.ID);
            txtNumeroEpisodio.Text = episodio.NumeroEpisodio.ToString();
            txtTemporada.Text = episodio.IDTemporada.Titulo;
            txtTitulo.Text = episodio.Titulo;
            txtDuracao.Text = episodio.Duracao;
            txtLink.Text = episodio.Link;
            txtSinopse.Text = episodio.Sinopse;

            if (episodio.Imagem != string.Empty)
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(episodio.Imagem)));
                pictureBoxEpisodio.Image = img;
            }

            checkBoxSituacao.Checked = episodio.Situacao;

            lblIDUsuarioCadastrouResult.Text = episodio.IDUsuarioCadastrou.ID.ToString();
            lblUsuarioCadastrouResult.Text = episodio.IDUsuarioCadastrou.UsuarioLogin;
            lblNomeCadastrouResult.Text = episodio.IDUsuarioCadastrou.Nome;
            lblDataCadastroResult.Text = episodio.DataCadastro.ToString();

            lblFuncaoCadastrou.Text = episodio.IDUsuarioCadastrou.IDTipoUsuario.Descricao;

            if (episodio.IDUsuarioCadastrou.Imagem != string.Empty)
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(episodio.IDUsuarioCadastrou.Imagem)));
                pictureBoxUsuarioCadastrou.Image = img;
            }

            lblIDUsuarioAlterouResult.Text = episodio.IDUsuarioAlterou.ID == 0 ? "NENHUM" : episodio.IDUsuarioAlterou.ID.ToString();
            lblUsuarioAlterouResult.Text = episodio.IDUsuarioAlterou.UsuarioLogin;
            lblNomeAlterouResult.Text = episodio.IDUsuarioAlterou.Nome;
            lblDataAlteracaoResult.Text = episodio.DataAlteracao.ToString() == "01/01/0001 00:00:00" ? "NENHUM"
                : episodio.DataAlteracao.ToString();

            if (episodio.IDUsuarioAlterou.Imagem != string.Empty)
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(episodio.IDUsuarioAlterou.Imagem)));
                pictureBoxUsuarioAlterou.Image = img;
            }

            lblFuncaoAlterou.Text = episodio.IDUsuarioAlterou.IDTipoUsuario.Descricao;

            titulo = episodio.Titulo;
            duracao = episodio.Duracao;
            link = episodio.Link;
            sinopse = episodio.Sinopse;
            imagem = episodio.Imagem;
            situacao = episodio.Situacao;
            numeroEpisodio = episodio.NumeroEpisodio.ToString();
        }
        #endregion

        public FrmEpisodio(AcaoNaTela acaoNaTela, Episodio episodio)
        {
            InitializeComponent();
            CarregarComboBoxTemporada();

            #region Eliminar oscilação do formulário ou controles da interface

            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            #endregion

            #region Ação na tela

            if (acaoNaTela == AcaoNaTela.Novo)
            {
                checkBoxSituacao.Visible = false;
                lblAtivo.Visible = false;

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
                PreencherDados(episodio);
                txtNumeroEpisodio.Text = episodio.NumeroEpisodio.Replace("º EPISÓDIO", string.Empty);
                lblID.Visible = true;
                lblIDResult.Visible = true;
                btn_Salvar_Atualizar.Text = "ATUALIZAR";
                lblNovoCadastro_Usuario.Text = "EDITAR - (EPISÓDIO)";
            }
            else if (acaoNaTela == AcaoNaTela.Exibir)
            {
                PreencherDados(episodio);

                ComboBoxTemporada.Visible = false;
                txtTemporada.Visible = true;
                txtTemporada.ReadOnly = true;
                lblAstTemporada.Visible = false;
                btnNovo_Temporada.Visible = false;
                checkBoxSituacao.Enabled = false;
                lblID.Visible = true;
                lblIDResult.Visible = true;
                txtNumeroEpisodio.ReadOnly = true;
                lblAstNumeroEpisodio.Visible = false;
                txtTitulo.ReadOnly = true;
                lblAstTitulo.Visible = false;
                if (txtDuracao.PlaceholderText == "00:00:00")
                    txtDuracao.PlaceholderText = string.Empty;
                txtDuracao.ReadOnly = true;
                lblAstDuracao.Visible = false;
                checkBoxMinutos.Enabled = false;
                checkBoxMTotal.Enabled = false;
                txtLink.ReadOnly = true;
                lblAstLink.Visible = false;
                txtSinopse.ReadOnly = true;
                btnCarregar.Visible = false;
                btnEditar.Visible = false;
                btnLimpar.Visible = false;
                btn_Salvar_Atualizar.Visible = false;
                lblNovoCadastro_Usuario.Text = "EXIBIR - (EPISÓDIO)";
                btn_Salvar_Atualizar.Text = string.Empty;

                if (LoginSistema.UsuarioLogin.IDTipoUsuario.IDTipoUsuario == 3)
                {
                    lblIDResult.Visible = false;
                    lblID.Visible = false;
                    checkBoxSituacao.Visible = false;
                    lblAtivo.Visible = false;
                    btnSetaDireita.Visible = false;
                    btnSetaEsquerda.Visible = false;
                    txtLink.Text = string.Empty;
                }
            }
            #endregion
        }

        #region Time Data Hora, Fade in, fade out e formClosing

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

        private void FrmTemporada_FormClosing(object sender, FormClosingEventArgs e)
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

        #region Evento Changed

        private void TextChanged_TextChanged(object sender, EventArgs e)
        {
            txtNumeroEpisodio.MaxLength = 3;
            txtTitulo.MaxLength = 100;

            if (txtDuracao.Text != string.Empty)
            {
                if (!checkBoxMinutos.Checked)
                    txtDuracao.MaxLength = 8;
                else
                    txtDuracao.MaxLength = 4;

                if (checkBoxMTotal.Checked)
                    txtDuracao.MaxLength = 3;
            }

            if (txtNumeroEpisodio.Text != numeroEpisodio || txtTitulo.Text != titulo || 
                txtDuracao.Text != duracao || txtLink.Text != link || 
                txtSinopse.Text != sinopse || checkBoxSituacao.Checked != situacao)
            {
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text + "*";
            }
        }

        private void checkBoxMinutos_CheckedChanged(object sender, EventArgs e)
        {
            txtDuracao.Clear();
            txtDuracao.Focus();

            if (checkBoxMinutos.Checked)
            {
                checkBoxMTotal.Checked = false;
                txtDuracao.PlaceholderText = "0:00";
            }
            else
                txtDuracao.PlaceholderText = "00:00:00";
        }

        private void checkBoxMTotal_CheckedChanged(object sender, EventArgs e)
        {
            txtDuracao.Clear();
            txtDuracao.Focus();

            if (checkBoxMTotal.Checked)
            {
                checkBoxMinutos.Checked = false;
                txtDuracao.PlaceholderText = string.Empty;
            }
            else
                txtDuracao.PlaceholderText = "00:00:00";
        }
        #endregion

        #region Evento Enter

        private void comboBoxTemporada_Enter(object sender, EventArgs e)
        {
            focus = "temporada";
        }

        private void txtNumeroEpisodio_Enter(object sender, EventArgs e)
        {
            focus = "numeroEpisodio";
        }

        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            focus = "titulo";
        }

        private void txtDuracao_Enter(object sender, EventArgs e)
        {
            focus = "duracao";
        }

        private void txtLink_Enter(object sender, EventArgs e)
        {
            focus = "link";
        }

        private void txtSinopse_Enter(object sender, EventArgs e)
        {
            focus = "sinopse";
        }

        private void CampoFocus()
        {
            if (focus == "numeroEpisodio")
                txtNumeroEpisodio.Focus();
            if (focus == "titulo")
                txtTitulo.Focus();
            if (focus == "duracao")
                txtDuracao.Focus();
            if (focus == "link")
                txtLink.Focus();
            if (focus == "sinopse")
                txtSinopse.Focus();
        }
        #endregion;

        #region Evento Leave

        private void comboBoxTemporada_Leave(object sender, EventArgs e)
        {
            lblTemporada.ForeColor = Color.LightGray;
        }

        private void txtNumeroEpisodio_Leave(object sender, EventArgs e)
        {
            lblNumeroEpisodio.ForeColor = Color.LightGray;
        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = Color.LightGray;
        }

        private void txtDuracao_Leave(object sender, EventArgs e)
        {
            lblDuracao.ForeColor = Color.LightGray;
        }

        private void txtLink_Leave(object sender, EventArgs e)
        {
            lblLink.ForeColor = Color.LightGray;
        }
        #endregion;

        #region Evento KeyPress

        private void txtNumeroEpisodio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtDuracao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;

            if (char.IsNumber(e.KeyChar))
            {
                if (btn_Salvar_Atualizar.Text != string.Empty)
                {
                    if (!checkBoxMinutos.Checked && !checkBoxMTotal.Checked)
                    {
                        switch (txtDuracao.TextLength)
                        {
                            case 2:
                                txtDuracao.Text = txtDuracao.Text + ":";
                                txtDuracao.SelectionStart = 3;
                                break;

                            case 5:
                                txtDuracao.Text = txtDuracao.Text + ":";
                                txtDuracao.SelectionStart = 6;
                                break;
                        }
                    }
                    else if (checkBoxMinutos.Checked)
                    {
                        switch (txtDuracao.TextLength)
                        {
                            case 1:
                                txtDuracao.Text = txtDuracao.Text + ":";
                                txtDuracao.SelectionStart = 2;
                                break;
                        }
                    }
                }
            }
        }
        #endregion

        #region Evento click

        private void btnNovo_Temporada_Click(object sender, EventArgs e)
        {
            FrmTemporada frmTemporada = new FrmTemporada(AcaoNaTela.Novo, null);
            frmTemporada.ShowDialog();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            try
            {
                var openFile = new OpenFileDialog();
                openFile.Filter = "Arquivos de imagens JPG e PNG|*.jpg; *.png";
                openFile.Multiselect = false;

                if (openFile.ShowDialog() == DialogResult.OK)
                    caminhoImagem = openFile.FileName;
                else { return; }

                if (caminhoImagem != string.Empty)
                    pictureBoxEpisodio.Load(caminhoImagem);

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

            if (pictureBoxEpisodio.Image != null)
            {
                pictureBoxEpisodio.Image = null;
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text + "*";
            }
        }

        private void btn_Salvar_Atualizar_Click(object sender, EventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#D63D5C");

            if (ComboBoxTemporada.SelectedIndex == -1)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Selecione a temporada desejada.", null).ShowDialog();
                lblTemporada.ForeColor = col;
                ComboBoxTemporada.Focus();
                return;
            }
            if (txtNumeroEpisodio.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite o número do episódio.", null).ShowDialog();
                lblNumeroEpisodio.ForeColor = col;
                txtNumeroEpisodio.Focus();
                return;
            }
            else if (txtTitulo.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite o título do episódio.", null).ShowDialog();
                lblTitulo.ForeColor = col;
                txtTitulo.Focus();
                return;
            }
            else if (txtDuracao.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite a duração do episódio.", null).ShowDialog();
                lblDuracao.ForeColor = col;
                txtDuracao.Focus();
                return;
            }
            else if (!checkBoxMinutos.Checked && !checkBoxMTotal.Checked
                     && txtDuracao.TextLength > 0 && txtDuracao.TextLength < 5
                     || txtDuracao.TextLength == 6 || txtDuracao.TextLength == 7)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite as horas e minutos da temporada corretamente.", null).ShowDialog();
                lblDuracao.ForeColor = col;
                txtDuracao.Focus();
                return;
            }
            else if (checkBoxMinutos.Checked && txtDuracao.TextLength > 0 && txtDuracao.TextLength < 4)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite os minutos e segundos da temporada corretamente.", null).ShowDialog();
                lblDuracao.ForeColor = col;
                txtDuracao.Focus();
                return;
            }
            else if (txtLink.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Adicione a URL do episódio.", null).ShowDialog();
                lblLink.ForeColor = col;
                txtLink.Focus();
                return;
            }

            if (btn_Salvar_Atualizar.Text == "SALVAR")
            {
                var question = new FrmCaixaDialogo("question", "Deseja salvar?", "Salvar").ShowDialog();

                if (question == DialogResult.Yes)
                {
                    Episodio episodio = Dados();
                    var episodioRegraNegocio = new EpisodioRegraNegocio();
                    string retorno = episodioRegraNegocio.Manipulacoes("1", episodio);

                    try
                    {
                        int idEpisodio = Convert.ToInt32(retorno);
                        lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");

                        var caixaDialogo = new FrmCaixaDialogo("sucesso", txtNumeroEpisodio.Text + "º EPISÓDIO - " + txtTitulo.Text + " cadastrado com sucesso.", null).ShowDialog();
                        var caixaDialogoNovo = new FrmCaixaDialogo("question", "Deseja cadastrar novo episódio?", "Novo episódio").ShowDialog();

                        if (caixaDialogoNovo == DialogResult.No)
                        {
                            this.Close();
                        }
                        else
                        {
                            LimparDados();
                            lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");
                            txtNumeroEpisodio.Focus();
                            return;
                        }

                        this.DialogResult = DialogResult.Yes;
                    }
                    catch (FormatException)
                    {
                        var caixaDialogo = new FrmCaixaDialogo("error", "Não foi possível realizar o cadastro. Detalhes: " + retorno, null).ShowDialog();
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
                        Episodio episodio = Dados();
                        var episodioRegraNegocio = new EpisodioRegraNegocio();
                        string retorno = episodioRegraNegocio.Manipulacoes("2", episodio);

                        try
                        {
                            int idEpisodio = Convert.ToInt32(retorno);
                            lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");

                            var caixaDialogo = new FrmCaixaDialogo("sucesso", txtNumeroEpisodio.Text + "º EPISÓDIO - " + txtTitulo.Text + " atualizado com sucesso.", null).ShowDialog();

                            this.Close();

                            this.DialogResult = DialogResult.Yes;
                        }
                        catch (FormatException)
                        {
                            var caixaDialogo = new FrmCaixaDialogo("error", "Não foi possível atualizar as informações. Detalhes: " + retorno, null).ShowDialog();
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
