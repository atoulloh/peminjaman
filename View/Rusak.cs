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
    public partial class Rusak : Form
    {
        public Rusak()
        {
            InitializeComponent();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            TambahRusak TA = new TambahRusak();
            TA.ShowDialog();
        }

        public void LoadData()
        {
            AlatServ al = new AlatServ();
            dgvalatrusak.DataSource = al.TampilRusak();

            int sum = 0;
            for (int i = 0; i < dgvalatrusak.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvalatrusak.Rows[i].Cells[4].Value);
            }
            labelrusak.Text = " Jumlah Alat : " + sum.ToString();
        }


        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
