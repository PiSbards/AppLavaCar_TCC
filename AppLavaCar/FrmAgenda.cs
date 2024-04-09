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
    public partial class FrmAgenda : MetroFramework.Forms.MetroForm
    {        
        public FrmAgenda()
        {
            InitializeComponent();
            btnAlterar.Enabled = false;
        }
        public FrmAgenda(bool gerente)
        {
            InitializeComponent();           
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {            
            lblData.Text = Calendario.SelectionRange.Start.ToShortDateString();
        }       

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            ControllerGeral geral = new ControllerGeral();
            Agenda agenda = new Agenda();
            List<Agenda> li = geral.listaAgendaDia();
            dgvAgenda.DataSource = li;
            btnAlterar.Enabled = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            mtxtCPF.Text = "";
            mtxtTelefone.Text = "";
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtPlaca.Text = "";
            lblData.Text = "";
            cbxTipo.Text = "";
            cboHoraAgenda.Text = "00:00";
            this.txtNome.Focus();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteController controller = new ClienteController();
                Cliente cliente = new Cliente();
                VerificacaoCpfCnpj ve = new VerificacaoCpfCnpj();
                if (chbxCNPJ.Checked == true)
                {
                    var result = ve.ValidarCNPJ(mtxtCPF.Text);
                    if (result == false)
                    {
                        MessageBox.Show("CNPJ inválido, por favor reescreva!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNome.Text = "";
                        mtxtCPF.Text = "";
                        mtxtTelefone.Text = "";
                        txtModelo.Text = "";
                        txtMarca.Text = "";
                        txtPlaca.Text = "";
                        lblData.Text = "";
                        cbxTipo.Text = "";
                        cboHoraAgenda.Text = "00:00";
                        this.txtNome.Focus();
                        return;
                    }
                    else
                    {
                        if (controller.RegistroRepetido(txtNome.Text, Convert.ToInt32(mtxtCPF.Text.Trim()), txtPlaca.Text) == true)
                        {
                            MessageBox.Show("Cliente já existe em nossa base de dados! - Verifique o Nome,CNPJ e Placa do Carro",
                                "Registro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNome.Text = "";
                            mtxtCPF.Text = "";
                            mtxtTelefone.Text = "";
                            txtModelo.Text = "";
                            txtMarca.Text = "";
                            txtPlaca.Text = "";
                            lblData.Text = "";
                            cbxTipo.Text = "";
                            cboHoraAgenda.Text = "00:00";
                            this.txtNome.Focus();
                            return;
                        }
                        else
                        {
                            DateTime dataHorario = Convert.ToDateTime(lblData.Text + cboHoraAgenda.Text);
                            controller.Inserir(txtNome.Text, Convert.ToInt32(mtxtCPF.Text.Trim()), mtxtTelefone.Text, txtModelo.Text, txtMarca.Text, txtPlaca.Text);
                            controller.AgendarCliente(txtNome.Text, Convert.ToInt32(mtxtCPF.Text.Trim()), mtxtTelefone.Text, txtPlaca.Text, cbxTipo.Text, dataHorario);
                            MessageBox.Show("Agendamento efetuado com sucesso! Cliente cadastrado" +Environment.NewLine+
                                $"Informações: {dataHorario.ToString("dd/mm/yy g")}", "Registro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNome.Text = "";
                            mtxtCPF.Text = "";
                            mtxtTelefone.Text = "";
                            txtModelo.Text = "";
                            txtMarca.Text = "";
                            txtPlaca.Text = "";
                            lblData.Text = "";
                            cbxTipo.Text = "";
                            cboHoraAgenda.Text = "00:00";
                            this.txtNome.Focus();
                        }
                    }
                }
                else
                {
                    var result = ve.ValidarCPF(mtxtCPF.Text);
                    if (result == false)
                    {
                        MessageBox.Show("CPF inválido, por favor reescreva!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNome.Text = "";
                        mtxtCPF.Text = "";
                        mtxtTelefone.Text = "";
                        txtModelo.Text = "";
                        txtMarca.Text = "";
                        txtPlaca.Text = "";
                        lblData.Text = "";
                        cbxTipo.Text = "";
                        cboHoraAgenda.Text = "00:00";
                        this.txtNome.Focus();
                        return;
                    }
                    else
                    {
                        if (controller.RegistroRepetido(txtNome.Text, Convert.ToInt32(mtxtCPF.Text.Trim()), txtPlaca.Text) == true)
                        {
                            MessageBox.Show("Cliente já existe em nossa base de dados! - Verifique o Nome,CPF e Placa do Carro",
                                "Registro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNome.Text = "";
                            mtxtCPF.Text = "";
                            mtxtTelefone.Text = "";
                            txtModelo.Text = "";
                            txtMarca.Text = "";
                            txtPlaca.Text = "";
                            lblData.Text = "";
                            cbxTipo.Text = "";
                            cboHoraAgenda.Text = "00:00";
                            this.txtNome.Focus();
                            return;
                        }
                        else
                        {
                            DateTime dataHorario = Convert.ToDateTime(lblData.Text + cboHoraAgenda.Text);
                            controller.Inserir(txtNome.Text, Convert.ToInt32(mtxtCPF.Text.Trim()), mtxtTelefone.Text, txtModelo.Text, txtMarca.Text, txtPlaca.Text);
                            controller.AgendarCliente(txtNome.Text, Convert.ToInt32(mtxtCPF.Text.Trim()),mtxtTelefone.Text, txtPlaca.Text, cbxTipo.Text, dataHorario);
                            MessageBox.Show("Agendamento efetuado com sucesso! Cliente cadastrado" + Environment.NewLine+
                                $"Informações: {dataHorario.ToString("dd/mm/yy g")}", "Registro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNome.Text = "";
                            mtxtCPF.Text = "";
                            mtxtTelefone.Text = "";
                            txtModelo.Text = "";
                            txtMarca.Text = "";
                            txtPlaca.Text = "";
                            lblData.Text = "";
                            cbxTipo.Text = "";
                            cboHoraAgenda.Text = "00:00";
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

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                int cpf = Convert.ToInt32(mtxtCPF.Text.Trim());

                ClienteController controller = new ClienteController();
                Cliente cliente = controller.Localizar(cpf);
                txtNome.Text = cliente.nome;
                mtxtTelefone.Text = cliente.telefone;
                txtModelo.Text = cliente.modelo;
                txtMarca.Text = cliente.marca;
                txtPlaca.Text = cliente.placaCarro;
            }
            catch (Exception)
            {
                MessageBox.Show("CPF/CNPJ informado, encontra-se incorreto ou não existe no banco de dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSomenteAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteController controller = new ClienteController();
                Cliente cliente = new Cliente();
                
                if (chbxCNPJ.Checked == true)
                {
                    DateTime dataHorario = Convert.ToDateTime(lblData.Text + cboHoraAgenda.Text);
                    controller.Inserir(txtNome.Text, Convert.ToInt32(mtxtCPF.Text.Trim()), mtxtTelefone.Text, txtModelo.Text, txtMarca.Text, txtPlaca.Text);
                    controller.AgendarCliente(txtNome.Text, Convert.ToInt32(mtxtCPF.Text.Trim()), mtxtTelefone.Text, txtPlaca.Text, cbxTipo.Text, dataHorario);
                    MetroMessageBox.Show(this, "Agendamento efetuado com sucesso!" + Environment.NewLine +
                        $"Informações: {dataHorario.ToString("dd/mm/yy g")}", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Text = "";
                    mtxtCPF.Text = "";
                    mtxtTelefone.Text = "";
                    txtModelo.Text = "";
                    txtMarca.Text = "";
                    txtPlaca.Text = "";
                    lblData.Text = "";
                    cbxTipo.Text = "";
                    cboHoraAgenda.Text = "00:00";
                    this.txtNome.Focus();

                }
                

            }
            catch (Exception er)
            {
                MetroMessageBox.Show(this,er.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || mtxtCPF.Text == "" || mtxtTelefone.Text == "" || lblData.Text == "" || cboHoraAgenda.Text == "" || txtPlaca.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DateTime dataHorario = Convert.ToDateTime(lblData.Text + cboHoraAgenda.Text);
                Cliente cliente = new Cliente();
                ControllerGeral geral = new ControllerGeral();
                ClienteController controller = new ClienteController();
                controller.AlterarAgendamento(Convert.ToInt32(lblID.Text.Trim()), txtNome.Text, Convert.ToInt32(mtxtCPF.Text.Trim()),
                    mtxtTelefone.Text,txtPlaca.Text, cbxTipo.Text, dataHorario);
                MetroMessageBox.Show(this,"Agendamento atualizado com sucesso!!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Agenda> li = geral.listaAgendaDia();
                dgvAgenda.DataSource = li;
                txtNome.Text = "";
                mtxtCPF.Text = "";
                mtxtTelefone.Text = "";
                txtModelo.Text = "";
                txtMarca.Text = "";
                txtPlaca.Text = "";
                lblData.Text = "";
                cbxTipo.Text = "";
                cboHoraAgenda.Text = "00:00";
                this.txtNome.Focus();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClienteController cli = new ClienteController();
                Cliente cliente = new Cliente();
                Agenda agenda = new Agenda();
                DataGridViewRow row = this.dgvAgenda.Rows[e.RowIndex];
                this.dgvAgenda.Rows[e.RowIndex].Selected = true;                
                if (row.Cells[2].Value.ToString().Length == 11)
                {
                    chbxCNPJ.Checked = false;
                }
                else
                {
                    chbxCNPJ.Checked = true;
                }
                lblID.Text = row.Cells[0].Value.ToString();
                cliente = cli.Localizar(Convert.ToInt32(row.Cells[2].Value));
                agenda = cli.localizarAgenda(Convert.ToInt32(row.Cells[0]));

                txtMarca.Text = cliente.marca.ToString();
                txtNome.Text = cliente.nome.ToString();
                mtxtCPF.Text = cliente.cpf.ToString();
                txtModelo.Text = cliente.modelo.ToString();
                txtPlaca.Text = agenda.placaCarro.ToString();
                cbxTipo.Text = agenda.tipoTratamento.ToString();
                var data = agenda.agendamento;
                Calendario.SetDate(data);                
                cboHoraAgenda.Text = data.ToString("t");
                
            }
        }
    }
}
