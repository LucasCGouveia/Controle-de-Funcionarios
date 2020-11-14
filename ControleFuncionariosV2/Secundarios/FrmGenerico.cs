using ControleFuncionarios.Repository;
using ControleFuncionarios.Repository.BancoDados;
using ControleFuncionariosV2.Cadastro;
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
    public partial class FrmGenerico : Form
    {
        public FrmGenerico()
        {
            InitializeComponent();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            ClnUsuarioRepository ObjUser = new ClnUsuarioRepository();
            IDataReader drDadosListarUserAdmin;
            string TipoLogin = "A";
            drDadosListarUserAdmin = ObjUser.ListarUserAdmin(txtDois.Text, txtUm.Text, TipoLogin);

            if (lblFuncao.Text == "Excluir Usuario")
            {
                if (drDadosListarUserAdmin.Read())
                {
                    int msg; //Pergunta e aguarda resposta
                    msg = Convert.ToInt32(MessageBox.Show("Deseja excluir o registro? " + Convert.ToString(txtCinco.Text), "E X C L U S Ã O", MessageBoxButtons.YesNo, MessageBoxIcon.Information));//msg aguardando resposta

                    //Exclusão física, será apagado do BD
                    if (msg == 6) //6 representa Yes e 7 No
                    {
                        ObjUser.Excluir(Convert.ToInt32(lblCinco.Text)); //Por Código
                        MessageBox.Show("Registro excluído com sucesso", "E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmCadUsuario ObjCadUsuario = new FrmCadUsuario();
                        ObjCadUsuario.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("OPERAÇÃO CANCELADA", "CANCELAMENTO E X C L U S Ã O", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmCadUsuario ObjCadUsuario = new FrmCadUsuario();
                        ObjCadUsuario.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario administrador ou senhas incorretas", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (lblFuncao.Text == "Editar Usuario")
            {
                FrmCadUsuario ObjCadUsuario = new FrmCadUsuario();
                ObjCadUsuario.Text = ">>> Alterar <<<";
                ObjCadUsuario.txtSenha.Visible = false;
                ObjCadUsuario.lblSenha.Text = "Necessario Logar para alterar a senha";
                ObjCadUsuario.LblPesquisar.Text = "Atenção voce esta alterando o Usuario:";
                ObjCadUsuario.txtPesquisa.Enabled = false;
                ObjCadUsuario.txtPesquisa.Text = Convert.ToString(txtCinco.Text); //Envia para o campo código o valor do código marcado
                ObjCadUsuario.btnEditar.Visible = false;
                ObjCadUsuario.btnExcluir.Visible = false;
                ObjCadUsuario.btnGravar.Text = "&Alterar";
                ObjCadUsuario.TxtCod.Text = Convert.ToString(lblCinco.Text); //Envia para o campo código o valor do código marcado
                ObjCadUsuario.txtUsuario.Focus();
                ObjCadUsuario.EnumProperty = ClnFuncoesGerais.Operacao.Alteracao; //Informa que é Alteração
                ObjCadUsuario.ShowDialog();
                this.Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (lblFuncao.Text == "Excluir Usuario")
            {
                FrmCadUsuario ObjCadUsuario = new FrmCadUsuario();
                ObjCadUsuario.Show();
                this.Close();
            }

        }

        private void Btn1_Click(object sender, EventArgs e)
        {

        }

        private void txtCinco_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblCinco_Click(object sender, EventArgs e)
        {

        }

        private void txtQuatro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUm_Click(object sender, EventArgs e)
        {

        }

        private void lblDois_Click(object sender, EventArgs e)
        {

        }

        private void lblTres_Click(object sender, EventArgs e)
        {

        }

        private void txtUm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDois_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTres_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuatro_Click(object sender, EventArgs e)
        {

        }

        private void lblFuncao_Click(object sender, EventArgs e)
        {

        }
    }
}
