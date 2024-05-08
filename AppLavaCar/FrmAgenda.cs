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
            btnCancelar.Enabled = false;
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
            ControllerGeral geral= new ControllerGeral();
            AgendaController controller = new AgendaController();
            Agenda agenda = new Agenda();
            List<Agenda> li = controller.listaAgendaDia();
            dgvAgenda.DataSource = li;            
            DateTime[] date = geral.BoldDates();
            Calendario.BoldedDates = date;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            lblID.Text = "";
            txtNome.Text = "";
            mtxtCPF.Text = "";
            mtxtTelefone.Text = "";
            txtModelo.Text = "";
            txtMarca.Text = "";
            cbxPlaca.Text = "";
            lblData.Text = "";
            cbxTipo.Text = "";
            cboHoraAgenda.Text = "00:00";
            cbxPlaca.Items.Clear();
            this.txtNome.Focus();
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
                ClienteController controller = new ClienteController();
                Cliente cliente = controller.Localizar(mtxtCPF.Text.Trim());
                txtNome.Text = cliente.nome;
                mtxtTelefone.Text = cliente.telefone;

                CarroController carro = new CarroController();
                List<string> li = carro.CarregaCbxCarro(mtxtCPF.Text);
                foreach (string placa in li)
                {
                    cbxPlaca.Items.Add(placa);
                }
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
                AgendaController agendaController = new AgendaController();
                Cliente cliente = new Cliente();
                DateTime dataHorario = Convert.ToDateTime(lblData.Text + " " + cboHoraAgenda.Text);                

                agendaController.AgendarCliente(txtNome.Text.Trim(), mtxtCPF.Text.Trim(), mtxtTelefone.Text.Trim(), cbxPlaca.Text.Trim(), cbxTipo.Text.Trim(),
                    Convert.ToDateTime(dataHorario.ToString("yyyy/MM/dd HH:mm").Trim()));
                MessageBox.Show(this, "Agendamento efetuado com sucesso!" + Environment.NewLine +
                    $"Informações: {dataHorario.ToString("dd/MM/yyyy HH:mm")}", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblID.Text = "";
                txtNome.Text = "";
                mtxtCPF.Text = "";
                mtxtTelefone.Text = "";
                txtModelo.Text = "";
                txtMarca.Text = "";
                cbxPlaca.Text = "";
                lblData.Text = "";
                cbxTipo.Text = "";
                cboHoraAgenda.Text = "00:00";
                ControllerGeral geral = new ControllerGeral();
                DateTime[] date = geral.BoldDates();
                Calendario.BoldedDates = date;
                
                Agenda agenda = new Agenda();
                List<Agenda> li = agendaController.listaAgendaDia();
                dgvAgenda.DataSource = li;
                this.txtNome.Focus();
            }
            catch (Exception er)
            {
                MessageBox.Show(this,er.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || mtxtCPF.Text == "" || mtxtTelefone.Text == "" || lblData.Text == "" || cboHoraAgenda.Text == "" || cbxPlaca.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DateTime dataHorario = Convert.ToDateTime(lblData.Text +" "+ cboHoraAgenda.Text);                
                AgendaController agendaController = new AgendaController();
                
                agendaController.AlterarAgendamento(Convert.ToInt32(lblID.Text.Trim()), txtNome.Text, mtxtCPF.Text.Trim(),
                    mtxtTelefone.Text,cbxPlaca.Text, cbxTipo.Text, Convert.ToDateTime(dataHorario.ToString("yyyy/MM/dd HH:mm")));
                MessageBox.Show(this,"Agendamento atualizado com sucesso!!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                List<Agenda> li = agendaController.listaAgendaSelecionada(Convert.ToDateTime(lblData.Text));
                dgvAgenda.DataSource = li;
                lblID.Text = "";
                txtNome.Text = "";
                mtxtCPF.Text = "";
                mtxtTelefone.Text = "";
                txtModelo.Text = "";
                txtMarca.Text = "";
                cbxPlaca.Text = "";
                lblData.Text = "";
                cbxTipo.Text = "";
                cboHoraAgenda.Text = "00:00";
                ControllerGeral geral = new ControllerGeral();
                DateTime[] date = geral.BoldDates();
                Calendario.BoldedDates = date;
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
                Carro carro = new Carro();
                CarroController car = new CarroController();

                AgendaController agendaController = new AgendaController();
                Agenda agenda = new Agenda();
                DataGridViewRow row = this.dgvAgenda.Rows[e.RowIndex];
                this.dgvAgenda.Rows[e.RowIndex].Selected = true;                
                if (row.Cells[2].Value.ToString().Length == 14)
                {
                    chbxCNPJ.Checked = false;
                }
                else
                {
                    chbxCNPJ.Checked = true;
                }
                lblID.Text = row.Cells[0].Value.ToString();                
                agenda = agendaController.localizarAgenda(Convert.ToInt32(lblID.Text));
                string placa = row.Cells[5].Value.ToString();
                carro = car.LocalizarPelaPlaca(placa);

                txtNome.Text = row.Cells[1].Value.ToString();
                mtxtCPF.Text = row.Cells[2].Value.ToString();
                mtxtTelefone.Text = row.Cells[3].Value.ToString();

                txtMarca.Text = carro.marca.ToString();
                txtModelo.Text = carro.modelo.ToString();

                cbxPlaca.Text = agenda.placaCarro.ToString();
                cbxTipo.Text = agenda.tipoTratamento.ToString();
                var data = agenda.agendamento;
                Calendario.SetDate(data);                
                cboHoraAgenda.Text = data.ToString("t");                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AgendaController agenda = new AgendaController();
            if (lblID.Text == "")
            {
                MessageBox.Show("Selecione um agendamento, na tabela,para efetuar o cancelamento", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblID.Text = "";
                txtNome.Text = "";
                mtxtCPF.Text = "";
                mtxtTelefone.Text = "";
                txtModelo.Text = "";
                txtMarca.Text = "";
                cbxPlaca.Text = "";
                lblData.Text = "";
                cbxTipo.Text = "";
                cboHoraAgenda.Text = "00:00";
                ControllerGeral geral = new ControllerGeral();
                DateTime[] date = geral.BoldDates();
                Calendario.BoldedDates = date;                
                return;
            }
            agenda.ExcluirAgendamento(Convert.ToInt32(lblID.Text));
            List<Agenda> li = agenda.listaAgendaSelecionada(Convert.ToDateTime(lblData.Text));
            dgvAgenda.DataSource = li;
            MessageBox.Show("Agendamento cancelado com sucesso!","INFROMAÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void cbxPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarroController car = new CarroController();
            Carro carro = car.LocalizarPelaPlaca(cbxPlaca.Text);
            txtMarca.Text = carro.marca;
            txtModelo.Text = carro.modelo;
        }

        private void btnNovoCarro_Click(object sender, EventArgs e)
        {
            if (mtxtCPF.Text == "")
            {
                FrmCarro carro = new FrmCarro();
                carro.Show();                
            }
            else
            {
                FrmCarro carro = new FrmCarro(mtxtCPF.Text,txtNome.Text);
                carro.Show();                
            }
        }

        private void mtxtCPF_Leave(object sender, EventArgs e)
        {
            
        }

        private void pbxRefreshPlaca_Click(object sender, EventArgs e)
        {
            cbxPlaca.Items.Clear();
            CarroController carro = new CarroController();
            List<string> li = carro.CarregaCbxCarro(mtxtCPF.Text);
            foreach (string placa in li)
            {
                cbxPlaca.Items.Add(placa);
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmNovoCliente cliente = new FrmNovoCliente();
            cliente.Show();
        }
    }
}
