namespace ControleFuncionariosV2.Buscar
{
    partial class FrmBuscarFunc
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gbResultadoDaPesquisa = new System.Windows.Forms.GroupBox();
            this.lblResultadoDaPesquisa = new System.Windows.Forms.Label();
            this.gbPesquisa = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblPsquisaRapida = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblDadosDoCadastro = new System.Windows.Forms.Label();
            this.btnGerEndereco = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGerContato = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.txtSenhaCookie = new System.Windows.Forms.TextBox();
            this.txtUsuarioCookie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbResultadoDaPesquisa.SuspendLayout();
            this.gbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 45);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(867, 343);
            this.dgv.TabIndex = 3;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // gbResultadoDaPesquisa
            // 
            this.gbResultadoDaPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbResultadoDaPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.gbResultadoDaPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbResultadoDaPesquisa.Controls.Add(this.dgv);
            this.gbResultadoDaPesquisa.Controls.Add(this.lblResultadoDaPesquisa);
            this.gbResultadoDaPesquisa.Location = new System.Drawing.Point(24, 143);
            this.gbResultadoDaPesquisa.Name = "gbResultadoDaPesquisa";
            this.gbResultadoDaPesquisa.Size = new System.Drawing.Size(879, 394);
            this.gbResultadoDaPesquisa.TabIndex = 50;
            this.gbResultadoDaPesquisa.TabStop = false;
            this.gbResultadoDaPesquisa.Enter += new System.EventHandler(this.gbResultadoDaPesquisa_Enter);
            // 
            // lblResultadoDaPesquisa
            // 
            this.lblResultadoDaPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResultadoDaPesquisa.AutoSize = true;
            this.lblResultadoDaPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.lblResultadoDaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoDaPesquisa.ForeColor = System.Drawing.Color.Black;
            this.lblResultadoDaPesquisa.Location = new System.Drawing.Point(389, 15);
            this.lblResultadoDaPesquisa.Name = "lblResultadoDaPesquisa";
            this.lblResultadoDaPesquisa.Size = new System.Drawing.Size(155, 15);
            this.lblResultadoDaPesquisa.TabIndex = 0;
            this.lblResultadoDaPesquisa.Text = "Resultado da Pesquisa";
            this.lblResultadoDaPesquisa.Click += new System.EventHandler(this.lblResultadoDaPesquisa_Click);
            // 
            // gbPesquisa
            // 
            this.gbPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.gbPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbPesquisa.Controls.Add(this.btnPesquisar);
            this.gbPesquisa.Controls.Add(this.lblPsquisaRapida);
            this.gbPesquisa.Controls.Add(this.txtPesquisa);
            this.gbPesquisa.Location = new System.Drawing.Point(30, 71);
            this.gbPesquisa.Name = "gbPesquisa";
            this.gbPesquisa.Size = new System.Drawing.Size(879, 66);
            this.gbPesquisa.TabIndex = 49;
            this.gbPesquisa.TabStop = false;
            this.gbPesquisa.Enter += new System.EventHandler(this.gbPesquisa_Enter);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(671, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(91, 44);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblPsquisaRapida
            // 
            this.lblPsquisaRapida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPsquisaRapida.AutoSize = true;
            this.lblPsquisaRapida.BackColor = System.Drawing.Color.Transparent;
            this.lblPsquisaRapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPsquisaRapida.ForeColor = System.Drawing.Color.Black;
            this.lblPsquisaRapida.Location = new System.Drawing.Point(223, 16);
            this.lblPsquisaRapida.Name = "lblPsquisaRapida";
            this.lblPsquisaRapida.Size = new System.Drawing.Size(71, 15);
            this.lblPsquisaRapida.TabIndex = 1;
            this.lblPsquisaRapida.Text = "Pesquisar";
            this.lblPsquisaRapida.Click += new System.EventHandler(this.lblPsquisaRapida_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(226, 35);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(394, 20);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // lblDadosDoCadastro
            // 
            this.lblDadosDoCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDadosDoCadastro.AutoSize = true;
            this.lblDadosDoCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblDadosDoCadastro.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosDoCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDadosDoCadastro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDadosDoCadastro.Location = new System.Drawing.Point(303, 20);
            this.lblDadosDoCadastro.Name = "lblDadosDoCadastro";
            this.lblDadosDoCadastro.Size = new System.Drawing.Size(386, 46);
            this.lblDadosDoCadastro.TabIndex = 55;
            this.lblDadosDoCadastro.Text = "Busca de Funcionarios";
            this.lblDadosDoCadastro.Click += new System.EventHandler(this.lblDadosDoCadastro_Click);
            // 
            // btnGerEndereco
            // 
            this.btnGerEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerEndereco.BackColor = System.Drawing.Color.Transparent;
            this.btnGerEndereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGerEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerEndereco.ForeColor = System.Drawing.Color.Black;
            this.btnGerEndereco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerEndereco.Location = new System.Drawing.Point(24, 553);
            this.btnGerEndereco.Name = "btnGerEndereco";
            this.btnGerEndereco.Size = new System.Drawing.Size(171, 47);
            this.btnGerEndereco.TabIndex = 53;
            this.btnGerEndereco.Text = "   &Gerenciar Endereço";
            this.btnGerEndereco.UseVisualStyleBackColor = false;
            this.btnGerEndereco.Click += new System.EventHandler(this.btnGerEndereco_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.Color.DimGray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(732, 553);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(171, 47);
            this.btnSair.TabIndex = 52;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGerContato
            // 
            this.btnGerContato.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerContato.BackColor = System.Drawing.Color.Transparent;
            this.btnGerContato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGerContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerContato.ForeColor = System.Drawing.Color.Black;
            this.btnGerContato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerContato.Location = new System.Drawing.Point(201, 553);
            this.btnGerContato.Name = "btnGerContato";
            this.btnGerContato.Size = new System.Drawing.Size(171, 47);
            this.btnGerContato.TabIndex = 51;
            this.btnGerContato.Text = "     &Gerenciar Contato";
            this.btnGerContato.UseVisualStyleBackColor = false;
            this.btnGerContato.Click += new System.EventHandler(this.btnGerContato_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.Black;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(555, 552);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(171, 47);
            this.BtnExcluir.TabIndex = 56;
            this.BtnExcluir.Text = "   &Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.Black;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(378, 552);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(171, 47);
            this.BtnEditar.TabIndex = 57;
            this.BtnEditar.Text = "     &Editar\r\n";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // txtSenhaCookie
            // 
            this.txtSenhaCookie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSenhaCookie.Location = new System.Drawing.Point(12, 44);
            this.txtSenhaCookie.MaxLength = 20;
            this.txtSenhaCookie.Name = "txtSenhaCookie";
            this.txtSenhaCookie.PasswordChar = '*';
            this.txtSenhaCookie.Size = new System.Drawing.Size(199, 20);
            this.txtSenhaCookie.TabIndex = 112;
            this.txtSenhaCookie.Text = "txtSenhaCookie";
            this.txtSenhaCookie.TextChanged += new System.EventHandler(this.txtSenhaCookie_TextChanged);
            // 
            // txtUsuarioCookie
            // 
            this.txtUsuarioCookie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsuarioCookie.Location = new System.Drawing.Point(12, 12);
            this.txtUsuarioCookie.MaxLength = 20;
            this.txtUsuarioCookie.Name = "txtUsuarioCookie";
            this.txtUsuarioCookie.Size = new System.Drawing.Size(199, 20);
            this.txtUsuarioCookie.TabIndex = 111;
            this.txtUsuarioCookie.Text = "txtUsuarioCookie";
            this.txtUsuarioCookie.TextChanged += new System.EventHandler(this.txtUsuarioCookie_TextChanged);
            // 
            // FrmBuscarFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 634);
            this.Controls.Add(this.txtSenhaCookie);
            this.Controls.Add(this.txtUsuarioCookie);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.gbResultadoDaPesquisa);
            this.Controls.Add(this.gbPesquisa);
            this.Controls.Add(this.lblDadosDoCadastro);
            this.Controls.Add(this.btnGerEndereco);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerContato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmBuscarFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBuscarFunc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBuscarFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbResultadoDaPesquisa.ResumeLayout(false);
            this.gbResultadoDaPesquisa.PerformLayout();
            this.gbPesquisa.ResumeLayout(false);
            this.gbPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgv;
        internal System.Windows.Forms.GroupBox gbResultadoDaPesquisa;
        internal System.Windows.Forms.Label lblResultadoDaPesquisa;
        internal System.Windows.Forms.GroupBox gbPesquisa;
        internal System.Windows.Forms.Button btnPesquisar;
        internal System.Windows.Forms.Label lblPsquisaRapida;
        internal System.Windows.Forms.TextBox txtPesquisa;
        internal System.Windows.Forms.Label lblDadosDoCadastro;
        internal System.Windows.Forms.Button btnGerEndereco;
        internal System.Windows.Forms.Button btnSair;
        internal System.Windows.Forms.Button btnGerContato;
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Button BtnEditar;
        internal System.Windows.Forms.TextBox txtSenhaCookie;
        public System.Windows.Forms.TextBox txtUsuarioCookie;
    }
}