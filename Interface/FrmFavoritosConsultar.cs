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
    public partial class FrmFavoritosConsultar : Form
    {
        private void FrmFavoritosConsultar_Load(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
        }

        #region Fadein, FadeOut

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            /*for (double cont = 0; cont <= 1; cont += 0.1)
            {
                this.Opacity = cont;
                this.Refresh();
                System.Threading.Thread.Sleep(15);
            }
            this.Opacity = 0.96;
            timerFadeIn.Stop();*/
        }
        #endregion

        public FrmFavoritosConsultar()
        {
            InitializeComponent();
            dataGridViewFavoritos.AutoGenerateColumns = false;
        }

        private void LimparPesquisa()
        {
            txtPesquisar.Text = string.Empty;
            txtPesquisar.Focus();
        }

        private void radioButtonTitulo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFavoritos.DataSource = null;
        }

        private void radioButtonGenero_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFavoritos.DataSource = null;
        }

        private void radioButtonProdutor_Editora_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFavoritos.DataSource = null;
        }

        private void AtualizarGrid()
        {
            var favoritosRegraNegocio = new FavoritosRegraNegocio();

            string filme_erie = null;

            if (checkBoxFilme.Checked)
                filme_erie = "FILME";
            else if (checkBoxSerie.Checked)
                filme_erie = "SÉRIE";

            if (radioButtonTitulo.Checked)
            {
                dataGridViewFavoritos.DataSource = null;
                dataGridViewFavoritos.DataSource = favoritosRegraNegocio.Consultar(
                    filme_erie,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null);
                dataGridViewFavoritos.Update();
                dataGridViewFavoritos.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewFavoritos.RowCount.ToString();
            }
            else if (radioButtonGenero.Checked)
            {
                dataGridViewFavoritos.DataSource = null;
                dataGridViewFavoritos.DataSource = favoritosRegraNegocio.Consultar(
                    filme_erie,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null);
                dataGridViewFavoritos.Update();
                dataGridViewFavoritos.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewFavoritos.RowCount.ToString();
            }
            else
            {
                dataGridViewFavoritos.DataSource = null;
                dataGridViewFavoritos.DataSource = favoritosRegraNegocio.Consultar(
                    filme_erie,
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString());
                dataGridViewFavoritos.Update();
                dataGridViewFavoritos.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewFavoritos.RowCount.ToString();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarGrid();
                txtPesquisar.Focus();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro. Detalhes: " + exception.Message, "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewFavoritos.SelectedRows.Count == 0)
            {
                var warning = new FrmCaixaDialogo("warning", "Nenhum filme ou série selecionado.", null).ShowDialog();
                txtPesquisar.Focus();
                return;
            }

            try
            {
                var favoritos = (dataGridViewFavoritos.SelectedRows[0].DataBoundItem as Favoritos);
                var favoritosRegraNegocio = new FavoritosRegraNegocio();
                string retorno = favoritosRegraNegocio.Manipulacoes("3", favoritos);

                int idFavoritos = Convert.ToInt32(retorno);

                var caixaDialogo = new FrmCaixaDialogo("sucesso", "Filme excluído do favoritos.", null).ShowDialog();
                AtualizarGrid();
            }
            catch (Exception exception)
            {
                var caixaDialogo = new FrmCaixaDialogo("error", "Detalhes: " + exception.Message, null).ShowDialog();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dataGridViewFavoritos.DataSource = null;
        }

        private void dataGridViewFavoritos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewFavoritos.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewFavoritos.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewFavoritos.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewFavoritos.Columns[e.ColumnIndex].DataPropertyName
                        );
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void checkBoxFilme_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFilme.Checked)
            {
                txtPesquisar.Focus();
                checkBoxSerie.Checked = false;
            }
            else
                txtPesquisar.Focus();
        }

        private void checkBoxSerie_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSerie.Checked)
            {
                txtPesquisar.Focus();
                checkBoxFilme.Checked = false;
            }
            else
                txtPesquisar.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
