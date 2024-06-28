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
    public partial class FrmRelatorio : MetroFramework.Forms.MetroForm
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            CheckController controller = new CheckController();
            List<CheckOut> li = controller.listaCheckOut();
            dgvHistorico.DataSource = li;
            pbxFoto1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFoto2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFoto3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFoto4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxFoto5.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void dgvHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvHistorico.Rows[e.RowIndex];
            this.dgvHistorico.Rows[e.RowIndex].Selected = true;
            lblNomeCliente.Text = row.Cells[1].Value.ToString().Trim();
            lblCPF.Text = row.Cells[2].Value.ToString().Trim();
            lblTelefone.Text = row.Cells[3].Value.ToString().Trim();
            lblPlacaCarro.Text = row.Cells[4].Value.ToString().Trim();
            lblTipoTratamento.Text = row.Cells[5].Value.ToString().Trim();
            lblAgendamento.Text = row.Cells[6].Value.ToString().Trim();
            lblSituacao.Text = row.Cells[7].Value.ToString().Trim();
            lblDefeito.Text = row.Cells[8].Value.ToString().Trim();
            lblClienteCiente.Text = row.Cells[9].Value.ToString().Trim();
            txtObservacao.Text = row.Cells[10].Value.ToString().Trim();
            pbxFoto1.ImageLocation = row.Cells[11].Value.ToString().Trim();
            pbxFoto2.ImageLocation = row.Cells[12].Value.ToString().Trim();
            pbxFoto3.ImageLocation = row.Cells[13].Value.ToString().Trim();
            pbxFoto4.ImageLocation = row.Cells[14].Value.ToString().Trim();
            pbxFoto5.ImageLocation = row.Cells[15].Value.ToString().Trim();
        }
        private void dgvHistorico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cbxTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CheckController controller = new CheckController();
            if (cbxTipo.SelectedItem.ToString() == "Todos")
            {
                List<CheckOut> list = controller.listaCheckOut();
                dgvHistorico.DataSource = list;
            }
            else
            {
                List<CheckOut> check = controller.FiltrarPorTipo(cbxTipo.SelectedItem.ToString());
                dgvHistorico.DataSource = check;
            }

        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            CheckController controller = new CheckController();
            if (txtNomeCliente.Text == "")
            {
                MessageBox.Show("Por favor insira o nome para efetuar o filtro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                List<CheckOut> check = controller.FiltrarPorNome(txtNomeCliente.Text);
                if (check == null)
                {
                    MessageBox.Show("Cliente não encontrado, Por Favor verefique o nome dado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    dgvHistorico.DataSource = check;
                }
            }
        }
    }
}
