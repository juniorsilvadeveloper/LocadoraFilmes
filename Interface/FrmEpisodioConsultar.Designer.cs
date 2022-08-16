
namespace Interface
{
    partial class FrmEpisodioConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEpisodioConsultar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timerFadeIn = new System.Windows.Forms.Timer(this.components);
            this.radioButtonGeral = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonInativo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonAtivo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonNumeroEpisodio = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panelSituacao = new System.Windows.Forms.Panel();
            this.radioButtonID = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.radioButtonTitulo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtPesquisar = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.PictureBoxEpisodio_BarraTitulo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnFechar = new Guna.UI2.WinForms.Guna2Button();
            this.lblConsultaEpisodio = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.dataGridViewEpisodio = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroEpisodio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDTemporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeTemporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeroTemporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnoTemporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnNovo = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimpar = new Guna.UI2.WinForms.Guna2Button();
            this.radioButtonNumeroTemporada = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonNomeTemporada = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonIDSerie = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonNomeSerie = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonIDTemporada = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panelSituacao.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEpisodio_BarraTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEpisodio)).BeginInit();
            this.SuspendLayout();
            // 
            // timerFadeIn
            // 
            this.timerFadeIn.Enabled = true;
            this.timerFadeIn.Tick += new System.EventHandler(this.timerFadeIn_Tick);
            // 
            // radioButtonGeral
            // 
            this.radioButtonGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonGeral.Animated = true;
            this.radioButtonGeral.AutoSize = true;
            this.radioButtonGeral.Checked = true;
            this.radioButtonGeral.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonGeral.CheckedState.BorderThickness = 0;
            this.radioButtonGeral.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonGeral.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonGeral.CheckedState.InnerOffset = -4;
            this.radioButtonGeral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonGeral.FlatAppearance.BorderSize = 0;
            this.radioButtonGeral.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonGeral.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonGeral.Location = new System.Drawing.Point(128, 7);
            this.radioButtonGeral.Name = "radioButtonGeral";
            this.radioButtonGeral.Size = new System.Drawing.Size(52, 17);
            this.radioButtonGeral.TabIndex = 33;
            this.radioButtonGeral.TabStop = true;
            this.radioButtonGeral.Text = "Geral";
            this.radioButtonGeral.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonGeral.UncheckedState.BorderThickness = 2;
            this.radioButtonGeral.UseVisualStyleBackColor = true;
            this.radioButtonGeral.CheckedChanged += new System.EventHandler(this.radioButtonAtivo_Inativo_CheckedChanged);
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
            this.radioButtonInativo.Location = new System.Drawing.Point(62, 7);
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
            this.radioButtonAtivo.Location = new System.Drawing.Point(5, 7);
            this.radioButtonAtivo.Name = "radioButtonAtivo";
            this.radioButtonAtivo.Size = new System.Drawing.Size(51, 17);
            this.radioButtonAtivo.TabIndex = 32;
            this.radioButtonAtivo.Text = "Ativo";
            this.radioButtonAtivo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAtivo.UncheckedState.BorderThickness = 2;
            this.radioButtonAtivo.UseVisualStyleBackColor = true;
            this.radioButtonAtivo.CheckedChanged += new System.EventHandler(this.radioButtonAtivo_CheckedChanged);
            // 
            // radioButtonNumeroEpisodio
            // 
            this.radioButtonNumeroEpisodio.Animated = true;
            this.radioButtonNumeroEpisodio.AutoSize = true;
            this.radioButtonNumeroEpisodio.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonNumeroEpisodio.CheckedState.BorderThickness = 0;
            this.radioButtonNumeroEpisodio.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonNumeroEpisodio.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonNumeroEpisodio.CheckedState.InnerOffset = -4;
            this.radioButtonNumeroEpisodio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonNumeroEpisodio.FlatAppearance.BorderSize = 0;
            this.radioButtonNumeroEpisodio.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonNumeroEpisodio.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonNumeroEpisodio.Location = new System.Drawing.Point(110, 108);
            this.radioButtonNumeroEpisodio.Name = "radioButtonNumeroEpisodio";
            this.radioButtonNumeroEpisodio.Size = new System.Drawing.Size(86, 17);
            this.radioButtonNumeroEpisodio.TabIndex = 158;
            this.radioButtonNumeroEpisodio.Text = "Nº Episódio";
            this.radioButtonNumeroEpisodio.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonNumeroEpisodio.UncheckedState.BorderThickness = 2;
            this.radioButtonNumeroEpisodio.UseVisualStyleBackColor = true;
            this.radioButtonNumeroEpisodio.CheckedChanged += new System.EventHandler(this.radioButtonNumeroEpisodio_CheckedChanged);
            // 
            // panelSituacao
            // 
            this.panelSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSituacao.Controls.Add(this.radioButtonInativo);
            this.panelSituacao.Controls.Add(this.radioButtonAtivo);
            this.panelSituacao.Controls.Add(this.radioButtonGeral);
            this.panelSituacao.Location = new System.Drawing.Point(953, 101);
            this.panelSituacao.Name = "panelSituacao";
            this.panelSituacao.Size = new System.Drawing.Size(183, 31);
            this.panelSituacao.TabIndex = 154;
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
            this.radioButtonID.TabIndex = 142;
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
            this.lblTotalRegistros.TabIndex = 144;
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
            this.radioButtonTitulo.TabIndex = 143;
            this.radioButtonTitulo.Text = "Título";
            this.radioButtonTitulo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonTitulo.UncheckedState.BorderThickness = 2;
            this.radioButtonTitulo.UseVisualStyleBackColor = true;
            this.radioButtonTitulo.CheckedChanged += new System.EventHandler(this.radioButtonTitulo_CheckedChanged);
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(8, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1284, 8);
            this.panelTop.TabIndex = 147;
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
            this.txtPesquisar.TabIndex = 152;
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
            this.btnPesquisar.TabIndex = 151;
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
            this.btnExcluir.TabIndex = 150;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
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
            this.btnEditar.TabIndex = 157;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(8, 650);
            this.panelLeft.TabIndex = 145;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelBarraTitulo.Controls.Add(this.PictureBoxEpisodio_BarraTitulo);
            this.panelBarraTitulo.Controls.Add(this.btnFechar);
            this.panelBarraTitulo.Controls.Add(this.lblConsultaEpisodio);
            this.panelBarraTitulo.Location = new System.Drawing.Point(8, 8);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1284, 40);
            this.panelBarraTitulo.TabIndex = 148;
            // 
            // PictureBoxEpisodio_BarraTitulo
            // 
            this.PictureBoxEpisodio_BarraTitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxEpisodio_BarraTitulo.BackgroundImage")));
            this.PictureBoxEpisodio_BarraTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBoxEpisodio_BarraTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.PictureBoxEpisodio_BarraTitulo.Location = new System.Drawing.Point(7, 5);
            this.PictureBoxEpisodio_BarraTitulo.Name = "PictureBoxEpisodio_BarraTitulo";
            this.PictureBoxEpisodio_BarraTitulo.ShadowDecoration.Parent = this.PictureBoxEpisodio_BarraTitulo;
            this.PictureBoxEpisodio_BarraTitulo.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxEpisodio_BarraTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxEpisodio_BarraTitulo.TabIndex = 94;
            this.PictureBoxEpisodio_BarraTitulo.TabStop = false;
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
            // lblConsultaEpisodio
            // 
            this.lblConsultaEpisodio.AutoSize = true;
            this.lblConsultaEpisodio.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblConsultaEpisodio.ForeColor = System.Drawing.Color.LightGray;
            this.lblConsultaEpisodio.Location = new System.Drawing.Point(43, 14);
            this.lblConsultaEpisodio.Name = "lblConsultaEpisodio";
            this.lblConsultaEpisodio.Size = new System.Drawing.Size(134, 13);
            this.lblConsultaEpisodio.TabIndex = 22;
            this.lblConsultaEpisodio.Text = "CONSULTA - (EPISÓDIOS)";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1292, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(8, 650);
            this.panelRight.TabIndex = 146;
            // 
            // dataGridViewEpisodio
            // 
            this.dataGridViewEpisodio.AllowUserToAddRows = false;
            this.dataGridViewEpisodio.AllowUserToDeleteRows = false;
            this.dataGridViewEpisodio.AllowUserToResizeColumns = false;
            this.dataGridViewEpisodio.AllowUserToResizeRows = false;
            this.dataGridViewEpisodio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
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
            this.colID,
            this.colNome,
            this.colNumeroEpisodio,
            this.colIDTemporada,
            this.colNomeTemporada,
            this.colNumeroTemporada,
            this.colAnoTemporada,
            this.colIDSerie,
            this.colNomeSerie,
            this.colSituacao});
            this.dataGridViewEpisodio.EnableHeadersVisualStyles = false;
            this.dataGridViewEpisodio.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewEpisodio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewEpisodio.Location = new System.Drawing.Point(8, 138);
            this.dataGridViewEpisodio.MultiSelect = false;
            this.dataGridViewEpisodio.Name = "dataGridViewEpisodio";
            this.dataGridViewEpisodio.ReadOnly = true;
            this.dataGridViewEpisodio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewEpisodio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEpisodio.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEpisodio.RowHeadersWidth = 40;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewEpisodio.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewEpisodio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEpisodio.Size = new System.Drawing.Size(1128, 487);
            this.dataGridViewEpisodio.StandardTab = true;
            this.dataGridViewEpisodio.TabIndex = 141;
            this.dataGridViewEpisodio.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewEpisodio_CellFormatting);
            this.dataGridViewEpisodio.DoubleClick += new System.EventHandler(this.dataGridViewEpisodio_DoubleClick);
            this.dataGridViewEpisodio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewEpisodio_KeyDown);
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
            this.colNome.HeaderText = "Título";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 288;
            // 
            // colNumeroEpisodio
            // 
            this.colNumeroEpisodio.DataPropertyName = "NumeroEpisodio";
            this.colNumeroEpisodio.HeaderText = "Nº Episódio";
            this.colNumeroEpisodio.Name = "colNumeroEpisodio";
            this.colNumeroEpisodio.ReadOnly = true;
            this.colNumeroEpisodio.Width = 140;
            // 
            // colIDTemporada
            // 
            this.colIDTemporada.DataPropertyName = "IDTemporada.ID";
            this.colIDTemporada.HeaderText = "ID Temporada";
            this.colIDTemporada.Name = "colIDTemporada";
            this.colIDTemporada.ReadOnly = true;
            // 
            // colNomeTemporada
            // 
            this.colNomeTemporada.DataPropertyName = "IDTemporada.Titulo";
            this.colNomeTemporada.HeaderText = "Nome Temporada";
            this.colNomeTemporada.Name = "colNomeTemporada";
            this.colNomeTemporada.ReadOnly = true;
            this.colNomeTemporada.Width = 288;
            // 
            // colNumeroTemporada
            // 
            this.colNumeroTemporada.DataPropertyName = "IDTemporada.NumeroTemporada";
            this.colNumeroTemporada.HeaderText = "Nº Temporada";
            this.colNumeroTemporada.Name = "colNumeroTemporada";
            this.colNumeroTemporada.ReadOnly = true;
            this.colNumeroTemporada.Width = 140;
            // 
            // colAnoTemporada
            // 
            this.colAnoTemporada.DataPropertyName = "IDTemporada.Ano";
            this.colAnoTemporada.HeaderText = "Ano";
            this.colAnoTemporada.Name = "colAnoTemporada";
            this.colAnoTemporada.ReadOnly = true;
            // 
            // colIDSerie
            // 
            this.colIDSerie.DataPropertyName = "IDTemporada.IDFilme_Serie.ID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colIDSerie.DefaultCellStyle = dataGridViewCellStyle3;
            this.colIDSerie.HeaderText = "ID Série";
            this.colIDSerie.Name = "colIDSerie";
            this.colIDSerie.ReadOnly = true;
            // 
            // colNomeSerie
            // 
            this.colNomeSerie.DataPropertyName = "IDTemporada.IDFilme_Serie.Titulo";
            this.colNomeSerie.HeaderText = "Nome Série";
            this.colNomeSerie.Name = "colNomeSerie";
            this.colNomeSerie.ReadOnly = true;
            this.colNomeSerie.Width = 288;
            // 
            // colSituacao
            // 
            this.colSituacao.DataPropertyName = "Situacao";
            this.colSituacao.HeaderText = "Situação";
            this.colSituacao.Name = "colSituacao";
            this.colSituacao.ReadOnly = true;
            this.colSituacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSituacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSituacao.Width = 130;
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
            this.btnNovo.TabIndex = 149;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
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
            this.btnLimpar.TabIndex = 159;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
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
            this.radioButtonNumeroTemporada.Location = new System.Drawing.Point(425, 108);
            this.radioButtonNumeroTemporada.Name = "radioButtonNumeroTemporada";
            this.radioButtonNumeroTemporada.Size = new System.Drawing.Size(98, 17);
            this.radioButtonNumeroTemporada.TabIndex = 160;
            this.radioButtonNumeroTemporada.Text = "Nº Temporada";
            this.radioButtonNumeroTemporada.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonNumeroTemporada.UncheckedState.BorderThickness = 2;
            this.radioButtonNumeroTemporada.UseVisualStyleBackColor = true;
            this.radioButtonNumeroTemporada.CheckedChanged += new System.EventHandler(this.radioButtonNumeroTemporada_CheckedChanged);
            // 
            // radioButtonNomeTemporada
            // 
            this.radioButtonNomeTemporada.Animated = true;
            this.radioButtonNomeTemporada.AutoSize = true;
            this.radioButtonNomeTemporada.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonNomeTemporada.CheckedState.BorderThickness = 0;
            this.radioButtonNomeTemporada.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonNomeTemporada.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonNomeTemporada.CheckedState.InnerOffset = -4;
            this.radioButtonNomeTemporada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonNomeTemporada.FlatAppearance.BorderSize = 0;
            this.radioButtonNomeTemporada.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonNomeTemporada.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonNomeTemporada.Location = new System.Drawing.Point(304, 108);
            this.radioButtonNomeTemporada.Name = "radioButtonNomeTemporada";
            this.radioButtonNomeTemporada.Size = new System.Drawing.Size(115, 17);
            this.radioButtonNomeTemporada.TabIndex = 161;
            this.radioButtonNomeTemporada.Text = "Nome Temporada";
            this.radioButtonNomeTemporada.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonNomeTemporada.UncheckedState.BorderThickness = 2;
            this.radioButtonNomeTemporada.UseVisualStyleBackColor = true;
            this.radioButtonNomeTemporada.CheckedChanged += new System.EventHandler(this.radioButtonNomeTemporada_CheckedChanged);
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
            this.radioButtonIDSerie.Location = new System.Drawing.Point(529, 108);
            this.radioButtonIDSerie.Name = "radioButtonIDSerie";
            this.radioButtonIDSerie.Size = new System.Drawing.Size(64, 17);
            this.radioButtonIDSerie.TabIndex = 162;
            this.radioButtonIDSerie.Text = "ID Série";
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
            this.radioButtonNomeSerie.Location = new System.Drawing.Point(599, 108);
            this.radioButtonNomeSerie.Name = "radioButtonNomeSerie";
            this.radioButtonNomeSerie.Size = new System.Drawing.Size(83, 17);
            this.radioButtonNomeSerie.TabIndex = 163;
            this.radioButtonNomeSerie.Text = "Nome Série";
            this.radioButtonNomeSerie.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonNomeSerie.UncheckedState.BorderThickness = 2;
            this.radioButtonNomeSerie.UseVisualStyleBackColor = true;
            this.radioButtonNomeSerie.CheckedChanged += new System.EventHandler(this.radioButtonNomeSerie_CheckedChanged);
            // 
            // radioButtonIDTemporada
            // 
            this.radioButtonIDTemporada.Animated = true;
            this.radioButtonIDTemporada.AutoSize = true;
            this.radioButtonIDTemporada.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonIDTemporada.CheckedState.BorderThickness = 0;
            this.radioButtonIDTemporada.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonIDTemporada.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonIDTemporada.CheckedState.InnerOffset = -4;
            this.radioButtonIDTemporada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonIDTemporada.FlatAppearance.BorderSize = 0;
            this.radioButtonIDTemporada.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonIDTemporada.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonIDTemporada.Location = new System.Drawing.Point(202, 108);
            this.radioButtonIDTemporada.Name = "radioButtonIDTemporada";
            this.radioButtonIDTemporada.Size = new System.Drawing.Size(96, 17);
            this.radioButtonIDTemporada.TabIndex = 164;
            this.radioButtonIDTemporada.Text = "ID Temporada";
            this.radioButtonIDTemporada.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonIDTemporada.UncheckedState.BorderThickness = 2;
            this.radioButtonIDTemporada.UseVisualStyleBackColor = true;
            this.radioButtonIDTemporada.CheckedChanged += new System.EventHandler(this.radioButtonIDTemporada_CheckedChanged);
            // 
            // FrmEpisodioConsultar
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.ControlBox = false;
            this.Controls.Add(this.radioButtonIDTemporada);
            this.Controls.Add(this.radioButtonNomeSerie);
            this.Controls.Add(this.radioButtonIDSerie);
            this.Controls.Add(this.radioButtonNomeTemporada);
            this.Controls.Add(this.radioButtonNumeroTemporada);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.radioButtonNumeroEpisodio);
            this.Controls.Add(this.panelSituacao);
            this.Controls.Add(this.radioButtonID);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.radioButtonTitulo);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.dataGridViewEpisodio);
            this.Controls.Add(this.btnNovo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEpisodioConsultar";
            this.Load += new System.EventHandler(this.FrmEpisodioConsultar_Load);
            this.panelSituacao.ResumeLayout(false);
            this.panelSituacao.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEpisodio_BarraTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEpisodio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerFadeIn;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonGeral;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonInativo;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonAtivo;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonNumeroEpisodio;
        private System.Windows.Forms.Panel panelSituacao;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonID;
        private System.Windows.Forms.Label lblTotalRegistros;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonTitulo;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxEpisodio_BarraTitulo;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
        private System.Windows.Forms.Label lblConsultaEpisodio;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.DataGridView dataGridViewEpisodio;
        private Guna.UI2.WinForms.Guna2Button btnNovo;
        private Guna.UI2.WinForms.Guna2Button btnLimpar;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonNumeroTemporada;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonNomeTemporada;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonIDSerie;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonNomeSerie;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonIDTemporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroEpisodio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDTemporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeTemporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeroTemporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnoTemporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeSerie;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSituacao;
    }
}