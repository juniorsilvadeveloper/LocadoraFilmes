using ObjetoTransferencia;
using RegraNegocio;
using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmEpisodioConsultar : Form
    {
        private void FrmEpisodioConsultar_Load(object sender, EventArgs e)
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

        public FrmEpisodioConsultar()
        {
            InitializeComponent();
            dataGridViewEpisodio.AutoGenerateColumns = false;
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonID.Checked || radioButtonNumeroEpisodio.Checked || 
                radioButtonIDTemporada.Checked || radioButtonNumeroTemporada.Checked || radioButtonIDSerie.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    e.Handled = true;
            }

            if (radioButtonNumeroEpisodio.Checked)
                txtPesquisar.MaxLength = 3;
            else if (radioButtonNumeroTemporada.Checked)
                txtPesquisar.MaxLength = 3;
        }

        private void LimparPesquisa()
        {
            txtPesquisar.Text = string.Empty;
            txtPesquisar.Focus();
        }

        private void radioButtonID_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewEpisodio.DataSource = null;
        }

        private void radioButtonTitulo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewEpisodio.DataSource = null;
        }

        private void radioButtonNumeroEpisodio_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewEpisodio.DataSource = null;
        }

        private void radioButtonIDTemporada_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewEpisodio.DataSource = null;
        }

        private void radioButtonNomeTemporada_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewEpisodio.DataSource = null;
        }

        private void radioButtonNumeroTemporada_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewEpisodio.DataSource = null;
        }

        private void radioButtonIDSerie_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewEpisodio.DataSource = null;
        }

        private void radioButtonNomeSerie_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewEpisodio.DataSource = null;
        }

        private void radioButtonAtivo_Inativo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewEpisodio.DataSource = null;
        }

        private void radioButtonAtivo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewEpisodio.DataSource = null;
        }

        private void radioButtonInativo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewEpisodio.DataSource = null;
        }

        private void AtualizarGrid()
        {
            var episodioRegraNegocio = new EpisodioRegraNegocio();

            string situacao = null;

            if (radioButtonAtivo.Checked)
                situacao = "1";
            else if (radioButtonInativo.Checked)
                situacao = "0";

            if (radioButtonID.Checked)
            {
                dataGridViewEpisodio.DataSource = null;
                dataGridViewEpisodio.DataSource = episodioRegraNegocio.Consultar(
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    situacao);
                dataGridViewEpisodio.Update();
                dataGridViewEpisodio.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewEpisodio.RowCount.ToString();
            }
            else if (radioButtonTitulo.Checked)
            {
                dataGridViewEpisodio.DataSource = null;
                dataGridViewEpisodio.DataSource = episodioRegraNegocio.Consultar(
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    situacao);
                dataGridViewEpisodio.Update();
                dataGridViewEpisodio.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewEpisodio.RowCount.ToString();
            }
            else if (radioButtonNumeroEpisodio.Checked)
            {
                dataGridViewEpisodio.DataSource = null;
                dataGridViewEpisodio.DataSource = episodioRegraNegocio.Consultar(
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    null,
                    null,
                    null,
                    situacao);
                dataGridViewEpisodio.Update();
                dataGridViewEpisodio.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewEpisodio.RowCount.ToString();
            }
            else if (radioButtonIDTemporada.Checked)
            {
                dataGridViewEpisodio.DataSource = null;
                dataGridViewEpisodio.DataSource = episodioRegraNegocio.Consultar(
                    null,
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    null,
                    null,
                    situacao);
                dataGridViewEpisodio.Update();
                dataGridViewEpisodio.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewEpisodio.RowCount.ToString();
            }
            else if (radioButtonNomeTemporada.Checked)
            {
                dataGridViewEpisodio.DataSource = null;
                dataGridViewEpisodio.DataSource = episodioRegraNegocio.Consultar(
                    null,
                    null,
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    null,
                    situacao);
                dataGridViewEpisodio.Update();
                dataGridViewEpisodio.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewEpisodio.RowCount.ToString();
            }
            else if (radioButtonIDSerie.Checked)
            {
                dataGridViewEpisodio.DataSource = null;
                dataGridViewEpisodio.DataSource = episodioRegraNegocio.Consultar(
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    situacao);
                dataGridViewEpisodio.Update();
                dataGridViewEpisodio.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewEpisodio.RowCount.ToString();
            }
            else if (radioButtonNomeSerie.Checked)
            {
                dataGridViewEpisodio.DataSource = null;
                dataGridViewEpisodio.DataSource = episodioRegraNegocio.Consultar(
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    situacao);
                dataGridViewEpisodio.Update();
                dataGridViewEpisodio.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewEpisodio.RowCount.ToString();
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

        private void dataGridViewEpisodio_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewEpisodio.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewEpisodio.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewEpisodio.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewEpisodio.Columns[e.ColumnIndex].DataPropertyName
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
                var frmEpisodio = new FrmEpisodio(AcaoNaTela.Novo, null);
                DialogResult dialogResult = frmEpisodio.ShowDialog();

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
            if (dataGridViewEpisodio.SelectedRows.Count == 0)
            {
                var warning = new FrmCaixaDialogo("warning", "Nenhum episódio selecionado.", null).ShowDialog();
                return;
            }

            try
            {
                var episodio = (dataGridViewEpisodio.SelectedRows[0].DataBoundItem as Episodio);
                var frmEpisodio = new FrmEpisodio(AcaoNaTela.Editar, episodio);
                frmEpisodio.ShowDialog();

                AtualizarGrid();
            }
            catch (Exception exception)
            {
                var caixaDialogo = new FrmCaixaDialogo("error", "Não foi possível editar o episódio. Detalhes: " + exception.Message, null).ShowDialog();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewEpisodio.SelectedRows.Count == 0)
            {
                var warning = new FrmCaixaDialogo("warning", "Nenhum episódio selecionado.", null).ShowDialog();
                txtPesquisar.Focus();
                return;
            }

            var question = new FrmCaixaDialogo("question", "Deseja excluir o episódio selecioado?", "Excluir").ShowDialog();
            if (question == DialogResult.No)
                return;

            try
            {
                var episodio = (dataGridViewEpisodio.SelectedRows[0].DataBoundItem as Episodio);
                var episodioRegraNegocio = new EpisodioRegraNegocio();
                string retorno = episodioRegraNegocio.Manipulacoes("3", episodio);

                int idEpisodio = Convert.ToInt32(retorno);

                var caixaDialogo = new FrmCaixaDialogo("sucesso", "Episódio selecionado excluído com sucesso.", null).ShowDialog();

                AtualizarGrid();
            }
            catch (Exception exception)
            {
                var caixaDialogo = new FrmCaixaDialogo("error", "Não foi possível realizar a exclusão. Detalhes: " + exception.Message, null).ShowDialog();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dataGridViewEpisodio.DataSource = null;
        }

        private void dataGridViewEpisodio_DoubleClick(object sender, EventArgs e)
        {
            var episodioSelecionado = (dataGridViewEpisodio.SelectedRows[0].DataBoundItem as Episodio);

            var frmEpisodio = new FrmEpisodio(AcaoNaTela.Exibir, episodioSelecionado);
            frmEpisodio.ShowDialog();
        }

        private void dataGridViewEpisodio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                var episodioSelecionado = (dataGridViewEpisodio.SelectedRows[0].DataBoundItem as Episodio);

                var frmEpisodio = new FrmEpisodio(AcaoNaTela.Exibir, episodioSelecionado);
                frmEpisodio.ShowDialog();
            }

            if (e.KeyCode == Keys.Delete)
            {
                var question = new FrmCaixaDialogo("question", "Deseja excluir o episódio selecioado?", "Excluir").ShowDialog();
                if (question == DialogResult.No)
                    return;

                try
                {
                    var episodio = (dataGridViewEpisodio.SelectedRows[0].DataBoundItem as Episodio);
                    var episodioRegraNegocio = new EpisodioRegraNegocio();
                    string retorno = episodioRegraNegocio.Manipulacoes("3", episodio);

                    int idEpisodio = Convert.ToInt32(retorno);

                    var caixaDialogo = new FrmCaixaDialogo("sucesso", "Episódio selecionado excluído com sucesso.", null).ShowDialog();

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
