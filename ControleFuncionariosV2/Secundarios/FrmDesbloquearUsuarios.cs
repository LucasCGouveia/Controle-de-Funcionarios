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
    public partial class FrmDesbloquearUsuarios : Form
    {
        public FrmDesbloquearUsuarios()
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
            ClnUsuarioRepository ObjUsuario = new ClnUsuarioRepository();//Criar Obj
            dgv.DataSource = ObjUsuario.ListarUsuariosDesativados(txtPesquisa.Text).Tables[0]; //Método Listar que passa o parâmetro do texto digitado para o Grid
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

        private void btnAtribuir_Click(object sender, EventArgs e)
        {
            int msg; //Pergunta e aguarda resposta
            msg = Convert.ToInt32(MessageBox.Show("Deseja Ativar o Usuario? " + Convert.ToString(dgv.CurrentRow.Cells[1].Value), "Ativar usuario Desabilitado", MessageBoxButtons.YesNo, MessageBoxIcon.Information));//msg aguardando resposta

            //Exclusão física, será apagado do BD
            if (msg == 6) //6 representa Yes e 7 No
            {
                ClnUsuarioRepository objFunc = new ClnUsuarioRepository(); //Apagar da Agenda
                objFunc.AtivarUsuario(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value)); //Por Código
                MessageBox.Show("Usuario atribuido com sucesso", "A T R I B U I Ç Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("OPERAÇÃO CANCELADA", "A T R I B U I Ç Ã O CANCELADA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CarregaDataGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmGerenciamento ObjGer = new FrmGerenciamento();
            ObjGer.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            ObjGer.txtSenhaCookie.Text = txtSenhaCookie.Text;
            ObjGer.Show();
            Close();
        }

        private void FrmDesbloquearUsuarios_Load(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }
    }
}
