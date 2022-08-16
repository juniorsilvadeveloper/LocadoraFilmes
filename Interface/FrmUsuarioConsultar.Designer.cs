
namespace Interface
{
    partial class FrmUsuarioConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioConsultar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PictureBoxUsuarioBarraTitulo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblConsultaUsuario = new System.Windows.Forms.Label();
            this.btnPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btnNovo = new Guna.UI2.WinForms.Guna2Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnFechar = new Guna.UI2.WinForms.Guna2Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuarioLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSituacao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.radioButtonID = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.radioButtonNomeReal = new Guna.UI2.WinForms.Guna2RadioButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.radioButtonUsuarioLogin = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonAtivo_Inativo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonInativo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonAtivo = new Guna.UI2.WinForms.Guna2RadioButton();
            this.timerFadeIn = new System.Windows.Forms.Timer(this.components);
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBoxTipoUsuario = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelBtnNovo = new System.Windows.Forms.Panel();
            this.panelBtnExcluir = new System.Windows.Forms.Panel();
            this.panelBtnAtivarDesativar = new System.Windows.Forms.Panel();
            this.panelManipulacaoGeral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new Guna.UI2.WinForms.Guna2Button();
            this.panelBtnPesquisar = new System.Windows.Forms.Panel();
            this.panelSituacao = new System.Windows.Forms.Panel();
            this.txtPesquisar = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUsuarioBarraTitulo)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            this.panelBtnNovo.SuspendLayout();
            this.panelBtnExcluir.SuspendLayout();
            this.panelBtnAtivarDesativar.SuspendLayout();
            this.panelManipulacaoGeral.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBtnPesquisar.SuspendLayout();
            this.panelSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxUsuarioBarraTitulo
            // 
            this.PictureBoxUsuarioBarraTitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxUsuarioBarraTitulo.BackgroundImage")));
            this.PictureBoxUsuarioBarraTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBoxUsuarioBarraTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.PictureBoxUsuarioBarraTitulo.Location = new System.Drawing.Point(7, 5);
            this.PictureBoxUsuarioBarraTitulo.Name = "PictureBoxUsuarioBarraTitulo";
            this.PictureBoxUsuarioBarraTitulo.ShadowDecoration.Parent = this.PictureBoxUsuarioBarraTitulo;
            this.PictureBoxUsuarioBarraTitulo.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxUsuarioBarraTitulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxUsuarioBarraTitulo.TabIndex = 23;
            this.PictureBoxUsuarioBarraTitulo.TabStop = false;
            // 
            // lblConsultaUsuario
            // 
            this.lblConsultaUsuario.AutoSize = true;
            this.lblConsultaUsuario.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblConsultaUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.lblConsultaUsuario.Location = new System.Drawing.Point(43, 14);
            this.lblConsultaUsuario.Name = "lblConsultaUsuario";
            this.lblConsultaUsuario.Size = new System.Drawing.Size(132, 13);
            this.lblConsultaUsuario.TabIndex = 22;
            this.lblConsultaUsuario.Text = "CONSULTA - (USUÁRIOS)";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Animated = true;
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnPesquisar.CheckedState.Parent = this.btnPesquisar;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.CustomImages.Parent = this.btnPesquisar;
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesquisar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.LightGray;
            this.btnPesquisar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnPesquisar.HoverState.Parent = this.btnPesquisar;
            this.btnPesquisar.Location = new System.Drawing.Point(0, 0);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.PressedColor = System.Drawing.Color.Empty;
            this.btnPesquisar.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnPesquisar.ShadowDecoration.Parent = this.btnPesquisar;
            this.btnPesquisar.Size = new System.Drawing.Size(150, 40);
            this.btnPesquisar.TabIndex = 95;
            this.btnPesquisar.Text = "PESQUISAR";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Animated = true;
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnExcluir.CheckedState.Parent = this.btnExcluir;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.CustomImages.Parent = this.btnExcluir;
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcluir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnExcluir.ForeColor = System.Drawing.Color.LightGray;
            this.btnExcluir.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnExcluir.HoverState.Parent = this.btnExcluir;
            this.btnExcluir.Location = new System.Drawing.Point(0, 0);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.PressedColor = System.Drawing.Color.Empty;
            this.btnExcluir.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnExcluir.ShadowDecoration.Parent = this.btnExcluir;
            this.btnExcluir.Size = new System.Drawing.Size(150, 40);
            this.btnExcluir.TabIndex = 94;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Animated = true;
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnNovo.CheckedState.Parent = this.btnNovo;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.CustomImages.Parent = this.btnNovo;
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnNovo.ForeColor = System.Drawing.Color.LightGray;
            this.btnNovo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnNovo.HoverState.Parent = this.btnNovo;
            this.btnNovo.Location = new System.Drawing.Point(0, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.PressedColor = System.Drawing.Color.Empty;
            this.btnNovo.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnNovo.ShadowDecoration.Parent = this.btnNovo;
            this.btnNovo.Size = new System.Drawing.Size(150, 40);
            this.btnNovo.TabIndex = 92;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panelBarraTitulo.Controls.Add(this.btnFechar);
            this.panelBarraTitulo.Controls.Add(this.PictureBoxUsuarioBarraTitulo);
            this.panelBarraTitulo.Controls.Add(this.lblConsultaUsuario);
            this.panelBarraTitulo.Location = new System.Drawing.Point(8, 8);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1284, 40);
            this.panelBarraTitulo.TabIndex = 91;
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
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1292, 8);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(8, 642);
            this.panelRight.TabIndex = 89;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 8);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(8, 642);
            this.panelLeft.TabIndex = 88;
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.AllowUserToAddRows = false;
            this.dataGridViewUsuario.AllowUserToDeleteRows = false;
            this.dataGridViewUsuario.AllowUserToResizeColumns = false;
            this.dataGridViewUsuario.AllowUserToResizeRows = false;
            this.dataGridViewUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.dataGridViewUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.dataGridViewUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsuario.ColumnHeadersHeight = 30;
            this.dataGridViewUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colUsuarioLogin,
            this.colNome,
            this.colTipoUsuario,
            this.colSituacao});
            this.dataGridViewUsuario.EnableHeadersVisualStyles = false;
            this.dataGridViewUsuario.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewUsuario.Location = new System.Drawing.Point(8, 146);
            this.dataGridViewUsuario.MultiSelect = false;
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.ReadOnly = true;
            this.dataGridViewUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUsuario.RowHeadersWidth = 40;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewUsuario.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsuario.Size = new System.Drawing.Size(1128, 479);
            this.dataGridViewUsuario.StandardTab = true;
            this.dataGridViewUsuario.TabIndex = 84;
            this.dataGridViewUsuario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewUsuario_CellFormatting);
            this.dataGridViewUsuario.DoubleClick += new System.EventHandler(this.dataGridViewUsuario_DoubleClick);
            this.dataGridViewUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewUsuario_KeyDown);
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
            // colUsuarioLogin
            // 
            this.colUsuarioLogin.DataPropertyName = "UsuarioLogin";
            this.colUsuarioLogin.HeaderText = "Usuário Login";
            this.colUsuarioLogin.Name = "colUsuarioLogin";
            this.colUsuarioLogin.ReadOnly = true;
            this.colUsuarioLogin.Width = 320;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Nome";
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 360;
            // 
            // colTipoUsuario
            // 
            this.colTipoUsuario.DataPropertyName = "IDTipoUsuario.Descricao";
            this.colTipoUsuario.HeaderText = "Tipo de usuário";
            this.colTipoUsuario.Name = "colTipoUsuario";
            this.colTipoUsuario.ReadOnly = true;
            this.colTipoUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTipoUsuario.Width = 166;
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
            this.radioButtonID.Location = new System.Drawing.Point(8, 114);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(36, 17);
            this.radioButtonID.TabIndex = 85;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "ID";
            this.radioButtonID.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonID.UncheckedState.BorderThickness = 2;
            this.radioButtonID.UseVisualStyleBackColor = true;
            this.radioButtonID.CheckedChanged += new System.EventHandler(this.radioButtonIDUsuario_CheckedChanged);
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
            this.lblTotalRegistros.TabIndex = 87;
            this.lblTotalRegistros.Text = "Total Registro(s): 0";
            // 
            // radioButtonNomeReal
            // 
            this.radioButtonNomeReal.Animated = true;
            this.radioButtonNomeReal.AutoSize = true;
            this.radioButtonNomeReal.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonNomeReal.CheckedState.BorderThickness = 0;
            this.radioButtonNomeReal.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonNomeReal.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonNomeReal.CheckedState.InnerOffset = -4;
            this.radioButtonNomeReal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonNomeReal.FlatAppearance.BorderSize = 0;
            this.radioButtonNomeReal.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonNomeReal.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonNomeReal.Location = new System.Drawing.Point(154, 114);
            this.radioButtonNomeReal.Name = "radioButtonNomeReal";
            this.radioButtonNomeReal.Size = new System.Drawing.Size(80, 17);
            this.radioButtonNomeReal.TabIndex = 86;
            this.radioButtonNomeReal.Text = "Nome Real";
            this.radioButtonNomeReal.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonNomeReal.UncheckedState.BorderThickness = 2;
            this.radioButtonNomeReal.UseVisualStyleBackColor = true;
            this.radioButtonNomeReal.CheckedChanged += new System.EventHandler(this.radioButtonNome_CheckedChanged);
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1300, 8);
            this.panelTop.TabIndex = 90;
            // 
            // radioButtonUsuarioLogin
            // 
            this.radioButtonUsuarioLogin.Animated = true;
            this.radioButtonUsuarioLogin.AutoSize = true;
            this.radioButtonUsuarioLogin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonUsuarioLogin.CheckedState.BorderThickness = 0;
            this.radioButtonUsuarioLogin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonUsuarioLogin.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonUsuarioLogin.CheckedState.InnerOffset = -4;
            this.radioButtonUsuarioLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonUsuarioLogin.FlatAppearance.BorderSize = 0;
            this.radioButtonUsuarioLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonUsuarioLogin.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonUsuarioLogin.Location = new System.Drawing.Point(50, 114);
            this.radioButtonUsuarioLogin.Name = "radioButtonUsuarioLogin";
            this.radioButtonUsuarioLogin.Size = new System.Drawing.Size(98, 17);
            this.radioButtonUsuarioLogin.TabIndex = 98;
            this.radioButtonUsuarioLogin.Text = "Nome Usuário";
            this.radioButtonUsuarioLogin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonUsuarioLogin.UncheckedState.BorderThickness = 2;
            this.radioButtonUsuarioLogin.UseVisualStyleBackColor = true;
            this.radioButtonUsuarioLogin.CheckedChanged += new System.EventHandler(this.radioButtonUsuarioLogin_CheckedChanged);
            // 
            // radioButtonAtivo_Inativo
            // 
            this.radioButtonAtivo_Inativo.Animated = true;
            this.radioButtonAtivo_Inativo.AutoSize = true;
            this.radioButtonAtivo_Inativo.Checked = true;
            this.radioButtonAtivo_Inativo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAtivo_Inativo.CheckedState.BorderThickness = 0;
            this.radioButtonAtivo_Inativo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAtivo_Inativo.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonAtivo_Inativo.CheckedState.InnerOffset = -4;
            this.radioButtonAtivo_Inativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAtivo_Inativo.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButtonAtivo_Inativo.FlatAppearance.BorderSize = 0;
            this.radioButtonAtivo_Inativo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonAtivo_Inativo.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonAtivo_Inativo.Location = new System.Drawing.Point(115, 0);
            this.radioButtonAtivo_Inativo.Name = "radioButtonAtivo_Inativo";
            this.radioButtonAtivo_Inativo.Size = new System.Drawing.Size(52, 36);
            this.radioButtonAtivo_Inativo.TabIndex = 33;
            this.radioButtonAtivo_Inativo.TabStop = true;
            this.radioButtonAtivo_Inativo.Text = "Geral";
            this.radioButtonAtivo_Inativo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAtivo_Inativo.UncheckedState.BorderThickness = 2;
            this.radioButtonAtivo_Inativo.UseVisualStyleBackColor = true;
            this.radioButtonAtivo_Inativo.CheckedChanged += new System.EventHandler(this.RadioButtonAtivo_Inativo_CheckedChanged);
            // 
            // radioButtonInativo
            // 
            this.radioButtonInativo.Animated = true;
            this.radioButtonInativo.AutoSize = true;
            this.radioButtonInativo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonInativo.CheckedState.BorderThickness = 0;
            this.radioButtonInativo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonInativo.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonInativo.CheckedState.InnerOffset = -4;
            this.radioButtonInativo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonInativo.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButtonInativo.FlatAppearance.BorderSize = 0;
            this.radioButtonInativo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonInativo.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonInativo.Location = new System.Drawing.Point(55, 0);
            this.radioButtonInativo.Name = "radioButtonInativo";
            this.radioButtonInativo.Size = new System.Drawing.Size(60, 36);
            this.radioButtonInativo.TabIndex = 31;
            this.radioButtonInativo.Text = "Inativo";
            this.radioButtonInativo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonInativo.UncheckedState.BorderThickness = 2;
            this.radioButtonInativo.UseVisualStyleBackColor = true;
            this.radioButtonInativo.CheckedChanged += new System.EventHandler(this.RadioButtonInativo_CheckedChanged);
            // 
            // radioButtonAtivo
            // 
            this.radioButtonAtivo.Animated = true;
            this.radioButtonAtivo.AutoSize = true;
            this.radioButtonAtivo.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAtivo.CheckedState.BorderThickness = 0;
            this.radioButtonAtivo.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAtivo.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.radioButtonAtivo.CheckedState.InnerOffset = -4;
            this.radioButtonAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAtivo.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButtonAtivo.FlatAppearance.BorderSize = 0;
            this.radioButtonAtivo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radioButtonAtivo.ForeColor = System.Drawing.Color.LightGray;
            this.radioButtonAtivo.Location = new System.Drawing.Point(4, 0);
            this.radioButtonAtivo.Name = "radioButtonAtivo";
            this.radioButtonAtivo.Size = new System.Drawing.Size(51, 36);
            this.radioButtonAtivo.TabIndex = 32;
            this.radioButtonAtivo.Text = "Ativo";
            this.radioButtonAtivo.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonAtivo.UncheckedState.BorderThickness = 2;
            this.radioButtonAtivo.UseVisualStyleBackColor = true;
            this.radioButtonAtivo.CheckedChanged += new System.EventHandler(this.RadioButtonAtivo_CheckedChanged);
            // 
            // timerFadeIn
            // 
            this.timerFadeIn.Enabled = true;
            this.timerFadeIn.Tick += new System.EventHandler(this.timerFadeIn_Tick);
            // 
            // btnEditar
            // 
            this.btnEditar.Animated = true;
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnEditar.CheckedState.Parent = this.btnEditar;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.CustomImages.Parent = this.btnEditar;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnEditar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEditar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnEditar.HoverState.Parent = this.btnEditar;
            this.btnEditar.Location = new System.Drawing.Point(0, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.PressedColor = System.Drawing.Color.Empty;
            this.btnEditar.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnEditar.ShadowDecoration.Parent = this.btnEditar;
            this.btnEditar.Size = new System.Drawing.Size(150, 40);
            this.btnEditar.TabIndex = 102;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // ComboBoxTipoUsuario
            // 
            this.ComboBoxTipoUsuario.Animated = true;
            this.ComboBoxTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxTipoUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ComboBoxTipoUsuario.BorderRadius = 3;
            this.ComboBoxTipoUsuario.BorderThickness = 0;
            this.ComboBoxTipoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBoxTipoUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.ComboBoxTipoUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboBoxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTipoUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ComboBoxTipoUsuario.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.ComboBoxTipoUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.ComboBoxTipoUsuario.FocusedState.Parent = this.ComboBoxTipoUsuario;
            this.ComboBoxTipoUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxTipoUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.ComboBoxTipoUsuario.FormattingEnabled = true;
            this.ComboBoxTipoUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.ComboBoxTipoUsuario.HoverState.Parent = this.ComboBoxTipoUsuario;
            this.ComboBoxTipoUsuario.ItemHeight = 30;
            this.ComboBoxTipoUsuario.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "COLABORADOR",
            "VISITANTE",
            "USUÁRIOS"});
            this.ComboBoxTipoUsuario.ItemsAppearance.Parent = this.ComboBoxTipoUsuario;
            this.ComboBoxTipoUsuario.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.ComboBoxTipoUsuario.Location = new System.Drawing.Point(167, 0);
            this.ComboBoxTipoUsuario.Name = "ComboBoxTipoUsuario";
            this.ComboBoxTipoUsuario.ShadowDecoration.Parent = this.ComboBoxTipoUsuario;
            this.ComboBoxTipoUsuario.Size = new System.Drawing.Size(190, 36);
            this.ComboBoxTipoUsuario.TabIndex = 103;
            this.ComboBoxTipoUsuario.Visible = false;
            this.ComboBoxTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTipoUsuario_SelectedIndexChanged);
            // 
            // panelBtnNovo
            // 
            this.panelBtnNovo.Controls.Add(this.btnNovo);
            this.panelBtnNovo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBtnNovo.Location = new System.Drawing.Point(0, 86);
            this.panelBtnNovo.Name = "panelBtnNovo";
            this.panelBtnNovo.Size = new System.Drawing.Size(150, 47);
            this.panelBtnNovo.TabIndex = 104;
            // 
            // panelBtnExcluir
            // 
            this.panelBtnExcluir.Controls.Add(this.btnExcluir);
            this.panelBtnExcluir.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBtnExcluir.Location = new System.Drawing.Point(0, 180);
            this.panelBtnExcluir.Name = "panelBtnExcluir";
            this.panelBtnExcluir.Size = new System.Drawing.Size(150, 47);
            this.panelBtnExcluir.TabIndex = 105;
            // 
            // panelBtnAtivarDesativar
            // 
            this.panelBtnAtivarDesativar.Controls.Add(this.btnEditar);
            this.panelBtnAtivarDesativar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBtnAtivarDesativar.Location = new System.Drawing.Point(0, 133);
            this.panelBtnAtivarDesativar.Name = "panelBtnAtivarDesativar";
            this.panelBtnAtivarDesativar.Size = new System.Drawing.Size(150, 47);
            this.panelBtnAtivarDesativar.TabIndex = 106;
            // 
            // panelManipulacaoGeral
            // 
            this.panelManipulacaoGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManipulacaoGeral.Controls.Add(this.panel1);
            this.panelManipulacaoGeral.Controls.Add(this.panelBtnExcluir);
            this.panelManipulacaoGeral.Controls.Add(this.panelBtnAtivarDesativar);
            this.panelManipulacaoGeral.Controls.Add(this.panelBtnNovo);
            this.panelManipulacaoGeral.Controls.Add(this.panelBtnPesquisar);
            this.panelManipulacaoGeral.Location = new System.Drawing.Point(1142, 60);
            this.panelManipulacaoGeral.Name = "panelManipulacaoGeral";
            this.panelManipulacaoGeral.Size = new System.Drawing.Size(150, 565);
            this.panelManipulacaoGeral.TabIndex = 107;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 47);
            this.panel1.TabIndex = 107;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Animated = true;
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnLimpar.CheckedState.Parent = this.btnLimpar;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.CustomImages.Parent = this.btnLimpar;
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLimpar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnLimpar.ForeColor = System.Drawing.Color.LightGray;
            this.btnLimpar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnLimpar.HoverState.Parent = this.btnLimpar;
            this.btnLimpar.Location = new System.Drawing.Point(0, 0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.PressedColor = System.Drawing.Color.Empty;
            this.btnLimpar.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btnLimpar.ShadowDecoration.Parent = this.btnLimpar;
            this.btnLimpar.Size = new System.Drawing.Size(150, 40);
            this.btnLimpar.TabIndex = 94;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panelBtnPesquisar
            // 
            this.panelBtnPesquisar.Controls.Add(this.btnPesquisar);
            this.panelBtnPesquisar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBtnPesquisar.Location = new System.Drawing.Point(0, 0);
            this.panelBtnPesquisar.Name = "panelBtnPesquisar";
            this.panelBtnPesquisar.Size = new System.Drawing.Size(150, 86);
            this.panelBtnPesquisar.TabIndex = 96;
            // 
            // panelSituacao
            // 
            this.panelSituacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSituacao.Controls.Add(this.radioButtonAtivo);
            this.panelSituacao.Controls.Add(this.radioButtonInativo);
            this.panelSituacao.Controls.Add(this.radioButtonAtivo_Inativo);
            this.panelSituacao.Controls.Add(this.ComboBoxTipoUsuario);
            this.panelSituacao.Location = new System.Drawing.Point(779, 104);
            this.panelSituacao.Name = "panelSituacao";
            this.panelSituacao.Size = new System.Drawing.Size(357, 36);
            this.panelSituacao.TabIndex = 99;
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
            this.txtPesquisar.Location = new System.Drawing.Point(8, 62);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PasswordChar = '\0';
            this.txtPesquisar.PlaceholderText = "";
            this.txtPesquisar.SelectedText = "";
            this.txtPesquisar.ShadowDecoration.Parent = this.txtPesquisar;
            this.txtPesquisar.Size = new System.Drawing.Size(1128, 36);
            this.txtPesquisar.TabIndex = 96;
            this.txtPesquisar.TextOffset = new System.Drawing.Point(0, 1);
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // FrmUsuarioConsultar
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.CancelButton = this.btnFechar;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelManipulacaoGeral);
            this.Controls.Add(this.panelSituacao);
            this.Controls.Add(this.radioButtonUsuarioLogin);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.radioButtonID);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.radioButtonNomeReal);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dataGridViewUsuario);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuarioConsultar";
            this.Opacity = 0.96D;
            this.Load += new System.EventHandler(this.FrmUsuarioConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxUsuarioBarraTitulo)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            this.panelBtnNovo.ResumeLayout(false);
            this.panelBtnExcluir.ResumeLayout(false);
            this.panelBtnAtivarDesativar.ResumeLayout(false);
            this.panelManipulacaoGeral.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelBtnPesquisar.ResumeLayout(false);
            this.panelSituacao.ResumeLayout(false);
            this.panelSituacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox PictureBoxUsuarioBarraTitulo;
        private System.Windows.Forms.Label lblConsultaUsuario;
        private Guna.UI2.WinForms.Guna2Button btnPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnNovo;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonID;
        private System.Windows.Forms.Label lblTotalRegistros;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonNomeReal;
        private System.Windows.Forms.Panel panelTop;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonUsuarioLogin;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonAtivo_Inativo;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonInativo;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonAtivo;
        private Guna.UI2.WinForms.Guna2Button btnFechar;
        private System.Windows.Forms.DataGridView dataGridViewUsuario;
        private System.Windows.Forms.Timer timerFadeIn;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxTipoUsuario;
        private System.Windows.Forms.Panel panelBtnNovo;
        private System.Windows.Forms.Panel panelBtnExcluir;
        private System.Windows.Forms.Panel panelBtnAtivarDesativar;
        private System.Windows.Forms.Panel panelManipulacaoGeral;
        private System.Windows.Forms.Panel panelBtnPesquisar;
        private System.Windows.Forms.Panel panelSituacao;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisar;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnLimpar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuarioLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoUsuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSituacao;
    }
}