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
using MetroFramework;

namespace AppLavaCar
{
    public partial class FrmFunc : MetroFramework.Forms.MetroForm
    {        
        public FrmFunc()
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
                UsuarioController user = new UsuarioController();
                Funcionario func = new Funcionario();                
                if (user.RegistroRepetido(txtNome.Text, Convert.ToInt32(mtxtCpf.Text.Trim())) == true)
                {
                    MessageBox.Show("Pessoa já existe em nossa base de dados!!", "Registro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtId.Text = "";
                    txtNome.Text = "";
                    mtxtCpf.Text = "";
                    txtSenha.Text = "";
                    txtEmail.Text = "";
                    chkbSim.Checked = false;
                    this.txtId.Focus();
                    return;
                }
                else
                {                    
                    bool gerente = false;
                    if (chkbSim.Checked == true)
                    {
                        gerente = true;
                    }
                    user.Inserir(txtNome.Text, Convert.ToInt32(mtxtCpf.Text.Trim()), txtSenha.Text,txtEmail.Text, gerente);
                    MessageBox.Show("Funcionário inserido com sucesso!", "Registro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<Funcionario> li = user.listaFuncionario();
                    dgvFunc.DataSource = li;
                    txtId.Text = "";
                    txtNome.Text = "";
                    mtxtCpf.Text = "";
                    txtSenha.Text = "";
                    txtEmail.Text = "";
                    chkbSim.Checked = false;
                    this.txtId.Focus();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmFunc_Load(object sender, EventArgs e)
        {
            try
            {
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                Funcionario func = new Funcionario();
                UsuarioController controller = new UsuarioController();
                List<Funcionario> li = controller.listaFuncionario();
                dgvFunc.DataSource = li;
            }
            catch (Exception er )
            {

                MessageBox.Show(er.Message,"erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || mtxtCpf.Text == "" || txtSenha.Text == "" || txtEmail.Text == "" )
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bool gerente = false;
                Funcionario func = new Funcionario();
                UsuarioController controller = new UsuarioController();
                if (chkbSim.Checked)
                {
                   gerente = true;
                }                               
                controller.Atualizar(Convert.ToInt32(txtId.Text.Trim()),txtNome.Text, Convert.ToInt32(mtxtCpf.Text.Trim()),txtSenha.Text,txtEmail.Text,gerente);
                MessageBox.Show("Cadastro de funcionário atualizado com sucesso!!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Funcionario> funcionario = controller.listaFuncionario();
                dgvFunc.DataSource = funcionario;
                txtId.Text = "";
                txtNome.Text = "";
                mtxtCpf.Text = "";
                txtSenha.Text = "";
                txtEmail.Text = "";
                chkbSim.Checked = false;
                this.txtNome.Focus();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                UsuarioController controller = new UsuarioController();
                var result = MessageBox.Show("Deseja realmente excluir este funcionário " +
                    "- Lembre-se que edição é melhor que exclusão, somente utilize da exclusão em último caso", "IMPORTANTE!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    controller.Excluir(id);
                }
                else
                {
                    return;
                }                
                MessageBox.Show("Funcionário excluído com sucesso!!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Funcionario> funcionarios = controller.listaFuncionario();
                dgvFunc.DataSource = funcionarios;
                txtId.Text = "";
                mtxtCpf.Text = "";
                txtNome.Text = "";
                txtSenha.Text = "";
                txtEmail.Text = "";
                chkbSim.Checked = false;
                this.txtId.Focus();
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
                int id = Convert.ToInt32(txtId.Text.Trim());

                UsuarioController controller = new UsuarioController();
                Funcionario func = controller.Localizar(id);
                mtxtCpf.Text = Convert.ToString(func.cpf);
                txtNome.Text = func.nome;
                txtSenha.Text = func.senha;
                txtEmail.Text = func.email;
                if (func.gerente == "SIM")
                {
                    chkbSim.Checked = true;
                }
                else
                {
                    chkbSim.Checked = false;
                }
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
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                mtxtCpf.Text = row.Cells[2].Value.ToString();
                txtSenha.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
                if (row.Cells[5].Value.ToString() == "SIM")
                {
                    chkbSim.Checked = true;
                }

            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }
    }
}

