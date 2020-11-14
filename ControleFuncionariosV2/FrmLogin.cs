using ControleFuncionarios.Repository;
using ControleFuncionariosV2.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;



namespace ControleFuncionariosV2
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void LlblCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.Visible = false;
                FrmCadUsuario ObjFrmCadUsuario_FrmLogin = new FrmCadUsuario();
                ObjFrmCadUsuario_FrmLogin.Show();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja Realmente Fechar o Sistema???", "Fechar...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string str = txtUsuario.Text;
            string test = str.Replace("'", "'");

            if (txtUsuario.Text != test)
            {
                MessageBox.Show("Nome de Usuario ou senhas Incorretas.", "Problema ao Logar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Text = "";
                txtUsuario.Focus();
            }
            else
            {
                ClnUsuarioRepository ObjUser = new ClnUsuarioRepository();
                //Aqui Listo se o usuario é ativo = 0
                IDataReader drDadosListarUsuarioBloqueado;
                drDadosListarUsuarioBloqueado = ObjUser.ListarUsuarioBloqueado(txtUsuario.Text, txtSenha.Text);
                //Aqui listo usuario comum
                IDataReader drDadosListarUsuario;
                drDadosListarUsuario = ObjUser.ListarUsuario(txtUsuario.Text, txtSenha.Text);
                //Aqui listo se usuario é Administrador
                string TipoUser = "A";
                IDataReader drDadosListarUserAdmin;
                drDadosListarUserAdmin = ObjUser.ListarUserAdmin(txtUsuario.Text, txtSenha.Text, TipoUser) ;
                
                if (drDadosListarUsuarioBloqueado.Read())
                {
                    MessageBox.Show("Usuario esta desabilitado, informe seu supervisor.", "Problema ao Logar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha.Text = "";
                    txtUsuario.Focus();
                }
                else
                {
                    if (drDadosListarUserAdmin.Read())
                    {
                        this.Visible = false;
                        FrmMenuPrincipal ObjMenu = new FrmMenuPrincipal();
                        ObjMenu.txtUsuarioCookie.Text = txtUsuario.Text;
                        ObjMenu.txtSenhaCookie.Text = txtSenha.Text;
                        ObjMenu.Show();
                    }
                    else if (drDadosListarUsuario.Read())
                    {
                        this.Visible = false;
                        FrmMenuPrincipal ObjMenu = new FrmMenuPrincipal();
                        ObjMenu.BtnGerencia.Visible = false;
                        ObjMenu.txtUsuarioCookie.Text = txtUsuario.Text;
                        ObjMenu.txtSenhaCookie.Text = txtSenha.Text;
                        ObjMenu.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Nome de Usuario ou senhas Incorretas.", "Problema ao Logar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSenha.Text = "";
                        txtUsuario.Focus();
                    }
                }

            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
