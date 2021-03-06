﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using peminjaman.Service;
using peminjaman.Services;
using peminjaman.Reports;

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

            LabelPengembali.Text = "Jumlah Pengembali : " + DgvKembali.RowCount.ToString();

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

        private void textkembali_TextChanged(object sender, EventArgs e)
        {
            PinjamServ pjm = new PinjamServ();
            //PinjamServ km = PinjamServ();
            dgvdetailkembali.DataSource = pjm.TampilPinjaman(textkembali.Text);
 
        }
        private void DgvKembali_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PinjamServ pjm = new PinjamServ();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DgvKembali.Rows[e.RowIndex];

                textkembali.Text = row.Cells[0].Value.ToString();
                //TxtNamaAnggota.Text = row.Cells[1].Value.ToString();

                grpdetailkembali.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpdetailkembali.Visible = false;
        }

        private void BtnCetak_Click(object sender, EventArgs e)
        {
            Kembali al = new Kembali();
            FrmLaporanKembali rp = new FrmLaporanKembali();
            rp.Show();
        }

        private void TxtCariDtKembali_TextChanged(object sender, EventArgs e)
        {
           // btncari.PerformClick();
            KembaliServ kembali = new KembaliServ();
            DgvKembali.DataSource = kembali.CariKembali(TxtCariDtKembali.Text, "").DefaultView;
        }

        private void btncari_Click(object sender, EventArgs e)
        {
          
        }
    }
}
