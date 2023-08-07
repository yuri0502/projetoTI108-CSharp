﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PadariaCarmel
{
    public partial class frmSplash : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmSplash()
        {
            InitializeComponent();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            if (pgbCarregando.Value < 100)
            {
                pgbCarregando.Value = pgbCarregando.Value + 2;
                lblCarregando.Text = pgbCarregando.Value.ToString();

            }
            else
            {
                tmrSplash.Enabled = false;
                frmLogin abri = new frmLogin();
                abri.Show();
                this.Hide();
            }
            
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);

        }
    }
}
