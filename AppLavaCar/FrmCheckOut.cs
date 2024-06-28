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

namespace AppLavaCar
{
    public partial class FrmCheckOut : MetroFramework.Forms.MetroForm
    {
        public FrmCheckOut()
        {
            InitializeComponent();
        }

        private void FrmCheckOut_Load(object sender, EventArgs e)
        {
            CheckController controller = new CheckController();
            List<CheckIn> li = controller.listaCheckin();
            dgvCheckout.DataSource = li;

            pbxFoto1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFoto2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFoto3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFoto4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFoto5.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvCheckout_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvCheckout.Rows[e.RowIndex];
            this.dgvCheckout.Rows[e.RowIndex].Selected = true;
            lblID.Text = row.Cells[0].Value.ToString().Trim();
            lblNomeCliente.Text = row.Cells[1].Value.ToString().Trim();
            lblCPF.Text = row.Cells[2].Value.ToString().Trim();
            lblTelefone.Text = row.Cells[3].Value.ToString().Trim();
            lblPlacaCarro.Text = row.Cells[5].Value.ToString().Trim();
            lblTipoTratamento.Text = row.Cells[4].Value.ToString().Trim();
            lblAgendamento.Text = row.Cells[6].Value.ToString().Trim();
            lblClienteCiente.Text = row.Cells[7].Value.ToString().Trim();
            lblDefeito.Text = row.Cells[8].Value.ToString().Trim();
            txtObservacao.Text = row.Cells[9].Value.ToString().Trim();
            pbxFoto1.ImageLocation = row.Cells[10].Value.ToString().Trim();            
            pbxFoto2.ImageLocation = row.Cells[11].Value.ToString().Trim();
            pbxFoto3.ImageLocation = row.Cells[12].Value.ToString().Trim();
            pbxFoto4.ImageLocation = row.Cells[13].Value.ToString().Trim();
            pbxFoto5.ImageLocation = row.Cells[14].Value.ToString().Trim();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (lblID.Text == null)
            {
                MessageBox.Show("Por Favor, selecione um cliente em situação de check-in, para efetuar a entrega do veículo", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string pago = "PAGO";
                CheckController check = new CheckController();
                check.InserirCheckOut(lblNomeCliente.Text, lblCPF.Text, lblTelefone.Text, lblPlacaCarro.Text, lblTipoTratamento.Text, Convert.ToDateTime(lblAgendamento.Text),pago,
                     lblClienteCiente.Text, lblDefeito.Text,txtObservacao.Text, pbxFoto1.ImageLocation, pbxFoto2.ImageLocation, pbxFoto3.ImageLocation, pbxFoto4.ImageLocation,pbxFoto5.ImageLocation);
                check.ExcluirCheckin(Convert.ToInt32(lblID.Text));
                MessageBox.Show("Check-out realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<CheckIn> chechin = check.listaCheckin();
                dgvCheckout.DataSource = chechin;
                lblID.Text = "";
                lblNomeCliente.Text = "";
                lblCPF.Text = "";
                lblTelefone.Text = "";
                lblPlacaCarro.Text = "";
                lblTipoTratamento.Text = "";
                lblAgendamento.Text = "";
                lblDefeito.Text = "";
                lblClienteCiente.Text = "";
                txtObservacao.Text = "";
                pbxFoto1.Image = null;
                pbxFoto2.Image = null;
                pbxFoto3.Image = null;
                pbxFoto4.Image = null;
                pbxFoto5.Image = null;
            }
        }
    }
}
