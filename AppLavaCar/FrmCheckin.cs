using AppLavaCar.Controller;
using AppLavaCar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
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
            dialog.Filter = "Arquivos de Imagem|*.bmp;*.jpg;*.jpeg;*.png;*.gif;|Todos os Arquivos|*.*";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagem = dialog.FileName;                
                if (pbxFoto1.ImageLocation == null)
                {
                    pbxFoto1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbxFoto1.ImageLocation = imagem;                    
                }
                else if (pbxFoto1.ImageLocation != null && pbxFoto2.ImageLocation == null)
                {
                    pbxFoto2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbxFoto2.ImageLocation = imagem;
                }
                else if (pbxFoto1.ImageLocation != null && pbxFoto2.ImageLocation != null && pbxFoto3.ImageLocation == null)
                {
                    pbxFoto3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbxFoto3.ImageLocation = imagem;
                }
                else if (pbxFoto1.ImageLocation != null && pbxFoto2.ImageLocation != null && pbxFoto3.ImageLocation != null && pbxFoto4.ImageLocation == null)
                {
                    pbxFoto4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbxFoto4.ImageLocation = imagem;
                }
                else if (pbxFoto1.ImageLocation != null && pbxFoto2.ImageLocation != null && pbxFoto3.ImageLocation != null && pbxFoto4.ImageLocation != null && pbxFoto5.ImageLocation == null)
                {
                    pbxFoto5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbxFoto5.ImageLocation = imagem;
                }                
            }
            
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFoto1.Text == string.Empty && pbxFoto1.ImageLocation != null || txtFoto2.Text == string.Empty && pbxFoto2.ImageLocation != null || txtFoto3.Text == string.Empty && pbxFoto3.ImageLocation != null
                    || txtFoto4.Text == string.Empty && pbxFoto4.ImageLocation != null || txtFoto5.Text == string.Empty && pbxFoto5.ImageLocation != null)
                {
                    MessageBox.Show("Por favor, Nomeie todas as fotos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cbxSim2.Checked == false && cbxSim.Checked == false && cbxNao.Checked == false && cbxNao2.Checked == false && lblID.Text == "")
                {
                    MessageBox.Show("Por favor, selecione um agendamento e/ou termine de preencher os campos");
                }
                string foto1 = txtFoto1.Text.Replace(" ", "");
                string foto2 = txtFoto2.Text.Replace(" ", "");
                string foto3 = txtFoto3.Text.Replace(" ", "");
                string foto4 = txtFoto4.Text.Replace(" ", "");
                string foto5 = txtFoto5.Text.Replace(" ", "");
                string caminho = "C:\\AppLavaCar\\AppLavaCar\\Fotos";
                if (pbxFoto1.Image != null && pbxFoto1.Image !=null)
                {
                    string novoCaminho = caminho + "\\" + foto1 + ".jpg";
                    pbxFoto1.Image.Save(novoCaminho);
                    foto1 = novoCaminho;
                }
                if (pbxFoto2.Image != null && pbxFoto2.Image != null)
                {
                    string novoCaminho = caminho + "\\" + foto2 + ".jpg";
                    pbxFoto2.Image.Save(novoCaminho);
                    foto2 = novoCaminho;

                }
                if (pbxFoto3.Image != null && pbxFoto3.Image != null)
                {
                    string novoCaminho = caminho + "\\" + foto3 + ".jpg";
                    pbxFoto3.Image.Save(novoCaminho);
                    foto3 = novoCaminho;

                }
                if (pbxFoto4.Image != null && pbxFoto4.Image != null)
                {
                    string novoCaminho = caminho + "\\" + foto4 + ".jpg";
                    pbxFoto4.Image.Save(novoCaminho);
                    foto4 = novoCaminho;

                }
                if (pbxFoto5.Image != null && pbxFoto5.Image != null)
                {
                    string novoCaminho = caminho + "\\" + foto5 + ".jpg";
                    pbxFoto5.Image.Save(novoCaminho);
                    foto5 = novoCaminho;

                }
                CheckController check = new CheckController();
                string defeito;
                string clienteCiente;
                if (cbxSim.Checked == true)
                {
                    defeito = "SIM";
                }
                else
                {
                    defeito = "NÃO";
                }
                if (cbxSim2.Checked == true)
                {
                    clienteCiente = "SIM";
                }
                else
                {
                    clienteCiente = "NÃO";
                }

                check.InserirCheckIn(lblNomeCliente.Text,lblCPF.Text,lblTelefone.Text, defeito, clienteCiente, lblTipoTratamento.Text, lblPlacaCarro.Text,
                    Convert.ToDateTime(lblAgendamento.Text),txtDefeitos.Text, foto1,foto2,foto3,foto4,foto5);

                MessageBox.Show("Check-in realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AgendaController agendaController = new AgendaController();

                agendaController.ExcluirAgendamento(Convert.ToInt32(lblID.Text));
                List<Agenda> agendamento = agendaController.listaAgendaDia();
                dgvAgenda.DataSource = agendamento;
                lblNomeCliente.Text = "";
                lblCPF.Text = "";
                lblID.Text = "";
                lblPlacaCarro.Text = "";
                lblTelefone.Text = "";
                lblTipoTratamento.Text = "";
                lblAgendamento.Text = "";
                txtFoto1.Text = "";
                txtFoto2.Text = "";
                txtFoto3.Text = "";
                txtFoto4.Text = "";
                txtFoto5.Text = "";
                cbxNao.Checked = false;
                cbxNao2.Checked = false;
                cbxSim.Checked = false;
                cbxSim2.Checked = false;
                pbxFoto1.Image = null;
                pbxFoto2.Image = null;
                pbxFoto3.Image = null;
                pbxFoto4.Image = null;
                pbxFoto5.Image = null;
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
                DataGridViewRow row = this.dgvAgenda.Rows[e.RowIndex];
                this.dgvAgenda.Rows[e.RowIndex].Selected = true;
                lblID.Text = row.Cells[0].Value.ToString();
                lblNomeCliente.Text = row.Cells[1].Value.ToString();
                lblCPF.Text = row.Cells[2].Value.ToString();
                lblTelefone.Text = row.Cells[3].Value.ToString();
                lblPlacaCarro.Text = row.Cells[5].Value.ToString();
                lblTipoTratamento.Text = row.Cells[4].Value.ToString();
                lblAgendamento.Text = row.Cells[6].Value.ToString();
            }
        }
    }
}
