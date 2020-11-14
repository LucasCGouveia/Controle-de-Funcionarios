using ControleFuncionarios.Repository;
using ControleFuncionarios.Repository.BancoDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFuncionariosV2.Cadastro
{
    public partial class FrmCadCargos : Form
    {
        public FrmCadCargos()
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
            ClnCargosRepository ObjCargos = new ClnCargosRepository();//Criar Obj
            dgv.DataSource = ObjCargos.ListarCargosCadCargos(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
            dgv.Columns[0].HeaderText = ("COD");
            dgv.Columns[1].HeaderText = ("Cargo");
            dgv.Columns[2].HeaderText = ("Salario");
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
            FrmGerenciamento ObjfrmGerenciamento = new FrmGerenciamento();
            ObjfrmGerenciamento.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            ObjfrmGerenciamento.txtSenhaCookie.Text = txtSenhaCookie.Text;
            ObjfrmGerenciamento.Show();
            this.Close();
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

        private void FrmCadCargos_Load(object sender, EventArgs e)
        {
            try
            {
                //Chama o Método Preencher a Grid 
                CarregaDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opa!!! falha ao carregar usuarios cadastrados. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmCadCargos ObjCadCargos = new FrmCadCargos();
            ObjCadCargos.Text = ">>> Alterar <<<";
            ObjCadCargos.LblPesquisar.Text = "Atenção voce esta alterando o Usuario:";
            ObjCadCargos.btnEditar.Visible = false;
            ObjCadCargos.btnExcluir.Visible = false;
            ObjCadCargos.btnGravar.Text = "&Alterar";
            ObjCadCargos.txtPesquisa.Enabled = false;
            ObjCadCargos.txtPesquisa.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value); //Envia para o campo código o valor do código marcado
            ObjCadCargos.TxtCod.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value); //Envia para o campo código o valor do código marcado
            ObjCadCargos.txtCargo.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value); //Envia para o campo código o valor do código marcado
            ObjCadCargos.txtSalario.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value); //Envia para o campo código o valor do código marcado
            ObjCadCargos.txtCargo.Focus();
            ObjCadCargos.EnumProperty = ClnFuncoesGerais.Operacao.Alteracao; //Informa que é Alteração
            ObjCadCargos.ShowDialog();
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
                ClnCargosRepository objUsuario = new ClnCargosRepository(); //Apagar da Agenda
                objUsuario.Excluir(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value)); //Por Código
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
            if ((txtCargo.Text == ""))
            {
                MessageBox.Show("Opa!!! algum Campo ficou em branco. ", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPesquisa.Focus();
            }
            else
            {
                ClnCargosRepository Usuario = new ClnCargosRepository();
                Usuario.CARGO = txtCargo.Text;
                Usuario.SALARIO = TxtRS.Text + txtSalario.Text;
                if (btnGravar.Text == "&Alterar")
                {
                    Usuario.COD = Convert.ToInt32(TxtCod.Text);
                }
                if (ObjOperacao == ClnFuncoesGerais.Operacao.Inclusao)//Verifica se é inclusão faça
                {
                    Usuario.Gravar();
                    MessageBox.Show("Usuario: " + txtCargo.Text + ", cadastrado com sucesso", "Item Novo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCargo.Text = "";
                    txtSalario.Text = "";
                    txtPesquisa.Text = "";
                    CarregaDataGrid(); //Chama o Método Preencher a Grid
                }
                else if (ObjOperacao == ClnFuncoesGerais.Operacao.Alteracao)//Verifica se é alteração faça
                {
                    Usuario.Alterar();
                    MessageBox.Show("Usuario " + txtCargo.Text + ", Alterado com sucesso", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregaDataGrid(); //Chama o Método Preencher a Grid
                    FrmCadCargos objCadCargos = new FrmCadCargos();
                    objCadCargos.Show();
                    this.Close();
                }
            }
        }
    }
}
