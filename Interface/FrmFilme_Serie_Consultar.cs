using ObjetoTransferencia;
using RegraNegocio;
using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmFilme_Serie_Consultar : Form
    {
        private void FrmFilme_Serie_Consultar_Load(object sender, EventArgs e)
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

        public FrmFilme_Serie_Consultar()
        {
            InitializeComponent();
            dataGridViewFilme_Serie.AutoGenerateColumns = false;
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonID.Checked || radioButtonAno.Checked)
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
                    e.Handled = true;
            }

            if (radioButtonAno.Checked)
                txtPesquisar.MaxLength = 4;
        }

        private void LimparPesquisa()
        {
            txtPesquisar.Text = string.Empty;
            txtPesquisar.Focus();
        }

        private void radioButtonID_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFilme_Serie.DataSource = null;
        }

        private void radioButtonTitulo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFilme_Serie.DataSource = null;
        }

        private void radioButtonGenero_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFilme_Serie.DataSource = null;
        }

        private void radioButtonAno_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFilme_Serie.DataSource = null;
        }

        private void radioButtonProdutor_Editora_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFilme_Serie.DataSource = null;
        }

        private void radioButtonAtivo_Inativo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFilme_Serie.DataSource = null;
        }

        private void radioButtonAtivo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFilme_Serie.DataSource = null;
        }

        private void radioButtonInativo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewFilme_Serie.DataSource = null;
        }

        private void AtualizarGrid()
        {
            var filme_Serie_RegraNegocio = new Filme_Serie_RegraNegocio();

            string situacao = null;
            string filme_erie = null;

            if (radioButtonAtivo.Checked)
                situacao = "1";
            else if (radioButtonInativo.Checked)
                situacao = "0";

            if (checkBoxFilme.Checked)
                filme_erie = "FILME";
            else if (checkBoxSerie.Checked)
                filme_erie = "SÉRIE";

            if (radioButtonID.Checked)
            {
                dataGridViewFilme_Serie.DataSource = null;
                dataGridViewFilme_Serie.DataSource = filme_Serie_RegraNegocio.Consultar(
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    null,
                    null,
                    filme_erie,
                    situacao);
                dataGridViewFilme_Serie.Update();
                dataGridViewFilme_Serie.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewFilme_Serie.RowCount.ToString();
            }
            else if (radioButtonTitulo.Checked)
            {
                dataGridViewFilme_Serie.DataSource = null;
                dataGridViewFilme_Serie.DataSource = filme_Serie_RegraNegocio.Consultar(
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    null,
                    filme_erie,
                    situacao);
                dataGridViewFilme_Serie.Update();
                dataGridViewFilme_Serie.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewFilme_Serie.RowCount.ToString();
            }
            else if (radioButtonGenero.Checked)
            {
                dataGridViewFilme_Serie.DataSource = null;
                dataGridViewFilme_Serie.DataSource = filme_Serie_RegraNegocio.Consultar(
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    filme_erie,
                    situacao);
                dataGridViewFilme_Serie.Update();
                dataGridViewFilme_Serie.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewFilme_Serie.RowCount.ToString();
            }
            else if (radioButtonAno.Checked)
            {
                dataGridViewFilme_Serie.DataSource = null;
                dataGridViewFilme_Serie.DataSource = filme_Serie_RegraNegocio.Consultar(
                    null,
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    filme_erie,
                    situacao);
                dataGridViewFilme_Serie.Update();
                dataGridViewFilme_Serie.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewFilme_Serie.RowCount.ToString();
            }
            else if (radioButtonProdutor_Editora.Checked)
            {
                dataGridViewFilme_Serie.DataSource = null;
                dataGridViewFilme_Serie.DataSource = filme_Serie_RegraNegocio.Consultar(
                    null,
                    null,
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    filme_erie,
                    situacao);
                dataGridViewFilme_Serie.Update();
                dataGridViewFilme_Serie.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewFilme_Serie.RowCount.ToString();
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

        private void dataGridViewFilme_Serie_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewFilme_Serie.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewFilme_Serie.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewFilme_Serie.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewFilme_Serie.Columns[e.ColumnIndex].DataPropertyName
                        );
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                var frmFilmeSerie = new FrmFilme_Serie(AcaoNaTela.Novo, null);
                DialogResult dialogResult = frmFilmeSerie.ShowDialog();

                if (dialogResult == DialogResult.Yes)
                    AtualizarGrid();
                else
                    txtPesquisar.Focus();
            }
            catch (Exception exception)
            {
                var caixaDialogo = new FrmCaixaDialogo("error", "Não foi possível realizar o cadastro. Detalhes: " + exception.Message, null).ShowDialog();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewFilme_Serie.SelectedRows.Count == 0)
            {
                var warning = new FrmCaixaDialogo("warning", "Nenhum filme ou série selecionado.", null).ShowDialog();
                return;
            }

            try
            {
                var filme_Serie = (dataGridViewFilme_Serie.SelectedRows[0].DataBoundItem as Filme_Serie);
                var frmFilmeSerie = new FrmFilme_Serie(AcaoNaTela.Editar, filme_Serie);
                frmFilmeSerie.ShowDialog();

                AtualizarGrid();
            }
            catch (Exception exception)
            {
                var caixaDialogo = new FrmCaixaDialogo("error", "Não foi possível editar o filme ou série. Detalhes: " + exception.Message, null).ShowDialog();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewFilme_Serie.SelectedRows.Count == 0)
            {
                var warning = new FrmCaixaDialogo("warning", "Nenhum filme ou série selecionado.", null).ShowDialog();
                txtPesquisar.Focus();
                return;
            }

            var question = new FrmCaixaDialogo("question", "Tem certeza que deseja realizar a exclusão? Todos os registros vinculados a este(a) filme | série serão excluídos.", "Excluir").ShowDialog();
            if (question == DialogResult.No)
                return;
            try
            {
                var filme_Serie = (dataGridViewFilme_Serie.SelectedRows[0].DataBoundItem as Filme_Serie);
                var filme_Serie_RegraNegocio = new Filme_Serie_RegraNegocio();
                string retorno = filme_Serie_RegraNegocio.Manipulacoes("3", filme_Serie);

                int idFilmeSerie = Convert.ToInt32(retorno);

                var caixaDialogo = new FrmCaixaDialogo("sucesso", "Filme ou série selecionado excluído com sucesso.", null).ShowDialog();

                AtualizarGrid();
            }
            catch (Exception exception)
            {
                var caixaDialogo = new FrmCaixaDialogo("error", "Não foi possível realizar a exclusão. Detalhes: " + exception.Message, null).ShowDialog();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dataGridViewFilme_Serie.DataSource = null;
        }

        private void dataGridViewFilme_Serie_DoubleClick(object sender, EventArgs e)
        {
            var filme_SerieSelecionado = (dataGridViewFilme_Serie.SelectedRows[0].DataBoundItem as Filme_Serie);

            var frmFilmeSerie = new FrmFilme_Serie(AcaoNaTela.Exibir, filme_SerieSelecionado);
            frmFilmeSerie.ShowDialog();
        }

        private void dataGridViewFilme_Serie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                var filme_SerieSelecionado = (dataGridViewFilme_Serie.SelectedRows[0].DataBoundItem as Filme_Serie);

                var frmFilmeSerie = new FrmFilme_Serie(AcaoNaTela.Exibir, filme_SerieSelecionado);
                frmFilmeSerie.ShowDialog();
            }

            if (e.KeyCode == Keys.Delete)
            {
                var question = new FrmCaixaDialogo("question", "Tem certeza que deseja realizar a exclusão? Todos os registros vinculados a este(a) filme | série serão excluídos.", "Excluir").ShowDialog();
                if (question == DialogResult.No)
                    return;
                try
                {
                    var filme_Serie = (dataGridViewFilme_Serie.SelectedRows[0].DataBoundItem as Filme_Serie);
                    var filme_Serie_RegraNegocio = new Filme_Serie_RegraNegocio();
                    string retorno = filme_Serie_RegraNegocio.Manipulacoes("3", filme_Serie);

                    int idFilmeSerie = Convert.ToInt32(retorno);

                    var caixaDialogo = new FrmCaixaDialogo("sucesso", "Filme ou série selecionado excluído com sucesso.", null).ShowDialog();

                    AtualizarGrid();
                }
                catch (Exception exception)
                {
                    var caixaDialogo = new FrmCaixaDialogo("error", "Não foi possível realizar a exclusão. Detalhes: " + exception.Message, null).ShowDialog();
                }
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
