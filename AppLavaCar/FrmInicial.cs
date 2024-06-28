using AppLavaCar.Controller;
using AppLavaCar.Model;
using MetroFramework;
using MySqlConnector;
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
        private Cripto b;
        public FrmInicial()
        {
            InitializeComponent();
            b = new Cripto();
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            VerificacaoCpfCnpj ve = new VerificacaoCpfCnpj();
            UsuarioController controller = new UsuarioController();
            bool cpf = ve.IsCpf(mtxtCPF.Text);
            if (cpf == true)
            {
                string senha = b.Base64Encode(txtSenha.Text);
                Funcionario func = controller.Login(mtxtCPF.Text.Trim());
                if (func.cpf.Trim() == mtxtCPF.Text.Trim() && func.senha.Trim() == senha)
                {
                    if (func.gerente == "SIM")
                    {
                        bool gerente = true;
                        string chefe = "sim";
                        FrmPrincipal principalGerente = new FrmPrincipal(gerente, chefe);
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
                MessageBox.Show("CPF inválido, por favor reescreva!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtCPF.Text = "";
                txtSenha.Text = "";
            }

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

        private void FrmInicial_Load(object sender, EventArgs e)
        {
            this.ActiveControl = mtxtCPF;
        }
    }
}
