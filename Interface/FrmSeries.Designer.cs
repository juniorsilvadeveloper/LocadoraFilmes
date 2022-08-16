
namespace Interface
{
    partial class FrmSeries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeries));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timerFadeIn = new System.Windows.Forms.Timer(this.components);
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.PictureBoxSeries = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnFechar = new Guna.UI2.WinForms.Guna2Button();
            this.lblSeries = new System.Windows.Forms.Label();
            this.radioButtonTitulo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonProdutor_Editora = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtPesquisar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lblTotalRegistrosEpisodios = new System.Windows.Forms.Label();
            this.lblTotalRegistrosTemporadas = new System.Windows.Forms.Label();
            this.dataGridViewEpisodio = new System.Windows.Forms.DataGridView();
            this.colNumeroEpisodio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTemporada = new System.Windows.Forms.DataGridView();
            this.colNumeroTemporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalRegistrosSeries = new System.Windows.Forms.Label();
            this.dataGridViewSeries = new System.Windows.Forms.DataGridView();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProdutor_Editor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFavoritos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelTemporadas = new System.Windows.Forms.Panel();
            this.lblTemporadas = new System.Windows.Forms.Label();
            this.panelEpisodios = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSeries)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEpisodio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemporada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeries)).BeginInit();
            this.panelTemporadas.SuspendLayout();
            this.panelEpisodios.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerFadeIn
            // 
            this.timerFadeIn.Enabled = true;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1062, 8);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(8, 520);
            this.panelRight.TabIndex = 169;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 8);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(8, 520);
            this.panelLeft.TabIndex = 168;
            // 
            // PictureBoxSeries
            // 
            this.PictureBoxSeries.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxSeries.BackgroundImage")));
            this.PictureBoxSeries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBoxSeries.Cursor = System.Windows.Forms.Cursors.Default;
            this.PictureBoxSeries.Location = new System.Drawing.Point(7, 5);
            this.PictureBoxSeries.Name = "PictureBoxSeries";
            this.PictureBoxSeries.ShadowDecoration.Parent = this.PictureBoxSeries;
            this.PictureBoxSeries.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxSeries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxSeries.TabIndex = 94;
            this.PictureBoxSeries.TabStop = false;
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
            this.btnFechar.Location = new System.Drawing.Point(1003, 8);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.PressedColor = System.Drawing.Color.Empty;
            this.btnFechar.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnFechar.ShadowDecoration.Parent = this.btnFechar;
            this.btnFechar.Size = new System.Drawing.Size(25, 25);
            this.btnFechar.TabIndex = 93;
            // 
            // lblSeries
            // 
            this.lblSeries.AutoSize = true;
            this.lblSeries.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSeries.ForeColor = System.Drawing.Color.LightGray;
            this.lblSeries.Location = new System.Drawing.Point(43, 14);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(41, 13);
            this.lblSeries.TabIndex = 22;
            this.lblSeries.Text = "SÉRIES";
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
            this.radioButtonTitulo.TabIndex = 166;
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
            this.radioButtonProdutor_Editora.Location = new System.Drawing.Point(68, 108);
            this.radioButtonProdutor_Editora.Name = "radioButtonProdutor_Editora";
            this.radioButtonProdutor_Editora.Size = new System.Drawing.Size(135, 17);
            this.radioButtonProdutor_Editora.TabIndex = 177;
            this.radioButtonProdutor_Editora.Text = "Produtor(a) | Editor(a)";
            this.radioButtonProdutor_Editora.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonProdutor_Editora.UncheckedState.BorderThickness = 2;
            this.radioButtonProdutor_Editora.UseVisualStyleBackColor = true;
            this.radioButtonProdutor_Editora.CheckedChanged += new System.EventHandler(this.radioButtonProdutor_Editora_CheckedChanged);
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1070, 8);
            this.panelTop.TabIndex = 170;
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
            this.txtPesquisar.Size = new System.Drawing.Size(898, 29);
            this.txtPesquisar.TabIndex = 174;
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
            this.btnPesquisar.Location = new System.Drawing.Point(912, 60);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.PressedColor = System.Drawing.Color.Empty;
            this.btnPesquisar.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnPesquisar.ShadowDecoration.Parent = this.btnPesquisar;
            this.btnPesquisar.Size = new System.Drawing.Size(150, 40);
            this.btnPesquisar.TabIndex = 173;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelBarraTitulo.Controls.Add(this.PictureBoxSeries);
            this.panelBarraTitulo.Controls.Add(this.btnFechar);
            this.panelBarraTitulo.Controls.Add(this.lblSeries);
            this.panelBarraTitulo.Location = new System.Drawing.Point(8, 8);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1054, 40);
            this.panelBarraTitulo.TabIndex = 171;
            // 
            // lblTotalRegistrosEpisodios
            // 
            this.lblTotalRegistrosEpisodios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRegistrosEpisodios.AutoSize = true;
            this.lblTotalRegistrosEpisodios.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTotalRegistrosEpisodios.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotalRegistrosEpisodios.Location = new System.Drawing.Point(578, 506);
            this.lblTotalRegistrosEpisodios.Name = "lblTotalRegistrosEpisodios";
            this.lblTotalRegistrosEpisodios.Size = new System.Drawing.Size(101, 13);
            this.lblTotalRegistrosEpisodios.TabIndex = 181;
            this.lblTotalRegistrosEpisodios.Text = "Total Registro(s): 0";
            // 
            // lblTotalRegistrosTemporadas
            // 
            this.lblTotalRegistrosTemporadas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalRegistrosTemporadas.AutoSize = true;
            this.lblTotalRegistrosTemporadas.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTotalRegistrosTemporadas.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotalRegistrosTemporadas.Location = new System.Drawing.Point(5, 506);
            this.lblTotalRegistrosTemporadas.Name = "lblTotalRegistrosTemporadas";
            this.lblTotalRegistrosTemporadas.Size = new System.Drawing.Size(101, 13);
            this.lblTotalRegistrosTemporadas.TabIndex = 179;
            this.lblTotalRegistrosTemporadas.Text = "Total Registro(s): 0";
            // 
            // dataGridViewEpisodio
            // 
            this.dataGridViewEpisodio.AllowUserToAddRows = false;
            this.dataGridViewEpisodio.AllowUserToDeleteRows = false;
            this.dataGridViewEpisodio.AllowUserToResizeColumns = false;
            this.dataGridViewEpisodio.AllowUserToResizeRows = false;
            this.dataGridViewEpisodio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEpisodio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.dataGridViewEpisodio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEpisodio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.dataGridViewEpisodio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEpisodio.ColumnHeadersHeight = 30;
            this.dataGridViewEpisodio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumeroEpisodio,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewEpisodio.EnableHeadersVisualStyles = false;
            this.dataGridViewEpisodio.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewEpisodio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewEpisodio.Location = new System.Drawing.Point(581, 353);
            this.dataGridViewEpisodio.MultiSelect = false;
            this.dataGridViewEpisodio.Name = "dataGridViewEpisodio";
            this.dataGridViewEpisodio.ReadOnly = true;
            this.dataGridViewEpisodio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewEpisodio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEpisodio.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEpisodio.RowHeadersWidth = 40;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewEpisodio.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEpisodio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEpisodio.Size = new System.Drawing.Size(480, 150);
            this.dataGridViewEpisodio.StandardTab = true;
            this.dataGridViewEpisodio.TabIndex = 180;
            this.dataGridViewEpisodio.DoubleClick += new System.EventHandler(this.dataGridViewEpisodio_DoubleClick);
            // 
            // colNumeroEpisodio
            // 
            this.colNumeroEpisodio.DataPropertyName = "NumeroEpisodio";
            this.colNumeroEpisodio.HeaderText = "Nº Episódio";
            this.colNumeroEpisodio.Name = "colNumeroEpisodio";
            this.colNumeroEpisodio.ReadOnly = true;
            this.colNumeroEpisodio.Width = 140;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Título do Episódio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 440;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.dataGridViewTemporada.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTemporada.ColumnHeadersHeight = 30;
            this.dataGridViewTemporada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumeroTemporada,
            this.dataGridViewTextBoxColumn1,
            this.colGenero,
            this.colAno});
            this.dataGridViewTemporada.EnableHeadersVisualStyles = false;
            this.dataGridViewTemporada.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewTemporada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewTemporada.Location = new System.Drawing.Point(8, 353);
            this.dataGridViewTemporada.MultiSelect = false;
            this.dataGridViewTemporada.Name = "dataGridViewTemporada";
            this.dataGridViewTemporada.ReadOnly = true;
            this.dataGridViewTemporada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewTemporada.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTemporada.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTemporada.RowHeadersWidth = 40;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTemporada.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTemporada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTemporada.Size = new System.Drawing.Size(480, 150);
            this.dataGridViewTemporada.StandardTab = true;
            this.dataGridViewTemporada.TabIndex = 178;
            this.dataGridViewTemporada.SelectionChanged += new System.EventHandler(this.dataGridViewTemporada_SelectionChanged);
            this.dataGridViewTemporada.DoubleClick += new System.EventHandler(this.dataGridViewTemporada_DoubleClick);
            // 
            // colNumeroTemporada
            // 
            this.colNumeroTemporada.DataPropertyName = "NumeroTemporada";
            this.colNumeroTemporada.HeaderText = "Nº da temporada";
            this.colNumeroTemporada.Name = "colNumeroTemporada";
            this.colNumeroTemporada.ReadOnly = true;
            this.colNumeroTemporada.Width = 140;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Título da Temporada";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 440;
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
            // lblTotalRegistrosSeries
            // 
            this.lblTotalRegistrosSeries.AutoSize = true;
            this.lblTotalRegistrosSeries.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTotalRegistrosSeries.ForeColor = System.Drawing.Color.LightGray;
            this.lblTotalRegistrosSeries.Location = new System.Drawing.Point(5, 291);
            this.lblTotalRegistrosSeries.Name = "lblTotalRegistrosSeries";
            this.lblTotalRegistrosSeries.Size = new System.Drawing.Size(101, 13);
            this.lblTotalRegistrosSeries.TabIndex = 167;
            this.lblTotalRegistrosSeries.Text = "Total Registro(s): 0";
            // 
            // dataGridViewSeries
            // 
            this.dataGridViewSeries.AllowUserToAddRows = false;
            this.dataGridViewSeries.AllowUserToDeleteRows = false;
            this.dataGridViewSeries.AllowUserToResizeColumns = false;
            this.dataGridViewSeries.AllowUserToResizeRows = false;
            this.dataGridViewSeries.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSeries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.dataGridViewSeries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSeries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.dataGridViewSeries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSeries.ColumnHeadersHeight = 30;
            this.dataGridViewSeries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNome,
            this.colProdutor_Editor,
            this.colFavoritos});
            this.dataGridViewSeries.EnableHeadersVisualStyles = false;
            this.dataGridViewSeries.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewSeries.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewSeries.Location = new System.Drawing.Point(9, 138);
            this.dataGridViewSeries.MultiSelect = false;
            this.dataGridViewSeries.Name = "dataGridViewSeries";
            this.dataGridViewSeries.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewSeries.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSeries.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSeries.RowHeadersWidth = 40;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewSeries.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewSeries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSeries.Size = new System.Drawing.Size(1052, 150);
            this.dataGridViewSeries.StandardTab = true;
            this.dataGridViewSeries.TabIndex = 165;
            this.dataGridViewSeries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeries_CellContentClick);
            this.dataGridViewSeries.SelectionChanged += new System.EventHandler(this.dataGridViewSeries_SelectionChanged);
            this.dataGridViewSeries.DoubleClick += new System.EventHandler(this.dataGridViewSeries_DoubleClick);
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Titulo";
            this.colNome.HeaderText = "Título da Série";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 621;
            // 
            // colProdutor_Editor
            // 
            this.colProdutor_Editor.DataPropertyName = "Produtor_Editora";
            this.colProdutor_Editor.HeaderText = "Produtor(a) | Editor(a)";
            this.colProdutor_Editor.Name = "colProdutor_Editor";
            this.colProdutor_Editor.ReadOnly = true;
            this.colProdutor_Editor.Width = 621;
            // 
            // colFavoritos
            // 
            this.colFavoritos.DataPropertyName = "Favoritos";
            this.colFavoritos.HeaderText = "Favoritos";
            this.colFavoritos.Name = "colFavoritos";
            // 
            // panelTemporadas
            // 
            this.panelTemporadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTemporadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelTemporadas.Controls.Add(this.lblTemporadas);
            this.panelTemporadas.Location = new System.Drawing.Point(9, 315);
            this.panelTemporadas.Name = "panelTemporadas";
            this.panelTemporadas.Size = new System.Drawing.Size(479, 25);
            this.panelTemporadas.TabIndex = 182;
            // 
            // lblTemporadas
            // 
            this.lblTemporadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTemporadas.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTemporadas.ForeColor = System.Drawing.Color.LightGray;
            this.lblTemporadas.Location = new System.Drawing.Point(0, 0);
            this.lblTemporadas.Name = "lblTemporadas";
            this.lblTemporadas.Size = new System.Drawing.Size(479, 25);
            this.lblTemporadas.TabIndex = 22;
            this.lblTemporadas.Text = "TEMPORADAS";
            this.lblTemporadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelEpisodios
            // 
            this.panelEpisodios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEpisodios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelEpisodios.Controls.Add(this.label3);
            this.panelEpisodios.Location = new System.Drawing.Point(581, 315);
            this.panelEpisodios.Name = "panelEpisodios";
            this.panelEpisodios.Size = new System.Drawing.Size(481, 25);
            this.panelEpisodios.TabIndex = 183;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(481, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "EPISÓDIOS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmSeries
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(1070, 528);
            this.ControlBox = false;
            this.Controls.Add(this.panelEpisodios);
            this.Controls.Add(this.panelTemporadas);
            this.Controls.Add(this.lblTotalRegistrosEpisodios);
            this.Controls.Add(this.dataGridViewEpisodio);
            this.Controls.Add(this.lblTotalRegistrosTemporadas);
            this.Controls.Add(this.dataGridViewTemporada);
            this.Controls.Add(this.dataGridViewSeries);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.lblTotalRegistrosSeries);
            this.Controls.Add(this.radioButtonTitulo);
            this.Controls.Add(this.radioButtonProdutor_Editora);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.panelBarraTitulo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeries";
            this.Opacity = 0.96D;
            this.Load += new System.EventHandler(this.FrmSeries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSeries)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEpisodio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemporada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeries)).EndInit();
            this.panelTemporadas.ResumeLayout(false);
            this.panelEpisodios.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerFadeIn;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxSeries;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
        private System.Windows.Forms.Label lblSeries;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonTitulo;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonProdutor_Editora;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnPesquisar;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Label lblTotalRegistrosEpisodios;
        private System.Windows.Forms.Label lblTotalRegistrosTemporadas;
        private System.Windows.Forms.DataGridView dataGridViewEpisodio;
        private System.Windows.Forms.DataGridView dataGridViewTemporada;
        private System.Windows.Forms.Label lblTotalRegistrosSeries;
        private System.Windows.Forms.DataGridView dataGridViewSeries;
        private System.Windows.Forms.Panel panelTemporadas;
        private System.Windows.Forms.Label lblTemporadas;
        private System.Windows.Forms.Panel panelEpisodios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroEpisodio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroTemporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProdutor_Editor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFavoritos;
    }
}