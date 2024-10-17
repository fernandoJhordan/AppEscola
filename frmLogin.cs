using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscola
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Digite o usuário...");
                return;
            }

            if (txtSenha.Text != "123")
            {
                MessageBox.Show("Senha incorreta...");
                return;
            }

            //a variavel que está em Program recebe o nome do usuário
            Program.usuario = txtUsuario.Text;

            //instancia o form para conseguir abri-lo
            frmPrincipal frm = new frmPrincipal();
            frm.ShowDialog();

            //fecha o form atual
            this.Close();

        }
    }
}
