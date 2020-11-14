namespace ControleFuncionariosV2.Principais
{
    partial class FrmTrocaSenha
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
            this.label1 = new System.Windows.Forms.Label();
            this.textUsuario_Troca = new System.Windows.Forms.TextBox();
            this.lblConfirmacao = new System.Windows.Forms.Label();
            this.lblNovaSenha = new System.Windows.Forms.Label();
            this.lblSenhaAtual = new System.Windows.Forms.Label();
            this.txtConfirmacao = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtSenhaCookie = new System.Windows.Forms.TextBox();
            this.txtUsuarioCookie = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 46);
            this.label1.TabIndex = 95;
            this.label1.Text = "Troca de Senha";
            // 
            // textUsuario_Troca
            // 
            this.textUsuario_Troca.Location = new System.Drawing.Point(102, 20);
            this.textUsuario_Troca.Name = "textUsuario_Troca";
            this.textUsuario_Troca.Size = new System.Drawing.Size(176, 20);
            this.textUsuario_Troca.TabIndex = 15;
            // 
            // lblConfirmacao
            // 
            this.lblConfirmacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmacao.AutoSize = true;
            this.lblConfirmacao.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblConfirmacao.Location = new System.Drawing.Point(4, 96);
            this.lblConfirmacao.Name = "lblConfirmacao";
            this.lblConfirmacao.Size = new System.Drawing.Size(92, 15);
            this.lblConfirmacao.TabIndex = 14;
            this.lblConfirmacao.Text = "Confirmação:";
            // 
            // lblNovaSenha
            // 
            this.lblNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNovaSenha.AutoSize = true;
            this.lblNovaSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNovaSenha.Location = new System.Drawing.Point(9, 72);
            this.lblNovaSenha.Name = "lblNovaSenha";
            this.lblNovaSenha.Size = new System.Drawing.Size(86, 15);
            this.lblNovaSenha.TabIndex = 13;
            this.lblNovaSenha.Text = "Nova senha:";
            // 
            // lblSenhaAtual
            // 
            this.lblSenhaAtual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSenhaAtual.AutoSize = true;
            this.lblSenhaAtual.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAtual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSenhaAtual.Location = new System.Drawing.Point(8, 48);
            this.lblSenhaAtual.Name = "lblSenhaAtual";
            this.lblSenhaAtual.Size = new System.Drawing.Size(88, 15);
            this.lblSenhaAtual.TabIndex = 12;
            this.lblSenhaAtual.Text = "Senha atual:";
            // 
            // txtConfirmacao
            // 
            this.txtConfirmacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConfirmacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtConfirmacao.Location = new System.Drawing.Point(102, 93);
            this.txtConfirmacao.MaxLength = 10;
            this.txtConfirmacao.Name = "txtConfirmacao";
            this.txtConfirmacao.PasswordChar = '*';
            this.txtConfirmacao.Size = new System.Drawing.Size(176, 21);
            this.txtConfirmacao.TabIndex = 4;
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNovaSenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNovaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNovaSenha.Location = new System.Drawing.Point(102, 69);
            this.txtNovaSenha.MaxLength = 10;
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(176, 21);
            this.txtNovaSenha.TabIndex = 3;
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaAtual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSenhaAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaAtual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSenhaAtual.Location = new System.Drawing.Point(102, 45);
            this.txtSenhaAtual.MaxLength = 10;
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '*';
            this.txtSenhaAtual.Size = new System.Drawing.Size(176, 21);
            this.txtSenhaAtual.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuario.Location = new System.Drawing.Point(31, 24);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 15);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuário:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GroupBox1.Controls.Add(this.textUsuario_Troca);
            this.GroupBox1.Controls.Add(this.lblConfirmacao);
            this.GroupBox1.Controls.Add(this.lblNovaSenha);
            this.GroupBox1.Controls.Add(this.lblSenhaAtual);
            this.GroupBox1.Controls.Add(this.txtConfirmacao);
            this.GroupBox1.Controls.Add(this.txtNovaSenha);
            this.GroupBox1.Controls.Add(this.txtSenhaAtual);
            this.GroupBox1.Controls.Add(this.lblUsuario);
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GroupBox1.Location = new System.Drawing.Point(19, 96);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(298, 132);
            this.GroupBox1.TabIndex = 92;
            this.GroupBox1.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.Location = new System.Drawing.Point(332, 102);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(84, 50);
            this.btnAlterar.TabIndex = 93;
            this.btnAlterar.Text = "&OK";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSair.Location = new System.Drawing.Point(332, 168);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(84, 50);
            this.btnSair.TabIndex = 94;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtSenhaCookie
            // 
            this.txtSenhaCookie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSenhaCookie.Location = new System.Drawing.Point(217, 12);
            this.txtSenhaCookie.MaxLength = 20;
            this.txtSenhaCookie.Name = "txtSenhaCookie";
            this.txtSenhaCookie.PasswordChar = '*';
            this.txtSenhaCookie.Size = new System.Drawing.Size(199, 20);
            this.txtSenhaCookie.TabIndex = 116;
            this.txtSenhaCookie.Text = "txtSenhaCookie";
            // 
            // txtUsuarioCookie
            // 
            this.txtUsuarioCookie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsuarioCookie.Location = new System.Drawing.Point(10, 12);
            this.txtUsuarioCookie.MaxLength = 20;
            this.txtUsuarioCookie.Name = "txtUsuarioCookie";
            this.txtUsuarioCookie.Size = new System.Drawing.Size(199, 20);
            this.txtUsuarioCookie.TabIndex = 115;
            this.txtUsuarioCookie.Text = "txtUsuarioCookie";
            // 
            // FrmTrocaSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 272);
            this.Controls.Add(this.txtSenhaCookie);
            this.Controls.Add(this.txtUsuarioCookie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTrocaSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTrocaSenha";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTrocaSenha_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textUsuario_Troca;
        internal System.Windows.Forms.Label lblConfirmacao;
        internal System.Windows.Forms.Label lblNovaSenha;
        internal System.Windows.Forms.Label lblSenhaAtual;
        internal System.Windows.Forms.TextBox txtConfirmacao;
        internal System.Windows.Forms.TextBox txtNovaSenha;
        internal System.Windows.Forms.TextBox txtSenhaAtual;
        internal System.Windows.Forms.Label lblUsuario;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnAlterar;
        internal System.Windows.Forms.Button btnSair;
        internal System.Windows.Forms.TextBox txtSenhaCookie;
        public System.Windows.Forms.TextBox txtUsuarioCookie;
    }
}