using ObjetoTransferencia;
using RegraNegocio;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmTemporada : Form
    {
        #region Variável global

        string caminhoImagem = null;
        string focus = string.Empty;
        string titulo = string.Empty; string geneero = string.Empty; string duracao = string.Empty;
        string ano = string.Empty; string classificacao = string.Empty; string origem = string.Empty;
        string produtorEditora = string.Empty; string sinopse = string.Empty; string imagem = string.Empty;
        string semImagem = string.Empty; Boolean situacao; string numeroTemporada = string.Empty;
        #endregion

        private void FrmTemporada_Activated(object sender, EventArgs e)
        {
            if(txtNumeroTemporada.Text == string.Empty && txtTitulo.Text == string.Empty && txtGenero.Text == string.Empty &&
                txtDuracao.Text == string.Empty && txtAno.Text == string.Empty && txtClassificacao.Text == string.Empty &&
                txtOrigem.Text == string.Empty && txtProdutorEditora.Text == string.Empty && txtSinopse.Text == string.Empty &&
                ComboBoxSerie.Text == string.Empty)
            {
                txtNumeroTemporada.Focus();
            }
        }

        private void FrmTemporada_Load(object sender, EventArgs e)
        {
            lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");
        }

        private void CarregarComboBoxFilme_Serie()
        {
            try
            {
                var filme_Serie_RegraNegocio = new Filme_Serie_RegraNegocio();
                var dataTable = filme_Serie_RegraNegocio.CarregarComboBox();
                ComboBoxSerie.DataSource = dataTable;
                ComboBoxSerie.ValueMember = "ID";
                ComboBoxSerie.DisplayMember = "Titulo";
                ComboBoxSerie.SelectedIndex = -1;
                ComboBoxSerie.Update();
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
            CarregarComboBoxFilme_Serie();
            txtNumeroTemporada.Clear();
            txtTitulo.Clear();
            txtGenero.Clear();
            txtDuracao.Clear();
            txtAno.Clear();
            txtClassificacao.Clear();
            txtOrigem.Clear();
            txtProdutorEditora.Clear();
            txtSinopse.Clear();
            pictureBoxTemporada.Image = null;
        }

        private Temporada Dados()
        {
            try
            {
                var temporada = new Temporada();
                var filme_Serie = new Filme_Serie();

                temporada.ID = Convert.ToInt32(lblIDResult.Text);
                filme_Serie.ID = Convert.ToInt32(ComboBoxSerie.SelectedValue);
                temporada.IDFilme_Serie = filme_Serie;
                temporada.NumeroTemporada = txtNumeroTemporada.Text;
                temporada.Titulo = txtTitulo.Text;
                temporada.Genero = txtGenero.Text;
                temporada.Duracao = txtDuracao.Text;
                temporada.Ano = Convert.ToInt32(txtAno.Text);
                temporada.Classificacao = Convert.ToInt32(txtClassificacao.Text);
                temporada.Origem = txtOrigem.Text;
                temporada.Produtor_Editora = txtProdutorEditora.Text;
                temporada.Sinopse = txtSinopse.Text;

                if (caminhoImagem != null)
                {
                    byte[] imageArray = System.IO.File.ReadAllBytes(caminhoImagem);
                    temporada.Imagem = Convert.ToBase64String(imageArray);
                }
                else if (semImagem == "vazio")
                    temporada.Imagem = string.Empty;
                else
                    temporada.Imagem = imagem;

                temporada.Situacao = checkBoxSituacao.Checked ? true : false;
                temporada.IDUsuarioCadastrou = LoginSistema.UsuarioLogin;
                temporada.IDUsuarioAlterou = LoginSistema.UsuarioLogin;

                return temporada;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void PreencherDados(Temporada temporada)
        {
            lblIDResult.Text = temporada.ID.ToString();
            ComboBoxSerie.SelectedValue = Convert.ToInt32(temporada.IDFilme_Serie.ID);
            txtSerie.Text = temporada.IDFilme_Serie.Titulo;
            txtNumeroTemporada.Text = temporada.NumeroTemporada.ToString();
            txtTitulo.Text = temporada.Titulo;
            txtGenero.Text = temporada.Genero;
            txtDuracao.Text = temporada.Duracao;
            txtAno.Text = temporada.Ano.ToString();
            txtClassificacao.Text = temporada.Classificacao.ToString();
            txtOrigem.Text = temporada.Origem;
            txtProdutorEditora.Text = temporada.Produtor_Editora;
            txtSinopse.Text = temporada.Sinopse;

            if (temporada.Imagem != string.Empty)
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(temporada.Imagem)));
                pictureBoxTemporada.Image = img;
            }

            checkBoxSituacao.Checked = temporada.Situacao;

            lblIDUsuarioCadastrouResult.Text = temporada.IDUsuarioCadastrou.ID.ToString();
            lblUsuarioCadastrouResult.Text = temporada.IDUsuarioCadastrou.UsuarioLogin;
            lblNomeCadastrouResult.Text = temporada.IDUsuarioCadastrou.Nome;
            lblDataCadastroResult.Text = temporada.DataCadastro.ToString();

            lblFuncaoCadastrou.Text = temporada.IDUsuarioCadastrou.IDTipoUsuario.Descricao;

            if (temporada.IDUsuarioCadastrou.Imagem != string.Empty)
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(temporada.IDUsuarioCadastrou.Imagem)));
                pictureBoxUsuarioCadastrou.Image = img;
            }

            lblIDUsuarioAlterouResult.Text = temporada.IDUsuarioAlterou.ID == 0 ? "NENHUM" : temporada.IDUsuarioAlterou.ID.ToString();
            lblUsuarioAlterouResult.Text = temporada.IDUsuarioAlterou.UsuarioLogin;
            lblNomeAlterouResult.Text = temporada.IDUsuarioAlterou.Nome;
            lblDataAlteracaoResult.Text = temporada.DataAlteracao.ToString() == "01/01/0001 00:00:00" ? "NENHUM"
                : temporada.DataAlteracao.ToString();

            if (temporada.IDUsuarioAlterou.Imagem != string.Empty)
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(temporada.IDUsuarioAlterou.Imagem)));
                pictureBoxUsuarioAlterou.Image = img;
            }

            lblFuncaoAlterou.Text = temporada.IDUsuarioAlterou.IDTipoUsuario.Descricao;

            titulo = temporada.Titulo;
            geneero = temporada.Genero;
            duracao = temporada.Duracao;
            ano = temporada.Ano.ToString();
            classificacao = temporada.Classificacao.ToString();
            origem = temporada.Origem;
            produtorEditora = temporada.Produtor_Editora;
            sinopse = temporada.Sinopse;
            imagem = temporada.Imagem;
            situacao = temporada.Situacao;
            numeroTemporada = temporada.NumeroTemporada.ToString();
        }
        #endregion

        public FrmTemporada(AcaoNaTela acaoNaTela, Temporada temporada)
        {
            InitializeComponent();
            CarregarComboBoxFilme_Serie();

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
                PreencherDados(temporada);
                txtNumeroTemporada.Text = temporada.NumeroTemporada.Replace("ª TEMPORADA", string.Empty).ToString();
                lblID.Visible = true;
                lblIDResult.Visible = true;
                btn_Salvar_Atualizar.Text = "ATUALIZAR";
                lblNovoCadastro_Usuario.Text = "EDITAR - (TEMPORADA)";
            }
            else if (acaoNaTela == AcaoNaTela.Exibir)
            {
                PreencherDados(temporada);

                lblAstSerie.Visible = false;
                ComboBoxSerie.Visible = false;
                txtSerie.Visible = true;
                txtSerie.ReadOnly = true;
                btnNovo_Serie.Visible = false;
                checkBoxSituacao.Enabled = false;
                lblID.Visible = true;
                lblIDResult.Visible = true;
                lblAstNumeroTemporada.Visible = false;
                txtNumeroTemporada.ReadOnly = true;
                lblAstTitulo.Visible = false;
                txtTitulo.ReadOnly = true;
                lblAstGenero.Visible = false;
                txtGenero.ReadOnly = true;
                if (txtDuracao.PlaceholderText == "00:00:00")
                    txtDuracao.PlaceholderText = string.Empty;
                txtDuracao.ReadOnly = true;
                checkBoxMinutos.Enabled = false;
                checkBoxMTotal.Enabled = false;
                lblAstAno.Visible = false;
                txtAno.ReadOnly = true;
                lblAstClassificacao.Visible = false;
                txtClassificacao.ReadOnly = true;
                txtOrigem.ReadOnly = true;
                lblAstProdutorEditora.Visible = false;
                txtProdutorEditora.ReadOnly = true;
                txtSinopse.ReadOnly = true;
                btnCarregar.Visible = false;
                btnEditar.Visible = false;
                btnLimpar.Visible = false;
                btn_Salvar_Atualizar.Visible = false;
                lblNovoCadastro_Usuario.Text = "EXIBIR - (TEMPORADA)";
                btn_Salvar_Atualizar.Text = string.Empty;

                if (LoginSistema.UsuarioLogin.IDTipoUsuario.IDTipoUsuario == 3)
                    lblIDResult.Visible = false;
                    lblID.Visible = false;
                    checkBoxSituacao.Visible = false;
                    lblAtivo.Visible = false;
                    btnSetaDireita.Visible = false;
                    btnSetaEsquerda.Visible = false;
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
            txtNumeroTemporada.MaxLength = 3;
            txtTitulo.MaxLength = 100;
            txtGenero.MaxLength = 100;

            if (txtDuracao.Text != string.Empty)
            {
                if (!checkBoxMinutos.Checked)
                    txtDuracao.MaxLength = 8;
                else
                    txtDuracao.MaxLength = 4;

                if (checkBoxMTotal.Checked)
                    txtDuracao.MaxLength = 3;
            }

            txtAno.MaxLength = 4;
            txtClassificacao.MaxLength = 2;
            txtOrigem.MaxLength = 100;
            txtProdutorEditora.MaxLength = 100;

            if (txtNumeroTemporada.Text != numeroTemporada ||
                txtTitulo.Text != titulo || txtGenero.Text != geneero || txtDuracao.Text != duracao ||
                txtAno.Text != ano || txtClassificacao.Text != classificacao || txtOrigem.Text != origem ||
                txtProdutorEditora.Text != produtorEditora || txtSinopse.Text != sinopse ||
                checkBoxSituacao.Checked != situacao)
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

        private void txtNumeroTemporada_Enter(object sender, EventArgs e)
        {
            focus = "numeroEpisodio";
        }

        private void txtTituloTemporada_Enter(object sender, EventArgs e)
        {
            focus = "titulo";
        }

        private void txtGenero_Enter(object sender, EventArgs e)
        {
            focus = "genero";
        }

        private void txtDuracao_Enter(object sender, EventArgs e)
        {
            focus = "duracao";
        }

        private void txtAno_Enter(object sender, EventArgs e)
        {
            focus = "ano";
        }

        private void txtClassificacao_Enter(object sender, EventArgs e)
        {
            focus = "classificacao";
        }

        private void txtOrigem_Enter(object sender, EventArgs e)
        {
            focus = "origem";
        }

        private void txtProdutorEditora_Enter(object sender, EventArgs e)
        {
            focus = "produtorEditora";
        }

        private void txtSinopse_Enter(object sender, EventArgs e)
        {
            focus = "sinopse";
        }

        private void CampoFocus()
        {
            if (focus == "numeroEpisodio")
                txtNumeroTemporada.Focus();
            if (focus == "titulo")
                txtTitulo.Focus();
            if (focus == "genero")
                txtGenero.Focus();
            if (focus == "duracao")
                txtDuracao.Focus();
            if (focus == "ano")
                txtAno.Focus();
            if (focus == "classificacao")
                txtClassificacao.Focus();
            if (focus == "origem")
                txtOrigem.Focus();
            if (focus == "produtorEditora")
                txtProdutorEditora.Focus();
            if (focus == "sinopse")
                txtSinopse.Focus();
        }
        #endregion

        #region Evento Leave

        private void comboBoxSerie_Leave(object sender, EventArgs e)
        {
            lblSerie.ForeColor = Color.LightGray;
        }

        private void txtNumeroTemporada_Leave(object sender, EventArgs e)
        {
            lblNumeroTemporada.ForeColor = Color.LightGray;
        }

        private void txtTitulo_Leave(object sender, EventArgs e)
        {
            lblTitulo.ForeColor = Color.LightGray;
        }

        private void txtGenero_Leave(object sender, EventArgs e)
        {
            lblGenero.ForeColor = Color.LightGray;
        }

        private void txtDuracao_Leave(object sender, EventArgs e)
        {
            lblDuracao.ForeColor = Color.LightGray;
        }

        private void txtAno_Leave(object sender, EventArgs e)
        {
            lblAno.ForeColor = Color.LightGray;
        }

        private void txtClassificacao_Leave(object sender, EventArgs e)
        {
            lblClassificacao.ForeColor = Color.LightGray;
        }

        private void txtProdutorEditora_Leave(object sender, EventArgs e)
        {
            lblProdutorEditora.ForeColor = Color.LightGray;
        }
        #endregion

        #region Evento KeyPress

        private void txtNumeroTemporada_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtClassificacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
        #endregion

        #region Evento Click

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            var frmFilmeSerie = new FrmFilme_Serie(AcaoNaTela.Novo, null);
            frmFilmeSerie.ShowDialog();
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
                    pictureBoxTemporada.Load(caminhoImagem);

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

            if (pictureBoxTemporada.Image != null)
            {
                pictureBoxTemporada.Image = null;
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text + "*";
            }
        }

        private void btn_Salvar_Atualizar_Click(object sender, EventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#D63D5C");

            if (ComboBoxSerie.SelectedIndex == -1)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Selecione a série desejada.", null).ShowDialog();
                lblSerie.ForeColor = col;
                ComboBoxSerie.Focus();
                return;
            }
            if (txtNumeroTemporada.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite o número da temporada.", null).ShowDialog();
                lblNumeroTemporada.ForeColor = col;
                txtNumeroTemporada.Focus();
                return;
            }
            else if (txtTitulo.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite o título da temporada.", null).ShowDialog();
                lblTitulo.ForeColor = col;
                txtTitulo.Focus();
                return;
            }
            else if (txtGenero.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite o gênero da temporada.", null).ShowDialog();
                lblGenero.ForeColor = col;
                txtGenero.Focus();
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
            else if (txtAno.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite o ano do lançamento.", null).ShowDialog();
                lblAno.ForeColor = col;
                txtAno.Focus();
                return;
            }
            else if (txtAno.TextLength > 0 && txtAno.TextLength < 4)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite o ano da temporada corretamente.", null).ShowDialog();
                lblAno.ForeColor = col;
                txtAno.Focus();
                return;
            }
            else if (txtClassificacao.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite a classificação de idade.", null).ShowDialog();
                lblClassificacao.ForeColor = col;
                txtClassificacao.Focus();
                return;
            }
            else if (txtProdutorEditora.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Produtor(a) | Editor(a) obrigatório.", null).ShowDialog();
                lblProdutorEditora.ForeColor = col;
                txtProdutorEditora.Focus();
                return;
            }

            if (btn_Salvar_Atualizar.Text == "SALVAR")
            {
                var question = new FrmCaixaDialogo("question", "Deseja salvar?", "Salvar").ShowDialog();

                if (question == DialogResult.Yes)
                {
                    Temporada temporada = Dados();
                    var temporadaRegraNegocio = new TemporadaRegraNegocio();
                    string retorno = temporadaRegraNegocio.Manipulacoes("1", temporada);

                    try
                    {
                        int idTemporada = Convert.ToInt32(retorno);
                        lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");

                        var caixaDialogo = new FrmCaixaDialogo("sucesso", txtTitulo.Text + " - " + txtNumeroTemporada.Text + "ª TEMPORADA cadastrada com sucesso.", null).ShowDialog();
                        var caixaDialogoNovo = new FrmCaixaDialogo("question", "Deseja cadastrar nova temporada?", "Nova temporada").ShowDialog();

                        if (caixaDialogoNovo == DialogResult.No)
                        {
                            this.Close();
                        }
                        else
                        {
                            LimparDados();
                            lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");
                            txtNumeroTemporada.Focus();
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
                        Temporada temporada = Dados();
                        var temporadaRegraNegocio = new TemporadaRegraNegocio();
                        string retorno = temporadaRegraNegocio.Manipulacoes("2", temporada);

                        try
                        {
                            int idTemporada = Convert.ToInt32(retorno);
                            lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");

                            var caixaDialogo = new FrmCaixaDialogo("sucesso", txtTitulo.Text + " - " + txtNumeroTemporada.Text + "ª TEMPORADA atualizada com sucesso.", null).ShowDialog();
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
