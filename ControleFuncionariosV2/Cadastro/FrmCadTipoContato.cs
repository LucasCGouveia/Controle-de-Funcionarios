using ControleFuncionarios.Repository;
using ControleFuncionarios.Repository.BancoDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFuncionariosV2.Cadastro
{
    public partial class FrmCadTipoContato : Form
    {
        public FrmCadTipoContato()
        {
            InitializeComponent();
        }
        ClnFuncoesGerais.Operacao ObjOperacao;   //Cria Obj da Operação
        public ClnFuncoesGerais.Operacao EnumProperty //Método para receber o valor
        {
            get { return ObjOperacao; }//Retorna o valor
            set { ObjOperacao = value; }//Recebe o valor
        }
        //==============================================

        public void CarregaDataGrid()
        {
            ClnContatosRepository ObjContatos = new ClnContatosRepository();//Criar Obj
            dgv.DataSource = ObjContatos.ListarTiposContatos(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
            dgv.Columns[0].HeaderText = ("Codigo");
            dgv.Columns[1].HeaderText = ("Tipo de Contato");
            dgv.AutoResizeColumns(); //Tamanho exato da maior coluna
            if (dgv.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
            {
                //btnRelatorio.Enabled = false; //Desativar os botões
                //btnConsultar.Enabled = false;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: " + txtPesquisa.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.DataSource = null; //Limpa o cabeçalho
                txtPesquisa.Text = "";
                txtPesquisa.Focus();
            }
            else
            {
                //btnRelatorio.Enabled = true; //Ativar os botões
                //btnConsultar.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmGerenciamento ObjGerenciamento = new FrmGerenciamento();
            ObjGerenciamento.Show();
            ObjGerenciamento.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            ObjGerenciamento.txtSenhaCookie.Text = txtSenhaCookie.Text;
            this.Close();
        }

        private void FrmCadTipoContato_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "")
            {
                CarregaDataGrid();
            }
            else
            {
                MessageBox.Show("Opa!!! esqueceu de preencher o campo Pesquisar. vou trazer tudo beleza!!! ", "Falta de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregaDataGrid();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmCadUsuario ObjCadUsuario = new FrmCadUsuario();
            ObjCadUsuario.Text = ">>> Alterar <<<";
            ObjCadUsuario.txtSenha.Visible = false;
            ObjCadUsuario.lblSenha.Text = "Necessario Logar para alterar a senha";
            ObjCadUsuario.LblPesquisar.Text = "Atenção voce esta alterando o Usuario:";
            ObjCadUsuario.txtPesquisa.Enabled = false;
            ObjCadUsuario.txtPesquisa.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value); //Envia para o campo código o valor do código marcado
            ObjCadUsuario.btnEditar.Visible = false;
            ObjCadUsuario.btnExcluir.Visible = false;
            ObjCadUsuario.btnGravar.Text = "&Alterar";
            ObjCadUsuario.TxtCod.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value); //Envia para o campo código o valor do código marcado
            ObjCadUsuario.txtUsuario.Focus();
            ObjCadUsuario.EnumProperty = ClnFuncoesGerais.Operacao.Alteracao; //Informa que é Alteração
            ObjCadUsuario.ShowDialog();
            CarregaDataGrid();
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int msg; //Pergunta e aguarda resposta
            msg = Convert.ToInt32(MessageBox.Show("Deseja excluir o registro? " + Convert.ToString(dgv.CurrentRow.Cells[0].Value), "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information));//msg aguardando resposta

            //Exclusão física, será apagado do BD
            if (msg == 6) //6 representa Yes e 7 No
            {
                ClnContatosRepository objContatos = new ClnContatosRepository(); //Apagar da Agenda
                objContatos.ExcluirTipoContato(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value)); //Por Código
                MessageBox.Show("Registro excluído com sucesso", "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("OPERAÇÃO CANCELADA", "CANCELAMENTO E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregaDataGrid();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Verifica se os campos nome e telefone estão preenchidos, porque são obrigatórios
            if ((txtTipo.Text == ""))
            {
                MessageBox.Show("Opa!!! algum Campo ficou em branco. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPesquisa.Focus();
            }
            else
            {
                ClnContatosRepository ObjContatos = new ClnContatosRepository();
                ObjContatos.TIPO = txtTipo.Text;
                if (btnGravar.Text == "&Alterar")
                {
                    ObjContatos.COD = Convert.ToInt32(TxtCod.Text);
                }
                if (ObjOperacao == ClnFuncoesGerais.Operacao.Inclusao)//Verifica se é inclusão faça
                {
                    ObjContatos.GravarTipoContato();
                    MessageBox.Show("Tipo de Contato: " + txtTipo.Text + ", cadastrado com sucesso", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTipo.Text = "";
                    txtPesquisa.Text = "";
                    CarregaDataGrid(); //Chama o Método Preencher a Grid
                }
                else if (ObjOperacao == ClnFuncoesGerais.Operacao.Alteracao)//Verifica se é alteração faça
                {
                    ObjContatos.AlterarTipoContato();
                    MessageBox.Show("Tipo de Contato: " + txtTipo.Text + ", Alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaDataGrid(); //Chama o Método Preencher a Grid
                    FrmCadUsuario objCadUsuario = new FrmCadUsuario();
                    objCadUsuario.Show();
                    this.Close();
                }
            }
        }
    }
}
