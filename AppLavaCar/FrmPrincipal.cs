using AppLavaCar.Controller;
using AppLavaCar.Model;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }
        public FrmPrincipal(bool gerente,string chefe)
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
            var resposta = MetroMessageBox.Show(this,"Deseja realmente sair?","SAIR",MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            if(resposta == DialogResult.OK)
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
            var resposta = MetroMessageBox.Show(this,"Deseja realmente sair?", "SAIR", MessageBoxButtons.OKCancel);
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
            if (e.RowIndex >= 0)
            {
                CarroController car = new CarroController();                               
                DataGridViewRow row = this.dgvAgendamento.Rows[e.RowIndex];
                this.dgvAgendamento.Rows[e.RowIndex].Selected = true;
                
                Carro carro = car.LocalizarPelaPlaca(row.Cells[4].Value.ToString().Trim());
                lblMarca.Text = carro.marca;
                lblModelo.Text = carro.modelo;
                lblNomeCliente.Text = row.Cells[1].Value.ToString();
                lblTipoTratamento.Text = row.Cells[5].Value.ToString().Trim();
                lblPlaca.Text = row.Cells[4].Value.ToString();
                var data = Convert.ToDateTime(row.Cells[6].Value);                
                lblAgendamento.Text = data.ToString("dd/MM/yyyy HH:mm");

                if (lblTipoTratamento.Text == "Lavagem Simples - R$60,00".Trim())
                {
                    lblTempoEstimado.Text = "1H15min";
                    lblTimer.Text = "01:15:00";
                }
                else if (lblTipoTratamento.Text == "Lavagem Completa - R$70,00".Trim())
                {
                    lblTempoEstimado.Text = "1H45min";
                    lblTimer.Text = "01:45:00";
                }
                else if (lblTipoTratamento.Text == "Lavagem Completa + Enceramento - R$90,00".Trim())
                {
                    lblTempoEstimado.Text = "2H15min";
                    lblTimer.Text = "02:15:00";
                }
                else if (lblTipoTratamento.Text == "Combo Bronze - R$120,00".Trim())
                {
                    lblTempoEstimado.Text = "2H30min";
                    lblTimer.Text = "02:30:00";
                }
                else if (lblTipoTratamento.Text == "Combo Prata - R$150,00".Trim())
                {
                    lblTempoEstimado.Text = "3H";
                    lblTimer.Text = "03:00:00";
                }
                else if (lblTipoTratamento.Text == "Combo Ouro - R$200,00".Trim())
                {
                    lblTempoEstimado.Text = "3H30min";
                    lblTimer.Text = "03:30:00";
                } 
            }
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            string[] totalSeconds = lblTimer.Text.Split();            
            int minutes = Convert.ToInt32(totalSeconds[0]);
            int seconds = Convert.ToInt32(totalSeconds[1]);
            if (lblTipoTratamento.Text == "Lavagem Simples - R$60,00".Trim() || lblTipoTratamento.Text == "Lavagem Completa - R$70,00".Trim())
            {
                timeLeft = (minutes * 120) + seconds;
                timer1.Start();
            }            
            else if (lblTipoTratamento.Text == "Lavagem Completa + Enceramento - R$90,00".Trim() || lblTipoTratamento.Text == "Combo Bronze - R$120,00".Trim())
            {
                timeLeft = (minutes * 180) + seconds;
                timer1.Start();
            }            
            else if (lblTipoTratamento.Text == "Combo Prata - R$150,00".Trim() || lblTipoTratamento.Text == "Combo Ouro - R$200,00".Trim())
            {
                timeLeft = (minutes * 240) + seconds;
                timer1.Start();
            }            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                var timespan = TimeSpan.FromSeconds(timeLeft);
                lblTimer.Text = timespan.ToString(@"HH\:mm\:ss");
                //lblTimer.Text = (int.Parse(lblTimer.Text) - 1).ToString();
            }
            else
            {
                timer1.Stop();
                SystemSounds.Exclamation.Play();
                MetroMessageBox.Show(this,"O tempo do procedimento acabou!","ATENÇÃO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
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
    }
}
