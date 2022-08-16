
namespace Interface
{
    partial class FrmFavoritosConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFavoritosConsultar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radioButtonGenero = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.radioButtonTitulo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonProdutor_Editora = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtPesquisar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.PictureBoxFavoritos = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnFechar = new Guna.UI2.WinForms.Guna2Button();
            this.lblFavoritos = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dataGridViewFavoritos = new System.Windows.Forms.DataGridView();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.timerFadeIn = new System.Windows.Forms.Timer(this.components);
            this.checkBoxSerie = new Guna.UI2.WinForms.Guna2CheckBox();
            this.checkBoxFilme = new Guna.UI2.WinForms.Guna2CheckBox();
            this.colAdministrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdutor_Editor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpar = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFavoritos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavoritos)).BeginInit();
            this.SuspendLayout();
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
            this.radioButtonProdutor_Editora.Location = new System.Drawing.Point(137, 108);
            this.radioButtonProdutor_Editora.Name = "radioButtonProdutor_Editora";
            this.radioButtonProdutor_Editora.Size = new System.Drawing.Size(135, 17);
            this.radioButtonProdutor_Editora.TabIndex = 162;
            this.radioButtonProdutor_Editora.Text = "Produtor(a) | Editor(a)";
            this.radioButtonProdutor_Editora.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonProdutor_Editora.UncheckedState.BorderThickness = 2;
            this.radioButtonProdutor_Editora.UseVisualStyleBackColor = true;
            this.radioButtonProdutor_Editora.CheckedChanged += new System.EventHandler(this.radioButtonProdutor_Editora_CheckedChanged);
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
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelBarraTitulo.Controls.Add(this.PictureBoxFavoritos);
            this.panelBarraTitulo.Controls.Add(this.btnFechar);
            this.panelBarraTitulo.Controls.Add(this.lblFavoritos);
            this.panelBarraTitulo.Location = new System.Drawing.Point(8, 8);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1284, 40);
            this.panelBarraTitulo.TabIndex = 152;
            // 
            // PictureBoxFavoritos
            // 
            this.PictureBoxFavoritos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxFavoritos.BackgroundImage")));
            this.PictureBoxFavoritos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBoxFavoritos.Cursor = System.Windows.Forms.Cursors.Default;
            this.PictureBoxFavoritos.Location = new System.Drawing.Point(7, 5);
            this.PictureBoxFavoritos.Name = "PictureBoxFavoritos";
            this.PictureBoxFavoritos.ShadowDecoration.Parent = this.PictureBoxFavoritos;
            this.PictureBoxFavoritos.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxFavoritos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxFavoritos.TabIndex = 94;
            this.PictureBoxFavoritos.TabStop = false;
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
            // lblFavoritos
            // 
            this.lblFavoritos.AutoSize = true;
            this.lblFavoritos.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblFavoritos.ForeColor = System.Drawing.Color.LightGray;
            this.lblFavoritos.Location = new System.Drawing.Point(43, 14);
            this.lblFavoritos.Name = "lblFavoritos";
            this.lblFavoritos.Size = new System.Drawing.Size(66, 13);
            this.lblFavoritos.TabIndex = 22;
            this.lblFavoritos.Text = "FAVORITOS";
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
            // dataGridViewFavoritos
            // 
            this.dataGridViewFavoritos.AllowUserToAddRows = false;
            this.dataGridViewFavoritos.AllowUserToDeleteRows = false;
            this.dataGridViewFavoritos.AllowUserToResizeColumns = false;
            this.dataGridViewFavoritos.AllowUserToResizeRows = false;
            this.dataGridViewFavoritos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFavoritos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.dataGridViewFavoritos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewFavoritos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.dataGridViewFavoritos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewFavoritos.ColumnHeadersHeight = 30;
            this.dataGridViewFavoritos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAdministrador,
            this.colNome,
            this.colGenero,
            this.colProdutor_Editor,
            this.colDataCriacao});
            this.dataGridViewFavoritos.EnableHeadersVisualStyles = false;
            this.dataGridViewFavoritos.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewFavoritos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewFavoritos.Location = new System.Drawing.Point(8, 138);
            this.dataGridViewFavoritos.MultiSelect = false;
            this.dataGridViewFavoritos.Name = "dataGridViewFavoritos";
            this.dataGridViewFavoritos.ReadOnly = true;
            this.dataGridViewFavoritos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewFavoritos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFavoritos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewFavoritos.RowHeadersWidth = 40;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewFavoritos.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewFavoritos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFavoritos.Size = new System.Drawing.Size(1128, 487);
            this.dataGridViewFavoritos.StandardTab = true;
            this.dataGridViewFavoritos.TabIndex = 145;
            this.dataGridViewFavoritos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewFavoritos_CellFormatting);
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
            // checkBoxSerie
            // 
            this.checkBoxSerie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSerie.Animated = true;
            this.checkBoxSerie.AutoSize = true;
            this.checkBoxSerie.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.checkBoxSerie.CheckedState.BorderRadius = 2;
            this.checkBoxSerie.CheckedState.BorderThickness = 0;
            this.checkBoxSerie.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.checkBoxSerie.CheckMarkColor = System.Drawing.Color.LightGray;
            this.checkBoxSerie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSerie.FlatAppearance.BorderSize = 0;
            this.checkBoxSerie.ForeColor = System.Drawing.Color.LightGray;
            this.checkBoxSerie.Location = new System.Drawing.Point(1090, 109);
            this.checkBoxSerie.Name = "checkBoxSerie";
            this.checkBoxSerie.Size = new System.Drawing.Size(51, 17);
            this.checkBoxSerie.TabIndex = 160;
            this.checkBoxSerie.Text = "Série";
            this.checkBoxSerie.UncheckedState.BorderRadius = 2;
            this.checkBoxSerie.UncheckedState.BorderThickness = 0;
            this.checkBoxSerie.UncheckedState.FillColor = System.Drawing.Color.White;
            this.checkBoxSerie.CheckedChanged += new System.EventHandler(this.checkBoxSerie_CheckedChanged);
            // 
            // checkBoxFilme
            // 
            this.checkBoxFilme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFilme.Animated = true;
            this.checkBoxFilme.AutoSize = true;
            this.checkBoxFilme.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.checkBoxFilme.CheckedState.BorderRadius = 2;
            this.checkBoxFilme.CheckedState.BorderThickness = 0;
            this.checkBoxFilme.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.checkBoxFilme.CheckMarkColor = System.Drawing.Color.LightGray;
            this.checkBoxFilme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxFilme.FlatAppearance.BorderSize = 0;
            this.checkBoxFilme.ForeColor = System.Drawing.Color.LightGray;
            this.checkBoxFilme.Location = new System.Drawing.Point(1031, 109);
            this.checkBoxFilme.Name = "checkBoxFilme";
            this.checkBoxFilme.Size = new System.Drawing.Size(53, 17);
            this.checkBoxFilme.TabIndex = 159;
            this.checkBoxFilme.Text = "Filme";
            this.checkBoxFilme.UncheckedState.BorderRadius = 2;
            this.checkBoxFilme.UncheckedState.BorderThickness = 0;
            this.checkBoxFilme.UncheckedState.FillColor = System.Drawing.Color.White;
            this.checkBoxFilme.CheckedChanged += new System.EventHandler(this.checkBoxFilme_CheckedChanged);
            // 
            // colAdministrador
            // 
            this.colAdministrador.DataPropertyName = "Filme_Serie.FilmeSerie";
            this.colAdministrador.HeaderText = "Filme | Série";
            this.colAdministrador.Name = "colAdministrador";
            this.colAdministrador.ReadOnly = true;
            this.colAdministrador.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAdministrador.Width = 140;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Filme_Serie.Titulo";
            this.colNome.HeaderText = "Título";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 400;
            // 
            // colGenero
            // 
            this.colGenero.DataPropertyName = "Genero";
            dataGridViewCellStyle14.NullValue = "-";
            this.colGenero.DefaultCellStyle = dataGridViewCellStyle14;
            this.colGenero.HeaderText = "Gênero";
            this.colGenero.Name = "colGenero";
            this.colGenero.ReadOnly = true;
            this.colGenero.Width = 400;
            // 
            // colProdutor_Editor
            // 
            this.colProdutor_Editor.DataPropertyName = "Filme_Serie.Produtor_Editora";
            this.colProdutor_Editor.HeaderText = "Produtor(a) | Editor(a)";
            this.colProdutor_Editor.Name = "colProdutor_Editor";
            this.colProdutor_Editor.ReadOnly = true;
            this.colProdutor_Editor.Width = 400;
            // 
            // colDataCriacao
            // 
            this.colDataCriacao.DataPropertyName = "DataCriacao";
            this.colDataCriacao.HeaderText = "Data Criação";
            this.colDataCriacao.Name = "colDataCriacao";
            this.colDataCriacao.ReadOnly = true;
            this.colDataCriacao.Width = 150;
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
            this.btnLimpar.Location = new System.Drawing.Point(1142, 184);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.PressedColor = System.Drawing.Color.Empty;
            this.btnLimpar.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnLimpar.ShadowDecoration.Parent = this.btnLimpar;
            this.btnLimpar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpar.TabIndex = 164;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
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
            this.btnExcluir.Location = new System.Drawing.Point(1142, 138);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.PressedColor = System.Drawing.Color.Empty;
            this.btnExcluir.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnExcluir.ShadowDecoration.Parent = this.btnExcluir;
            this.btnExcluir.Size = new System.Drawing.Size(150, 40);
            this.btnExcluir.TabIndex = 163;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FrmFavoritosConsultar
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.radioButtonGenero);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.radioButtonTitulo);
            this.Controls.Add(this.radioButtonProdutor_Editora);
            this.Controls.Add(this.checkBoxFilme);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.checkBoxSerie);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.dataGridViewFavoritos);
            this.Controls.Add(this.panelLeft);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFavoritosConsultar";
            this.Opacity = 0.96D;
            this.Load += new System.EventHandler(this.FrmFavoritosConsultar_Load);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFavoritos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavoritos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonGenero;
        private System.Windows.Forms.Label lblTotalRegistros;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonTitulo;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonProdutor_Editora;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnPesquisar;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxFavoritos;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
        private System.Windows.Forms.Label lblFavoritos;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dataGridViewFavoritos;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Timer timerFadeIn;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxSerie;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxFilme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdministrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdutor_Editor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataCriacao;
        private Guna.UI2.WinForms.Guna2Button btnLimpar;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
    }
}