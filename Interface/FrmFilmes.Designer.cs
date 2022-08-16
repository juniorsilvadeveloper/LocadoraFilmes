
namespace Interface
{
    partial class FrmFilmes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilmes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLimpar = new Guna.UI2.WinForms.Guna2Button();
            this.radioButtonGenero = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.radioButtonTitulo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnAssistir = new Guna.UI2.WinForms.Guna2Button();
            this.radioButtonProdutor_Editora = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonAno = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtPesquisar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeguir = new Guna.UI2.WinForms.Guna2Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.PictureBoxFilmes = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnFechar = new Guna.UI2.WinForms.Guna2Button();
            this.lblFilmes = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dataGridViewFilmes = new System.Windows.Forms.DataGridView();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdutor_Editor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdministrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssistir = new System.Windows.Forms.DataGridViewImageColumn();
            this.colSeguir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.timerFadeIn = new System.Windows.Forms.Timer(this.components);
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Animated = true;
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnLimpar.CheckedState.Parent = this.btnLimpar;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.CustomImages.Parent = this.btnLimpar;
            this.btnLimpar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnLimpar.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnLimpar.HoverState.Parent = this.btnLimpar;
            this.btnLimpar.Location = new System.Drawing.Point(1142, 230);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.PressedColor = System.Drawing.Color.Empty;
            this.btnLimpar.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnLimpar.ShadowDecoration.Parent = this.btnLimpar;
            this.btnLimpar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpar.TabIndex = 164;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // radioButtonGenero
            // 
            this.radioButtonGenero.Animated = true;
            this.radioButtonGenero.AutoSize = true;
            this.radioButtonGenero.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonGenero.CheckedState.BorderThickness = 0;
            this.radioButtonGenero.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonGenero.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonGenero.CheckedState.InnerOffset = -4;
            this.radioButtonGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonGenero.FlatAppearance.BorderSize = 0;
            this.radioButtonGenero.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonGenero.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonGenero.Location = new System.Drawing.Point(68, 108);
            this.radioButtonGenero.Name = "radioButtonGenero";
            this.radioButtonGenero.Size = new System.Drawing.Size(63, 17);
            this.radioButtonGenero.TabIndex = 157;
            this.radioButtonGenero.Text = "Gênero";
            this.radioButtonGenero.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonGenero.UncheckedState.BorderThickness = 2;
            this.radioButtonGenero.UseVisualStyleBackColor = true;
            this.radioButtonGenero.CheckedChanged += new System.EventHandler(this.radioButtonGenero_CheckedChanged);
            // 
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTotalRegistros.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotalRegistros.Location = new System.Drawing.Point(5, 628);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(101, 13);
            this.lblTotalRegistros.TabIndex = 148;
            this.lblTotalRegistros.Text = "Total Registro(s): 0";
            // 
            // radioButtonTitulo
            // 
            this.radioButtonTitulo.Animated = true;
            this.radioButtonTitulo.AutoSize = true;
            this.radioButtonTitulo.Checked = true;
            this.radioButtonTitulo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonTitulo.CheckedState.BorderThickness = 0;
            this.radioButtonTitulo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonTitulo.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonTitulo.CheckedState.InnerOffset = -4;
            this.radioButtonTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonTitulo.FlatAppearance.BorderSize = 0;
            this.radioButtonTitulo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonTitulo.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonTitulo.Location = new System.Drawing.Point(8, 108);
            this.radioButtonTitulo.Name = "radioButtonTitulo";
            this.radioButtonTitulo.Size = new System.Drawing.Size(54, 17);
            this.radioButtonTitulo.TabIndex = 147;
            this.radioButtonTitulo.TabStop = true;
            this.radioButtonTitulo.Text = "Título";
            this.radioButtonTitulo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonTitulo.UncheckedState.BorderThickness = 2;
            this.radioButtonTitulo.UseVisualStyleBackColor = true;
            this.radioButtonTitulo.CheckedChanged += new System.EventHandler(this.radioButtonTitulo_CheckedChanged);
            // 
            // btnAssistir
            // 
            this.btnAssistir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssistir.Animated = true;
            this.btnAssistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnAssistir.CheckedState.Parent = this.btnAssistir;
            this.btnAssistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssistir.CustomImages.Parent = this.btnAssistir;
            this.btnAssistir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnAssistir.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAssistir.ForeColor = System.Drawing.Color.LightGray;
            this.btnAssistir.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnAssistir.HoverState.Parent = this.btnAssistir;
            this.btnAssistir.Location = new System.Drawing.Point(1142, 184);
            this.btnAssistir.Name = "btnAssistir";
            this.btnAssistir.PressedColor = System.Drawing.Color.Empty;
            this.btnAssistir.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnAssistir.ShadowDecoration.Parent = this.btnAssistir;
            this.btnAssistir.Size = new System.Drawing.Size(150, 40);
            this.btnAssistir.TabIndex = 163;
            this.btnAssistir.Text = "ASSISTIR";
            this.btnAssistir.Click += new System.EventHandler(this.btnAssistir_Click);
            // 
            // radioButtonProdutor_Editora
            // 
            this.radioButtonProdutor_Editora.Animated = true;
            this.radioButtonProdutor_Editora.AutoSize = true;
            this.radioButtonProdutor_Editora.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonProdutor_Editora.CheckedState.BorderThickness = 0;
            this.radioButtonProdutor_Editora.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonProdutor_Editora.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonProdutor_Editora.CheckedState.InnerOffset = -4;
            this.radioButtonProdutor_Editora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonProdutor_Editora.FlatAppearance.BorderSize = 0;
            this.radioButtonProdutor_Editora.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonProdutor_Editora.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonProdutor_Editora.Location = new System.Drawing.Point(189, 108);
            this.radioButtonProdutor_Editora.Name = "radioButtonProdutor_Editora";
            this.radioButtonProdutor_Editora.Size = new System.Drawing.Size(135, 17);
            this.radioButtonProdutor_Editora.TabIndex = 162;
            this.radioButtonProdutor_Editora.Text = "Produtor(a) | Editor(a)";
            this.radioButtonProdutor_Editora.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonProdutor_Editora.UncheckedState.BorderThickness = 2;
            this.radioButtonProdutor_Editora.UseVisualStyleBackColor = true;
            this.radioButtonProdutor_Editora.CheckedChanged += new System.EventHandler(this.radioButtonProdutor_Editora_CheckedChanged);
            // 
            // radioButtonAno
            // 
            this.radioButtonAno.Animated = true;
            this.radioButtonAno.AutoSize = true;
            this.radioButtonAno.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAno.CheckedState.BorderThickness = 0;
            this.radioButtonAno.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAno.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonAno.CheckedState.InnerOffset = -4;
            this.radioButtonAno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAno.FlatAppearance.BorderSize = 0;
            this.radioButtonAno.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonAno.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonAno.Location = new System.Drawing.Point(137, 108);
            this.radioButtonAno.Name = "radioButtonAno";
            this.radioButtonAno.Size = new System.Drawing.Size(46, 17);
            this.radioButtonAno.TabIndex = 161;
            this.radioButtonAno.Text = "Ano";
            this.radioButtonAno.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAno.UncheckedState.BorderThickness = 2;
            this.radioButtonAno.UseVisualStyleBackColor = true;
            this.radioButtonAno.CheckedChanged += new System.EventHandler(this.radioButtonAno_CheckedChanged);
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(8, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1284, 8);
            this.panelTop.TabIndex = 151;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Animated = true;
            this.txtPesquisar.BorderRadius = 3;
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisar.DefaultText = "";
            this.txtPesquisar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisar.DisabledState.Parent = this.txtPesquisar;
            this.txtPesquisar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.txtPesquisar.FocusedState.Parent = this.txtPesquisar;
            this.txtPesquisar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.txtPesquisar.HoverState.Parent = this.txtPesquisar;
            this.txtPesquisar.Location = new System.Drawing.Point(8, 66);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PasswordChar = '\0';
            this.txtPesquisar.PlaceholderText = "";
            this.txtPesquisar.SelectedText = "";
            this.txtPesquisar.ShadowDecoration.Parent = this.txtPesquisar;
            this.txtPesquisar.Size = new System.Drawing.Size(1128, 29);
            this.txtPesquisar.TabIndex = 156;
            this.txtPesquisar.TextOffset = new System.Drawing.Point(0, 1);
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Animated = true;
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnPesquisar.CheckedState.Parent = this.btnPesquisar;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.CustomImages.Parent = this.btnPesquisar;
            this.btnPesquisar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.LightGray;
            this.btnPesquisar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnPesquisar.HoverState.Parent = this.btnPesquisar;
            this.btnPesquisar.Location = new System.Drawing.Point(1142, 60);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.PressedColor = System.Drawing.Color.Empty;
            this.btnPesquisar.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnPesquisar.ShadowDecoration.Parent = this.btnPesquisar;
            this.btnPesquisar.Size = new System.Drawing.Size(150, 40);
            this.btnPesquisar.TabIndex = 155;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnSeguir
            // 
            this.btnSeguir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeguir.Animated = true;
            this.btnSeguir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnSeguir.CheckedState.Parent = this.btnSeguir;
            this.btnSeguir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeguir.CustomImages.Parent = this.btnSeguir;
            this.btnSeguir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnSeguir.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnSeguir.ForeColor = System.Drawing.Color.LightGray;
            this.btnSeguir.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnSeguir.HoverState.Parent = this.btnSeguir;
            this.btnSeguir.Location = new System.Drawing.Point(1142, 138);
            this.btnSeguir.Name = "btnSeguir";
            this.btnSeguir.PressedColor = System.Drawing.Color.Empty;
            this.btnSeguir.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnSeguir.ShadowDecoration.Parent = this.btnSeguir;
            this.btnSeguir.Size = new System.Drawing.Size(150, 40);
            this.btnSeguir.TabIndex = 153;
            this.btnSeguir.Text = "SEGUIR";
            this.btnSeguir.Click += new System.EventHandler(this.btnSeguir_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelBarraTitulo.Controls.Add(this.PictureBoxFilmes);
            this.panelBarraTitulo.Controls.Add(this.btnFechar);
            this.panelBarraTitulo.Controls.Add(this.lblFilmes);
            this.panelBarraTitulo.Location = new System.Drawing.Point(8, 8);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1284, 40);
            this.panelBarraTitulo.TabIndex = 152;
            // 
            // PictureBoxFilmes
            // 
            this.PictureBoxFilmes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxFilmes.BackgroundImage")));
            this.PictureBoxFilmes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBoxFilmes.Cursor = System.Windows.Forms.Cursors.Default;
            this.PictureBoxFilmes.Location = new System.Drawing.Point(7, 5);
            this.PictureBoxFilmes.Name = "PictureBoxFilmes";
            this.PictureBoxFilmes.ShadowDecoration.Parent = this.PictureBoxFilmes;
            this.PictureBoxFilmes.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxFilmes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxFilmes.TabIndex = 94;
            this.PictureBoxFilmes.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.CheckedState.Parent = this.btnFechar;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.CustomImages.Parent = this.btnFechar;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.FillColor = System.Drawing.Color.Empty;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnFechar.ForeColor = System.Drawing.Color.LightGray;
            this.btnFechar.HoverState.Parent = this.btnFechar;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageSize = new System.Drawing.Size(18, 18);
            this.btnFechar.Location = new System.Drawing.Point(1233, 8);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.PressedColor = System.Drawing.Color.Empty;
            this.btnFechar.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnFechar.ShadowDecoration.Parent = this.btnFechar;
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 93;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblFilmes
            // 
            this.lblFilmes.AutoSize = true;
            this.lblFilmes.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblFilmes.ForeColor = System.Drawing.Color.LightGray;
            this.lblFilmes.Location = new System.Drawing.Point(43, 14);
            this.lblFilmes.Name = "lblFilmes";
            this.lblFilmes.Size = new System.Drawing.Size(43, 13);
            this.lblFilmes.TabIndex = 22;
            this.lblFilmes.Text = "FILMES";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1292, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(8, 650);
            this.panelRight.TabIndex = 150;
            // 
            // dataGridViewFilmes
            // 
            this.dataGridViewFilmes.AllowUserToAddRows = false;
            this.dataGridViewFilmes.AllowUserToDeleteRows = false;
            this.dataGridViewFilmes.AllowUserToResizeColumns = false;
            this.dataGridViewFilmes.AllowUserToResizeRows = false;
            this.dataGridViewFilmes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFilmes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.dataGridViewFilmes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFilmes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.dataGridViewFilmes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFilmes.ColumnHeadersHeight = 30;
            this.dataGridViewFilmes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNome,
            this.colGenero,
            this.colAno,
            this.colProdutor_Editor,
            this.colAdministrador,
            this.colAssistir,
            this.colSeguir});
            this.dataGridViewFilmes.EnableHeadersVisualStyles = false;
            this.dataGridViewFilmes.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewFilmes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewFilmes.Location = new System.Drawing.Point(8, 138);
            this.dataGridViewFilmes.MultiSelect = false;
            this.dataGridViewFilmes.Name = "dataGridViewFilmes";
            this.dataGridViewFilmes.ReadOnly = true;
            this.dataGridViewFilmes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewFilmes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilmes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFilmes.RowHeadersWidth = 40;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewFilmes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewFilmes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFilmes.Size = new System.Drawing.Size(1128, 487);
            this.dataGridViewFilmes.StandardTab = true;
            this.dataGridViewFilmes.TabIndex = 145;
            this.dataGridViewFilmes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewFilme_Serie_Usuarios_CellFormatting);
            this.dataGridViewFilmes.DoubleClick += new System.EventHandler(this.dataGridViewFilme_Serie_Usuarios_DoubleClick);
            this.dataGridViewFilmes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewFilme_Serie_Usuarios_KeyDown);
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Titulo";
            this.colNome.HeaderText = "Título";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 400;
            // 
            // colGenero
            // 
            this.colGenero.DataPropertyName = "Genero";
            dataGridViewCellStyle2.NullValue = "-";
            this.colGenero.DefaultCellStyle = dataGridViewCellStyle2;
            this.colGenero.HeaderText = "Gênero";
            this.colGenero.Name = "colGenero";
            this.colGenero.ReadOnly = true;
            this.colGenero.Width = 400;
            // 
            // colAno
            // 
            this.colAno.DataPropertyName = "Ano";
            dataGridViewCellStyle3.NullValue = "-";
            this.colAno.DefaultCellStyle = dataGridViewCellStyle3;
            this.colAno.HeaderText = "Ano";
            this.colAno.Name = "colAno";
            this.colAno.ReadOnly = true;
            // 
            // colProdutor_Editor
            // 
            this.colProdutor_Editor.DataPropertyName = "Produtor_Editora";
            this.colProdutor_Editor.HeaderText = "Produtor(a) | Editor(a)";
            this.colProdutor_Editor.Name = "colProdutor_Editor";
            this.colProdutor_Editor.ReadOnly = true;
            this.colProdutor_Editor.Width = 400;
            // 
            // colAdministrador
            // 
            this.colAdministrador.DataPropertyName = "FilmeSerie";
            this.colAdministrador.HeaderText = "Filme | Série";
            this.colAdministrador.Name = "colAdministrador";
            this.colAdministrador.ReadOnly = true;
            this.colAdministrador.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAdministrador.Width = 140;
            // 
            // colAssistir
            // 
            this.colAssistir.HeaderText = "Assistir";
            this.colAssistir.Name = "colAssistir";
            this.colAssistir.ReadOnly = true;
            this.colAssistir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAssistir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colSeguir
            // 
            this.colSeguir.HeaderText = "Assistir Mais Tarde";
            this.colSeguir.Name = "colSeguir";
            this.colSeguir.ReadOnly = true;
            this.colSeguir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSeguir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSeguir.Text = "SEGUIR";
            this.colSeguir.UseColumnTextForButtonValue = true;
            this.colSeguir.Width = 130;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(8, 650);
            this.panelLeft.TabIndex = 149;
            // 
            // timerFadeIn
            // 
            this.timerFadeIn.Enabled = true;
            this.timerFadeIn.Tick += new System.EventHandler(this.timerFadeIn_Tick);
            // 
            // FrmFilmes
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.radioButtonGenero);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.radioButtonTitulo);
            this.Controls.Add(this.btnAssistir);
            this.Controls.Add(this.radioButtonProdutor_Editora);
            this.Controls.Add(this.radioButtonAno);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnSeguir);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.dataGridViewFilmes);
            this.Controls.Add(this.panelLeft);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFilmes";
            this.Opacity = 0.96D;
            this.Load += new System.EventHandler(this.FrmFilmes_Load);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnLimpar;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonGenero;
        private System.Windows.Forms.Label lblTotalRegistros;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonTitulo;
        private Guna.UI2.WinForms.Guna2Button btnAssistir;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonProdutor_Editora;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonAno;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnSeguir;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxFilmes;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
        private System.Windows.Forms.Label lblFilmes;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dataGridViewFilmes;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Timer timerFadeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdutor_Editor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdministrador;
        private System.Windows.Forms.DataGridViewImageColumn colAssistir;
        private System.Windows.Forms.DataGridViewButtonColumn colSeguir;
    }
}