namespace ControleFuncionariosV2.Cadastro
{
    partial class FrmCadTipoContato
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
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cbUsuariosCadastrados = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.LblPesquisar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaCookie = new System.Windows.Forms.TextBox();
            this.txtUsuarioCookie = new System.Windows.Forms.TextBox();
            this.gbCadastro.SuspendLayout();
            this.cbUsuariosCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(61, 209);
            this.txtPesquisa.MaxLength = 50;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(274, 20);
            this.txtPesquisa.TabIndex = 80;
            // 
            // gbCadastro
            // 
            this.gbCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCadastro.BackColor = System.Drawing.Color.Transparent;
            this.gbCadastro.Controls.Add(this.txtTipo);
            this.gbCadastro.Controls.Add(this.lblCargo);
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
            // 
            // txtTipo
            // 
            this.txtTipo.AcceptsReturn = true;
            this.txtTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTipo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTipo.Location = new System.Drawing.Point(58, 49);
            this.txtTipo.MaxLength = 50;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTipo.Size = new System.Drawing.Size(243, 21);
            this.txtTipo.TabIndex = 2;
            // 
            // lblCargo
            // 
            this.lblCargo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCargo.Location = new System.Drawing.Point(24, 52);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCargo.Size = new System.Drawing.Size(64, 21);
            this.lblCargo.TabIndex = 46;
            this.lblCargo.Tag = "&User Name:";
            this.lblCargo.Text = "Tipo:";
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
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(353, 189);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(113, 56);
            this.btnPesquisar.TabIndex = 46;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            this.cbUsuariosCadastrados.Text = "Tipos de Contatos Cadastrados";
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
            this.GroupBox1.Location = new System.Drawing.Point(35, 74);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(509, 450);
            this.GroupBox1.TabIndex = 96;
            this.GroupBox1.TabStop = false;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(52, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 46);
            this.label1.TabIndex = 97;
            this.label1.Text = "Cadastrar Tipo Contatos";
            // 
            // txtSenhaCookie
            // 
            this.txtSenhaCookie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSenhaCookie.Location = new System.Drawing.Point(218, 2);
            this.txtSenhaCookie.MaxLength = 20;
            this.txtSenhaCookie.Name = "txtSenhaCookie";
            this.txtSenhaCookie.PasswordChar = '*';
            this.txtSenhaCookie.Size = new System.Drawing.Size(199, 20);
            this.txtSenhaCookie.TabIndex = 125;
            this.txtSenhaCookie.Text = "txtSenhaCookie";
            // 
            // txtUsuarioCookie
            // 
            this.txtUsuarioCookie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsuarioCookie.Location = new System.Drawing.Point(3, 2);
            this.txtUsuarioCookie.MaxLength = 20;
            this.txtUsuarioCookie.Name = "txtUsuarioCookie";
            this.txtUsuarioCookie.Size = new System.Drawing.Size(199, 20);
            this.txtUsuarioCookie.TabIndex = 124;
            this.txtUsuarioCookie.Text = "txtUsuarioCookie";
            // 
            // FrmCadTipoContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 548);
            this.Controls.Add(this.txtSenhaCookie);
            this.Controls.Add(this.txtUsuarioCookie);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadTipoContato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadTipoContato";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCadTipoContato_Load);
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            this.cbUsuariosCadastrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtPesquisa;
        public System.Windows.Forms.GroupBox gbCadastro;
        public System.Windows.Forms.TextBox txtTipo;
        public System.Windows.Forms.Label lblCargo;
        internal System.Windows.Forms.Button btnSair;
        internal System.Windows.Forms.Button btnPesquisar;
        internal System.Windows.Forms.Button btnGravar;
        internal System.Windows.Forms.Button btnExcluir;
        internal System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.GroupBox cbUsuariosCadastrados;
        internal System.Windows.Forms.DataGridView dgv;
        public System.Windows.Forms.Label label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        public System.Windows.Forms.TextBox TxtCod;
        public System.Windows.Forms.Label LblPesquisar;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtSenhaCookie;
        public System.Windows.Forms.TextBox txtUsuarioCookie;
    }
}