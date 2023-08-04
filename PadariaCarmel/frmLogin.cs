using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaCarmel
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttEntra_Click(object sender, EventArgs e)
        {

            if (txtUsuário.Text.Equals("senac") && txtSenha.Text.Equals("senac"))
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparTela();
            }
        }


        public void limparTela()
        {
            txtUsuário.Clear();
            txtSenha.Clear();
            txtUsuário.Focus();
        }

        private void txtUsuário_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                txtSenha.Focus();
     
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttEntra.Focus();
            }
        }
    }

 
}
