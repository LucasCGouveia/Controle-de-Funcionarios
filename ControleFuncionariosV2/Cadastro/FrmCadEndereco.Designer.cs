namespace ControleFuncionariosV2.Cadastro
{
    partial class FrmCadEndereco
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
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.lblDadosDoCadastro = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.gbtxts = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade2 = new System.Windows.Forms.Label();
            this.mtxtNumero = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.mtxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtComplemento2 = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.Label();
            this.txtEnderco = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCodEndereco = new System.Windows.Forms.Label();
            this.txtSenhaCookie = new System.Windows.Forms.TextBox();
            this.txtUsuarioCookie = new System.Windows.Forms.TextBox();
            this.lblValidacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbResultadoDaPesquisa.SuspendLayout();
            this.gbtxts.SuspendLayout();
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
            this.dgv.Location = new System.Drawing.Point(6, 43);
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
            this.dgv.Size = new System.Drawing.Size(867, 185);
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
            this.gbResultadoDaPesquisa.Location = new System.Drawing.Point(12, 93);
            this.gbResultadoDaPesquisa.Name = "gbResultadoDaPesquisa";
            this.gbResultadoDaPesquisa.Size = new System.Drawing.Size(879, 255);
            this.gbResultadoDaPesquisa.TabIndex = 59;
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
            this.lblResultadoDaPesquisa.Location = new System.Drawing.Point(389, 14);
            this.lblResultadoDaPesquisa.Name = "lblResultadoDaPesquisa";
            this.lblResultadoDaPesquisa.Size = new System.Drawing.Size(155, 15);
            this.lblResultadoDaPesquisa.TabIndex = 0;
            this.lblResultadoDaPesquisa.Text = "Resultado da Pesquisa";
            this.lblResultadoDaPesquisa.Click += new System.EventHandler(this.lblResultadoDaPesquisa_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.Black;
            this.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar.Location = new System.Drawing.Point(14, 556);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(171, 47);
            this.BtnEditar.TabIndex = 65;
            this.BtnEditar.Text = "E&ditar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.Black;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(190, 556);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(171, 47);
            this.BtnExcluir.TabIndex = 64;
            this.BtnExcluir.Text = "   &Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // lblDadosDoCadastro
            // 
            this.lblDadosDoCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDadosDoCadastro.AutoSize = true;
            this.lblDadosDoCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblDadosDoCadastro.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosDoCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDadosDoCadastro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDadosDoCadastro.Location = new System.Drawing.Point(157, 41);
            this.lblDadosDoCadastro.Name = "lblDadosDoCadastro";
            this.lblDadosDoCadastro.Size = new System.Drawing.Size(255, 46);
            this.lblDadosDoCadastro.TabIndex = 63;
            this.lblDadosDoCadastro.Text = "Endereços de: ";
            this.lblDadosDoCadastro.Click += new System.EventHandler(this.lblDadosDoCadastro_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(366, 556);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(171, 47);
            this.btnLimpar.TabIndex = 62;
            this.btnLimpar.Text = "   &Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.BackColor = System.Drawing.Color.DimGray;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(720, 556);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(171, 47);
            this.btnSair.TabIndex = 61;
            this.btnSair.Text = "Sair";
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
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(543, 556);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(171, 47);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "     &Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNomeFuncionario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(402, 41);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(253, 46);
            this.lblNomeFuncionario.TabIndex = 66;
            this.lblNomeFuncionario.Text = "Funcionario!!!";
            this.lblNomeFuncionario.Click += new System.EventHandler(this.lblNomeFuncionario_Click);
            // 
            // LblCodigo
            // 
            this.LblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.LblCodigo.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblCodigo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblCodigo.Location = new System.Drawing.Point(17, 41);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(141, 46);
            this.LblCodigo.TabIndex = 67;
            this.LblCodigo.Text = "COD!!!";
            this.LblCodigo.Visible = false;
            this.LblCodigo.Click += new System.EventHandler(this.LblCodigo_Click);
            // 
            // gbtxts
            // 
            this.gbtxts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbtxts.BackColor = System.Drawing.Color.Transparent;
            this.gbtxts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbtxts.Controls.Add(this.txtDescricao);
            this.gbtxts.Controls.Add(this.label1);
            this.gbtxts.Controls.Add(this.Label24);
            this.gbtxts.Controls.Add(this.cboxEstado);
            this.gbtxts.Controls.Add(this.lblEstado);
            this.gbtxts.Controls.Add(this.lblCidade2);
            this.gbtxts.Controls.Add(this.mtxtNumero);
            this.gbtxts.Controls.Add(this.txtCidade);
            this.gbtxts.Controls.Add(this.lblCidade);
            this.gbtxts.Controls.Add(this.mtxtCEP);
            this.gbtxts.Controls.Add(this.txtComplemento2);
            this.gbtxts.Controls.Add(this.txtBairro);
            this.gbtxts.Controls.Add(this.lblBairro);
            this.gbtxts.Controls.Add(this.txtEnd);
            this.gbtxts.Controls.Add(this.txtComplemento);
            this.gbtxts.Controls.Add(this.txtEnderco);
            this.gbtxts.Controls.Add(this.lblNumero);
            this.gbtxts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtxts.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbtxts.Location = new System.Drawing.Point(12, 354);
            this.gbtxts.Name = "gbtxts";
            this.gbtxts.Size = new System.Drawing.Size(879, 184);
            this.gbtxts.TabIndex = 107;
            this.gbtxts.TabStop = false;
            this.gbtxts.Enter += new System.EventHandler(this.gbtxts_Enter);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtDescricao.Location = new System.Drawing.Point(33, 85);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(313, 22);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Descrição:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label24
            // 
            this.Label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label24.AutoSize = true;
            this.Label24.BackColor = System.Drawing.Color.Transparent;
            this.Label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Label24.ForeColor = System.Drawing.Color.Black;
            this.Label24.Location = new System.Drawing.Point(344, 19);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(167, 20);
            this.Label24.TabIndex = 0;
            this.Label24.Text = "Endereço Completo";
            this.Label24.Click += new System.EventHandler(this.Label24_Click);
            // 
            // cboxEstado
            // 
            this.cboxEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxEstado.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.cboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cboxEstado.Location = new System.Drawing.Point(719, 130);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(139, 24);
            this.cboxEstado.Sorted = true;
            this.cboxEstado.TabIndex = 7;
            this.cboxEstado.UseWaitCursor = true;
            this.cboxEstado.SelectedIndexChanged += new System.EventHandler(this.cboxEstado_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(716, 113);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(57, 16);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado :";
            this.lblEstado.Click += new System.EventHandler(this.lblEstado_Click);
            // 
            // lblCidade2
            // 
            this.lblCidade2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCidade2.AutoSize = true;
            this.lblCidade2.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCidade2.ForeColor = System.Drawing.Color.Black;
            this.lblCidade2.Location = new System.Drawing.Point(352, 62);
            this.lblCidade2.Name = "lblCidade2";
            this.lblCidade2.Size = new System.Drawing.Size(38, 16);
            this.lblCidade2.TabIndex = 0;
            this.lblCidade2.Text = "CEP:";
            this.lblCidade2.Click += new System.EventHandler(this.lblCidade2_Click);
            // 
            // mtxtNumero
            // 
            this.mtxtNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mtxtNumero.Location = new System.Drawing.Point(807, 85);
            this.mtxtNumero.Mask = "000000";
            this.mtxtNumero.Name = "mtxtNumero";
            this.mtxtNumero.Size = new System.Drawing.Size(51, 22);
            this.mtxtNumero.TabIndex = 3;
            this.mtxtNumero.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtNumero_MaskInputRejected);
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCidade.Location = new System.Drawing.Point(464, 130);
            this.txtCidade.MaxLength = 20;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(238, 22);
            this.txtCidade.TabIndex = 6;
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidade_TextChanged);
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCidade.AutoSize = true;
            this.lblCidade.BackColor = System.Drawing.Color.Transparent;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblCidade.ForeColor = System.Drawing.Color.Black;
            this.lblCidade.Location = new System.Drawing.Point(462, 113);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(55, 16);
            this.lblCidade.TabIndex = 0;
            this.lblCidade.Text = "Cidade:";
            this.lblCidade.Click += new System.EventHandler(this.lblCidade_Click);
            // 
            // mtxtCEP
            // 
            this.mtxtCEP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.mtxtCEP.Location = new System.Drawing.Point(352, 85);
            this.mtxtCEP.Mask = "00000-9999";
            this.mtxtCEP.Name = "mtxtCEP";
            this.mtxtCEP.Size = new System.Drawing.Size(74, 22);
            this.mtxtCEP.TabIndex = 1;
            this.mtxtCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtCEP_MaskInputRejected);
            // 
            // txtComplemento2
            // 
            this.txtComplemento2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComplemento2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtComplemento2.Location = new System.Drawing.Point(33, 130);
            this.txtComplemento2.MaxLength = 50;
            this.txtComplemento2.Name = "txtComplemento2";
            this.txtComplemento2.Size = new System.Drawing.Size(167, 22);
            this.txtComplemento2.TabIndex = 4;
            this.txtComplemento2.TextChanged += new System.EventHandler(this.txtComplemento2_TextChanged);
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtBairro.Location = new System.Drawing.Point(206, 130);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(254, 22);
            this.txtBairro.TabIndex = 5;
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBairro.AutoSize = true;
            this.lblBairro.BackColor = System.Drawing.Color.Transparent;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblBairro.ForeColor = System.Drawing.Color.Black;
            this.lblBairro.Location = new System.Drawing.Point(203, 113);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(47, 16);
            this.lblBairro.TabIndex = 0;
            this.lblBairro.Text = "Bairro:";
            this.lblBairro.Click += new System.EventHandler(this.lblBairro_Click);
            // 
            // txtEnd
            // 
            this.txtEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEnd.Location = new System.Drawing.Point(436, 85);
            this.txtEnd.MaxLength = 50;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(366, 22);
            this.txtEnd.TabIndex = 2;
            this.txtEnd.TextChanged += new System.EventHandler(this.txtEnd_TextChanged);
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComplemento.AutoSize = true;
            this.txtComplemento.BackColor = System.Drawing.Color.Transparent;
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtComplemento.ForeColor = System.Drawing.Color.Black;
            this.txtComplemento.Location = new System.Drawing.Point(30, 113);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(95, 16);
            this.txtComplemento.TabIndex = 0;
            this.txtComplemento.Text = "Complemento:";
            this.txtComplemento.Click += new System.EventHandler(this.txtComplemento_Click);
            // 
            // txtEnderco
            // 
            this.txtEnderco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnderco.AutoSize = true;
            this.txtEnderco.BackColor = System.Drawing.Color.Transparent;
            this.txtEnderco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtEnderco.ForeColor = System.Drawing.Color.Black;
            this.txtEnderco.Location = new System.Drawing.Point(433, 62);
            this.txtEnderco.Name = "txtEnderco";
            this.txtEnderco.Size = new System.Drawing.Size(70, 16);
            this.txtEnderco.TabIndex = 0;
            this.txtEnderco.Text = "Endereço:";
            this.txtEnderco.Click += new System.EventHandler(this.txtEnderco_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblNumero.ForeColor = System.Drawing.Color.Black;
            this.lblNumero.Location = new System.Drawing.Point(802, 62);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(25, 16);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "N°:";
            this.lblNumero.Click += new System.EventHandler(this.lblNumero_Click);
            // 
            // lblCodEndereco
            // 
            this.lblCodEndereco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodEndereco.AutoSize = true;
            this.lblCodEndereco.BackColor = System.Drawing.Color.Transparent;
            this.lblCodEndereco.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEndereco.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodEndereco.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCodEndereco.Location = new System.Drawing.Point(750, 39);
            this.lblCodEndereco.Name = "lblCodEndereco";
            this.lblCodEndereco.Size = new System.Drawing.Size(141, 46);
            this.lblCodEndereco.TabIndex = 108;
            this.lblCodEndereco.Text = "COD!!!";
            this.lblCodEndereco.Visible = false;
            this.lblCodEndereco.Click += new System.EventHandler(this.lblCodEndereco_Click);
            // 
            // txtSenhaCookie
            // 
            this.txtSenhaCookie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSenhaCookie.Location = new System.Drawing.Point(218, 12);
            this.txtSenhaCookie.MaxLength = 20;
            this.txtSenhaCookie.Name = "txtSenhaCookie";
            this.txtSenhaCookie.PasswordChar = '*';
            this.txtSenhaCookie.Size = new System.Drawing.Size(199, 20);
            this.txtSenhaCookie.TabIndex = 123;
            this.txtSenhaCookie.Text = "txtSenhaCookie";
            this.txtSenhaCookie.Visible = false;
            this.txtSenhaCookie.TextChanged += new System.EventHandler(this.txtSenhaCookie_TextChanged);
            // 
            // txtUsuarioCookie
            // 
            this.txtUsuarioCookie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsuarioCookie.Location = new System.Drawing.Point(3, 12);
            this.txtUsuarioCookie.MaxLength = 20;
            this.txtUsuarioCookie.Name = "txtUsuarioCookie";
            this.txtUsuarioCookie.Size = new System.Drawing.Size(199, 20);
            this.txtUsuarioCookie.TabIndex = 122;
            this.txtUsuarioCookie.Text = "txtUsuarioCookie";
            this.txtUsuarioCookie.Visible = false;
            this.txtUsuarioCookie.TextChanged += new System.EventHandler(this.txtUsuarioCookie_TextChanged);
            // 
            // lblValidacao
            // 
            this.lblValidacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidacao.AutoSize = true;
            this.lblValidacao.BackColor = System.Drawing.Color.Transparent;
            this.lblValidacao.Font = new System.Drawing.Font("Goudy Old Style", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValidacao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblValidacao.Location = new System.Drawing.Point(603, -5);
            this.lblValidacao.Name = "lblValidacao";
            this.lblValidacao.Size = new System.Drawing.Size(290, 46);
            this.lblValidacao.TabIndex = 124;
            this.lblValidacao.Text = "VALIDACAO!!!";
            this.lblValidacao.Visible = false;
            this.lblValidacao.Click += new System.EventHandler(this.lblValidacao_Click);
            // 
            // FrmCadEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 643);
            this.Controls.Add(this.lblValidacao);
            this.Controls.Add(this.txtSenhaCookie);
            this.Controls.Add(this.txtUsuarioCookie);
            this.Controls.Add(this.lblCodEndereco);
            this.Controls.Add(this.gbtxts);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.gbResultadoDaPesquisa);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.lblDadosDoCadastro);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCadEndereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadEndereco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCadEndereco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbResultadoDaPesquisa.ResumeLayout(false);
            this.gbResultadoDaPesquisa.PerformLayout();
            this.gbtxts.ResumeLayout(false);
            this.gbtxts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgv;
        internal System.Windows.Forms.GroupBox gbResultadoDaPesquisa;
        internal System.Windows.Forms.Label lblResultadoDaPesquisa;
        internal System.Windows.Forms.Button BtnEditar;
        internal System.Windows.Forms.Button BtnExcluir;
        internal System.Windows.Forms.Label lblDadosDoCadastro;
        internal System.Windows.Forms.Button btnLimpar;
        internal System.Windows.Forms.Button btnSair;
        internal System.Windows.Forms.Button btnGravar;
        internal System.Windows.Forms.Label lblNomeFuncionario;
        internal System.Windows.Forms.Label LblCodigo;
        public System.Windows.Forms.GroupBox gbtxts;
        public System.Windows.Forms.Label Label24;
        public System.Windows.Forms.ComboBox cboxEstado;
        public System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.Label lblCidade2;
        public System.Windows.Forms.MaskedTextBox mtxtNumero;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.Label lblCidade;
        public System.Windows.Forms.MaskedTextBox mtxtCEP;
        public System.Windows.Forms.TextBox txtComplemento2;
        public System.Windows.Forms.TextBox txtBairro;
        public System.Windows.Forms.Label lblBairro;
        public System.Windows.Forms.TextBox txtEnd;
        public System.Windows.Forms.Label txtComplemento;
        public System.Windows.Forms.Label txtEnderco;
        public System.Windows.Forms.Label lblNumero;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblCodEndereco;
        internal System.Windows.Forms.TextBox txtSenhaCookie;
        public System.Windows.Forms.TextBox txtUsuarioCookie;
        internal System.Windows.Forms.Label lblValidacao;
    }
}