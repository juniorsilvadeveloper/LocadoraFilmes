
namespace Interface
{
    partial class FrmTemporadaConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTemporadaConsultar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.radioButtonAno = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.radioButtonProdutor_Editora = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.PictureBoxTemporada_BarraTitulo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnFechar = new Guna.UI2.WinForms.Guna2Button();
            this.lblConsultaTemporada = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dataGridViewTemporada = new System.Windows.Forms.DataGridView();
            this.timerFadeIn = new System.Windows.Forms.Timer(this.components);
            this.radioButtonAtivo_Inativo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonInativo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonAtivo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panelSituacao = new System.Windows.Forms.Panel();
            this.radioButtonGenero = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonID = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.radioButtonTitulo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtPesquisar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btnNovo = new Guna.UI2.WinForms.Guna2Button();
            this.radioButtonNumeroTemporada = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonIDSerie = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonNomeSerie = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnLimpar = new Guna.UI2.WinForms.Guna2Button();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroTemporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdutor_Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTemporada_BarraTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemporada)).BeginInit();
            this.panelSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Animated = true;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnEditar.CheckedState.Parent = this.btnEditar;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.CustomImages.Parent = this.btnEditar;
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnEditar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEditar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnEditar.HoverState.Parent = this.btnEditar;
            this.btnEditar.Location = new System.Drawing.Point(1142, 184);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.PressedColor = System.Drawing.Color.Empty;
            this.btnEditar.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnEditar.ShadowDecoration.Parent = this.btnEditar;
            this.btnEditar.Size = new System.Drawing.Size(150, 40);
            this.btnEditar.TabIndex = 139;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.radioButtonAno.Location = new System.Drawing.Point(298, 108);
            this.radioButtonAno.Name = "radioButtonAno";
            this.radioButtonAno.Size = new System.Drawing.Size(46, 17);
            this.radioButtonAno.TabIndex = 137;
            this.radioButtonAno.Text = "Ano";
            this.radioButtonAno.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAno.UncheckedState.BorderThickness = 2;
            this.radioButtonAno.UseVisualStyleBackColor = true;
            this.radioButtonAno.CheckedChanged += new System.EventHandler(this.radioButtonAno_CheckedChanged);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 8);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(8, 642);
            this.panelLeft.TabIndex = 125;
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
            this.radioButtonProdutor_Editora.Location = new System.Drawing.Point(350, 108);
            this.radioButtonProdutor_Editora.Name = "radioButtonProdutor_Editora";
            this.radioButtonProdutor_Editora.Size = new System.Drawing.Size(135, 17);
            this.radioButtonProdutor_Editora.TabIndex = 138;
            this.radioButtonProdutor_Editora.Text = "Produtor(a) | Editor(a)";
            this.radioButtonProdutor_Editora.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonProdutor_Editora.UncheckedState.BorderThickness = 2;
            this.radioButtonProdutor_Editora.UseVisualStyleBackColor = true;
            this.radioButtonProdutor_Editora.CheckedChanged += new System.EventHandler(this.radioButtonProdutor_Editora_CheckedChanged);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelBarraTitulo.Controls.Add(this.PictureBoxTemporada_BarraTitulo);
            this.panelBarraTitulo.Controls.Add(this.btnFechar);
            this.panelBarraTitulo.Controls.Add(this.lblConsultaTemporada);
            this.panelBarraTitulo.Location = new System.Drawing.Point(8, 8);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1284, 40);
            this.panelBarraTitulo.TabIndex = 128;
            // 
            // PictureBoxTemporada_BarraTitulo
            // 
            this.PictureBoxTemporada_BarraTitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxTemporada_BarraTitulo.BackgroundImage")));
            this.PictureBoxTemporada_BarraTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBoxTemporada_BarraTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.PictureBoxTemporada_BarraTitulo.Location = new System.Drawing.Point(7, 5);
            this.PictureBoxTemporada_BarraTitulo.Name = "PictureBoxTemporada_BarraTitulo";
            this.PictureBoxTemporada_BarraTitulo.ShadowDecoration.Parent = this.PictureBoxTemporada_BarraTitulo;
            this.PictureBoxTemporada_BarraTitulo.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxTemporada_BarraTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxTemporada_BarraTitulo.TabIndex = 94;
            this.PictureBoxTemporada_BarraTitulo.TabStop = false;
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
            // lblConsultaTemporada
            // 
            this.lblConsultaTemporada.AutoSize = true;
            this.lblConsultaTemporada.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblConsultaTemporada.ForeColor = System.Drawing.Color.LightGray;
            this.lblConsultaTemporada.Location = new System.Drawing.Point(43, 14);
            this.lblConsultaTemporada.Name = "lblConsultaTemporada";
            this.lblConsultaTemporada.Size = new System.Drawing.Size(149, 13);
            this.lblConsultaTemporada.TabIndex = 22;
            this.lblConsultaTemporada.Text = "CONSULTA - (TEMPORADAS)";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1292, 8);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(8, 642);
            this.panelRight.TabIndex = 126;
            // 
            // dataGridViewTemporada
            // 
            this.dataGridViewTemporada.AllowUserToAddRows = false;
            this.dataGridViewTemporada.AllowUserToDeleteRows = false;
            this.dataGridViewTemporada.AllowUserToResizeColumns = false;
            this.dataGridViewTemporada.AllowUserToResizeRows = false;
            this.dataGridViewTemporada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTemporada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.dataGridViewTemporada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTemporada.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.dataGridViewTemporada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTemporada.ColumnHeadersHeight = 30;
            this.dataGridViewTemporada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNome,
            this.colNumeroTemporada,
            this.colGenero,
            this.colAno,
            this.colProdutor_Editora,
            this.colIDSerie,
            this.colSerie,
            this.colSituacao});
            this.dataGridViewTemporada.EnableHeadersVisualStyles = false;
            this.dataGridViewTemporada.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewTemporada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewTemporada.Location = new System.Drawing.Point(8, 138);
            this.dataGridViewTemporada.MultiSelect = false;
            this.dataGridViewTemporada.Name = "dataGridViewTemporada";
            this.dataGridViewTemporada.ReadOnly = true;
            this.dataGridViewTemporada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewTemporada.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTemporada.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTemporada.RowHeadersWidth = 40;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTemporada.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTemporada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTemporada.Size = new System.Drawing.Size(1128, 487);
            this.dataGridViewTemporada.StandardTab = true;
            this.dataGridViewTemporada.TabIndex = 121;
            this.dataGridViewTemporada.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewTemporada_CellFormatting);
            this.dataGridViewTemporada.DoubleClick += new System.EventHandler(this.dataGridViewTemporada_DoubleClick);
            this.dataGridViewTemporada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewTemporada_KeyDown);
            // 
            // timerFadeIn
            // 
            this.timerFadeIn.Enabled = true;
            this.timerFadeIn.Tick += new System.EventHandler(this.timerFadeIn_Tick);
            // 
            // radioButtonAtivo_Inativo
            // 
            this.radioButtonAtivo_Inativo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAtivo_Inativo.Animated = true;
            this.radioButtonAtivo_Inativo.AutoSize = true;
            this.radioButtonAtivo_Inativo.Checked = true;
            this.radioButtonAtivo_Inativo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAtivo_Inativo.CheckedState.BorderThickness = 0;
            this.radioButtonAtivo_Inativo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAtivo_Inativo.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonAtivo_Inativo.CheckedState.InnerOffset = -4;
            this.radioButtonAtivo_Inativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAtivo_Inativo.FlatAppearance.BorderSize = 0;
            this.radioButtonAtivo_Inativo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonAtivo_Inativo.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonAtivo_Inativo.Location = new System.Drawing.Point(127, 7);
            this.radioButtonAtivo_Inativo.Name = "radioButtonAtivo_Inativo";
            this.radioButtonAtivo_Inativo.Size = new System.Drawing.Size(52, 17);
            this.radioButtonAtivo_Inativo.TabIndex = 33;
            this.radioButtonAtivo_Inativo.TabStop = true;
            this.radioButtonAtivo_Inativo.Text = "Geral";
            this.radioButtonAtivo_Inativo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAtivo_Inativo.UncheckedState.BorderThickness = 2;
            this.radioButtonAtivo_Inativo.UseVisualStyleBackColor = true;
            this.radioButtonAtivo_Inativo.CheckedChanged += new System.EventHandler(this.radioButtonAtivo_Inativo_CheckedChanged);
            // 
            // radioButtonInativo
            // 
            this.radioButtonInativo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonInativo.Animated = true;
            this.radioButtonInativo.AutoSize = true;
            this.radioButtonInativo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonInativo.CheckedState.BorderThickness = 0;
            this.radioButtonInativo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonInativo.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonInativo.CheckedState.InnerOffset = -4;
            this.radioButtonInativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonInativo.FlatAppearance.BorderSize = 0;
            this.radioButtonInativo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonInativo.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonInativo.Location = new System.Drawing.Point(61, 7);
            this.radioButtonInativo.Name = "radioButtonInativo";
            this.radioButtonInativo.Size = new System.Drawing.Size(60, 17);
            this.radioButtonInativo.TabIndex = 31;
            this.radioButtonInativo.Text = "Inativo";
            this.radioButtonInativo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonInativo.UncheckedState.BorderThickness = 2;
            this.radioButtonInativo.UseVisualStyleBackColor = true;
            this.radioButtonInativo.CheckedChanged += new System.EventHandler(this.radioButtonInativo_CheckedChanged);
            // 
            // radioButtonAtivo
            // 
            this.radioButtonAtivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAtivo.Animated = true;
            this.radioButtonAtivo.AutoSize = true;
            this.radioButtonAtivo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAtivo.CheckedState.BorderThickness = 0;
            this.radioButtonAtivo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAtivo.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonAtivo.CheckedState.InnerOffset = -4;
            this.radioButtonAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAtivo.FlatAppearance.BorderSize = 0;
            this.radioButtonAtivo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonAtivo.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonAtivo.Location = new System.Drawing.Point(4, 7);
            this.radioButtonAtivo.Name = "radioButtonAtivo";
            this.radioButtonAtivo.Size = new System.Drawing.Size(51, 17);
            this.radioButtonAtivo.TabIndex = 32;
            this.radioButtonAtivo.Text = "Ativo";
            this.radioButtonAtivo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAtivo.UncheckedState.BorderThickness = 2;
            this.radioButtonAtivo.UseVisualStyleBackColor = true;
            this.radioButtonAtivo.CheckedChanged += new System.EventHandler(this.radioButtonAtivo_CheckedChanged);
            // 
            // panelSituacao
            // 
            this.panelSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSituacao.Controls.Add(this.radioButtonAtivo_Inativo);
            this.panelSituacao.Controls.Add(this.radioButtonInativo);
            this.panelSituacao.Controls.Add(this.radioButtonAtivo);
            this.panelSituacao.Location = new System.Drawing.Point(954, 101);
            this.panelSituacao.Name = "panelSituacao";
            this.panelSituacao.Size = new System.Drawing.Size(182, 31);
            this.panelSituacao.TabIndex = 134;
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
            this.radioButtonGenero.Location = new System.Drawing.Point(229, 108);
            this.radioButtonGenero.Name = "radioButtonGenero";
            this.radioButtonGenero.Size = new System.Drawing.Size(63, 17);
            this.radioButtonGenero.TabIndex = 133;
            this.radioButtonGenero.Text = "Gênero";
            this.radioButtonGenero.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonGenero.UncheckedState.BorderThickness = 2;
            this.radioButtonGenero.UseVisualStyleBackColor = true;
            this.radioButtonGenero.CheckedChanged += new System.EventHandler(this.radioButtonGenero_CheckedChanged);
            // 
            // radioButtonID
            // 
            this.radioButtonID.Animated = true;
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Checked = true;
            this.radioButtonID.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonID.CheckedState.BorderThickness = 0;
            this.radioButtonID.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonID.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonID.CheckedState.InnerOffset = -4;
            this.radioButtonID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonID.FlatAppearance.BorderSize = 0;
            this.radioButtonID.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonID.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonID.Location = new System.Drawing.Point(8, 108);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(36, 17);
            this.radioButtonID.TabIndex = 122;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "ID";
            this.radioButtonID.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonID.UncheckedState.BorderThickness = 2;
            this.radioButtonID.UseVisualStyleBackColor = true;
            this.radioButtonID.CheckedChanged += new System.EventHandler(this.radioButtonID_CheckedChanged);
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
            this.lblTotalRegistros.TabIndex = 124;
            this.lblTotalRegistros.Text = "Total Registro(s): 0";
            // 
            // radioButtonTitulo
            // 
            this.radioButtonTitulo.Animated = true;
            this.radioButtonTitulo.AutoSize = true;
            this.radioButtonTitulo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonTitulo.CheckedState.BorderThickness = 0;
            this.radioButtonTitulo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonTitulo.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonTitulo.CheckedState.InnerOffset = -4;
            this.radioButtonTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonTitulo.FlatAppearance.BorderSize = 0;
            this.radioButtonTitulo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonTitulo.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonTitulo.Location = new System.Drawing.Point(50, 108);
            this.radioButtonTitulo.Name = "radioButtonTitulo";
            this.radioButtonTitulo.Size = new System.Drawing.Size(54, 17);
            this.radioButtonTitulo.TabIndex = 123;
            this.radioButtonTitulo.Text = "Título";
            this.radioButtonTitulo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonTitulo.UncheckedState.BorderThickness = 2;
            this.radioButtonTitulo.UseVisualStyleBackColor = true;
            this.radioButtonTitulo.CheckedChanged += new System.EventHandler(this.radioButtonTitulo_CheckedChanged);
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1300, 8);
            this.panelTop.TabIndex = 127;
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
            this.txtPesquisar.TabIndex = 132;
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
            this.btnPesquisar.TabIndex = 131;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Animated = true;
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnExcluir.CheckedState.Parent = this.btnExcluir;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.CustomImages.Parent = this.btnExcluir;
            this.btnExcluir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnExcluir.ForeColor = System.Drawing.Color.LightGray;
            this.btnExcluir.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnExcluir.HoverState.Parent = this.btnExcluir;
            this.btnExcluir.Location = new System.Drawing.Point(1142, 230);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.PressedColor = System.Drawing.Color.Empty;
            this.btnExcluir.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnExcluir.ShadowDecoration.Parent = this.btnExcluir;
            this.btnExcluir.Size = new System.Drawing.Size(150, 40);
            this.btnExcluir.TabIndex = 130;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Animated = true;
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnNovo.CheckedState.Parent = this.btnNovo;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.CustomImages.Parent = this.btnNovo;
            this.btnNovo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnNovo.ForeColor = System.Drawing.Color.LightGray;
            this.btnNovo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnNovo.HoverState.Parent = this.btnNovo;
            this.btnNovo.Location = new System.Drawing.Point(1142, 138);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.PressedColor = System.Drawing.Color.Empty;
            this.btnNovo.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnNovo.ShadowDecoration.Parent = this.btnNovo;
            this.btnNovo.Size = new System.Drawing.Size(150, 40);
            this.btnNovo.TabIndex = 129;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // radioButtonNumeroTemporada
            // 
            this.radioButtonNumeroTemporada.Animated = true;
            this.radioButtonNumeroTemporada.AutoSize = true;
            this.radioButtonNumeroTemporada.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonNumeroTemporada.CheckedState.BorderThickness = 0;
            this.radioButtonNumeroTemporada.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonNumeroTemporada.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonNumeroTemporada.CheckedState.InnerOffset = -4;
            this.radioButtonNumeroTemporada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonNumeroTemporada.FlatAppearance.BorderSize = 0;
            this.radioButtonNumeroTemporada.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonNumeroTemporada.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonNumeroTemporada.Location = new System.Drawing.Point(110, 108);
            this.radioButtonNumeroTemporada.Name = "radioButtonNumeroTemporada";
            this.radioButtonNumeroTemporada.Size = new System.Drawing.Size(113, 17);
            this.radioButtonNumeroTemporada.TabIndex = 140;
            this.radioButtonNumeroTemporada.Text = "Nº da temporada";
            this.radioButtonNumeroTemporada.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonNumeroTemporada.UncheckedState.BorderThickness = 2;
            this.radioButtonNumeroTemporada.UseVisualStyleBackColor = true;
            this.radioButtonNumeroTemporada.CheckedChanged += new System.EventHandler(this.radioButtonNumeroTemporada_CheckedChanged);
            // 
            // radioButtonIDSerie
            // 
            this.radioButtonIDSerie.Animated = true;
            this.radioButtonIDSerie.AutoSize = true;
            this.radioButtonIDSerie.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonIDSerie.CheckedState.BorderThickness = 0;
            this.radioButtonIDSerie.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonIDSerie.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonIDSerie.CheckedState.InnerOffset = -4;
            this.radioButtonIDSerie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonIDSerie.FlatAppearance.BorderSize = 0;
            this.radioButtonIDSerie.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonIDSerie.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonIDSerie.Location = new System.Drawing.Point(491, 108);
            this.radioButtonIDSerie.Name = "radioButtonIDSerie";
            this.radioButtonIDSerie.Size = new System.Drawing.Size(79, 17);
            this.radioButtonIDSerie.TabIndex = 141;
            this.radioButtonIDSerie.Text = "ID da série";
            this.radioButtonIDSerie.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonIDSerie.UncheckedState.BorderThickness = 2;
            this.radioButtonIDSerie.UseVisualStyleBackColor = true;
            this.radioButtonIDSerie.CheckedChanged += new System.EventHandler(this.radioButtonIDSerie_CheckedChanged);
            // 
            // radioButtonNomeSerie
            // 
            this.radioButtonNomeSerie.Animated = true;
            this.radioButtonNomeSerie.AutoSize = true;
            this.radioButtonNomeSerie.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonNomeSerie.CheckedState.BorderThickness = 0;
            this.radioButtonNomeSerie.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonNomeSerie.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonNomeSerie.CheckedState.InnerOffset = -4;
            this.radioButtonNomeSerie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonNomeSerie.FlatAppearance.BorderSize = 0;
            this.radioButtonNomeSerie.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonNomeSerie.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonNomeSerie.Location = new System.Drawing.Point(576, 108);
            this.radioButtonNomeSerie.Name = "radioButtonNomeSerie";
            this.radioButtonNomeSerie.Size = new System.Drawing.Size(98, 17);
            this.radioButtonNomeSerie.TabIndex = 142;
            this.radioButtonNomeSerie.Text = "Nome da série";
            this.radioButtonNomeSerie.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonNomeSerie.UncheckedState.BorderThickness = 2;
            this.radioButtonNomeSerie.UseVisualStyleBackColor = true;
            this.radioButtonNomeSerie.CheckedChanged += new System.EventHandler(this.radioButtonNomeSerie_CheckedChanged);
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
            this.btnLimpar.Location = new System.Drawing.Point(1142, 276);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.PressedColor = System.Drawing.Color.Empty;
            this.btnLimpar.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnLimpar.ShadowDecoration.Parent = this.btnLimpar;
            this.btnLimpar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpar.TabIndex = 143;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colID.DefaultCellStyle = dataGridViewCellStyle2;
            this.colID.FillWeight = 125.5184F;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Titulo";
            this.colNome.HeaderText = "Título da Temporada";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 400;
            // 
            // colNumeroTemporada
            // 
            this.colNumeroTemporada.DataPropertyName = "NumeroTemporada";
            this.colNumeroTemporada.HeaderText = "Nº da Temporada";
            this.colNumeroTemporada.Name = "colNumeroTemporada";
            this.colNumeroTemporada.ReadOnly = true;
            this.colNumeroTemporada.Width = 140;
            // 
            // colGenero
            // 
            this.colGenero.DataPropertyName = "Genero";
            this.colGenero.HeaderText = "Gênero";
            this.colGenero.Name = "colGenero";
            this.colGenero.ReadOnly = true;
            this.colGenero.Width = 400;
            // 
            // colAno
            // 
            this.colAno.DataPropertyName = "Ano";
            this.colAno.HeaderText = "Ano";
            this.colAno.Name = "colAno";
            this.colAno.ReadOnly = true;
            // 
            // colProdutor_Editora
            // 
            this.colProdutor_Editora.DataPropertyName = "Produtor_Editora";
            this.colProdutor_Editora.HeaderText = "Produtor(a) | Editor(a)";
            this.colProdutor_Editora.Name = "colProdutor_Editora";
            this.colProdutor_Editora.ReadOnly = true;
            this.colProdutor_Editora.Width = 400;
            // 
            // colIDSerie
            // 
            this.colIDSerie.DataPropertyName = "IDFilme_Serie.ID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colIDSerie.DefaultCellStyle = dataGridViewCellStyle3;
            this.colIDSerie.HeaderText = "ID da Série";
            this.colIDSerie.Name = "colIDSerie";
            this.colIDSerie.ReadOnly = true;
            // 
            // colSerie
            // 
            this.colSerie.DataPropertyName = "IDFilme_Serie.Titulo";
            this.colSerie.HeaderText = "Nome da Série";
            this.colSerie.Name = "colSerie";
            this.colSerie.ReadOnly = true;
            this.colSerie.Width = 400;
            // 
            // colSituacao
            // 
            this.colSituacao.DataPropertyName = "Situacao";
            this.colSituacao.HeaderText = "Situação";
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            this.colSituacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSituacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSituacao.Width = 140;
            // 
            // FrmTemporadaConsultar
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.radioButtonNomeSerie);
            this.Controls.Add(this.radioButtonIDSerie);
            this.Controls.Add(this.radioButtonNumeroTemporada);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.radioButtonAno);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.radioButtonProdutor_Editora);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.dataGridViewTemporada);
            this.Controls.Add(this.panelSituacao);
            this.Controls.Add(this.radioButtonGenero);
            this.Controls.Add(this.radioButtonID);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.radioButtonTitulo);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTemporadaConsultar";
            this.Load += new System.EventHandler(this.FrmTemporadaConsultar_Load);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTemporada_BarraTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemporada)).EndInit();
            this.panelSituacao.ResumeLayout(false);
            this.panelSituacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonAno;
        private System.Windows.Forms.Panel panelLeft;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonProdutor_Editora;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxTemporada_BarraTitulo;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
        private System.Windows.Forms.Label lblConsultaTemporada;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dataGridViewTemporada;
        private System.Windows.Forms.Timer timerFadeIn;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonAtivo_Inativo;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonInativo;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonAtivo;
        private System.Windows.Forms.Panel panelSituacao;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonGenero;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonID;
        private System.Windows.Forms.Label lblTotalRegistros;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonTitulo;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnNovo;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonNumeroTemporada;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonIDSerie;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonNomeSerie;
        private Guna.UI2.WinForms.Guna2Button btnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroTemporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdutor_Editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerie;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSituacao;
    }
}