using ObjetoTransferencia;
using RegraNegocio;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmFilme_Serie : Form
    {
        #region Variável global

        string caminhoImagem = null;
        string focus = string.Empty;
        string nomeTitulo = string.Empty; string geneero = string.Empty; string duracao = string.Empty;
        string ano = string.Empty; string classificacao = string.Empty; string origem = string.Empty;
        string link = string.Empty; string produtorEditora = string.Empty; string sinopse = string.Empty; 
        string imagem = string.Empty; string semImagem = string.Empty; Boolean serie; Boolean situacao;
        #endregion

        private void FrmFilmeSerie_Activated(object sender, EventArgs e)
        {
            if(txtTitulo.Text == string.Empty && txtGenero.Text == string.Empty &&
                txtDuracao.Text == string.Empty && txtAno.Text == string.Empty &&
                txtClassificacao.Text == string.Empty && txtOrigem.Text == string.Empty && txtLink.Text == string.Empty &&
                txtProdutorEditora.Text == string.Empty && txtSinopse.Text == string.Empty)
            {
                txtTitulo.Focus();
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
            txtTitulo.Clear();
            txtGenero.Clear();
            txtDuracao.Clear();
            txtAno.Clear();
            txtClassificacao.Clear();
            txtOrigem.Clear();
            txtLink.Clear();
            txtProdutorEditora.Clear();
            txtSinopse.Clear();
            checkBoxSerie.Checked = false;
            pictureBoxFilmeSerie.Image = null;
        }

        private Filme_Serie Dados()
        {
            try
            {
                var filme_Serie = new Filme_Serie();

                filme_Serie.ID = Convert.ToInt32(lblIDResult.Text);
                filme_Serie.Titulo = txtTitulo.Text;
                filme_Serie.Genero = txtGenero.Text;

                if (checkBoxMTotal.Checked)
                    filme_Serie.Duracao = txtDuracao.Text + " Min";
                else
                    filme_Serie.Duracao = txtDuracao.Text;

                filme_Serie.Ano = txtAno.Text;
                filme_Serie.Classificacao = txtClassificacao.Text;
                filme_Serie.Origem = txtOrigem.Text;
                filme_Serie.Link = txtLink.Text;
                filme_Serie.Produtor_Editora = txtProdutorEditora.Text;
                filme_Serie.Sinopse = txtSinopse.Text;

                if (caminhoImagem != null)
                {
                    byte[] imageArray = System.IO.File.ReadAllBytes(caminhoImagem);
                    filme_Serie.Imagem = Convert.ToBase64String(imageArray);
                }
                else if (semImagem == "vazio")
                    filme_Serie.Imagem = null;
                else
                    filme_Serie.Imagem = imagem;

                filme_Serie.FilmeSerie = checkBoxSerie.Checked ? "SÉRIE" : "FILME";
                filme_Serie.Situacao = checkBoxSituacao.Checked ? true : false;
                filme_Serie.IDUsuarioCadastrou = LoginSistema.UsuarioLogin;
                filme_Serie.IDUsuarioAlterou = LoginSistema.UsuarioLogin;

                return filme_Serie;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void PreencherDados(Filme_Serie filme_Serie)
        {
            lblIDResult.Text = filme_Serie.ID.ToString();
            txtTitulo.Text = filme_Serie.Titulo;
            txtGenero.Text = filme_Serie.Genero;
            txtDuracao.Text = filme_Serie.Duracao;

            if (txtDuracao.TextLength == 4)
                checkBoxMinutos.Checked = true;

            if (txtDuracao.TextLength == 7)
                checkBoxMTotal.Checked = true;

            txtDuracao.Text = filme_Serie.Duracao;
            txtAno.Text = filme_Serie.Ano;
            txtClassificacao.Text = filme_Serie.Classificacao;
            txtOrigem.Text = filme_Serie.Origem;
            txtLink.Text = filme_Serie.Link;
            txtProdutorEditora.Text = filme_Serie.Produtor_Editora;
            txtSinopse.Text = filme_Serie.Sinopse;

            if (filme_Serie.Imagem != null)
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(filme_Serie.Imagem)));
                pictureBoxFilmeSerie.Image = img;
            }

            if(filme_Serie.FilmeSerie == "FILME")
                checkBoxSerie.Checked = false;
            else
                checkBoxSerie.Checked = true;

            checkBoxSituacao.Checked = filme_Serie.Situacao;

            lblIDUsuarioCadastrouResult.Text = filme_Serie.IDUsuarioCadastrou.ID.ToString();
            lblUsuarioCadastrouResult.Text = filme_Serie.IDUsuarioCadastrou.UsuarioLogin;
            lblNomeCadastrouResult.Text = filme_Serie.IDUsuarioCadastrou.Nome;
            lblDataCadastroResult.Text = filme_Serie.DataCadastro.ToString();

            lblFuncaoCadastrou.Text = filme_Serie.IDUsuarioCadastrou.IDTipoUsuario.Descricao;

            if (filme_Serie.IDUsuarioCadastrou.Imagem != string.Empty)
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(filme_Serie.IDUsuarioCadastrou.Imagem)));
                pictureBoxUsuarioCadastrou.Image = img;
            }

            lblIDUsuarioAlterouResult.Text = filme_Serie.IDUsuarioAlterou.ID == 0 ? "NENHUM" : filme_Serie.IDUsuarioAlterou.ID.ToString();
            lblUsuarioAlterouResult.Text = filme_Serie.IDUsuarioAlterou.UsuarioLogin;
            lblNomeAlterouResult.Text = filme_Serie.IDUsuarioAlterou.Nome;
            lblDataAlteracaoResult.Text = filme_Serie.DataAlteracao.ToString() == "01/01/0001 00:00:00" ? "NENHUM" 
                : filme_Serie.DataAlteracao.ToString();

            if (filme_Serie.IDUsuarioAlterou.Imagem != string.Empty)
            {
                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(filme_Serie.IDUsuarioAlterou.Imagem)));
                pictureBoxUsuarioAlterou.Image = img;
            }

            lblFuncaoAlterou.Text = filme_Serie.IDUsuarioAlterou.IDTipoUsuario.Descricao;

            nomeTitulo = filme_Serie.Titulo;
            geneero = filme_Serie.Genero;
            duracao = filme_Serie.Duracao;
            ano = filme_Serie.Ano;
            classificacao = filme_Serie.Classificacao;
            origem = filme_Serie.Origem;
            link = filme_Serie.Link;
            produtorEditora = filme_Serie.Produtor_Editora;
            sinopse = filme_Serie.Sinopse;
            imagem = filme_Serie.Imagem;

            if (filme_Serie.FilmeSerie == "FILME")
                serie = true;
            else
                serie = false;

            situacao = filme_Serie.Situacao;
        }
        #endregion

        public FrmFilme_Serie(AcaoNaTela acaoNaTela, Filme_Serie filme_Serie)
        {
            InitializeComponent();

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
                PreencherDados(filme_Serie);
                lblID.Visible = true;
                lblIDResult.Visible = true;
                txtDuracao.Text = txtDuracao.Text.Replace(" Min", string.Empty);
                btn_Salvar_Atualizar.Text = "ATUALIZAR";
                lblNovoCadastro_Usuario.Text = "EDITAR - (FILME | SÉRIE)";
            }
            else if (acaoNaTela == AcaoNaTela.Exibir)
            {
                PreencherDados(filme_Serie);

                checkBoxSerie.Enabled = false;
                checkBoxSituacao.Enabled = false;
                lblID.Visible = true;
                lblIDResult.Visible = true;
                lblAstTitulo.Visible = false;
                txtTitulo.ReadOnly = true;
                lblAstGenero.Visible = false;
                txtGenero.ReadOnly = true;
                if (txtDuracao.PlaceholderText == "00:00:00")
                    txtDuracao.PlaceholderText = string.Empty;
                lblAstDuracao.Visible = false;
                txtDuracao.ReadOnly = true;
                checkBoxMinutos.Enabled = false;
                checkBoxMTotal.Enabled = false;
                lblAstAno.Visible = false;
                txtAno.ReadOnly = true;
                lblAstClassificacao.Visible = false;
                txtClassificacao.ReadOnly = true;
                txtOrigem.ReadOnly = true;
                lblAstLink.Visible = false;
                txtLink.ReadOnly = true;
                lblAstProdutorEditora.Visible = false;
                txtProdutorEditora.ReadOnly = true;
                txtSinopse.ReadOnly = true;
                btnCarregar.Visible = false;
                btnEditar.Visible = false;
                btnLimpar.Visible = false;
                btn_Salvar_Atualizar.Visible = false;
                lblNovoCadastro_Usuario.Text = "EXIBIR - (FILME | SÉRIE)";
                btn_Salvar_Atualizar.Text = string.Empty;

                if (LoginSistema.UsuarioLogin.IDTipoUsuario.IDTipoUsuario == 3)
                {
                    lblIDResult.Visible = false;
                    lblID.Visible = false;
                    panelCheckBox.Visible = false;
                    btnSetaDireita.Visible = false;
                    btnSetaEsquerda.Visible = false;
                    txtLink.Text = string.Empty;
                }
            }
            #endregion
        }

        #region Fade in, fade out e formClosing

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

        private void FrmFilmeSerie_FormClosing(object sender, FormClosingEventArgs e)
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
            txtTitulo.MaxLength = 100;
            txtGenero.MaxLength = 100;

            if (txtDuracao.Text != string.Empty)
            {
                if(!checkBoxMinutos.Checked)
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

            if (txtTitulo.Text != nomeTitulo || txtGenero.Text != geneero ||
                txtDuracao.Text != duracao || txtAno.Text != ano ||
                txtClassificacao.Text != classificacao || txtOrigem.Text != origem || txtLink.Text != link ||
                txtProdutorEditora.Text != produtorEditora || txtSinopse.Text != sinopse ||
                checkBoxSerie.Checked != serie || checkBoxSituacao.Checked != situacao)
            {
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text + "*";
            }

            if (checkBoxSerie.Checked)
            {
                lblTitulo.Text = "Nome da série";
                CampoFocus();
                lblAstDuracao.Visible = false;               
                lblAstGenero.Visible = false;
                lblAstAno.Visible = false;
                lblAstClassificacao.Visible = false;
                lblAstLink.Visible = false;
            }
            else
            {
                lblTitulo.Text = "Título";
                CampoFocus();
                lblAstDuracao.Visible = true;
                lblAstGenero.Visible = true;
                lblAstAno.Visible = true;
                lblAstClassificacao.Visible = true;
                lblAstLink.Visible = true;
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

        private void txtTitulo_Enter(object sender, EventArgs e)
        {
            focus = "Titulo";
        }

        private void txtGenero_Enter(object sender, EventArgs e)
        {
            focus = "Genero";
        }

        private void txtDuracao_Enter(object sender, EventArgs e)
        {
            focus = "Duracao";
        }

        private void txtAno_Enter(object sender, EventArgs e)
        {
            focus = "Ano";
        }

        private void txtClassificacao_Enter(object sender, EventArgs e)
        {
            focus = "Classificacao";
        }

        private void txtOrigem_Enter(object sender, EventArgs e)
        {
            focus = "Origem";
        }

        private void txtLink_Enter(object sender, EventArgs e)
        {
            focus = "link";
        }

        private void txtProdutorEditora_Enter(object sender, EventArgs e)
        {
            focus = "ProdutorEditora";
        }

        private void txtSinopse_Enter(object sender, EventArgs e)
        {
            focus = "Sinopse";
        }

        private void CampoFocus()
        {
            if (focus == "Titulo")
                txtTitulo.Focus();
            if (focus == "Genero")
                txtGenero.Focus();
            if (focus == "Duracao")
                txtDuracao.Focus();
            if (focus == "Ano")
                txtAno.Focus();
            if (focus == "Classificacao")
                txtClassificacao.Focus();
            if (focus == "Origem")
                txtOrigem.Focus();
            if (focus == "link")
                txtLink.Focus();
            if (focus == "ProdutorEditora")
                txtProdutorEditora.Focus();
            if (focus == "Sinopse")
                txtSinopse.Focus();
        }
        #endregion

        #region Evento Leave

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

        private void txtLink_Leave(object sender, EventArgs e)
        {
            lblLink.ForeColor = Color.LightGray;
        }

        private void txtProdutorEditora_Leave(object sender, EventArgs e)
        {
            lblProdutorEditora.ForeColor = Color.LightGray;
        }
        #endregion

        #region Evento KeyPress

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
                    pictureBoxFilmeSerie.Load(caminhoImagem);

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

            if (pictureBoxFilmeSerie.Image != null)
            {
                pictureBoxFilmeSerie.Image = null;
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");
                lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text + "*";
            }
        }

        private void btn_Salvar_Atualizar_Click(object sender, EventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#D63D5C");

            if (txtTitulo.Text == string.Empty)
            {
                if (checkBoxSerie.Checked)
                    nomeTitulo = "Digite o nome da série.";
                else
                    nomeTitulo = "Digite o título do filme.";

                var caixaDialogo = new FrmCaixaDialogo("warning", nomeTitulo, null).ShowDialog();
                lblTitulo.ForeColor = col;
                txtTitulo.Focus();
                return;
            }
            else if (!checkBoxSerie.Checked && txtGenero.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite o gênero do filme.", null).ShowDialog();
                lblGenero.ForeColor = col;
                txtGenero.Focus();
                return;
            }
            else if (!checkBoxSerie.Checked && txtDuracao.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite a duração do filme.", null).ShowDialog();
                lblDuracao.ForeColor = col;
                txtDuracao.Focus();
                return;
            }
            else if (!checkBoxMinutos.Checked && !checkBoxMTotal.Checked 
                     && txtDuracao.TextLength > 0 && txtDuracao.TextLength < 5 
                     || txtDuracao.TextLength == 6 || txtDuracao.TextLength == 7)
            {
                if (!checkBoxSerie.Checked)
                    duracao = "Digite as horas e minutos do filme corretamente.";
                else
                    duracao = "Digite as horas e minutos da série corretamente.";

                var caixaDialogo = new FrmCaixaDialogo("warning", duracao, null).ShowDialog();
                lblDuracao.ForeColor = col;
                txtDuracao.Focus();
                return;
            }
            else if (checkBoxMinutos.Checked && txtDuracao.TextLength > 0 && txtDuracao.TextLength < 4)
            {
                if (!checkBoxSerie.Checked)
                    duracao = "Digite os minutos e segundos do filme corretamente.";
                else
                    duracao = "Digite os minutos e segundos da série corretamente.";

                var caixaDialogo = new FrmCaixaDialogo("warning", duracao, null).ShowDialog();
                lblDuracao.ForeColor = col;
                txtDuracao.Focus();
                return;
            }
            else if (!checkBoxSerie.Checked && txtAno.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite o ano do lançamento.", null).ShowDialog();
                lblAno.ForeColor = col;
                txtAno.Focus();
                return;
            }
            else if (txtAno.TextLength > 0 && txtAno.TextLength < 4)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite o ano corretamente.", null).ShowDialog();
                lblAno.ForeColor = col;
                txtAno.Focus();
                return;
            }
            else if (!checkBoxSerie.Checked && txtClassificacao.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Digite a classificação de idade.", null).ShowDialog();
                lblClassificacao.ForeColor = col;
                txtClassificacao.Focus();
                return;
            }
            else if (!checkBoxSerie.Checked && txtLink.Text == string.Empty)
            {
                var caixaDialogo = new FrmCaixaDialogo("warning", "Adicione a URL do filme.", null).ShowDialog();
                lblLink.ForeColor = col;
                txtLink.Focus();
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
                    Filme_Serie filme_Serie = Dados();
                    var filme_Serie_RegraNegocio = new Filme_Serie_RegraNegocio();
                    string retorno = filme_Serie_RegraNegocio.Manipulacoes("1", filme_Serie);

                    try
                    {
                        int idFilme_Serie = Convert.ToInt32(retorno);
                        lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");

                        if (!checkBoxSerie.Checked)
                            nomeTitulo = "Filme cadastrado com sucesso.";
                        else
                            nomeTitulo = "Série cadastrado com sucesso.";

                        var caixaDialogo = new FrmCaixaDialogo("sucesso", nomeTitulo, null).ShowDialog();
                        var caixaDialogoNovo = new FrmCaixaDialogo("question", "Deseja cadastrar novo filme ou série?", "Novo Filme | Série").ShowDialog();

                        if (caixaDialogoNovo == DialogResult.No)
                        {
                            this.Close();
                        }
                        else
                        {
                            LimparDados();
                            lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");
                            txtTitulo.Focus();
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
                        Filme_Serie filme_Serie = Dados();
                        var filme_Serie_RegraNegocio = new Filme_Serie_RegraNegocio();
                        string retorno = filme_Serie_RegraNegocio.Manipulacoes("2", filme_Serie);

                        try
                        {
                            int idFilme_Serie = Convert.ToInt32(retorno);
                            lblNovoCadastro_Usuario.Text = lblNovoCadastro_Usuario.Text.Replace("*", "");

                            if (!checkBoxSerie.Checked)
                                nomeTitulo = "Filme atualizado com sucesso.";
                            else
                                nomeTitulo = "Série atualizado com sucesso.";

                            var caixaDialogo = new FrmCaixaDialogo("sucesso", nomeTitulo, null).ShowDialog();
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
