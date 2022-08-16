
namespace Interface
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panelCenter = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBloqueioSenha = new System.Windows.Forms.PictureBox();
            this.pictureBoxVerSenha = new System.Windows.Forms.PictureBox();
            this.lblCadastre_se = new System.Windows.Forms.LinkLabel();
            this.txtSenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblInformacaoPG = new System.Windows.Forms.Label();
            this.linkLabelCliqueAqui = new System.Windows.Forms.LinkLabel();
            this.progressBarLogin = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.lblMessageError = new System.Windows.Forms.Label();
            this.linkLabelEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.btnEntrar = new Guna.UI2.WinForms.Guna2Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShapeUsuario = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShapeSenha = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.backgroundWorkerLogin = new System.ComponentModel.BackgroundWorker();
            this.timerFadeIn = new System.Windows.Forms.Timer(this.components);
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelBarraFechar = new System.Windows.Forms.Panel();
            this.btnFechar = new Guna.UI2.WinForms.Guna2Button();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBloqueioSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerSenha)).BeginInit();
            this.panelBarraFechar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Controls.Add(this.pictureBox2);
            this.panelCenter.Controls.Add(this.pictureBox1);
            this.panelCenter.Controls.Add(this.pictureBoxBloqueioSenha);
            this.panelCenter.Controls.Add(this.pictureBoxVerSenha);
            this.panelCenter.Controls.Add(this.lblCadastre_se);
            this.panelCenter.Controls.Add(this.txtSenha);
            this.panelCenter.Controls.Add(this.txtUsuario);
            this.panelCenter.Controls.Add(this.lblInformacaoPG);
            this.panelCenter.Controls.Add(this.linkLabelCliqueAqui);
            this.panelCenter.Controls.Add(this.progressBarLogin);
            this.panelCenter.Controls.Add(this.lblMessageError);
            this.panelCenter.Controls.Add(this.linkLabelEsqueceuSenha);
            this.panelCenter.Controls.Add(this.lblLogin);
            this.panelCenter.Controls.Add(this.lblPergunta);
            this.panelCenter.Controls.Add(this.btnEntrar);
            this.panelCenter.Controls.Add(this.shapeContainer1);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panelCenter.Location = new System.Drawing.Point(210, 30);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(460, 280);
            this.panelCenter.TabIndex = 2;
            this.panelCenter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverTela_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(55, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 105;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxBloqueioSenha
            // 
            this.pictureBoxBloqueioSenha.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBloqueioSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBloqueioSenha.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBloqueioSenha.Image")));
            this.pictureBoxBloqueioSenha.Location = new System.Drawing.Point(379, 83);
            this.pictureBoxBloqueioSenha.Name = "pictureBoxBloqueioSenha";
            this.pictureBoxBloqueioSenha.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxBloqueioSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBloqueioSenha.TabIndex = 102;
            this.pictureBoxBloqueioSenha.TabStop = false;
            this.pictureBoxBloqueioSenha.Click += new System.EventHandler(this.pictureBoxBloqueioSenha_Click);
            // 
            // pictureBoxVerSenha
            // 
            this.pictureBoxVerSenha.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxVerSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVerSenha.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVerSenha.Image")));
            this.pictureBoxVerSenha.Location = new System.Drawing.Point(379, 83);
            this.pictureBoxVerSenha.Name = "pictureBoxVerSenha";
            this.pictureBoxVerSenha.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxVerSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVerSenha.TabIndex = 103;
            this.pictureBoxVerSenha.TabStop = false;
            this.pictureBoxVerSenha.Visible = false;
            this.pictureBoxVerSenha.Click += new System.EventHandler(this.pictureBoxVerSenha_Click);
            // 
            // lblCadastre_se
            // 
            this.lblCadastre_se.ActiveLinkColor = System.Drawing.Color.LightSlateGray;
            this.lblCadastre_se.AutoSize = true;
            this.lblCadastre_se.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCadastre_se.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCadastre_se.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.lblCadastre_se.Location = new System.Drawing.Point(251, 219);
            this.lblCadastre_se.Name = "lblCadastre_se";
            this.lblCadastre_se.Size = new System.Drawing.Size(72, 15);
            this.lblCadastre_se.TabIndex = 9;
            this.lblCadastre_se.TabStop = true;
            this.lblCadastre_se.Text = "Cadastre-se!";
            this.lblCadastre_se.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCadastrese_LinkClicked);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderColor = System.Drawing.Color.Empty;
            this.txtSenha.BorderRadius = 3;
            this.txtSenha.BorderThickness = 0;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.DefaultText = "Senha";
            this.txtSenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.DisabledState.Parent = this.txtSenha;
            this.txtSenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.txtSenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.txtSenha.FocusedState.Parent = this.txtSenha;
            this.txtSenha.ForeColor = System.Drawing.Color.LightSlateGray;
            this.txtSenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.txtSenha.HoverState.Parent = this.txtSenha;
            this.txtSenha.Location = new System.Drawing.Point(55, 72);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSenha.PlaceholderText = "";
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionStart = 5;
            this.txtSenha.ShadowDecoration.Parent = this.txtSenha;
            this.txtSenha.Size = new System.Drawing.Size(349, 42);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TextOffset = new System.Drawing.Point(20, 0);
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderColor = System.Drawing.Color.Empty;
            this.txtUsuario.BorderRadius = 3;
            this.txtUsuario.BorderThickness = 0;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "Usuário";
            this.txtUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.DisabledState.Parent = this.txtUsuario;
            this.txtUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.txtUsuario.FocusedState.Parent = this.txtUsuario;
            this.txtUsuario.ForeColor = System.Drawing.Color.LightSlateGray;
            this.txtUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.txtUsuario.HoverState.Parent = this.txtUsuario;
            this.txtUsuario.Location = new System.Drawing.Point(54, 33);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUsuario.PlaceholderText = "";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionStart = 7;
            this.txtUsuario.ShadowDecoration.Parent = this.txtUsuario;
            this.txtUsuario.Size = new System.Drawing.Size(350, 36);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextOffset = new System.Drawing.Point(20, 0);
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // lblInformacaoPG
            // 
            this.lblInformacaoPG.AutoSize = true;
            this.lblInformacaoPG.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblInformacaoPG.ForeColor = System.Drawing.Color.LightGray;
            this.lblInformacaoPG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInformacaoPG.Location = new System.Drawing.Point(66, 138);
            this.lblInformacaoPG.Name = "lblInformacaoPG";
            this.lblInformacaoPG.Size = new System.Drawing.Size(73, 12);
            this.lblInformacaoPG.TabIndex = 5;
            this.lblInformacaoPG.Text = "Para saber mais";
            this.lblInformacaoPG.Visible = false;
            // 
            // linkLabelCliqueAqui
            // 
            this.linkLabelCliqueAqui.ActiveLinkColor = System.Drawing.Color.LightSlateGray;
            this.linkLabelCliqueAqui.AutoSize = true;
            this.linkLabelCliqueAqui.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.linkLabelCliqueAqui.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabelCliqueAqui.Location = new System.Drawing.Point(138, 138);
            this.linkLabelCliqueAqui.Name = "linkLabelCliqueAqui";
            this.linkLabelCliqueAqui.Size = new System.Drawing.Size(57, 12);
            this.linkLabelCliqueAqui.TabIndex = 6;
            this.linkLabelCliqueAqui.TabStop = true;
            this.linkLabelCliqueAqui.Text = "Clique aqui!";
            this.linkLabelCliqueAqui.Visible = false;
            // 
            // progressBarLogin
            // 
            this.progressBarLogin.BackColor = System.Drawing.Color.Transparent;
            this.progressBarLogin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarLogin.FillColor = System.Drawing.Color.Empty;
            this.progressBarLogin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.progressBarLogin.Location = new System.Drawing.Point(0, 270);
            this.progressBarLogin.Name = "progressBarLogin";
            this.progressBarLogin.ProgressColor = System.Drawing.Color.LightGray;
            this.progressBarLogin.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.progressBarLogin.ShadowDecoration.Parent = this.progressBarLogin;
            this.progressBarLogin.Size = new System.Drawing.Size(460, 10);
            this.progressBarLogin.TabIndex = 11;
            this.progressBarLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // lblMessageError
            // 
            this.lblMessageError.AutoSize = true;
            this.lblMessageError.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Italic);
            this.lblMessageError.ForeColor = System.Drawing.Color.LightGray;
            this.lblMessageError.Image = ((System.Drawing.Image)(resources.GetObject("lblMessageError.Image")));
            this.lblMessageError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessageError.Location = new System.Drawing.Point(52, 124);
            this.lblMessageError.Name = "lblMessageError";
            this.lblMessageError.Size = new System.Drawing.Size(81, 12);
            this.lblMessageError.TabIndex = 4;
            this.lblMessageError.Text = "     Error Message";
            this.lblMessageError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMessageError.Visible = false;
            // 
            // linkLabelEsqueceuSenha
            // 
            this.linkLabelEsqueceuSenha.ActiveLinkColor = System.Drawing.Color.LightSlateGray;
            this.linkLabelEsqueceuSenha.AutoSize = true;
            this.linkLabelEsqueceuSenha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkLabelEsqueceuSenha.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabelEsqueceuSenha.Location = new System.Drawing.Point(172, 239);
            this.linkLabelEsqueceuSenha.Name = "linkLabelEsqueceuSenha";
            this.linkLabelEsqueceuSenha.Size = new System.Drawing.Size(117, 15);
            this.linkLabelEsqueceuSenha.TabIndex = 10;
            this.linkLabelEsqueceuSenha.TabStop = true;
            this.linkLabelEsqueceuSenha.Text = "Esqueceu sua senha?";
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(194, 3);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(73, 28);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "LOGIN";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPergunta.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblPergunta.Location = new System.Drawing.Point(136, 220);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(118, 15);
            this.lblPergunta.TabIndex = 8;
            this.lblPergunta.Text = "Não tem uma conta?";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Animated = true;
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnEntrar.BorderColor = System.Drawing.Color.Empty;
            this.btnEntrar.BorderThickness = 1;
            this.btnEntrar.CheckedState.Parent = this.btnEntrar;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.CustomImages.Parent = this.btnEntrar;
            this.btnEntrar.FillColor = System.Drawing.Color.Empty;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEntrar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEntrar.HoverState.Parent = this.btnEntrar;
            this.btnEntrar.Location = new System.Drawing.Point(54, 164);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.PressedColor = System.Drawing.Color.Empty;
            this.btnEntrar.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnEntrar.ShadowDecoration.Parent = this.btnEntrar;
            this.btnEntrar.Size = new System.Drawing.Size(352, 45);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShapeUsuario,
            this.lineShapeSenha});
            this.shapeContainer1.Size = new System.Drawing.Size(460, 280);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShapeUsuario
            // 
            this.lineShapeUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.lineShapeUsuario.Enabled = false;
            this.lineShapeUsuario.Name = "lineShapeUsuario";
            this.lineShapeUsuario.X1 = 405;
            this.lineShapeUsuario.X2 = 55;
            this.lineShapeUsuario.Y1 = 70;
            this.lineShapeUsuario.Y2 = 70;
            // 
            // lineShapeSenha
            // 
            this.lineShapeSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.lineShapeSenha.Enabled = false;
            this.lineShapeSenha.Name = "lineShapeSenha";
            this.lineShapeSenha.X1 = 405;
            this.lineShapeSenha.X2 = 55;
            this.lineShapeSenha.Y1 = 114;
            this.lineShapeSenha.Y2 = 114;
            // 
            // backgroundWorkerLogin
            // 
            this.backgroundWorkerLogin.WorkerReportsProgress = true;
            this.backgroundWorkerLogin.WorkerSupportsCancellation = true;
            this.backgroundWorkerLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLogin_DoWork);
            this.backgroundWorkerLogin.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerLogin_ProgressChanged);
            this.backgroundWorkerLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLogin_RunWorkerCompleted);
            // 
            // timerFadeIn
            // 
            this.timerFadeIn.Enabled = true;
            this.timerFadeIn.Interval = 30;
            this.timerFadeIn.Tick += new System.EventHandler(this.timerFadeIn_Tick);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelSide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSide.BackgroundImage")));
            this.panelSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(210, 310);
            this.panelSide.TabIndex = 0;
            this.panelSide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverTela_MouseDown);
            // 
            // panelBarraFechar
            // 
            this.panelBarraFechar.Controls.Add(this.btnFechar);
            this.panelBarraFechar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraFechar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panelBarraFechar.Location = new System.Drawing.Point(210, 0);
            this.panelBarraFechar.Name = "panelBarraFechar";
            this.panelBarraFechar.Size = new System.Drawing.Size(460, 30);
            this.panelBarraFechar.TabIndex = 1;
            this.panelBarraFechar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoverTela_MouseDown);
            // 
            // btnFechar
            // 
            this.btnFechar.BorderColor = System.Drawing.Color.Empty;
            this.btnFechar.CheckedState.Parent = this.btnFechar;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.CustomImages.Parent = this.btnFechar;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.FillColor = System.Drawing.Color.Empty;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnFechar.HoverState.Parent = this.btnFechar;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageSize = new System.Drawing.Size(14, 14);
            this.btnFechar.Location = new System.Drawing.Point(431, 8);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.PressedColor = System.Drawing.Color.Empty;
            this.btnFechar.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnFechar.ShadowDecoration.Parent = this.btnFechar;
            this.btnFechar.Size = new System.Drawing.Size(17, 14);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(670, 310);
            this.ControlBox = false;
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panelBarraFechar);
            this.Controls.Add(this.panelSide);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.FrmLogin_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBloqueioSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerSenha)).EndInit();
            this.panelBarraFechar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Label lblPergunta;
        private Guna.UI2.WinForms.Guna2Button btnEntrar;
        private System.Windows.Forms.Label lblLogin;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShapeUsuario;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShapeSenha;
        private System.Windows.Forms.LinkLabel linkLabelEsqueceuSenha;
        private System.Windows.Forms.Label lblMessageError;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLogin;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBarLogin;
        private System.Windows.Forms.LinkLabel linkLabelCliqueAqui;
        private System.Windows.Forms.Label lblInformacaoPG;
        private System.Windows.Forms.Timer timerFadeIn;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtSenha;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelBarraFechar;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
        private System.Windows.Forms.LinkLabel lblCadastre_se;
        private System.Windows.Forms.PictureBox pictureBoxBloqueioSenha;
        private System.Windows.Forms.PictureBox pictureBoxVerSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}