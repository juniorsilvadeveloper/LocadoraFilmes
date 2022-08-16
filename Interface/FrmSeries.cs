using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegraNegocio;

namespace Interface
{
    public partial class FrmSeries : Form
    {
        private void FrmSeries_Load(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
        }

        public FrmSeries()
        {
            InitializeComponent();

            #region Eliminar oscilação do formulário ou controles da interface
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            #endregion

            dataGridViewSeries.AutoGenerateColumns = false;
            dataGridViewTemporada.AutoGenerateColumns = false;
            dataGridViewEpisodio.AutoGenerateColumns = false;
        }

        private void LimparPesquisa()
        {
            txtPesquisar.Text = string.Empty;
            txtPesquisar.Focus();
        }

        private void radioButtonTitulo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewSeries.DataSource = null;
        }

        private void radioButtonProdutor_Editora_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewSeries.DataSource = null;
        }

        private void AtualizarGridSeries()
        {
            var filme_Serie_RegraNegocio = new Filme_Serie_RegraNegocio();

            if (radioButtonTitulo.Checked)
            {
                dataGridViewSeries.DataSource = null;
                dataGridViewSeries.DataSource = filme_Serie_RegraNegocio.Consultar(
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    null,
                    "SÉRIE",
                    "1");
                dataGridViewSeries.Update();
                dataGridViewSeries.Refresh();
                lblTotalRegistrosSeries.Text = "Total Registro(s): " + dataGridViewSeries.RowCount.ToString();
            }
            else if (radioButtonProdutor_Editora.Checked)
            {
                dataGridViewSeries.DataSource = null;
                dataGridViewSeries.DataSource = filme_Serie_RegraNegocio.Consultar(
                    null,
                    null,
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    "SÉRIE",
                    "1");
                dataGridViewSeries.Update();
                dataGridViewSeries.Refresh();
                lblTotalRegistrosSeries.Text = "Total Registro(s): " + dataGridViewSeries.RowCount.ToString();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarGridSeries();
                txtPesquisar.Focus();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dataGridViewSeries_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewSeries.SelectedRows.Count > 0)
                {
                    var filme_Serie = (dataGridViewSeries.SelectedRows[0].DataBoundItem as Filme_Serie);
                    var temporadaRegraNegocio = new TemporadaRegraNegocio();

                    dataGridViewTemporada.DataSource = null;
                    dataGridViewTemporada.DataSource = temporadaRegraNegocio.Consultar(
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        filme_Serie.ID.ToString(),
                        null,
                        null);
                    dataGridViewTemporada.Update();
                    dataGridViewTemporada.Refresh();
                    lblTotalRegistrosTemporadas.Text = "Total Registro(s): " + dataGridViewTemporada.RowCount.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void dataGridViewTemporada_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (dataGridViewTemporada.SelectedRows.Count > 0)
                    {
                        var episodioRegraNegocio = new EpisodioRegraNegocio();
                        var temporada = (dataGridViewTemporada.SelectedRows[0].DataBoundItem as Temporada);

                        dataGridViewEpisodio.DataSource = null;
                        dataGridViewEpisodio.DataSource = episodioRegraNegocio.Consultar(
                            null,
                            null,
                            null,
                            temporada.ID.ToString(),
                            null,
                            null,
                            null,
                            null,
                            null);
                        dataGridViewEpisodio.Update();
                        dataGridViewEpisodio.Refresh();
                        lblTotalRegistrosEpisodios.Text = "Total Registro(s): " + dataGridViewEpisodio.RowCount.ToString();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void dataGridViewSeries_DoubleClick(object sender, EventArgs e)
        {
            var serie_SerieSelecionada = (dataGridViewSeries.SelectedRows[0].DataBoundItem as Filme_Serie);

            var frmFilmeSerie = new FrmFilme_Serie(AcaoNaTela.Exibir, serie_SerieSelecionada);
            frmFilmeSerie.ShowDialog();
        }

        private void dataGridViewTemporada_DoubleClick(object sender, EventArgs e)
        {
            var temporada_SerieSelecionada = (dataGridViewTemporada.SelectedRows[0].DataBoundItem as Temporada);

            var frmTemporada = new FrmTemporada(AcaoNaTela.Exibir, temporada_SerieSelecionada);
            frmTemporada.ShowDialog();
        }

        private void dataGridViewEpisodio_DoubleClick(object sender, EventArgs e)
        {
            var episodio_SerieSelecionado = (dataGridViewEpisodio.SelectedRows[0].DataBoundItem as Episodio);

            var frmEpisodio = new FrmEpisodio(AcaoNaTela.Exibir, episodio_SerieSelecionado);
            frmEpisodio.ShowDialog();
        }

        private Favoritos Dados()
        {
            try
            {
                var favoritos = new Favoritos();
                var filme_Serie = (dataGridViewSeries.SelectedRows[0].DataBoundItem as Filme_Serie);

                favoritos.Usuario = LoginSistema.UsuarioLogin;
                favoritos.Filme_Serie = filme_Serie;

                return favoritos;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        private void dataGridViewSeries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)dataGridViewSeries.CurrentRow.Cells["colFavoritos"];

            if (e.ColumnIndex == 2 && (bool)checkBox.Value == false)
            {
                var question = new FrmCaixaDialogo("question", "Deseja salvar esta série em favoritos?", "Salvar").ShowDialog();

                if (question == DialogResult.Yes)
                {
                    Favoritos favoritos = Dados();
                    var favoritosRegraNegocio = new FavoritosRegraNegocio();
                    string retorno = favoritosRegraNegocio.Manipulacoes("1", favoritos);

                    try
                    {
                        int idFavoritos = Convert.ToInt32(retorno);
                        var caixaDialogo = new FrmCaixaDialogo("sucesso", "Série salvo em favoritos.", null).ShowDialog();
                        AtualizarGridSeries();
                    }
                    catch (FormatException)
                    {
                        var caixaDialogo = new FrmCaixaDialogo("error", "Detalhes: " + retorno, null).ShowDialog();
                    }
                }
                else
                {
                    AtualizarGridSeries();
                }
            }
            else if (e.ColumnIndex == 2 && (bool)checkBox.Value == true)
            {
                var question = new FrmCaixaDialogo("question", "Deseja excluir esta série do favoritos?", "Excluir").ShowDialog();

                if (question == DialogResult.No)
                {
                    AtualizarGridSeries();
                    return;
                }

                try
                {
                    var seire = (dataGridViewSeries.SelectedRows[0].DataBoundItem as Filme_Serie);

                    var favoritos = new Favoritos();

                    favoritos.Usuario = LoginSistema.UsuarioLogin;
                    favoritos.Filme_Serie = seire;
                    
                    var favoritosRegraNegocio = new FavoritosRegraNegocio();
                    string retorno = favoritosRegraNegocio.Manipulacoes("3", favoritos);

                    var caixaDialogo = new FrmCaixaDialogo("sucesso", "Série excluída do favoritos.", null).ShowDialog();
                    AtualizarGridSeries();
                }
                catch (Exception exception)
                {
                    var caixaDialogo = new FrmCaixaDialogo("error", "Detalhes: " + exception.Message, null).ShowDialog();
                }
            }
        }
    }
}
