namespace ControleFuncionariosV2.Cadastro
{
    partial class FrmCadUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPesquisar = new System.Windows.Forms.Label();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cbUsuariosCadastrados = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.gbCadastro.SuspendLayout();
            this.cbUsuariosCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(61, 209);
            this.txtPesquisa.MaxLength = 50;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(265, 20);
            this.txtPesquisa.TabIndex = 80;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(338, 189);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(128, 56);
            this.btnPesquisar.TabIndex = 46;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.AcceptsReturn = true;
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSenha.Location = new System.Drawing.Point(94, 62);
            this.txtSenha.MaxLength = 8;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSenha.Size = new System.Drawing.Size(207, 21);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AcceptsReturn = true;
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsuario.Location = new System.Drawing.Point(94, 35);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsuario.Size = new System.Drawing.Size(207, 21);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNome.Location = new System.Drawing.Point(24, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNome.Size = new System.Drawing.Size(64, 21);
            this.lblNome.TabIndex = 46;
            this.lblNome.Tag = "&User Name:";
            this.lblNome.Text = "Login:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSenha.Location = new System.Drawing.Point(24, 61);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSenha.Size = new System.Drawing.Size(277, 21);
            this.lblSenha.TabIndex = 45;
            this.lblSenha.Tag = "&Password:";
            this.lblSenha.Text = "Senha:";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
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
            this.GroupBox1.Controls.Add(this.btnGravar);
            this.GroupBox1.Controls.Add(this.btnExcluir);
            this.GroupBox1.Controls.Add(this.btnEditar);
            this.GroupBox1.Controls.Add(this.cbUsuariosCadastrados);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Location = new System.Drawing.Point(15, 49);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(509, 450);
            this.GroupBox1.TabIndex = 92;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // TxtCod
            // 
            this.TxtCod.AcceptsReturn = true;
            this.TxtCod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCod.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtCod.Location = new System.Drawing.Point(128, 358);
            this.TxtCod.MaxLength = 50;
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtCod.Size = new System.Drawing.Size(207, 21);
            this.TxtCod.TabIndex = 49;
            this.TxtCod.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(58, 358);
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
            this.LblPesquisar.Location = new System.Drawing.Point(61, 186);
            this.LblPesquisar.Name = "LblPesquisar";
            this.LblPesquisar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblPesquisar.Size = new System.Drawing.Size(274, 27);
            this.LblPesquisar.TabIndex = 49;
            this.LblPesquisar.Tag = "&User Name:";
            this.LblPesquisar.Text = "Pesquisar:";
            // 
            // gbCadastro
            // 
            this.gbCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCadastro.BackColor = System.Drawing.Color.Transparent;
            this.gbCadastro.Controls.Add(this.txtSenha);
            this.gbCadastro.Controls.Add(this.txtUsuario);
            this.gbCadastro.Controls.Add(this.lblNome);
            this.gbCadastro.Controls.Add(this.lblSenha);
            this.gbCadastro.Controls.Add(this.btnSair);
            this.gbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbCadastro.Location = new System.Drawing.Point(34, 249);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbCadastro.Size = new System.Drawing.Size(432, 103);
            this.gbCadastro.TabIndex = 0;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "Incluir/Alterar/Excluir";
            this.gbCadastro.Enter += new System.EventHandler(this.gbCadastro_Enter);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(319, 23);
            this.btnSair.Name = "btnSair";
            this.btnSair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSair.Size = new System.Drawing.Size(97, 59);
            this.btnSair.TabIndex = 48;
            this.btnSair.Text = "\r\n&Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGravar.BackColor = System.Drawing.Color.Transparent;
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.ForeColor = System.Drawing.Color.Black;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.Location = new System.Drawing.Point(305, 402);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGravar.Size = new System.Drawing.Size(105, 42);
            this.btnGravar.TabIndex = 50;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.Location = new System.Drawing.Point(194, 402);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExcluir.Size = new System.Drawing.Size(105, 42);
            this.btnExcluir.TabIndex = 49;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Location = new System.Drawing.Point(83, 402);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEditar.Size = new System.Drawing.Size(105, 42);
            this.btnEditar.TabIndex = 47;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cbUsuariosCadastrados
            // 
            this.cbUsuariosCadastrados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUsuariosCadastrados.BackColor = System.Drawing.Color.Transparent;
            this.cbUsuariosCadastrados.Controls.Add(this.dgv);
            this.cbUsuariosCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsuariosCadastrados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbUsuariosCadastrados.Location = new System.Drawing.Point(28, 10);
            this.cbUsuariosCadastrados.Name = "cbUsuariosCadastrados";
            this.cbUsuariosCadastrados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbUsuariosCadastrados.Size = new System.Drawing.Size(444, 173);
            this.cbUsuariosCadastrados.TabIndex = 45;
            this.cbUsuariosCadastrados.TabStop = false;
            this.cbUsuariosCadastrados.Text = "Listados usuarios não ADM e não atribuidos a funcionario";
            this.cbUsuariosCadastrados.Enter += new System.EventHandler(this.cbUsuariosCadastrados_Enter);
            // 
            // dgv
            // 
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Location = new System.Drawing.Point(6, 20);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(432, 147);
            this.dgv.TabIndex = 34;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(33, -12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 46);
            this.label1.TabIndex = 93;
            this.label1.Text = "Cadastro de Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 516);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCadUsuario_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.cbUsuariosCadastrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txtPesquisa;
        internal System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.Label lblNome;
        public System.Windows.Forms.Label lblSenha;
        internal System.Windows.Forms.GroupBox GroupBox1;
        public System.Windows.Forms.GroupBox gbCadastro;
        internal System.Windows.Forms.Button btnSair;
        internal System.Windows.Forms.Button btnGravar;
        internal System.Windows.Forms.Button btnExcluir;
        internal System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.GroupBox cbUsuariosCadastrados;
        internal System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LblPesquisar;
        public System.Windows.Forms.TextBox TxtCod;
        public System.Windows.Forms.Label label2;
    }
}