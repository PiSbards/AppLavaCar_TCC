using AppLavaCar.Controller;
using AppLavaCar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLavaCar
{
    public partial class FrmCliente : MetroFramework.Forms.MetroForm
    {        
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdiocionar_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }
    }
}

