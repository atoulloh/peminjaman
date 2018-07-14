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
            TampilKembali();

        }

        private void Kembali_Load(object sender, EventArgs e)
        {
            TampilKembali();
            KembaliServ km = new KembaliServ();
            int x = Convert.ToInt32(km.HitungKembali().Rows[0][0].ToString());

            labeljumlah.Text = "Jumlah Peminjam : " + DgvKembali.RowCount.ToString();

            TxtCariDtKembali.Focus();
        }

        private void TampilKembali()
        {
            try
            {
                KembaliServ km = new KembaliServ();
                DgvKembali.DataSource = km.TampilSemua().DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            TampilKembali();
        }
    }
}
