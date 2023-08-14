using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace PadariaCarmel
{
    public partial class frmFuncionarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmFuncionarios()
        {
            InitializeComponent();
        } public frmFuncionarios( string nome)
        {
            InitializeComponent();
            txtNome.Text = nome;
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
            desabilitarCampos();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        // Desabilitar campos

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEndereço.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtEmail.Enabled = false;

            makCEP.Enabled = false;
            makCPF.Enabled = false;
            makTelefone.Enabled = false;

            comEstado.Enabled = false;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        } public void habilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEndereço.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtEmail.Enabled = true;

            makCEP.Enabled = true;
            makCPF.Enabled = true;
            makTelefone.Enabled = true;

            comEstado.Enabled = true;

            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;

            txtNome.Focus();
        }public void limparCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Clear();
            txtEndereço.Clear();
            txtCidade.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtEmail.Clear();

            makCEP.Clear();
            makCPF.Clear();
            makTelefone.Clear();

            comEstado.Text = "";

            txtNome.Focus();
        }
        //cadastra funcionarios 



        private void btnCadastrar_Click(object sender, EventArgs e)
        {



            CadastraFuncionario();
            MessageBox.Show("Usuários cadastrado com sucesso!", " Menssagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            desabilitarCampos();
            btnNovo.Enabled = true;
            limparCampos();

        }

        public void CadastraFuncionario()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbFuncionarios(nome,email,telCel,cpf,endereco,numero,bairro,cidade,estado,cep)values(@nome,@email,@telCel,@cpf,@endereco,@numero,@bairro,@cidade,@estado,@cep);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome",MySqlDbType.VarChar,100).Value = txtNome.Text;
            comm.Parameters.Add("@email",MySqlDbType.VarChar,100).Value = txtEmail.Text;
            comm.Parameters.Add("@telCel",MySqlDbType.VarChar,15).Value = makTelefone.Text;
            comm.Parameters.Add("@cpf",MySqlDbType.VarChar,14).Value = makCPF.Text;
            comm.Parameters.Add("@endereco",MySqlDbType.VarChar,100).Value = txtEndereço.Text ;
            comm.Parameters.Add("@numero",MySqlDbType.VarChar,10).Value = txtNumero.Text;
            comm.Parameters.Add("@bairro",MySqlDbType.VarChar,100).Value = txtBairro.Text;
            comm.Parameters.Add("@cidade",MySqlDbType.VarChar,100).Value = txtCidade.Text;
            comm.Parameters.Add("@estado",MySqlDbType.VarChar,2).Value = comEstado.Text;
            comm.Parameters.Add("@cep",MySqlDbType.VarChar,9).Value = makCEP.Text;

            comm.Connection = Conectar.obterConexao();
            int res = comm.ExecuteNonQuery();
            Conectar.fecharConexao();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();

        }

        private void btnCarregaCEP_Click(object sender, EventArgs e)
        {
            buscarCEP(makCEP.Text);
            txtNumero.Focus();
    
        }

        public void buscarCEP(string numCEP)
        {
            WScorreio.AtendeClienteClient ws = new WScorreio.AtendeClienteClient();
            try
            {
                WScorreio.enderecoERP endereco = ws.consultaCEP(numCEP);
                txtEndereço.Text = endereco.end;
                txtBairro.Text = endereco.bairro;
                txtCidade.Text = endereco.cidade;
                comEstado.Text = endereco.uf;

            }
            catch (Exception)
            {
                MessageBox.Show("Fovaor inserir CEP válido!!","Menssagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                makCEP.Focus();
                makCEP.Text = "";
                
            }
            
        }

        private void makCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarCEP(makCEP.Text);
                txtNumero.Focus();

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarFuncionarios abri = new frmPesquisarFuncionarios();
            abri.Show();
            this.Hide();
        }

     
          
    }

}