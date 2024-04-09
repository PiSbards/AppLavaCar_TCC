using AppLavaCar.Controller;
using AppLavaCar.Model;
using MetroFramework;
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
            bool gerente = true;
            string chefe = "sim";
            FrmPrincipal principal = new FrmPrincipal(gerente,chefe);
            principal.Show();
            this.Hide();
            /*VerificacaoCpfCnpj ve = new VerificacaoCpfCnpj();
            UsuarioController controller = new UsuarioController();
            bool cpf = ve.ValidarCPF(txtUsuario.Text);
            if (cpf == true)
            {
                Funcionario func = controller.Login(Convert.ToInt32(txtUsuario.Text.Trim()));
                if (func.cpf == Convert.ToInt32(txtUsuario.Text.Trim()) && func.senha == txtSenha.Text)
                {
                    if (func.gerente == "SIM")
                    {
                        bool gerente = true;
                        string chefe = sim;
                        FrmPrincipal principalGerente = new FrmPrincipal(gerente,chefe);
                        principalGerente.Show();
                        this.Hide();
                    }
                    else
                    {
                        FrmPrincipal principal = new FrmPrincipal();
                        principal.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Informações incorretas, senha ou usuário equivocados!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("CPF inválido, por favor reescreva!","ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtSenha.Text = "";
            }*/
            
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }       

        private void llblSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSenha senha = new FrmSenha();
            senha.Show();
        }
    }
}
