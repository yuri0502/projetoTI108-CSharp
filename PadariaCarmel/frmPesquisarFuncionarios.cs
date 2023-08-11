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
            desativarCampos();
         
        }

        public void desativarCampos()
        {

            txtDescricao.Enabled = false;
            bntPesquisar.Enabled = false;
            btnLimpar.Enabled = false;


        }
        public void ativarCampos()
        {

            txtDescricao.Enabled = true;
            bntPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
            txtDescricao.Focus();

        }



        private void bntPesquisar_Click(object sender, EventArgs e)
        {
            if (rbdCodigo.Checked)
            {
                txtDescricao.Focus();
                lstPesquisar.Items.Clear();
                lstPesquisar.Items.Add(txtDescricao.Text);
        
            }
            if (rbdNome.Checked)
            {
                txtDescricao.Focus();
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

        private void rbdCodigo_CheckedChanged(object sender, EventArgs e)
        {

            ativarCampos();
        }

        private void rbdNome_CheckedChanged(object sender, EventArgs e)
        {
            ativarCampos();
        }

        private void lstPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
         string nome = lstPesquisar.SelectedItem.ToString();
            frmFuncionarios abrir = new frmFuncionarios(nome);
            abrir.Show();
            this.Hide();
        }
    }
}
