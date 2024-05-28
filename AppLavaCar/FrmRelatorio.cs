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
        }

        private void dgvHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvHistorico.Rows[e.RowIndex];
            this.dgvHistorico.Rows[e.RowIndex].Selected = true;
            lblNomeCliente.Text = row.Cells[1].Value.ToString();
            lblCPF.Text = row.Cells[2].Value.ToString();
            lblTelefone.Text = row.Cells[3].Value.ToString();
            lblPlacaCarro.Text = row.Cells[4].Value.ToString();
            lblTipoTratamento.Text = row.Cells[5].Value.ToString();
            lblAgendamento.Text = row.Cells[6].Value.ToString();
            lblDefeito.Text = row.Cells[7].Value.ToString();
            lblClienteCiente.Text = row.Cells[8].Value.ToString();
            txtObservacao.Text = row.Cells[9].Value.ToString();
            pbxFoto1.ImageLocation = row.Cells[10].Value.ToString();
            pbxFoto2.ImageLocation = row.Cells[11].Value.ToString();
            pbxFoto3.ImageLocation = row.Cells[12].Value.ToString();
            pbxFoto4.ImageLocation = row.Cells[13].Value.ToString();
            pbxFoto5.ImageLocation = row.Cells[14].Value.ToString();
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

    }
}
