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
            try
            {
                ClienteController cliente = new ClienteController();
                Cliente cli = new Cliente();
                if (cliente.RegistroRepetido(txtNome.Text, Convert.ToInt32(mtxtCpf.Text.Trim())) == true)
                {
                    MessageBox.Show("Cliente já existe em nossa base de dados!!", "Registro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                    txtNome.Text = "";
                    mtxtCpf.Text = "";
                    txtTelefone.Text = "";
                    txtModelo.Text = "";
                    txtMarca.Text = "";
                    txtPlaca.Text = "";
                    this.txtNome.Focus();
                    return;
                }
                else
                {                    
                    cliente.Inserir(txtNome.Text, Convert.ToInt32(mtxtCpf.Text.Trim()), txtTelefone.Text,txtModelo.Text,txtMarca.Text,txtPlaca.Text);
                    MessageBox.Show("Cliente inserido com sucesso!", "Registro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Cliente> li = cliente.listaCliente();
                    dgvFunc.DataSource = li;
                    txtNome.Text = "";
                    mtxtCpf.Text = "";
                    txtTelefone.Text = "";
                    txtModelo.Text = "";
                    txtMarca.Text = "";
                    txtPlaca.Text = "";
                    this.txtNome.Focus();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            try
            {
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                Cliente cliente = new Cliente();
                ClienteController controller = new ClienteController();
                List<Cliente> li = controller.listaCliente();
                dgvFunc.DataSource = li;
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || mtxtCpf.Text == "" || txtTelefone.Text == "" || txtModelo.Text == "" || txtMarca.Text == "" || txtPlaca.Text =="")
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {                
                Cliente cliente = new Cliente();
                ClienteController controller = new ClienteController();                
                controller.Atualizar(Convert.ToInt32(lblId.Text.Trim()), txtNome.Text, Convert.ToInt32(mtxtCpf.Text.Trim()), txtTelefone.Text, txtModelo.Text, txtMarca.Text, txtPlaca.Text);
                MessageBox.Show("Cadastro de Cliente atualizado com sucesso!!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Cliente> li = controller.listaCliente();
                dgvFunc.DataSource = li;
                lblId.Text = "";
                txtNome.Text = "";
                mtxtCpf.Text = "";
                txtTelefone.Text = "";
                txtModelo.Text = "";
                txtMarca.Text = "";
                txtPlaca.Text = "";
                this.txtNome.Focus();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || mtxtCpf.Text == "" || txtTelefone.Text == "" || txtModelo.Text == "" || txtMarca.Text == "" || txtPlaca.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int id = Convert.ToInt32(lblId.Text.Trim());
                ClienteController controller = new ClienteController();
                var result = MessageBox.Show("Deseja realmente excluir este Cliente " +
                    "- Lembre-se que edição é melhor que exclusão, somente utilize da exclusão em último caso", "IMPORTANTE!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    controller.Excluir(id);
                }
                else
                {
                    return;
                }
                MessageBox.Show("Cliente excluído com sucesso!!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                List<Cliente> li = controller.listaCliente();
                dgvFunc.DataSource = li;
                lblId.Text = "";
                txtNome.Text = "";
                mtxtCpf.Text = "";
                txtTelefone.Text = "";
                txtModelo.Text = "";
                txtMarca.Text = "";
                txtPlaca.Text = "";
                this.txtNome.Focus();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            try
            {
                int cpf = Convert.ToInt32(mtxtCpf.Text.Trim());

                ClienteController controller = new ClienteController();
                Cliente cliente = controller.Localizar(cpf);                
                txtNome.Text = cliente.nome;
                txtTelefone.Text = cliente.telefone;
                txtModelo.Text = cliente.modelo;
                txtMarca.Text = cliente.marca;
                txtPlaca.Text = cliente.placaCarro;                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFunc.Rows[e.RowIndex];
                this.dgvFunc.Rows[e.RowIndex].Selected = true;
                if (row.Cells[2].Value.ToString().Length == 11)
                {
                    chbxCNPJ.Checked = false;
                }
                else
                {
                    chbxCNPJ.Checked = true;
                }
                lblId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                mtxtCpf.Text = row.Cells[2].Value.ToString();
                txtTelefone.Text = row.Cells[3].Value.ToString();
                txtPlaca.Text = row.Cells[4].Value.ToString();
                txtMarca.Text = row.Cells[5].Value.ToString();
                txtModelo.Text = row.Cells[6].Value.ToString();

            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void chbxCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxCNPJ.Checked == false)
            {
                lblCpf.Text = "CPF";
                mtxtCpf.Mask = "999.999.999-00";
            }
            else if (chbxCNPJ.Checked == true)
            {
                lblCpf.Text = "CNPJ";
                mtxtCpf.Mask = "99.999.999 /9999-99";
            }
        }
    }
}

