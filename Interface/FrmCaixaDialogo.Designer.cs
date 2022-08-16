
namespace Interface
{
    partial class FrmCaixaDialogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaixaDialogo));
            this.btnOK = new Guna.UI2.WinForms.Guna2Button();
            this.lblMsn = new System.Windows.Forms.Label();
            this.lblMsnBarraTitulo = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBttom = new System.Windows.Forms.Panel();
            this.panelRigth = new System.Windows.Forms.Panel();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.pictureBoxQuestion = new System.Windows.Forms.PictureBox();
            this.pictureBoxWarning = new System.Windows.Forms.PictureBox();
            this.pictureBoxSucesso = new System.Windows.Forms.PictureBox();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            this.panelButtom = new System.Windows.Forms.Panel();
            this.panelOK = new System.Windows.Forms.Panel();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.btnNao = new Guna.UI2.WinForms.Guna2Button();
            this.btnSim = new Guna.UI2.WinForms.Guna2Button();
            this.panelTop.SuspendLayout();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSucesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            this.panelButtom.SuspendLayout();
            this.panelOK.SuspendLayout();
            this.panelQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Animated = true;
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnOK.BorderColor = System.Drawing.Color.Empty;
            this.btnOK.CheckedState.Parent = this.btnOK;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOK.CustomImages.Parent = this.btnOK;
            this.btnOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOK.ForeColor = System.Drawing.Color.LightGray;
            this.btnOK.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnOK.HoverState.Parent = this.btnOK;
            this.btnOK.Location = new System.Drawing.Point(138, 15);
            this.btnOK.Name = "btnOK";
            this.btnOK.PressedColor = System.Drawing.Color.Empty;
            this.btnOK.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnOK.ShadowDecoration.Parent = this.btnOK;
            this.btnOK.Size = new System.Drawing.Size(120, 37);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblMsn
            // 
            this.lblMsn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMsn.AutoEllipsis = true;
            this.lblMsn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMsn.ForeColor = System.Drawing.Color.LightGray;
            this.lblMsn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMsn.Location = new System.Drawing.Point(60, 6);
            this.lblMsn.Margin = new System.Windows.Forms.Padding(0);
            this.lblMsn.Name = "lblMsn";
            this.lblMsn.Size = new System.Drawing.Size(318, 80);
            this.lblMsn.TabIndex = 116;
            this.lblMsn.Text = "msn";
            this.lblMsn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMsn.UseCompatibleTextRendering = true;
            this.lblMsn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverTela_MouseDown);
            // 
            // lblMsnBarraTitulo
            // 
            this.lblMsnBarraTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMsnBarraTitulo.ForeColor = System.Drawing.Color.LightGray;
            this.lblMsnBarraTitulo.Location = new System.Drawing.Point(2, 5);
            this.lblMsnBarraTitulo.Name = "lblMsnBarraTitulo";
            this.lblMsnBarraTitulo.Size = new System.Drawing.Size(396, 23);
            this.lblMsnBarraTitulo.TabIndex = 117;
            this.lblMsnBarraTitulo.Text = "Sucesso!";
            this.lblMsnBarraTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMsnBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverTela_MouseDown);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 35);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(2, 165);
            this.panelLeft.TabIndex = 117;
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverTela_MouseDown);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelTop.Controls.Add(this.lblMsnBarraTitulo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(400, 35);
            this.panelTop.TabIndex = 118;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverTela_MouseDown);
            // 
            // panelBttom
            // 
            this.panelBttom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelBttom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBttom.Location = new System.Drawing.Point(2, 198);
            this.panelBttom.Name = "panelBttom";
            this.panelBttom.Size = new System.Drawing.Size(398, 2);
            this.panelBttom.TabIndex = 119;
            this.panelBttom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverTela_MouseDown);
            // 
            // panelRigth
            // 
            this.panelRigth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelRigth.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRigth.Location = new System.Drawing.Point(398, 35);
            this.panelRigth.Name = "panelRigth";
            this.panelRigth.Size = new System.Drawing.Size(2, 163);
            this.panelRigth.TabIndex = 120;
            this.panelRigth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverTela_MouseDown);
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.lblMsn);
            this.panelCenter.Controls.Add(this.pictureBoxQuestion);
            this.panelCenter.Controls.Add(this.pictureBoxWarning);
            this.panelCenter.Controls.Add(this.pictureBoxSucesso);
            this.panelCenter.Controls.Add(this.pictureBoxError);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(2, 35);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(396, 96);
            this.panelCenter.TabIndex = 121;
            // 
            // pictureBoxQuestion
            // 
            this.pictureBoxQuestion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxQuestion.Image")));
            this.pictureBoxQuestion.Location = new System.Drawing.Point(19, 27);
            this.pictureBoxQuestion.Name = "pictureBoxQuestion";
            this.pictureBoxQuestion.Size = new System.Drawing.Size(38, 42);
            this.pictureBoxQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQuestion.TabIndex = 129;
            this.pictureBoxQuestion.TabStop = false;
            this.pictureBoxQuestion.Visible = false;
            // 
            // pictureBoxWarning
            // 
            this.pictureBoxWarning.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxWarning.Image")));
            this.pictureBoxWarning.Location = new System.Drawing.Point(19, 27);
            this.pictureBoxWarning.Name = "pictureBoxWarning";
            this.pictureBoxWarning.Size = new System.Drawing.Size(38, 42);
            this.pictureBoxWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWarning.TabIndex = 122;
            this.pictureBoxWarning.TabStop = false;
            this.pictureBoxWarning.Visible = false;
            // 
            // pictureBoxSucesso
            // 
            this.pictureBoxSucesso.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSucesso.Image")));
            this.pictureBoxSucesso.Location = new System.Drawing.Point(19, 27);
            this.pictureBoxSucesso.Name = "pictureBoxSucesso";
            this.pictureBoxSucesso.Size = new System.Drawing.Size(38, 42);
            this.pictureBoxSucesso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSucesso.TabIndex = 127;
            this.pictureBoxSucesso.TabStop = false;
            this.pictureBoxSucesso.Visible = false;
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxError.Image")));
            this.pictureBoxError.Location = new System.Drawing.Point(19, 27);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(38, 42);
            this.pictureBoxError.TabIndex = 125;
            this.pictureBoxError.TabStop = false;
            this.pictureBoxError.Visible = false;
            // 
            // panelButtom
            // 
            this.panelButtom.Controls.Add(this.panelOK);
            this.panelButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtom.Location = new System.Drawing.Point(2, 131);
            this.panelButtom.Name = "panelButtom";
            this.panelButtom.Size = new System.Drawing.Size(396, 67);
            this.panelButtom.TabIndex = 128;
            // 
            // panelOK
            // 
            this.panelOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.panelOK.Controls.Add(this.panelQuestion);
            this.panelOK.Controls.Add(this.btnOK);
            this.panelOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOK.Location = new System.Drawing.Point(0, 0);
            this.panelOK.Name = "panelOK";
            this.panelOK.Size = new System.Drawing.Size(396, 67);
            this.panelOK.TabIndex = 0;
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.btnNao);
            this.panelQuestion.Controls.Add(this.btnSim);
            this.panelQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuestion.Location = new System.Drawing.Point(0, 0);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(396, 67);
            this.panelQuestion.TabIndex = 2;
            this.panelQuestion.Visible = false;
            // 
            // btnNao
            // 
            this.btnNao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNao.Animated = true;
            this.btnNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnNao.BorderColor = System.Drawing.Color.Empty;
            this.btnNao.CheckedState.Parent = this.btnNao;
            this.btnNao.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNao.CustomImages.Parent = this.btnNao;
            this.btnNao.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnNao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNao.ForeColor = System.Drawing.Color.LightGray;
            this.btnNao.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnNao.HoverState.Parent = this.btnNao;
            this.btnNao.Location = new System.Drawing.Point(266, 15);
            this.btnNao.Name = "btnNao";
            this.btnNao.PressedColor = System.Drawing.Color.Empty;
            this.btnNao.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnNao.ShadowDecoration.Parent = this.btnNao;
            this.btnNao.Size = new System.Drawing.Size(120, 37);
            this.btnNao.TabIndex = 2;
            this.btnNao.Text = "NÃO";
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // btnSim
            // 
            this.btnSim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSim.Animated = true;
            this.btnSim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnSim.BorderColor = System.Drawing.Color.Empty;
            this.btnSim.CheckedState.Parent = this.btnSim;
            this.btnSim.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSim.CustomImages.Parent = this.btnSim;
            this.btnSim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnSim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSim.ForeColor = System.Drawing.Color.LightGray;
            this.btnSim.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnSim.HoverState.Parent = this.btnSim;
            this.btnSim.Location = new System.Drawing.Point(140, 15);
            this.btnSim.Name = "btnSim";
            this.btnSim.PressedColor = System.Drawing.Color.Empty;
            this.btnSim.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnSim.ShadowDecoration.Parent = this.btnSim;
            this.btnSim.Size = new System.Drawing.Size(120, 37);
            this.btnSim.TabIndex = 1;
            this.btnSim.Text = "SIM";
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // FrmCaixaDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.ControlBox = false;
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelButtom);
            this.Controls.Add(this.panelRigth);
            this.Controls.Add(this.panelBttom);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCaixaDialogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaixaDialogo";
            this.panelTop.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSucesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            this.panelButtom.ResumeLayout(false);
            this.panelOK.ResumeLayout(false);
            this.panelQuestion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnOK;
        private System.Windows.Forms.Label lblMsn;
        private System.Windows.Forms.Label lblMsnBarraTitulo;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBttom;
        private System.Windows.Forms.Panel panelRigth;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.PictureBox pictureBoxWarning;
        private System.Windows.Forms.PictureBox pictureBoxError;
        private System.Windows.Forms.PictureBox pictureBoxSucesso;
        private Guna.UI2.WinForms.Guna2Button btnSim;
        private Guna.UI2.WinForms.Guna2Button btnNao;
        private System.Windows.Forms.Panel panelButtom;
        private System.Windows.Forms.Panel panelOK;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.PictureBox pictureBoxQuestion;
    }
}