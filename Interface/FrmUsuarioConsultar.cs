using ObjetoTransferencia;
using RegraNegocio;
using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmUsuarioConsultar : Form
    {
        private void FrmUsuarioConsultar_Load(object sender, EventArgs e)
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

        public FrmUsuarioConsultar()
        {
            InitializeComponent();
            dataGridViewUsuario.AutoGenerateColumns = false;

            ComboBoxTipoUsuario.SelectedItem = "USUÁRIOS";

            if (LoginSistema.UsuarioLogin.IDTipoUsuario.IDTipoUsuario == 1)
                ComboBoxTipoUsuario.Visible = true;

            if (LoginSistema.UsuarioLogin.IDTipoUsuario.IDTipoUsuario > 1)
                panelBtnNovo.Visible = false;
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioButtonID.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void LimparPesquisa()
        {
            txtPesquisar.Text = string.Empty;
            txtPesquisar.Focus();
        }

        private void ComboBoxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPesquisar.Focus();
        }

        private void radioButtonIDUsuario_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewUsuario.DataSource = null;
        }

        private void radioButtonNome_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewUsuario.DataSource = null;
        }

        private void radioButtonUsuarioLogin_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewUsuario.DataSource = null;
        }

        private void RadioButtonAtivo_Inativo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewUsuario.DataSource = null;
        }

        private void RadioButtonAtivo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewUsuario.DataSource = null;
        }

        private void RadioButtonInativo_CheckedChanged(object sender, EventArgs e)
        {
            LimparPesquisa();
            dataGridViewUsuario.DataSource = null;
        }

        private void AtualizarGrid()
        {
            var usuarioRegraNegocio = new UsuarioRegraNegocio();

            string situacao = null;
            string tipoUsuario = null;

            if (radioButtonAtivo.Checked)
                situacao = "1";
            else if (radioButtonInativo.Checked)
                situacao = "0";

            if (LoginSistema.UsuarioLogin.IDTipoUsuario.IDTipoUsuario == 1)
            {
                if (ComboBoxTipoUsuario.SelectedItem.ToString() == "ADMINISTRADOR")
                    tipoUsuario = "1";
                if (ComboBoxTipoUsuario.SelectedItem.ToString() == "COLABORADOR")
                    tipoUsuario = "2";
                else if (ComboBoxTipoUsuario.SelectedItem.ToString() == "VISITANTE")
                    tipoUsuario = "3";
            }
            else
            {
                tipoUsuario = "3";
            }

            if (radioButtonID.Checked)
            {
                dataGridViewUsuario.DataSource = null;
                dataGridViewUsuario.DataSource = usuarioRegraNegocio.Consultar(
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    null,
                    tipoUsuario,
                    situacao);
                dataGridViewUsuario.Update();
                dataGridViewUsuario.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewUsuario.RowCount.ToString();
            }
            else if (radioButtonUsuarioLogin.Checked)
            {
                dataGridViewUsuario.DataSource = null;
                dataGridViewUsuario.DataSource = usuarioRegraNegocio.Consultar(
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    null,
                    tipoUsuario,
                    situacao);
                dataGridViewUsuario.Update();
                dataGridViewUsuario.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewUsuario.RowCount.ToString();
            }
            else if (radioButtonNomeReal.Checked)
            {
                dataGridViewUsuario.DataSource = null;
                dataGridViewUsuario.DataSource = usuarioRegraNegocio.Consultar(
                    null,
                    null,
                    txtPesquisar.Text == string.Empty ? null : txtPesquisar.Text.ToString(),
                    tipoUsuario,
                    situacao);
                dataGridViewUsuario.Update();
                dataGridViewUsuario.Refresh();
                lblTotalRegistros.Text = "Total Registro(s): " + dataGridViewUsuario.RowCount.ToString();
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

        private void dataGridViewUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dataGridViewUsuario.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dataGridViewUsuario.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = ValidadorDados.CarregarPropriedade
                        (
                            dataGridViewUsuario.Rows[e.RowIndex].DataBoundItem,
                            dataGridViewUsuario.Columns[e.ColumnIndex].DataPropertyName
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
                var frmUsuario = new FrmUsuario(AcaoNaTela.Novo, null, 0);
                DialogResult dialogResult = frmUsuario.ShowDialog();

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
            if (dataGridViewUsuario.SelectedRows.Count == 0)
            {
                var warning = new FrmCaixaDialogo("warning", "Nenhum usuário selecionado.", null).ShowDialog();
                return;
            }

            try
            {
                var usuario = (dataGridViewUsuario.SelectedRows[0].DataBoundItem as Usuario);
                var frmUsuario = new FrmUsuario(AcaoNaTela.Editar, usuario, 0);
                frmUsuario.ShowDialog();

                AtualizarGrid();
            }
            catch (Exception exception)
            {
                var caixaDialogo = new FrmCaixaDialogo("error", "Não foi possível editar o usuário. Detalhes: " + exception.Message, null).ShowDialog();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuario.SelectedRows.Count == 0)
            {
                var warning = new FrmCaixaDialogo("warning", "Nenhum usuário selecionado.", null).ShowDialog();
                txtPesquisar.Focus();
                return;
            }

            var question = new FrmCaixaDialogo("question", "Deseja excluir o usuário selecioado?", "Excluir").ShowDialog();
            if (question == DialogResult.No)
                return;
            try
            {
                var usuario = (dataGridViewUsuario.SelectedRows[0].DataBoundItem as Usuario);
                var usuarioRegraNegocio = new UsuarioRegraNegocio();
                string retorno = usuarioRegraNegocio.Manipulacoes("3", usuario);

                int idUsuario = Convert.ToInt32(retorno);

                var caixaDialogo = new FrmCaixaDialogo("sucesso", "Usuário selecionado excluído com sucesso.", null).ShowDialog();

                AtualizarGrid();
            }
            catch (Exception)
            {
                var caixaDialogo = new FrmCaixaDialogo("error", "Não foi possível realizar a exclusão. Detalhes: Existem atividades vinculadas a este usuário no sistema.", null).ShowDialog();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dataGridViewUsuario.DataSource = null;
        }

        private void dataGridViewUsuario_DoubleClick(object sender, EventArgs e)
        {
            var usuarioSelecionado = (dataGridViewUsuario.SelectedRows[0].DataBoundItem as Usuario);

            var usuario = new FrmUsuario(AcaoNaTela.Exibir, usuarioSelecionado, 0);
            usuario.ShowDialog();
        }

        private void dataGridViewUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                var usuarioSelecionado = (dataGridViewUsuario.SelectedRows[0].DataBoundItem as Usuario);

                var usuario = new FrmUsuario(AcaoNaTela.Exibir, usuarioSelecionado, 0);
                usuario.ShowDialog();
            }

            if (e.KeyCode == Keys.Delete)
            {
                var question = new FrmCaixaDialogo("question", "Deseja excluir o usuário selecioado?", "Excluir").ShowDialog();
                if (question == DialogResult.No)
                    return;

                try
                {
                    var usuario = (dataGridViewUsuario.SelectedRows[0].DataBoundItem as Usuario);
                    var usuarioRegraNegocio = new UsuarioRegraNegocio();
                    string retorno = usuarioRegraNegocio.Manipulacoes("3", usuario);

                    int idUsuario = Convert.ToInt32(retorno);

                    var caixaDialogo = new FrmCaixaDialogo("sucesso", "Usuário selecionado excluído com sucesso.", null).ShowDialog();

                    AtualizarGrid();
                }
                catch (Exception)
                {
                    var caixaDialogo = new FrmCaixaDialogo("error", "Não foi possível realizar a exclusão. Detalhes: Existem atividades vinculadas a este usuário no sistema.", null).ShowDialog();

                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
