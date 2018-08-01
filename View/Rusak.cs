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

        private void Rusak_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnHapus_Click(object sender, EventArgs e)
        {
            AlatServ asv = new AlatServ();
            try
            {
                if (asv.isExistRusak(dgvalatrusak.Rows[dgvalatrusak.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                {
                    if (MessageBox.Show("Apakah data tersebut akan dihapus?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        asv.HapusRusak(dgvalatrusak.Rows[dgvalatrusak.CurrentCell.RowIndex].Cells[0].Value.ToString());
                        MessageBox.Show("Data Berhasil di hapus.  ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }

                else if (!asv.isExistRusak(dgvalatrusak.Rows[dgvalatrusak.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Belum ada data yang dipilih. ", " Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Terjadi kesalahan tidak dapat menghapus data !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}
