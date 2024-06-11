using AppLavaCar.Controller;
using AppLavaCar.Model;
using MetroFramework;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace AppLavaCar
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        private bool Hidden;
        public int timeLeft { get; set; }
        public FrmPrincipal()
        {
            InitializeComponent();
            btnFunc1.Enabled = false;
            btnFunc2.Enabled = false;
            btnRelatorio.Enabled = false;
            btnRelatorio2.Enabled = false;
        }
        public FrmPrincipal(bool gerente, string chefe)
        {
            InitializeComponent();
            lblChefe.Text = chefe;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (Hidden == true)
            {

                MenuConteudo.Width = 200;

                Hidden = false;
            }
            else
            {
                MenuConteudo.Width = 0;
                Hidden = true;
            }
        }

        private void btnFunc1_Click(object sender, EventArgs e)
        {
            FrmFunc func = new FrmFunc();
            func.Show();
        }

        private void btnAgenda1_Click(object sender, EventArgs e)
        {
            if (lblChefe.Text == "SIM".ToLower())
            {
                bool gerente = true;
                FrmAgenda agenda = new FrmAgenda(gerente);
                agenda.Show();
            }
            else
            {
                FrmAgenda agenda1 = new FrmAgenda();
                agenda1.Show();
            }
        }

        private void btnCliente1_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();

        }

        private void btnSair2_Click(object sender, EventArgs e)
        {
            FrmInicial inicial = new FrmInicial();
            var resposta = MetroMessageBox.Show(this, "Deseja realmente sair?", "SAIR", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            if (resposta == DialogResult.OK)
            {
                inicial.Show();
                this.Hide();
            }
            else
            {
                return;
            }

        }

        private void btnFunc2_Click(object sender, EventArgs e)
        {
            FrmFunc func = new FrmFunc();
            func.Show();

        }

        private void btnAgenda2_Click(object sender, EventArgs e)
        {
            if (lblChefe.Text == "SIM".ToLower())
            {
                bool gerente = true;
                FrmAgenda agenda = new FrmAgenda(gerente);
                agenda.Show();
            }
            else
            {
                FrmAgenda agenda1 = new FrmAgenda();
                agenda1.Show();
            }
        }

        private void btnCliente2_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();

        }

        private void btnSair1_Click(object sender, EventArgs e)
        {
            FrmInicial inicial = new FrmInicial();
            var resposta = MetroMessageBox.Show(this, "Deseja realmente sair?", "SAIR", MessageBoxButtons.OKCancel);
            if (resposta == DialogResult.OK)
            {
                inicial.Show();
                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Hidden = true;
            MenuConteudo.Width = 0;

            CheckIn check = new CheckIn();
            CheckController controller = new CheckController();
            List<CheckIn> li = controller.listaCheckin();
            dgvAgendamento.DataSource = li;
            AgendaController agenda = new AgendaController();
            List<Agenda> agendamento = agenda.listaAgendaDia();
            dgvAgendaDoDia.DataSource = agendamento;
            lblData.Text = DateTime.Today.ToString("D");
            lblAgendamentoDia.Text = agendamento.Count.ToString();
            ControllerGeral geral = new ControllerGeral();
            geral.AtualizarGraficos(this.chTipoTratamento, this.chSituacao);
            lblModelo.Text = geral.IndicadorModelo();
            if (lblModelo.Text == null)
            {
                lblModelo.Text = "Não há Modelos";
            }
            lblTratamento.Text = geral.IndicadorTipoTratamento();
            if (lblTratamento.Text == null)
            {
                lblTratamento.Text = "Não foram realizados nenhum tratamento";
            }
            List<string> top3 = geral.ObterTop3Clientes();
            if (top3.Count>=3 )
            {
                lbltop1.Text = top3[0].ToString();
                lbltop2.Text = top3[1].ToString();
                lblTop3.Text = top3[2].ToString();
            }
            else if (top3.Count == 2)
            {
                lbltop1.Text = top3[0].ToString();
                lbltop2.Text = top3[1].ToString();
                lblTop3.Text = "";
            }
            else if(top3.Count == 1)
            {
                lbltop1.Text = top3[0].ToString();
                lbltop2.Text = "";
                lblTop3.Text = "";
            } 
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            FrmCheckin check = new FrmCheckin();
            check.Show();
        }

        private void btnCheckin2_Click(object sender, EventArgs e)
        {
            FrmCheckin check = new FrmCheckin();
            check.Show();
        }

        private void dgvAgendamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            FrmCheckOut Checkout = new FrmCheckOut();
            Checkout.Show();
        }

        private void btnCheckOut2_Click(object sender, EventArgs e)
        {
            FrmCheckOut Checkout = new FrmCheckOut();
            Checkout.Show();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CheckIn check = new CheckIn();
            CheckController controller = new CheckController();
            List<CheckIn> li = controller.listaCheckin();
            dgvAgendamento.DataSource = li;
            AgendaController agenda = new AgendaController();
            List<Agenda> agendamento = agenda.listaAgendaDia();
            dgvAgendaDoDia.DataSource = agendamento;
            lblAgendamentoDia.Text = agendamento.Count.ToString();
            ControllerGeral geral = new ControllerGeral();
            geral.AtualizarGraficos(this.chTipoTratamento, this.chSituacao);

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            FrmRelatorio rel = new FrmRelatorio();
            rel.Show();
        }

        private void btnRelatorio2_Click(object sender, EventArgs e)
        {
            FrmRelatorio rel = new FrmRelatorio();
            rel.Show();
        }
    }
}
