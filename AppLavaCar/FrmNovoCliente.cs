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
    public partial class FrmNovoCliente : MetroFramework.Forms.MetroForm
    {
        public FrmNovoCliente()
        {
            InitializeComponent();
        }

        private void chbxCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxCNPJ.Checked == false)
            {
                lblCPF.Text = "CPF";
                mtxtCPF.Mask = "999,999,999-00";
            }
            else if (chbxCNPJ.Checked == true)
            {
                lblCPF.Text = "CNPJ";
                mtxtCPF.Mask = "999,999,999 /9999-99";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ClienteController controller = new ClienteController();
            VerificacaoCpfCnpj ve = new VerificacaoCpfCnpj();
            if (chbxCNPJ.Checked == true)
            {
                if (txtNome.Text == "" || mtxtCPF.Text == "" || mtxtTelefone.Text == "")
                {
                    MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNome.Text = "";
                    mtxtCPF.Text = "";
                    mtxtTelefone.Text = "";                    
                    this.mtxtCPF.Focus();
                    return;
                }
                bool result = ve.IsCnpj(mtxtCPF.Text.Trim());
                if (result == false)
                {
                    MessageBox.Show("CNPJ inválido, por favor reescreva!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNome.Text = "";
                    mtxtCPF.Text = "";
                    mtxtTelefone.Text = "";
                    this.mtxtCPF.Focus();
                    return;                    
                }
                else
                {
                    if (controller.RegistroRepetido(mtxtCPF.Text.Trim()) == true)
                    {
                        MessageBox.Show("Cliente já existe em nossa base de dados! - Verifique o Nome,CNPJ e Telefone",
                                "Registro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Text = "";
                        mtxtCPF.Text = "";
                        mtxtTelefone.Text = "";
                        this.mtxtCPF.Focus();
                        return;
                    }
                    else
                    {
                        controller.Inserir(txtNome.Text.Trim(), mtxtCPF.Text.Trim(), mtxtTelefone.Text.Trim());
                        MessageBox.Show("Cliente cadastrado com sucesso!","Registro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Text = "";
                        mtxtCPF.Text = "";
                        mtxtTelefone.Text = "";
                        this.mtxtCPF.Focus();
                        return;
                    }
                }
            }
            else
            {
                if (txtNome.Text == "" || mtxtCPF.Text == "" || mtxtTelefone.Text == "")
                {
                    MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNome.Text = "";
                    mtxtCPF.Text = "";
                    mtxtTelefone.Text = "";
                    this.mtxtCPF.Focus();
                    return;
                }
                bool result = ve.IsCpf(mtxtCPF.Text.Trim());
                if (result == false)
                {
                    MessageBox.Show("CPF inválido, por favor reescreva!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNome.Text = "";
                    mtxtCPF.Text = "";
                    mtxtTelefone.Text = "";
                    this.mtxtCPF.Focus();
                    return;
                }
                else
                {
                    if (controller.RegistroRepetido(mtxtCPF.Text.Trim()) == true)
                    {
                        MessageBox.Show("Cliente já existe em nossa base de dados! - Verifique o Nome,CPF e Telefone",
                                "Registro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Text = "";
                        mtxtCPF.Text = "";
                        mtxtTelefone.Text = "";
                        this.mtxtCPF.Focus();
                        return;
                    }
                    else
                    {
                        controller.Inserir(txtNome.Text.Trim(), mtxtCPF.Text.Trim(), mtxtTelefone.Text.Trim());
                        MessageBox.Show("Cliente cadastrado com sucesso!", "Registro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Text = "";
                        mtxtCPF.Text = "";
                        mtxtTelefone.Text = "";
                        this.mtxtCPF.Focus();
                        return;
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
