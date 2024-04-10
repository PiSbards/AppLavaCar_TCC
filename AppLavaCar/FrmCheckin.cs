using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            dialog.Filter = "Arquivos de Imagem|*.bmp;*.jpg;*.jpeg;*.png;*.gif|Todos os Arquivos|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imagem = dialog.FileName;
                PictureBox pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Height = 100;
                pb.Width = 100;
                pb.ImageLocation = imagem;
                flpFotos.Controls.Add(pb);
            }
        }
    }
}
