using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFuncionariosV2.Principais
{
    public partial class FrmTrocaSenha : Form
    {
        public FrmTrocaSenha()
        {
            InitializeComponent();
        }

        private void FrmTrocaSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal ObjFMP = new FrmMenuPrincipal();
            ObjFMP.txtUsuarioCookie.Text = txtUsuarioCookie.Text;
            ObjFMP.txtSenhaCookie.Text = txtSenhaCookie.Text;
            ObjFMP.Show();
            this.Close();
        }
    }
}
