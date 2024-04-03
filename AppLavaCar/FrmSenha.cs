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
    public partial class FrmSenha : MetroFramework.Forms.MetroForm
    {
        public FrmSenha()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMudar_Click(object sender, EventArgs e)
        {
            UsuarioController controller = new UsuarioController();
            if (mtxtCpf.Text == "" || txtSenha1.Text == "" || txtSenha2.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtSenha1 == txtSenha2 )
            {
                string senha = txtSenha2.Text;                
                controller.AlterarSenha(senha, Convert.ToInt32(mtxtCpf.Text.Trim()));
                MessageBox.Show("A Senha foi alterada com Sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtxtCpf.Text = "";
                txtSenha1.Text = "";
                txtSenha2.Text = "";
                this.Hide();
            }
            else
            {
                MessageBox.Show("As senhas estão incorretas entre si!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha2.Text = "";
                txtSenha1.Text = "";
            }
        }
    }
}
