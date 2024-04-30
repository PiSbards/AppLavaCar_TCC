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
            AgendaController controller = new AgendaController();
            ControllerGeral geral= new ControllerGeral();
            Agenda agenda = new Agenda();
            List<Agenda> li = controller.listaAgendaDia();
            DateTime[] date = geral.BoldDates();
            Calendario.BoldedDates = date;
            dgvAgenda.DataSource = li;            
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
                    if (txtNome.Text == ""|| mtxtCPF.Text == ""|| mtxtTelefone.Text==""|| cbxPlaca.Text==""|| txtMarca.Text==""||txtModelo.Text==""|| cbxTipo.Text == ""|| cboHoraAgenda.Text == "00:00")
                    {
                        MessageBox.Show("Por favor, preencha todos os campos!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                        return;
                    }
                    
                    bool result = ve.IsCnpj(mtxtCPF.Text);
                    if (result == false)
                    {
                        MessageBox.Show("CNPJ inválido, por favor reescreva!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        return;
                    }
                    else
                    {
                        if (controller.RegistroRepetido(txtNome.Text.Trim(), mtxtCPF.Text.Trim(), mtxtTelefone.Text.Trim()) == true)
                        {
                            MessageBox.Show("Cliente já existe em nossa base de dados! - Verifique o Nome,CNPJ e Telefone",
                                "Registro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            return;
                        }
                        else
                        {
                            DateTime dataHorario = Convert.ToDateTime(lblData.Text+" "+ cboHoraAgenda.Text);
                            

                            controller.Inserir(txtNome.Text.Trim(), mtxtCPF.Text.Trim(), mtxtTelefone.Text.Trim());

                            agendaController.AgendarCliente(txtNome.Text.Trim(), mtxtCPF.Text, mtxtTelefone.Text.Trim(),
                                cbxPlaca.Text.Trim(), cbxTipo.Text.Trim(), Convert.ToDateTime(dataHorario.ToString("yyyy/MM/dd HH:mm").Trim()));
                            MessageBox.Show("Agendamento efetuado com sucesso! Cliente cadastrado" +Environment.NewLine+
                                $"Informações: {dataHorario.ToString("dd/MM/yyyy HH:mm")}", "Registro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    }
                }
                else if(chbxCNPJ.Checked == false)
                {
                    if (txtNome.Text == "" || mtxtCPF.Text == "" || mtxtTelefone.Text == "" || cbxPlaca.Text == "" || txtMarca.Text == "" || txtModelo.Text == "" || cbxTipo.Text == "" || cboHoraAgenda.Text == "00:00")
                    {
                        MessageBox.Show("Por favor, preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        return;
                    }
                    bool result = ve.IsCpf(mtxtCPF.Text);
                    if (result == false)
                    {
                        MessageBox.Show("CPF inválido, por favor reescreva!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        return;
                    }
                    else if(result == true)
                    {
                        bool repetido = controller.RegistroRepetido(txtNome.Text, mtxtCPF.Text.Trim(), mtxtTelefone.Text);
                        if ( repetido == true)
                        {
                            MessageBox.Show("Cliente já existe em nossa base de dados! - Verifique o Nome,CPF e telefone",
                                "Registro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            return;
                        }
                        else
                        {
                            DateTime dataHorario = Convert.ToDateTime(lblData.Text.Trim() + " "+cboHoraAgenda.Text.Trim());
                            
                            controller.Inserir(txtNome.Text.Trim(), mtxtCPF.Text.Trim(), mtxtTelefone.Text.Trim());

                            agendaController.AgendarCliente(txtNome.Text.Trim(), mtxtCPF.Text.Trim(), mtxtTelefone.Text.Trim(),cbxPlaca.Text.Trim(), cbxTipo.Text.Trim(),
                                Convert.ToDateTime(dataHorario.ToString("yyyy/MM/dd HH:mm").Trim()));

                            MessageBox.Show("Agendamento efetuado com sucesso! Cliente cadastrado" + Environment.NewLine+
                                $"Informações: {dataHorario.ToString("dd/MM/yyyy HH:mm")}", "Registro Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                List<Agenda> li = agendaController.listaAgendaDia();
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
                Carro carro = new Carro();
                CarroController car = new CarroController();
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
                cliente = cli.Localizar(row.Cells[2].Value.ToString());
                agenda = agendaController.localizarAgenda(Convert.ToInt32(row.Cells[0].Value));
                carro = car.LocalizarPelaPlaca(row.Cells[4].Value.ToString());
                txtMarca.Text = carro.marca.ToString();
                txtModelo.Text = carro.modelo.ToString();
                txtNome.Text = cliente.nome.ToString();
                mtxtCPF.Text = cliente.cpf.ToString();
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
                MessageBox.Show("Selecione o agendamento para efetuar o cancelamento", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                return;
            }
            agenda.ExcluirAgendamento(Convert.ToInt32(lblID.Text));
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
            cbxPlaca.Items.Add(carro.CarregaCbxCarro(mtxtCPF.Text));
        }
    }
}
