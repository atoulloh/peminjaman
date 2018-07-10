using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using peminjaman.Service;
//using peminjaman.Report;

namespace peminjaman.View
{
    public partial class Alat : Form
    {
        public Alat()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AlatServ asv = new AlatServ();
            try
            {
                if(asv.isExistAlat(dgvAlat.Rows[dgvAlat.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                {
                    if (MessageBox.Show("Apakah data tersebut akan dihapus?" , "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        asv.HapusAlat(dgvAlat.Rows[dgvAlat.CurrentCell.RowIndex].Cells[0].Value.ToString());
                        MessageBox.Show("Data Berhasil di hapus.  ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }

                else if (!asv.isExistAlat(dgvAlat.Rows[dgvAlat.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Belum ada data yang dipilih. ", " Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                catch
            {
                    MessageBox.Show("Terjadi kesalahan tidak dapat menghapus data !","Pesan",MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                 
            }

        }

        private void Btnkeluar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //menampilkan data
        public void LoadData()
        {
            AlatServ asv = new AlatServ();
            dgvAlat.DataSource = asv.TampilSemua();
        }

        private void Alat_Load(object sender, EventArgs e)
        {
            //full screen
            WindowState = FormWindowState.Maximized;

            //memanggil tampil data 
            LoadData();

            //hitung kode alat otomatis
            AlatServ asv = new AlatServ();
            int x = Convert.ToInt32(asv.HitungAlat().Rows[0][0].ToString());

            //hitung jumlah data di tampilkan di label
            labeljumlaha.Text = "Jumlah Alat : " + x.ToString();
            TxtCariAlat.Focus();

        }
        //cari alat
        private void BtnCari_Click(object sender, EventArgs e)
        {
            AlatServ alat = new AlatServ();
            dgvAlat.DataSource = alat.CekAlat(TxtCariAlat.Text);
        }
        //menampilkan form tambah
        private void BtnTambah_Click(object sender, EventArgs e)
        {
            TambahAlat ta = new TambahAlat();
            ta.ShowDialog();
        }

        //mengambil data dari datagridview dengan mengklik cellnya
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
        //ubah data
        //private void BtnUbah_Click(object sender, EventArgs e)
        //{
         //   EditAlat();
        //}
        //refres data
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnCetakAL_Click(object sender, EventArgs e)
        {

        }

        private void TxtCariAlat_TextChanged(object sender, EventArgs e)
        {
            //Txt.PerFormClik();
        }

        private void CmbCariAlat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CmbCariAlat.PerformClik();
        }

        //menampilkan form Tambah alat
        private void BtnTambah_Click_1(object sender, EventArgs e)
        {
            TambahAlat TA = new TambahAlat();
            TA.ShowDialog();
        }

        private void BtnUbah_Click_1(object sender, EventArgs e)
        {
            EditAlat();
        }

        private void TxtCariAlat_TextChanged_1(object sender, EventArgs e)
        {
            BtnCari.PerformClick();
        }

       /* String kategori;
        private void CmbCariAlat_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string x = CmbCariAlat.Text;

            switch (x)
            {
                case "Kode Alat":
                    kategori = "kode_alat";
                    break;

                case "Nama Alat":
                    kategori = "nama_alat";
                    break;

                case "Jenis Alat":
                    kategori = "jenis_alat";
                    break;

                case "Letak":
                    kategori = "letak";
                    break;

                case "Harga Beli":
                    kategori = "harga_pembelian";
                    break;

                case "Tahun Beli":
                    kategori = "tahun_pembelian";
                    break;

                case "Kondisi":
                    kategori = "kondisi";
                    break;
            }
        }*/

        private void Alat_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnCari_Click_1(object sender, EventArgs e)
        {
            AlatServ asv = new AlatServ();
            dgvAlat.DataSource = asv.CariAlat(TxtCariAlat.Text);
        }

        private void Btnkeluar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void labeljumlaha_Click(object sender, EventArgs e)
        {

        }

        private void dgvAlat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       // private void Alat_Load
    

    }
}
