using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using peminjaman.Service;
using peminjaman.Services;

namespace peminjaman.View

{
    public partial class MonitorData : Form
    {
        public MonitorData()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MonitorData_Load(object sender, EventArgs e)
        {
            PinjamServ pjm = new PinjamServ();
            dgvdetailpinjam.DataSource = pjm.monitor();

            AlatServ alt = new AlatServ();
            dgvAlat.DataSource = alt.TampilSemua();
            //PinjamServ pj = new PinjamServ();
           // gvdetailpinjam.DataSource = pj.TampilSemuaPeminjam();
        }

        void EditAlat()
        {
            UbahAlat ua = new UbahAlat();

            if (dgvAlat.Rows.Count == 0)
            {
                MessageBox.Show("Data belum ada yang dipilih. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                ua.TxtKode.Text = this.dgvAlat.CurrentRow.Cells[0].Value.ToString();
                ua.TxtNama_alat.Text = this.dgvAlat.CurrentRow.Cells[1].Value.ToString();
                ua.TxtJenis_Alat.Text = this.dgvAlat.CurrentRow.Cells[2].Value.ToString();
                ua.TxtLetak.Text = this.dgvAlat.CurrentRow.Cells[3].Value.ToString();
                ua.TxtHarga.Text = this.dgvAlat.CurrentRow.Cells[4].Value.ToString();
                ua.TxtTahunPembelian.Text = this.dgvAlat.CurrentRow.Cells[5].Value.ToString();
                ua.TxtKondisi.Text = this.dgvAlat.CurrentRow.Cells[6].Value.ToString();

                ua.ShowDialog();
            }
        }

        private void dgvAlat_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dgvAlat_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            {
                dgvAlat[e.ColumnIndex, e.RowIndex].Style
                    .SelectionBackColor = Color.Blue;
            }
        }

        private void dgvAlat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            EditAlat();
        }

        private void dgvAlat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


        }
    }
}
