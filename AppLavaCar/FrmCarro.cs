using AppLavaCar.Controller;
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
    public partial class FrmCarro : MetroFramework.Forms.MetroForm
    {
        public FrmCarro()
        {
            InitializeComponent();
        }
        public FrmCarro(string cpf, string nome)
        {
            InitializeComponent();
            if (cpf.Length > 14)
            {
                chbxCNPJ.Checked = true;                
            }
            mtxtCPF.Text = cpf;
            txtNomeDono.Text = nome;
        }

        private void chbxCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxCNPJ.Checked == false)
            {
                lblCPF.Text = "CPF";
                mtxtCPF.Mask = "999.999.999-00";
            }
            else if (chbxCNPJ.Checked == true)
            {
                lblCPF.Text = "CNPJ";
                mtxtCPF.Mask = "99.999.999 /9999-99";
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text == "" || txtNomeDono.Text == "" || mtxtCPF.Text == "" || txtMarca.Text == "" || txtModelo.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            CarroController car = new CarroController();
            car.Inserir(txtPlaca.Text,txtNomeDono.Text,mtxtCPF.Text,txtMarca.Text,txtModelo.Text);
            MessageBox.Show("Carro inserido com sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
