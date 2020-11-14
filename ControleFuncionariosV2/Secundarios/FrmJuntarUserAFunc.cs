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

namespace ControleFuncionariosV2.Secundarios
{
    public partial class FrmJuntarUserAFunc : Form
    {
        public FrmJuntarUserAFunc()
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

        public void CarregaDataGridAtribuir()
        {
            ClnUsuarioRepository ObjUsuario = new ClnUsuarioRepository();//Criar Obj
            dgv.DataSource = ObjUsuario.ListarUserParaAtribuir(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
            dgv.Columns[0].HeaderText = ("COD");
            dgv.Columns[1].HeaderText = ("USUARIO");
            dgv.AutoResizeColumns(); //Tamanho exato da maior coluna
            if (dgv.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
            {
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: " + txtPesquisa.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgv.DataSource = null; //Limpa o cabeçalho
                txtPesquisa.Text = "";
                txtPesquisa.Focus();
            }
            else
            {
                //btnRelatorio.Enabled = true; //Ativar os botões
                //btnConsultar.Enabled = true;
            }
        }

        public void CarregaDataGridDesatribuir()
        {
            ClnUsuarioRepository ObjUsuario = new ClnUsuarioRepository();//Criar Obj
            dgvUserAtribuidos.DataSource = ObjUsuario.ListarUserAtribuidos(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
            //Cria os Cabeçalhos de cada coluna
            dgvUserAtribuidos.Columns[0].HeaderText = ("COD User");
            dgvUserAtribuidos.Columns[1].HeaderText = ("USUARIO");
            dgvUserAtribuidos.Columns[2].HeaderText = ("COD Func");
            dgvUserAtribuidos.Columns[3].HeaderText = ("Funcionario");
            dgvUserAtribuidos.AutoResizeColumns(); //Tamanho exato da maior coluna
            if (dgv.RowCount == 0) //Se não houver dados no DGV, os botão serão desativados
            {
                MessageBox.Show("NÃO FORAM ENCONTRADOS DADOS COM A INFORMAÇÃO: " + txtPesquisa.Text, "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvUserAtribuidos.DataSource = null; //Limpa o cabeçalho
                txtPesquisa.Text = "";
                txtPesquisa.Focus();
            }
            else
            {
                //btnRelatorio.Enabled = true; //Ativar os botões
                //btnConsultar.Enabled = true;
            }
        }

        public void CarregaComboBox()
        {
            //Carregar ComboBox de Usuarios Não Atribuidos
            ClnFuncRepository ObjClnFuncRepository = new ClnFuncRepository();//Criar Obj
            DataTable dtResultado = ObjClnFuncRepository.ListarFuncSemUser().Tables[0];
            cboxUsuarioNãoAtribuidos.DataSource = null;
            cboxUsuarioNãoAtribuidos.DataSource = dtResultado;
            cboxUsuarioNãoAtribuidos.ValueMember = "COD";
            cboxUsuarioNãoAtribuidos.DisplayMember = "NOME";
            cboxUsuarioNãoAtribuidos.SelectedItem = "Nenhum";
            cboxUsuarioNãoAtribuidos.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
        }
        private void FrmJuntarUserAFunc_Load(object sender, EventArgs e)
        {
            CarregaDataGridAtribuir();
            CarregaDataGridDesatribuir();
            CarregaComboBox();

            

            ////Carregar ComboBox de Usuarios Não Atribuidos
            //DataTable dtResultadoUserAtribuidos = ObjClnFuncRepository.ListarFuncComUser().Tables[0];
            //cboxUsuarioNãoAtribuidos.DataSource = null;
            //cboxUsuarioNãoAtribuidos.DataSource = dtResultado;
            //cboxUsuarioNãoAtribuidos.ValueMember = "COD";
            //cboxUsuarioNãoAtribuidos.DisplayMember = "NOME";
            //cboxUsuarioNãoAtribuidos.SelectedItem = "Nenhum";
            //cboxUsuarioNãoAtribuidos.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmGerenciamento ObjGer = new FrmGerenciamento();
            ObjGer.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            ObjGer.txtSenhaCookie.Text = txtSenhaCookie.Text;
            ObjGer.Show();
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaDataGridAtribuir();
        }

        private void btnAtribuir_Click(object sender, EventArgs e)
        {
            int msg; //Pergunta e aguarda resposta
            msg = Convert.ToInt32(MessageBox.Show("Deseja Atribuir o Usuario? " + Convert.ToString(dgv.CurrentRow.Cells[1].Value) + "Para Funcionario: " + cboxUsuarioNãoAtribuidos.Text, "A T R I B U I Ç Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information));//msg aguardando resposta

            //Exclusão física, será apagado do BD
            if (msg == 6) //6 representa Yes e 7 No
            {
                ClnFuncRepository objFunc = new ClnFuncRepository(); //Apagar da Agenda
                objFunc.AtribuirUserFunc(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value), Convert.ToInt32(cboxUsuarioNãoAtribuidos.SelectedValue)); //Por Código
                MessageBox.Show("Usuario atribuido com sucesso", "A T R I B U I Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("OPERAÇÃO CANCELADA", "A T R I B U I Ç Ã O CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregaDataGridAtribuir();
            CarregaDataGridDesatribuir();
            CarregaComboBox();
        }

        private void BtnPesquisaUserAtribuidos_Click(object sender, EventArgs e)
        {
            CarregaDataGridDesatribuir();
        }

        private void BtnDesatribuir_Click(object sender, EventArgs e)
        {
            int msg; //Pergunta e aguarda resposta
            msg = Convert.ToInt32(MessageBox.Show("Deseja Desatribuir o Usuario? " + Convert.ToString(dgvUserAtribuidos.CurrentRow.Cells[1].Value) , "D E S A T R I B U I Ç Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information));//msg aguardando resposta

            //Exclusão física, será apagado do BD
            if (msg == 6) //6 representa Yes e 7 No
            {
                ClnFuncRepository objFunc = new ClnFuncRepository(); //Apagar da Agenda
                objFunc.DesatribuirUserFunc(Convert.ToInt32(dgvUserAtribuidos.CurrentRow.Cells[2].Value)); //Por Código
                MessageBox.Show("Usuario desatribuido com sucesso", "D E S A T R I B U I Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("OPERAÇÃO CANCELADA", "D E S A T R I B U I Ç Ã O CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregaDataGridAtribuir();
            CarregaDataGridDesatribuir();
            CarregaComboBox();
        }
    }
}
