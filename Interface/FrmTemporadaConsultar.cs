using ObjetoTransferencia;
using RegraNegocio;
using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmTemporadaConsultar : Form
    {
        private void FrmTemporadaConsultar_Load(object sender, EventArgs e)
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

        public FrmTemporadaConsultar()
        {
            InitializeComponent();
            dataGridViewTemporada.AutoGenerateColumns = false;
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonID.Checked || radioButtonNumeroTemporada.Checked || 
                radioButtonAno.Checked || radioButtonIDSerie.Checked)
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
                    e.Handled = true;
            }

            if (radioButtonNumeroTemporada.Checked)
                txtPesquisar.MaxLength = 3;
            else if (radioButtonAno.Checked)
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
            dataGridViewTemporada.DataSource = null;
        }

        private void radioButtonTitulo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewTemporada.DataSource = null;
        }

        private void radioButtonNumeroTemporada_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewTemporada.DataSource = null;
        }

        private void radioButtonGenero_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewTemporada.DataSource = null;
        }

        private void radioButtonAno_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewTemporada.DataSource = null;
        }

        private void radioButtonProdutor_Editora_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewTemporada.DataSource = null;
        }

        private void radioButtonIDSerie_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewTemporada.DataSource = null;
        }

        private void radioButtonNomeSerie_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewTemporada.DataSource = null;
        }

        private void radioButtonAtivo_Inativo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewTemporada.DataSource = null;
        }

        private void radioButtonAtivo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewTemporada.DataSource = null;
        }

        private void radioButtonInativo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewTemporada.DataSource = null;
        }

        private void AtualizarGrid()
        {
            var temporadaRegraNegocio = new TemporadaRegraNegocio();

            string situacao = null;

            if (radioButtonAtivo.Checked)
                situacao = "1";
            else if (radioButtonInativo.Checked)
                situacao = "0";

            if (radioButtonID.Checked)
            {
                dataGridViewTemporada.DataSource = null;
                dataGridViewTemporada.DataSource = temporadaRegraNegocio.Consultar(
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    situacao);
                dataGridViewTemporada.Update();
                dataGridViewTemporada.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewTemporada.RowCount.ToString();
            }
            else if (radioButtonTitulo.Checked)
            {
                dataGridViewTemporada.DataSource = null;
                dataGridViewTemporada.DataSource = temporadaRegraNegocio.Consultar(
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    situacao);
                dataGridViewTemporada.Update();
                dataGridViewTemporada.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewTemporada.RowCount.ToString();
            }
            else if (radioButtonNumeroTemporada.Checked)
            {
                dataGridViewTemporada.DataSource = null;
                dataGridViewTemporada.DataSource = temporadaRegraNegocio.Consultar(
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    null,
                    null,
                    null,
                    situacao);
                dataGridViewTemporada.Update();
                dataGridViewTemporada.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewTemporada.RowCount.ToString();
            }
            else if (radioButtonGenero.Checked)
            {
                dataGridViewTemporada.DataSource = null;
                dataGridViewTemporada.DataSource = temporadaRegraNegocio.Consultar(
                    null,
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    null,
                    null,
                    situacao);
                dataGridViewTemporada.Update();
                dataGridViewTemporada.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewTemporada.RowCount.ToString();
            }
            else if (radioButtonAno.Checked)
            {
                dataGridViewTemporada.DataSource = null;
                dataGridViewTemporada.DataSource = temporadaRegraNegocio.Consultar(
                    null,
                    null,
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    null,
                    situacao);
                dataGridViewTemporada.Update();
                dataGridViewTemporada.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewTemporada.RowCount.ToString();
            }
            else if (radioButtonProdutor_Editora.Checked)
            {
                dataGridViewTemporada.DataSource = null;
                dataGridViewTemporada.DataSource = temporadaRegraNegocio.Consultar(
                    null,
                    null,
                    null,
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    situacao);
                dataGridViewTemporada.Update();
                dataGridViewTemporada.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewTemporada.RowCount.ToString();
            }
            else if (radioButtonIDSerie.Checked)
            {
                dataGridViewTemporada.DataSource = null;
                dataGridViewTemporada.DataSource = temporadaRegraNegocio.Consultar(
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    situacao);
                dataGridViewTemporada.Update();
                dataGridViewTemporada.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewTemporada.RowCount.ToString();
            }
            else if (radioButtonNomeSerie.Checked)
            {
                dataGridViewTemporada.DataSource = null;
                dataGridViewTemporada.DataSource = temporadaRegraNegocio.Consultar(
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    situacao);
                dataGridViewTemporada.Update();
                dataGridViewTemporada.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewTemporada.RowCount.ToString();
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

        private void dataGridViewTemporada_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewTemporada.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewTemporada.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewTemporada.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewTemporada.Columns[e.ColumnIndex].DataPropertyName
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
                var frmTemporada = new FrmTemporada(AcaoNaTela.Novo, null);
                DialogResult dialogResult = frmTemporada.ShowDialog();

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
            if (dataGridViewTemporada.SelectedRows.Count == 0)
            {
                var warning = new FrmCaixaDialogo("warning", "Nenhuma temporada selecionada.", null).ShowDialog();
                return;
            }

            try
            {
                var temporada = (dataGridViewTemporada.SelectedRows[0].DataBoundItem as Temporada);
                var frmTemporada = new FrmTemporada(AcaoNaTela.Editar, temporada);
                frmTemporada.ShowDialog();

                AtualizarGrid();
            }
            catch (Exception exception)
            {
                var caixaDialogo = new FrmCaixaDialogo("error", "Não foi possível editar a temporada. Detalhes: " + exception.Message, null).ShowDialog();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewTemporada.SelectedRows.Count == 0)
            {
                var warning = new FrmCaixaDialogo("warning", "Nenhuma temporada selecionada.", null).ShowDialog();
                txtPesquisar.Focus();
                return;
            }

            var question = new FrmCaixaDialogo("question", "Tem certeza que deseja realizar a exclusão? Todos os registros vinculados a esta temporada serão excluídas.", "Excluir").ShowDialog();
            if (question == DialogResult.No)
                return;
            try
            {
                var temporada = (dataGridViewTemporada.SelectedRows[0].DataBoundItem as Temporada);
                var temporadaRegraNegocio = new TemporadaRegraNegocio();
                string retorno = temporadaRegraNegocio.Manipulacoes("3", temporada);

                int idFilmeSerie = Convert.ToInt32(retorno);

                var caixaDialogo = new FrmCaixaDialogo("sucesso", "Temporada selecionada excluída com sucesso.", null).ShowDialog();

                AtualizarGrid();
            }
            catch (Exception exception)
            {
                var caixaDialogo = new FrmCaixaDialogo("error", "Não foi possível realizar a exclusão. Detalhes: " + exception.Message, null).ShowDialog();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dataGridViewTemporada.DataSource = null;
        }

        private void dataGridViewTemporada_DoubleClick(object sender, EventArgs e)
        {
            var temporadaSelecionado = (dataGridViewTemporada.SelectedRows[0].DataBoundItem as Temporada);

            var frmTemporada = new FrmTemporada(AcaoNaTela.Exibir, temporadaSelecionado);
            frmTemporada.ShowDialog();
        }

        private void dataGridViewTemporada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                var temporadaSerieSelecionado = (dataGridViewTemporada.SelectedRows[0].DataBoundItem as Temporada);

                var frmtemporada = new FrmTemporada(AcaoNaTela.Exibir, temporadaSerieSelecionado);
                frmtemporada.ShowDialog();
            }

            if (e.KeyCode == Keys.Delete)
            {
                var question = new FrmCaixaDialogo("question", "Tem certeza que deseja realizar a exclusão? Todos os registros vinculados a esta temporada serão excluídas.", "Excluir").ShowDialog();
                if (question == DialogResult.No)
                    return;
                try
                {
                    var temporada = (dataGridViewTemporada.SelectedRows[0].DataBoundItem as Temporada);
                    var temporadaRegraNegocio = new TemporadaRegraNegocio();
                    string retorno = temporadaRegraNegocio.Manipulacoes("3", temporada);

                    int idTemporada = Convert.ToInt32(retorno);

                    var caixaDialogo = new FrmCaixaDialogo("sucesso", "Temporada selecionada excluída com sucesso.", null).ShowDialog();

                    AtualizarGrid();
                }
                catch (Exception exception)
                {
                    var caixaDialogo = new FrmCaixaDialogo("error", "Não foi possível realizar a exclusão. Detalhes: " + exception.Message, null).ShowDialog();
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}   
