using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using peminjaman.Services;
using peminjaman.Service;
using peminjaman.Reports;

namespace peminjaman.View
{
    public partial class Hilang : Form
    {
        public Hilang()
        {
            InitializeComponent();
        }



        private void DgvKNamaAlat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Hilang_Load(object sender, EventArgs e)
        {
            KembaliServ km = new KembaliServ();
            dgvhilang.DataSource =km.Hilang();

            int sum = 0;
            for (int i = 0; i < dgvhilang.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvhilang.Rows[i].Cells[6].Value);
            }
            labelhilang.Text = " Jumlah Alat Hilang : " + sum.ToString();

            //int x = Convert.ToInt32(km.HitungHilang().Rows[0][0].ToString());

            //labelhilang.Text = "Jumlah Alat Hilang : " + dgvhilang.RowCount.ToString();

            //TxtCariDtKembali.Focus();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            KembaliServ km = new KembaliServ();
            dgvhilang.DataSource = km.Hilang();
        }

        private void BtnCetak_Click(object sender, EventArgs e)
        {
            Hilang al = new Hilang();
            FrmLaporanHilang rp = new FrmLaporanHilang();
            rp.Show();
        }
    }
}
