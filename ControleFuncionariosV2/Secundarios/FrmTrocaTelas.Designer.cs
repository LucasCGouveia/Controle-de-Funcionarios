namespace ControleFuncionariosV2.Secundarios
{
    partial class FrmTrocaTelas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrocaTelas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSim = new System.Windows.Forms.Button();
            this.BtnDeslogar = new System.Windows.Forms.Button();
            this.BtnNao = new System.Windows.Forms.Button();
            this.txtSenhaCookie = new System.Windows.Forms.TextBox();
            this.txtUsuarioCookie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(418, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(58, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Você Realmente Deseja Sair do Sistema?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnSim
            // 
            this.BtnSim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSim.Location = new System.Drawing.Point(62, 133);
            this.BtnSim.Name = "BtnSim";
            this.BtnSim.Size = new System.Drawing.Size(103, 61);
            this.BtnSim.TabIndex = 3;
            this.BtnSim.Text = "Sim";
            this.BtnSim.UseVisualStyleBackColor = true;
            this.BtnSim.Click += new System.EventHandler(this.BtnSim_Click);
            // 
            // BtnDeslogar
            // 
            this.BtnDeslogar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDeslogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeslogar.Location = new System.Drawing.Point(309, 133);
            this.BtnDeslogar.Name = "BtnDeslogar";
            this.BtnDeslogar.Size = new System.Drawing.Size(103, 61);
            this.BtnDeslogar.TabIndex = 4;
            this.BtnDeslogar.Text = "Deslogar-se";
            this.BtnDeslogar.UseVisualStyleBackColor = true;
            this.BtnDeslogar.Click += new System.EventHandler(this.BtnDeslogar_Click);
            // 
            // BtnNao
            // 
            this.BtnNao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNao.Location = new System.Drawing.Point(183, 133);
            this.BtnNao.Name = "BtnNao";
            this.BtnNao.Size = new System.Drawing.Size(103, 61);
            this.BtnNao.TabIndex = 5;
            this.BtnNao.Text = "Não";
            this.BtnNao.UseVisualStyleBackColor = true;
            this.BtnNao.Click += new System.EventHandler(this.BtnNao_Click);
            // 
            // txtSenhaCookie
            // 
            this.txtSenhaCookie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSenhaCookie.Location = new System.Drawing.Point(12, 45);
            this.txtSenhaCookie.MaxLength = 20;
            this.txtSenhaCookie.Name = "txtSenhaCookie";
            this.txtSenhaCookie.PasswordChar = '*';
            this.txtSenhaCookie.Size = new System.Drawing.Size(199, 20);
            this.txtSenhaCookie.TabIndex = 114;
            this.txtSenhaCookie.Text = "txtSenhaCookie";
            this.txtSenhaCookie.TextChanged += new System.EventHandler(this.txtSenhaCookie_TextChanged);
            // 
            // txtUsuarioCookie
            // 
            this.txtUsuarioCookie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsuarioCookie.Location = new System.Drawing.Point(12, 13);
            this.txtUsuarioCookie.MaxLength = 20;
            this.txtUsuarioCookie.Name = "txtUsuarioCookie";
            this.txtUsuarioCookie.Size = new System.Drawing.Size(199, 20);
            this.txtUsuarioCookie.TabIndex = 113;
            this.txtUsuarioCookie.Text = "txtUsuarioCookie";
            this.txtUsuarioCookie.TextChanged += new System.EventHandler(this.txtUsuarioCookie_TextChanged);
            // 
            // FrmTrocaTelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 299);
            this.Controls.Add(this.txtSenhaCookie);
            this.Controls.Add(this.txtUsuarioCookie);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSim);
            this.Controls.Add(this.BtnDeslogar);
            this.Controls.Add(this.BtnNao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTrocaTelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTrocaTelas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSim;
        private System.Windows.Forms.Button BtnDeslogar;
        private System.Windows.Forms.Button BtnNao;
        internal System.Windows.Forms.TextBox txtSenhaCookie;
        public System.Windows.Forms.TextBox txtUsuarioCookie;
    }
}