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
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        private bool Hidden;
        public FrmPrincipal()
        {
            InitializeComponent();            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (Hidden == true)
            {
                
                MenuConteudo.Width = 200;
                
                Hidden = false;
            }
            else
            {                
                MenuConteudo.Width = 0;                
                Hidden = true;
            }
        }

        private void btnHome1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnFunc1_Click(object sender, EventArgs e)
        {
            FrmFunc func = new FrmFunc();
            func.Show();
        }

        private void btnAgenda1_Click(object sender, EventArgs e)
        {
            FrmAgenda agenda = new FrmAgenda();
            agenda.Show();
        }

        private void btnCliente1_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
            
        }

        private void btnSair2_Click(object sender, EventArgs e)
        {
            FrmInicial inicial = new FrmInicial();
            var resposta = MessageBox.Show("Deseja realmente sair?","SAIR",MessageBoxButtons.OKCancel);
            if(resposta == DialogResult.OK)
            {
                inicial.Show();
                this.Hide();
            }
            else
            {
                return;
            }
            
        }

        private void btnHome2_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnFunc2_Click(object sender, EventArgs e)
        {
            FrmFunc func = new FrmFunc();
            func.Show();
            
        }

        private void btnAgenda2_Click(object sender, EventArgs e)
        {
            FrmAgenda agenda = new FrmAgenda();
            agenda.Show();
            
        }

        private void btnCliente2_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
            
        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            FrmInicial inicial = new FrmInicial();
            var resposta = MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.OKCancel);
            if (resposta == DialogResult.OK)
            {
                inicial.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Hidden = true;
            MenuConteudo.Width = 0;
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            FrmCheckin check = new FrmCheckin();
            check.Show();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmCheckin check = new FrmCheckin();
            check.Show();
        }
    }
}
