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
    public partial class frmPesquisarFuncionarios : Form
    {
        public frmPesquisarFuncionarios()
        {
            InitializeComponent();
        }

        private void bntPesquisar_Click(object sender, EventArgs e)
        {
            if (rbdCodigo.Checked)
            {
                lstPesquisar.Items.Clear();
                lstPesquisar.Items.Add(txtDescricao.Text);
            }
            if (rbdNome.Checked)
            {
                lstPesquisar.Items.Clear();
                lstPesquisar.Items.Add(txtDescricao.Text);
            }
            
        }

        public void limparCampos()
        {
            rbdCodigo.Checked = false;
            rbdNome.Checked = false;
            lstPesquisar.Items.Clear();
            txtDescricao.Focus();
           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
