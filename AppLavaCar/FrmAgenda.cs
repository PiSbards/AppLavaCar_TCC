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
            lblData.Text = Calendario.SelectionRange.Start.ToString("yyyy/MM/dd");
            AgendaController controller = new AgendaController();
            List<Agenda> agenda = controller.listaAgendaSelecionada(Convert.ToDateTime(lblData.Text));
            dgvAgenda.DataSource = agenda;
        }       

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            AgendaController controller = new AgendaController();
            ControllerGeral geral= new ControllerGeral();
            Agenda agenda = new Agenda();
            List<Agenda> li = controller.listaAgendaDia();
            DateTime[] date = geral.BoldDates();
            Calendario.BoldedDates = date;
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
                AgendaController agendaController= new AgendaController();
                Cliente cliente = new Cliente();
                VerificacaoCpfCnpj ve = new VerificacaoCpfCnpj();
                if (chbxCNPJ.Checked == true)
                {
                    var result = ve.ValidarCNPJ(mtxtCPF.Text.Trim());
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
                        if (controller.RegistroRepetido(txtNome.Text.Trim(), Convert.ToInt32(mtxtCPF.Text.Trim()), txtPlaca.Text.Trim()) == true)
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
                            DateTime dataHorario = Convert.ToDateTime(lblData.Text+" "+ cboHoraAgenda.Text);
                            controller.Inserir(txtNome.Text.Trim(), Convert.ToInt32(mtxtCPF.Text.Trim()), mtxtTelefone.Text.Trim(), txtPlaca.Text.Trim(), txtMarca.Text.Trim(), txtModelo.Text.Trim());
                            agendaController.AgendarCliente(txtNome.Text.Trim(), Convert.ToInt32(mtxtCPF.Text.Trim()), mtxtTelefone.Text.Trim(),
                                txtPlaca.Text.Trim(), cbxTipo.Text.Trim(), Convert.ToDateTime(dataHorario.ToString("yyyy/MM/dd HH:mm").Trim()));
                            MessageBox.Show("Agendamento efetuado com sucesso! Cliente cadastrado" +Environment.NewLine+
                                $"Informações: {dataHorario.ToString("dd/mm/yyyy g")}", "Registro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else if(chbxCNPJ.Checked == false)
                {
                    var result = ve.ValidarCPF(mtxtCPF.Text.Trim());
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
                        if (controller.RegistroRepetido(txtNome.Text.Trim(), Convert.ToInt32(mtxtCPF.Text.Trim()), txtPlaca.Text.Trim()) == true)
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
                            DateTime dataHorario = Convert.ToDateTime(lblData.Text.Trim() + " "+cboHoraAgenda.Text.Trim());
                            controller.Inserir(txtNome.Text.Trim(), Convert.ToInt32(mtxtCPF.Text.Trim()), mtxtTelefone.Text.Trim(), txtPlaca.Text.Trim(), txtMarca.Text.Trim(), txtModelo.Text.Trim());

                            agendaController.AgendarCliente(txtNome.Text.Trim(), Convert.ToInt32(mtxtCPF.Text.Trim()),mtxtTelefone.Text.Trim(),
                                txtPlaca.Text.Trim(), cbxTipo.Text.Trim(), Convert.ToDateTime(dataHorario.ToString("yyyy/MM/dd HH:mm").Trim()));

                            MessageBox.Show("Agendamento efetuado com sucesso! Cliente cadastrado" + Environment.NewLine+
                                $"Informações: {dataHorario.ToString("dd/MM/yyyy g")}", "Registro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                AgendaController agendaController = new AgendaController();
                Cliente cliente = new Cliente();

                DateTime dataHorario = Convert.ToDateTime(lblData.Text + " " + cboHoraAgenda.Text);
                controller.Inserir(txtNome.Text.Trim(), Convert.ToInt32(mtxtCPF.Text.Trim()), mtxtTelefone.Text.Trim(), txtModelo.Text.Trim(), txtMarca.Text.Trim(), txtPlaca.Text.Trim());
                agendaController.AgendarCliente(txtNome.Text.Trim(), Convert.ToInt32(mtxtCPF.Text.Trim()), mtxtTelefone.Text.Trim(), txtPlaca.Text.Trim(), cbxTipo.Text.Trim(),
                    Convert.ToDateTime(dataHorario.ToString("yyyy/MM/dd HH:mm").Trim()));
                MessageBox.Show(this, "Agendamento efetuado com sucesso!" + Environment.NewLine +
                    $"Informações: {dataHorario.ToString("dd/mm/yyyy g")}", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(this,er.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DateTime dataHorario = Convert.ToDateTime(lblData.Text +" "+ cboHoraAgenda.Text);
                Cliente cliente = new Cliente();
                AgendaController agendaController = new AgendaController();
                ClienteController controller = new ClienteController();
                agendaController.AlterarAgendamento(Convert.ToInt32(lblID.Text.Trim()), txtNome.Text, Convert.ToInt32(mtxtCPF.Text.Trim()),
                    mtxtTelefone.Text,txtPlaca.Text, cbxTipo.Text, Convert.ToDateTime(dataHorario.ToString("yyyy/MM/dd HH:mm")));
                MessageBox.Show(this,"Agendamento atualizado com sucesso!!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Agenda> li = agendaController.listaAgendaDia();
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
                AgendaController agendaController = new AgendaController();
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
                agenda = agendaController.localizarAgenda(Convert.ToInt32(row.Cells[0]));
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
