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
    public partial class frmCalculas : Form
    {
        public frmCalculas()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Text = "";
            lblResultado.Text = "";
            lblResposta.Text = "";
            radSoma.Checked = false;
            radSubitracao.Checked = false;
            radMultiplicacao.Checked = false;
            radDivisao.Checked = false;

            txtNum1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, resp = 0;
                num1 = Convert.ToDouble(txtNum1.Text);
                num2 = Convert.ToDouble(txtNum2.Text);
            try
            {
                if (radSoma.Checked)
                {
                    resp = num1 + num2;

                    lblResposta.Text = resp.ToString();

                }
                if (radSubitracao.Checked)
                {
                    resp = num1 - num2;

                }
                if (radMultiplicacao.Checked)
                {
                    resp = num1 * num2;
                }
                if (radDivisao.Checked)
                {
                    resp = num1 / num2;

                    if (num2 == 0)
                    {
                        MessageBox.Show("Impossível dividir por 0");
                        txtNum1.Text = "";
                        txtNum2.Text = "";
                        lblResposta.Text = "";
                        radDivisao.Checked = false;
                        txtNum1.Focus();
                    }
                    else
                    {
                        resp = num1 / num2;
                    }
                }
                if (radDivisao.Checked || radMultiplicacao.Checked || radSoma.Checked || radSubitracao.Checked)
                {
                    lblResposta.Text = resp.ToString();
                }
                else
                {
                    MessageBox.Show("Selecione uma operação",
                        "Mensagem do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                }

            }

            catch (Exception)
            {
                MessageBox.Show("Colocar somente Númerros!!");
                txtNum1.Text = "";
                txtNum2.Text = "";
                txtNum1.Focus();

            }
        }
    }
}
