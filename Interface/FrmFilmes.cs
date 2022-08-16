using System;
using System.Windows.Forms;
using ObjetoTransferencia;
using RegraNegocio;

namespace Interface
{
    public partial class FrmFilmes : Form
    {
        private void FrmFilmes_Load(object sender, EventArgs e)
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

        public FrmFilmes()
        {
            InitializeComponent();

            #region Eliminar oscilação do formulário ou controles da interface
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            #endregion

            dataGridViewFilmes.AutoGenerateColumns = false;
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonAno.Checked)
            {
                txtPesquisar.MaxLength = 4;

                if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
                    e.Handled = true; 
            }
        }

        private void LimparPesquisa()
        {
            txtPesquisar.Text = string.Empty;
            txtPesquisar.Focus();
        }

        private void radioButtonTitulo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFilmes.DataSource = null;
        }

        private void radioButtonGenero_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFilmes.DataSource = null;
        }

        private void radioButtonAno_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFilmes.DataSource = null;
        }

        private void radioButtonProdutor_Editora_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFilmes.DataSource = null;
        }

        private void radioButtonAtivo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFilmes.DataSource = null;
        }

        private void radioButtonInativo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFilmes.DataSource = null;
        }

        private void radioButtonAtivo_Inativo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFilmes.DataSource = null;
        }

        private void AtualizarGrid()
        {
            var filme_Serie_RegraNegocio = new Filme_Serie_RegraNegocio();

            if (radioButtonTitulo.Checked)
            {
                dataGridViewFilmes.DataSource = null;
                dataGridViewFilmes.DataSource = filme_Serie_RegraNegocio.Consultar(
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    null,
                    "FILME",
                    "1");
                dataGridViewFilmes.Update();
                dataGridViewFilmes.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewFilmes.RowCount.ToString();
            }
            else if (radioButtonGenero.Checked)
            {
                dataGridViewFilmes.DataSource = null;
                dataGridViewFilmes.DataSource = filme_Serie_RegraNegocio.Consultar(
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    "FILME",
                    "1");
                dataGridViewFilmes.Update();
                dataGridViewFilmes.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewFilmes.RowCount.ToString();
            }
            else if (radioButtonAno.Checked)
            {
                dataGridViewFilmes.DataSource = null;
                dataGridViewFilmes.DataSource = filme_Serie_RegraNegocio.Consultar(
                    null,
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    "FILME",
                    "1");
                dataGridViewFilmes.Update();
                dataGridViewFilmes.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewFilmes.RowCount.ToString();
            }
            else if (radioButtonProdutor_Editora.Checked)
            {
                dataGridViewFilmes.DataSource = null;
                dataGridViewFilmes.DataSource = filme_Serie_RegraNegocio.Consultar(
                    null,
                    null,
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    "FILME",
                    "1");
                dataGridViewFilmes.Update();
                dataGridViewFilmes.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewFilmes.RowCount.ToString();
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

        private void dataGridViewFilme_Serie_Usuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewFilmes.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewFilmes.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewFilmes.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewFilmes.Columns[e.ColumnIndex].DataPropertyName
                        );
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {

        }

        private void btnAssistir_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dataGridViewFilmes.DataSource = null;
        }

        private void dataGridViewFilme_Serie_Usuarios_DoubleClick(object sender, EventArgs e)
        {
            var filme_SerieSelecionado = (dataGridViewFilmes.SelectedRows[0].DataBoundItem as Filme_Serie);

            var frmFilmeSerie = new FrmFilme_Serie(AcaoNaTela.Exibir, filme_SerieSelecionado);
            frmFilmeSerie.ShowDialog();
        }

        private void dataGridViewFilme_Serie_Usuarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                var filme_SerieSelecionado = (dataGridViewFilmes.SelectedRows[0].DataBoundItem as Filme_Serie);

                var frmFilmeSerie = new FrmFilme_Serie(AcaoNaTela.Exibir, filme_SerieSelecionado);
                frmFilmeSerie.ShowDialog();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
