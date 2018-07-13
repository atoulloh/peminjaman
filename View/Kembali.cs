using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using peminjaman.Service;

namespace peminjaman.View
{
    public partial class Kembali : Form
    {
        KembaliServ km = new KembaliServ();
        public Kembali()
        {
            InitializeComponent();

            grpdetailkembali.Left = 400;
            grpdetailkembali.Top = 100;
            grpdetailkembali.Width = 500;
            grpdetailkembali.Height = 200;
            grpdetailkembali.BringToFront();
            dgvdetailkembali.AutoGenerateColumns = false;

            grpdetailkembali.Visible = false;
        }

        private void Kembali_Load(object sender, EventArgs e)
        {
            KembaliServ km = new KembaliServ();
            TampilKembali();
            DgvKembali.DataSource = km.TampilKembali();

            
            int x = Convert.ToInt32(km.HitungKembali().Rows[0][0].ToString());

            labeljumlah.Text = "Jumlah Peminjam : " + DgvKembali.RowCount.ToString();

            WindowState = FormWindowState.Maximized;

            TxtCariDtKembali.Focus();


        }

        void TampilKembali()
        {
            KembaliServ km = new KembaliServ();
            DgvKembali.DataSource = km.TampilSemua();
        }


        private void BtnCetak_Click(object sender, EventArgs e)
        {

        }

        private void BtnBackAnggota_Click(object sender, EventArgs e)
        {

        }

        private void Kembali_Load_1(object sender, EventArgs e)
        {

            KembaliServ km = new KembaliServ();
            DgvKembali.DataSource = km.TampilKembali();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            TampilKembali();
        }
    }
}
