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
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnEditarCarro.Enabled = false;
            btnExcluirCarro.Enabled = false;            
            Carro carro = new Carro();
            CarroController carroController = new CarroController();
            List<Carro> car = carroController.listaCarro();
            Cliente cliente = new Cliente();
            ClienteController controller = new ClienteController();
            List<Cliente> li = controller.listaCliente();
            dgvCliente.DataSource = li;
            dgvCarro.DataSource = car;

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
                VerificacaoCpfCnpj ve = new VerificacaoCpfCnpj();
                if (chbxCNPJ.Checked == true)
                {
                    var result = ve.IsCnpj(mtxtCpf.Text);
                    if (result == true)
                    {
                        if (controller.RegistroRepetido(mtxtCpf.Text) == true)
                        {
                            MessageBox.Show("Este CNPJ já esta em uso, por favor corrija", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            controller.Atualizar(Convert.ToInt32(lblIdCliente.Text.Trim()), txtNome.Text, mtxtCpf.Text.Trim(), txtTelefone.Text);
                            MessageBox.Show("Cadastro de Cliente atualizado com sucesso!!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            List<Cliente> li = controller.listaCliente();
                            dgvCliente.DataSource = li;
                            lblIdCliente.Text = "";
                            txtNome.Text = "";
                            mtxtCpf.Text = "";
                            txtTelefone.Text = "";
                            this.txtNome.Focus();
                        }
                    }                    
                }
                else
                {
                    var result = ve.IsCpf(mtxtCpf.Text);
                    if (result == true)
                    {
                        if (controller.RegistroRepetido(mtxtCpf.Text) == true)
                        {
                            MessageBox.Show("Este CPF já esta em uso, por favor corrija", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            controller.Atualizar(Convert.ToInt32(lblIdCliente.Text.Trim()), txtNome.Text, mtxtCpf.Text.Trim(), txtTelefone.Text);
                            MessageBox.Show("Cadastro de Cliente atualizado com sucesso!!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            List<Cliente> li = controller.listaCliente();
                            dgvCliente.DataSource = li;
                            lblIdCliente.Text = "";
                            txtNome.Text = "";
                            mtxtCpf.Text = "";
                            txtTelefone.Text = "";
                            this.txtNome.Focus();
                        }
                    }
                }
                        
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
                int id = Convert.ToInt32(lblIdCliente.Text.Trim());
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
                dgvCliente.DataSource = li;
                lblIdCliente.Text = "";
                txtNome.Text = "";
                mtxtCpf.Text = "";
                txtTelefone.Text = "";                
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
                ClienteController controller = new ClienteController();
                Cliente cliente = controller.Localizar(mtxtCpf.Text.Trim());                 
                txtNome.Text = cliente.nome;
                txtTelefone.Text = cliente.telefone;                                
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
                DataGridViewRow row = this.dgvCliente.Rows[e.RowIndex];
                this.dgvCliente.Rows[e.RowIndex].Selected = true;
                if (row.Cells[2].Value.ToString().Trim().Length == 14)
                {
                    chbxCNPJ.Checked = false;
                }
                else
                {
                    chbxCNPJ.Checked = true;
                }
                lblIdCliente.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                mtxtCpf.Text = row.Cells[2].Value.ToString();
                txtTelefone.Text = row.Cells[3].Value.ToString();
            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void chbxCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxCNPJ.Checked == false)
            {
                lblCpf.Text = "CPF";
                mtxtCpf.Mask = "999,999,999-00";
            }
            else if (chbxCNPJ.Checked == true)
            {
                lblCpf.Text = "CNPJ";
                mtxtCpf.Mask = "99,999,999/9999-99";
            }
        }

        private void chbxCnpjCarro_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxCnpjCarro.Checked == false)
            {
                lblCpfCarro.Text = "CPF";
                mktCpfDono.Mask = "999,999,999-00";
            }
            else if (chbxCnpjCarro.Checked == true)
            {
                lblCpfCarro.Text = "CNPJ";
                mktCpfDono.Mask = "99,999,999/9999-99";
            }
        }

        private void btnEditarCarro_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text == "" || txtMarca.Text == "" || txtPlaca.Text == "" || txtNomeDono.Text == "" ||mktCpfDono.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Carro carro = new Carro();
                CarroController controller = new CarroController();                
                if (controller.RegistroRepetido(txtPlaca.Text) == true)
                {                    
                    MessageBox.Show("Este carro já esta em uso,a placa já consta cadastrada.\n Por favor corrija", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    controller.Atualizar(Convert.ToInt32(lblIdCarro.Text), txtPlaca.Text, txtNomeDono.Text, mktCpfDono.Text, txtMarca.Text, txtModelo.Text);
                    MessageBox.Show("Cadastro de Carro atualizado com sucesso!!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Carro> li = controller.listaCarro();
                    dgvCarro.DataSource = li;
                    lblIdCarro.Text = "";
                    txtPlaca.Text = "";
                    txtNomeDono.Text = "";
                    mktCpfDono.Text = "";
                    txtMarca.Text = "";
                    txtModelo.Text = "";
                    this.txtPlaca.Focus();
                }
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirCarro_Click(object sender, EventArgs e)
        {
            if (txtModelo.Text == "" || txtMarca.Text == "" || txtPlaca.Text == "" || txtNomeDono.Text == "" || mktCpfDono.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int id = Convert.ToInt32(lblIdCarro.Text.Trim());
                CarroController controller = new CarroController();
                var result = MessageBox.Show("Deseja realmente excluir este Carro " +
                    "- Lembre-se que edição é melhor que exclusão, somente utilize da exclusão em último caso", "IMPORTANTE!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    controller.Excluir(id);
                }
                else
                {
                    return;
                }
                MessageBox.Show("Carro excluído com sucesso!!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Carro> li = controller.listaCarro();
                dgvCarro.DataSource = li;
                lblIdCarro.Text = "";
                txtPlaca.Text = "";
                txtNomeDono.Text = "";
                mktCpfDono.Text = "";
                txtMarca.Text = "";
                txtModelo.Text = "";
                this.txtPlaca.Focus();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalizarCarro_Click(object sender, EventArgs e)
        {
            btnEditarCarro.Enabled = true;
            btnExcluirCarro.Enabled = true;
            try
            {
                CarroController controller = new CarroController();
                Carro carro = controller.LocalizarPelaPlaca(txtPlaca.Text);
                txtNomeDono.Text = carro.nomeDono;
                if (carro.cpfDono.Trim().Length == 14)
                {
                    chbxCNPJ.Checked = false;
                }
                else
                {
                    chbxCNPJ.Checked = true;
                }
                mktCpfDono.Text = carro.cpfDono;
                txtMarca.Text = carro.marca;
                txtModelo.Text = carro.modelo;

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCarro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCarro.Rows[e.RowIndex];
                this.dgvCarro.Rows[e.RowIndex].Selected = true;
                if (row.Cells[3].Value.ToString().Trim().Length == 14)
                {
                    chbxCnpjCarro.Checked = false;
                }
                else
                {
                    chbxCnpjCarro.Checked = true;
                }
                lblIdCarro.Text = row.Cells[0].Value.ToString();
                txtPlaca.Text = row.Cells[1].Value.ToString();
                txtNomeDono.Text = row.Cells[2].Value.ToString();
                mktCpfDono.Text = row.Cells[3].Value.ToString();
                txtMarca.Text = row.Cells[4].Value.ToString();
                txtModelo.Text = row.Cells[5].Value.ToString();                
            }
            btnEditarCarro.Enabled = true;
            btnExcluirCarro.Enabled = true;
        }
    }
}

