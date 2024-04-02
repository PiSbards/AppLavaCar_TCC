using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLavaCar
{
    public partial class FrmInicial : MetroFramework.Forms.MetroForm
    {
        public FrmInicial()
        {
            InitializeComponent();
            
        }       

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblSenha_Click(object sender, EventArgs e)
        {
            
        }
    }
}
