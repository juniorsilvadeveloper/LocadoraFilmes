using System;
using System.Media;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Interface
{
    public partial class FrmCaixaDialogo : Form
    {
        #region Método para arrastar a tela

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

        public FrmCaixaDialogo()
        {
            InitializeComponent();

            #region Eliminar oscilação do formulário ou controles da interface
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            #endregion
        }

        public FrmCaixaDialogo(string TipoDialogo, string msn, string msnDialogo)
        {
            InitializeComponent();

            lblMsn.Text = msn;

            switch (TipoDialogo)
            {
                case "question":
                    panelQuestion.Visible = true;
                    pictureBoxQuestion.Visible = true;
                    btnOK.Visible = false;
                    lblMsnBarraTitulo.Text = msnDialogo;
                    SystemSounds.Question.Play();
                    break;

                case "warning":
                    pictureBoxWarning.Visible = true;
                    lblMsnBarraTitulo.Text = "Ops!";
                    SystemSounds.Asterisk.Play();
                    break;

                case "error":
                    pictureBoxError.Visible = true;
                    lblMsnBarraTitulo.Text = "Error";
                    SystemSounds.Hand.Play();
                    break;

                case "sucesso":
                    pictureBoxSucesso.Visible = true;
                    lblMsnBarraTitulo.Text = "Sucesso";
                    //SystemSounds.Asterisk.Play();
                    break;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
