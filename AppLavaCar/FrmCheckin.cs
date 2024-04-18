using AppLavaCar.Controller;
using AppLavaCar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AppLavaCar
{
    public partial class FrmCheckin : MetroFramework.Forms.MetroForm
    {
        public FrmCheckin()
        {
            InitializeComponent();
        }   
        private void FrmCheckin_Load(object sender, EventArgs e)
        {
            txtDefeitos.Enabled = false;
            AgendaController controller = new AgendaController();            
            List<Agenda> li = controller.listaAgendaDia();
            dgvAgenda.DataSource = li;
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }  
        private void cbxSim_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNao.Checked == true)
            {
                cbxNao.Checked = false;                
                
            }
            txtDefeitos.Enabled = true;
            if (cbxSim.Checked == false)
            {
                txtDefeitos.Enabled = false;
            }
        }

        private void cbxNao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSim.Checked == true)
            {
                cbxSim.Checked = false;
                
            }
        }

        private void cbxSim2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxNao2.Checked == true)
            {
                cbxNao2.Checked = false;
                
                
            }
        }

        private void cbxNao2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSim2.Checked == true)
            {
                cbxSim2.Checked = false;
                
            }
        }

        private void btnArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Selecionar Imagem...";
            dialog.Filter = "Arquivos de Imagem|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.pdf|Todos os Arquivos|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagem = dialog.FileName; 
                txtArquivo.Text += imagem;
                PictureBox pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Height = 100;
                pb.Width = 100;
                pb.ImageLocation = imagem;
                flpFotos.Controls.Add(pb);
            }
            
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteController controller = new ClienteController();
                string foto = txtArquivo.Text.Replace(" ", "");
                pbxFoto1.Image.Save(@"C:\Programas\LojaGeek\Produtos\" + foto + ".jpg");
                //fazer aqui linha de inserir no BD
                MessageBox.Show("Check-in realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AgendaController agendaController = new AgendaController();
                

                List<Agenda> agendamento = agendaController.listaAgendaDia();
                dgvAgenda.DataSource = agendamento;
                lblNomeCliente.Text = "";
                lblCPF.Text = "";
                lblID.Text = "";
                lblPlacaCarro.Text = "";
                lblTelefone.Text = "";
                lblTipoTratamento.Text = "";
                lblAgendamento.Text = "";


            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                lblID.Text = row.Cells[0].Value.ToString();
                lblNomeCliente.Text = row.Cells[1].Value.ToString();
                lblCPF.Text = row.Cells[2].Value.ToString();
                lblTelefone.Text = row.Cells[3].Value.ToString();
                lblPlacaCarro.Text = row.Cells[4].Value.ToString();
                lblTipoTratamento.Text = row.Cells[5].Value.ToString();
                lblAgendamento.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
