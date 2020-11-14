namespace ControleFuncionariosV2.Secundarios
{
    partial class FrmJuntarUserAFunc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.cboxUsuarioNãoAtribuidos = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnAtribuir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cbUsuariosCadastrados = new System.Windows.Forms.GroupBox();
            this.txtSenhaCookie = new System.Windows.Forms.TextBox();
            this.txtUsuarioCookie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCodUserAtribuidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesquisaUserAtribuidos = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnDesatribuir = new System.Windows.Forms.Button();
            this.BtnPesquisaUserAtribuidos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvUserAtribuidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.gbCadastro.SuspendLayout();
            this.cbUsuariosCadastrados.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAtribuidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(131, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 92);
            this.label1.TabIndex = 95;
            this.label1.Text = "Atribuir Usuario\r\na Funcionarios";
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(252, 32);
            this.btnSair.Name = "btnSair";
            this.btnSair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSair.Size = new System.Drawing.Size(128, 59);
            this.btnSair.TabIndex = 48;
            this.btnSair.Text = "\r\n&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dgv
            // 
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgv.Location = new System.Drawing.Point(14, 20);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(432, 147);
            this.dgv.TabIndex = 34;
            // 
            // TxtCod
            // 
            this.TxtCod.AcceptsReturn = true;
            this.TxtCod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCod.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtCod.Location = new System.Drawing.Point(130, 358);
            this.TxtCod.MaxLength = 50;
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCod.Size = new System.Drawing.Size(207, 21);
            this.TxtCod.TabIndex = 49;
            this.TxtCod.Visible = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.TxtCod);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.LblPesquisar);
            this.GroupBox1.Controls.Add(this.txtPesquisa);
            this.GroupBox1.Controls.Add(this.gbCadastro);
            this.GroupBox1.Controls.Add(this.btnPesquisar);
            this.GroupBox1.Controls.Add(this.cbUsuariosCadastrados);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Location = new System.Drawing.Point(31, 140);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(509, 450);
            this.GroupBox1.TabIndex = 94;
            this.GroupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(60, 358);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 50;
            this.label2.Tag = "&User Name:";
            this.label2.Text = "Codigo:";
            this.label2.Visible = false;
            // 
            // LblPesquisar
            // 
            this.LblPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.LblPesquisar.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPesquisar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblPesquisar.Location = new System.Drawing.Point(60, 193);
            this.LblPesquisar.Name = "LblPesquisar";
            this.LblPesquisar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblPesquisar.Size = new System.Drawing.Size(274, 27);
            this.LblPesquisar.TabIndex = 49;
            this.LblPesquisar.Tag = "&User Name:";
            this.LblPesquisar.Text = "Pesquisar Usuarios:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(57, 223);
            this.txtPesquisa.MaxLength = 50;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(265, 20);
            this.txtPesquisa.TabIndex = 80;
            // 
            // gbCadastro
            // 
            this.gbCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCadastro.BackColor = System.Drawing.Color.Transparent;
            this.gbCadastro.Controls.Add(this.cboxUsuarioNãoAtribuidos);
            this.gbCadastro.Controls.Add(this.lblNome);
            this.gbCadastro.Controls.Add(this.btnAtribuir);
            this.gbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbCadastro.Location = new System.Drawing.Point(36, 249);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbCadastro.Size = new System.Drawing.Size(451, 103);
            this.gbCadastro.TabIndex = 0;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "Atribuir";
            // 
            // cboxUsuarioNãoAtribuidos
            // 
            this.cboxUsuarioNãoAtribuidos.FormattingEnabled = true;
            this.cboxUsuarioNãoAtribuidos.Location = new System.Drawing.Point(21, 50);
            this.cboxUsuarioNãoAtribuidos.Name = "cboxUsuarioNãoAtribuidos";
            this.cboxUsuarioNãoAtribuidos.Size = new System.Drawing.Size(265, 23);
            this.cboxUsuarioNãoAtribuidos.TabIndex = 49;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNome.Location = new System.Drawing.Point(33, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNome.Size = new System.Drawing.Size(236, 24);
            this.lblNome.TabIndex = 46;
            this.lblNome.Tag = "&User Name:";
            this.lblNome.Text = "Usuarios não atribuidos a Funcionarios:";
            // 
            // btnAtribuir
            // 
            this.btnAtribuir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtribuir.BackColor = System.Drawing.Color.Transparent;
            this.btnAtribuir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtribuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtribuir.ForeColor = System.Drawing.Color.Black;
            this.btnAtribuir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtribuir.Location = new System.Drawing.Point(304, 23);
            this.btnAtribuir.Name = "btnAtribuir";
            this.btnAtribuir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAtribuir.Size = new System.Drawing.Size(128, 56);
            this.btnAtribuir.TabIndex = 50;
            this.btnAtribuir.Text = "&Atribuir";
            this.btnAtribuir.UseVisualStyleBackColor = false;
            this.btnAtribuir.Click += new System.EventHandler(this.btnAtribuir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(340, 189);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(128, 56);
            this.btnPesquisar.TabIndex = 46;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cbUsuariosCadastrados
            // 
            this.cbUsuariosCadastrados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUsuariosCadastrados.BackColor = System.Drawing.Color.Transparent;
            this.cbUsuariosCadastrados.Controls.Add(this.dgv);
            this.cbUsuariosCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsuariosCadastrados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbUsuariosCadastrados.Location = new System.Drawing.Point(30, 10);
            this.cbUsuariosCadastrados.Name = "cbUsuariosCadastrados";
            this.cbUsuariosCadastrados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbUsuariosCadastrados.Size = new System.Drawing.Size(457, 173);
            this.cbUsuariosCadastrados.TabIndex = 45;
            this.cbUsuariosCadastrados.TabStop = false;
            this.cbUsuariosCadastrados.Text = "Usuario sem Funcionarios Atribuido";
            // 
            // txtSenhaCookie
            // 
            this.txtSenhaCookie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSenhaCookie.Location = new System.Drawing.Point(264, 10);
            this.txtSenhaCookie.MaxLength = 20;
            this.txtSenhaCookie.Name = "txtSenhaCookie";
            this.txtSenhaCookie.PasswordChar = '*';
            this.txtSenhaCookie.Size = new System.Drawing.Size(199, 20);
            this.txtSenhaCookie.TabIndex = 127;
            this.txtSenhaCookie.Text = "txtSenhaCookie";
            // 
            // txtUsuarioCookie
            // 
            this.txtUsuarioCookie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsuarioCookie.Location = new System.Drawing.Point(49, 10);
            this.txtUsuarioCookie.MaxLength = 20;
            this.txtUsuarioCookie.Name = "txtUsuarioCookie";
            this.txtUsuarioCookie.Size = new System.Drawing.Size(199, 20);
            this.txtUsuarioCookie.TabIndex = 126;
            this.txtUsuarioCookie.Text = "txtUsuarioCookie";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(669, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 92);
            this.label3.TabIndex = 129;
            this.label3.Text = "Desatribuir Usuario\r\na Funcionarios";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtCodUserAtribuidos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPesquisaUserAtribuidos);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.BtnPesquisaUserAtribuidos);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox2.Location = new System.Drawing.Point(583, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 450);
            this.groupBox2.TabIndex = 95;
            this.groupBox2.TabStop = false;
            // 
            // txtCodUserAtribuidos
            // 
            this.txtCodUserAtribuidos.AcceptsReturn = true;
            this.txtCodUserAtribuidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodUserAtribuidos.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodUserAtribuidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodUserAtribuidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodUserAtribuidos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCodUserAtribuidos.Location = new System.Drawing.Point(130, 358);
            this.txtCodUserAtribuidos.MaxLength = 50;
            this.txtCodUserAtribuidos.Name = "txtCodUserAtribuidos";
            this.txtCodUserAtribuidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodUserAtribuidos.Size = new System.Drawing.Size(207, 21);
            this.txtCodUserAtribuidos.TabIndex = 49;
            this.txtCodUserAtribuidos.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(60, 358);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 50;
            this.label4.Tag = "&User Name:";
            this.label4.Text = "Codigo:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(60, 193);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(274, 27);
            this.label5.TabIndex = 49;
            this.label5.Tag = "&User Name:";
            this.label5.Text = "Pesquisar Funcionarios:";
            // 
            // txtPesquisaUserAtribuidos
            // 
            this.txtPesquisaUserAtribuidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisaUserAtribuidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisaUserAtribuidos.Location = new System.Drawing.Point(57, 223);
            this.txtPesquisaUserAtribuidos.MaxLength = 50;
            this.txtPesquisaUserAtribuidos.Name = "txtPesquisaUserAtribuidos";
            this.txtPesquisaUserAtribuidos.Size = new System.Drawing.Size(265, 20);
            this.txtPesquisaUserAtribuidos.TabIndex = 80;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.BtnDesatribuir);
            this.groupBox3.Controls.Add(this.btnSair);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(36, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(451, 103);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Atribuir";
            // 
            // BtnDesatribuir
            // 
            this.BtnDesatribuir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDesatribuir.BackColor = System.Drawing.Color.Transparent;
            this.BtnDesatribuir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDesatribuir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesatribuir.ForeColor = System.Drawing.Color.Black;
            this.BtnDesatribuir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDesatribuir.Location = new System.Drawing.Point(72, 32);
            this.BtnDesatribuir.Name = "BtnDesatribuir";
            this.BtnDesatribuir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnDesatribuir.Size = new System.Drawing.Size(128, 56);
            this.BtnDesatribuir.TabIndex = 50;
            this.BtnDesatribuir.Text = "&Desatribuir";
            this.BtnDesatribuir.UseVisualStyleBackColor = false;
            this.BtnDesatribuir.Click += new System.EventHandler(this.BtnDesatribuir_Click);
            // 
            // BtnPesquisaUserAtribuidos
            // 
            this.BtnPesquisaUserAtribuidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnPesquisaUserAtribuidos.BackColor = System.Drawing.Color.Transparent;
            this.BtnPesquisaUserAtribuidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPesquisaUserAtribuidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisaUserAtribuidos.ForeColor = System.Drawing.Color.Black;
            this.BtnPesquisaUserAtribuidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPesquisaUserAtribuidos.Location = new System.Drawing.Point(340, 189);
            this.BtnPesquisaUserAtribuidos.Name = "BtnPesquisaUserAtribuidos";
            this.BtnPesquisaUserAtribuidos.Size = new System.Drawing.Size(128, 56);
            this.BtnPesquisaUserAtribuidos.TabIndex = 46;
            this.BtnPesquisaUserAtribuidos.Text = "&Pesquisar";
            this.BtnPesquisaUserAtribuidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPesquisaUserAtribuidos.UseVisualStyleBackColor = false;
            this.BtnPesquisaUserAtribuidos.Click += new System.EventHandler(this.BtnPesquisaUserAtribuidos_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dgvUserAtribuidos);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Location = new System.Drawing.Point(30, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox4.Size = new System.Drawing.Size(457, 173);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usuario Atribuidos há Funcionarios";
            // 
            // dgvUserAtribuidos
            // 
            this.dgvUserAtribuidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvUserAtribuidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUserAtribuidos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUserAtribuidos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvUserAtribuidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserAtribuidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvUserAtribuidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUserAtribuidos.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvUserAtribuidos.Location = new System.Drawing.Point(14, 20);
            this.dgvUserAtribuidos.MultiSelect = false;
            this.dgvUserAtribuidos.Name = "dgvUserAtribuidos";
            this.dgvUserAtribuidos.ReadOnly = true;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserAtribuidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvUserAtribuidos.RowHeadersWidth = 51;
            dataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvUserAtribuidos.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvUserAtribuidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserAtribuidos.Size = new System.Drawing.Size(432, 147);
            this.dgvUserAtribuidos.TabIndex = 34;
            // 
            // FrmJuntarUserAFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSenhaCookie);
            this.Controls.Add(this.txtUsuarioCookie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmJuntarUserAFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmJuntarUserAFunc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmJuntarUserAFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.gbCadastro.ResumeLayout(false);
            this.cbUsuariosCadastrados.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAtribuidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnSair;
        internal System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.TextBox TxtCod;
        internal System.Windows.Forms.GroupBox GroupBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LblPesquisar;
        internal System.Windows.Forms.TextBox txtPesquisa;
        public System.Windows.Forms.GroupBox gbCadastro;
        public System.Windows.Forms.Label lblNome;
        internal System.Windows.Forms.Button btnPesquisar;
        internal System.Windows.Forms.Button btnAtribuir;
        public System.Windows.Forms.GroupBox cbUsuariosCadastrados;
        private System.Windows.Forms.ComboBox cboxUsuarioNãoAtribuidos;
        internal System.Windows.Forms.TextBox txtSenhaCookie;
        public System.Windows.Forms.TextBox txtUsuarioCookie;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtCodUserAtribuidos;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtPesquisaUserAtribuidos;
        public System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Button BtnDesatribuir;
        internal System.Windows.Forms.Button BtnPesquisaUserAtribuidos;
        public System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.DataGridView dgvUserAtribuidos;
    }
}