using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using peminjaman.Service;
using peminjaman.Reports;

namespace peminjaman.View
{
    public partial class Anggota : Form
    {

        public Anggota()
        {
            InitializeComponent();
        }

        //Menampilkan Data
        private void Anggota_Load(object sender, EventArgs e)
        {
            //Full Screen
            WindowState = FormWindowState.Maximized;

            //memanggil tampil anggota
            LoadData();

            //hitung jumlah alat  otomatis
            AnggotaServ agt1 = new AnggotaServ();
            int X = Convert.ToInt32(agt1.HitungAnggota().Rows[0][0].ToString());

            //hitung jumlah anggota di tampilkan di label
           labeljumlahag.Text = "Jumlah Anggota : " + X.ToString();
           TxtCariAg.Focus();
               
        }
        //Menampilkan isi data
        public void LoadData()
        {
            AnggotaServ agt = new AnggotaServ();
            DgvAnggota.DataSource = agt.TampilSemua();
        }
        //refres data
        private void BtnRefAg_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        //Get Data
        void Edit()
        {
            EditAnggota EA = new EditAnggota();

            if (DgvAnggota.Rows.Count == 0)
            {
                MessageBox.Show("data belum ada yang dipili.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                EA.TxtIdAnggota.Text = this.DgvAnggota.CurrentRow.Cells[0].Value.ToString();
                EA.TxtNIM.Text = this.DgvAnggota.CurrentRow.Cells[1].Value.ToString();
                EA.TxtNama.Text = this.DgvAnggota.CurrentRow.Cells[2].Value.ToString();
                EA.TxtJenisKelamin.Text = this.DgvAnggota.CurrentRow.Cells[3].Value.ToString();
                EA.TxtKelas.Text = this.DgvAnggota.CurrentRow.Cells[4].Value.ToString();
                EA.TxtJurusan.Text = this.DgvAnggota.CurrentRow.Cells[5].Value.ToString();
                EA.txtNoHp.Text = this.DgvAnggota.CurrentRow.Cells[6].Value.ToString();
                EA.TxtAlamat.Text = this.DgvAnggota.CurrentRow.Cells[7].Value.ToString();

                EA.ShowDialog();
            }
        }

        //Keluar
        private void BtnBackAnggota_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEditAg_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void BtnCari_Click(object sender, EventArgs e)
        {
            AnggotaServ ag = new AnggotaServ();
            DgvAnggota.DataSource = ag.CariAnggota(TxtCariAg.Text, Kategori);
        }

        //kategori pencarian anggota
        String Kategori;
        private void CmbCariAnggota_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = CmbCariAnggota.Text;

            switch (x)
            {
                case "ID Anggota":
                 Kategori ="id_anggota";
                    break;
                case "Nis":
                    Kategori ="nis";
                    break;
                case "Nama":
                    Kategori = "nama";
                    break;
                case "Jenis Kelamin":
                    Kategori = "jenis_kelamin";
                    break;
                case "Kelas":
                    Kategori = "kelas";
                    break;
                case "Jurusan":
                    Kategori = "jurusan";
                    break;
                case "Alamat":
                    Kategori = "alamat";
                    break;

            }

        }

        private void TxtCariAg_TextChanged(object sender, EventArgs e)
        {
            BtnCari.PerformClick();
        }

        //Hapus Anggota
        private void BtnHapusAg_Click(object sender, EventArgs e)
        {
            AnggotaServ AGS = new AnggotaServ();
            try
            {
                if(AGS.isExist(DgvAnggota.Rows[DgvAnggota.CurrentCell.RowIndex].Cells[1].Value.ToString()))
                {
                    if (MessageBox.Show("Apakah data tersebut akan dihapus?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        AGS.HapusAnggota(DgvAnggota.Rows[DgvAnggota.CurrentCell.RowIndex].Cells[1].Value.ToString());
                        MessageBox.Show("Data Berhasil di hapus.  ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                else if (!AGS.isExist(DgvAnggota.Rows[DgvAnggota.CurrentCell.RowIndex].Cells[1].Value.ToString()))
                {
                    MessageBox.Show("Delum ada data yg dipilih.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Terjadi Kesalahan tidak dapat menghapus data !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labeljumlahag_Click(object sender, EventArgs e)
        {

        }

        private void Anggota_Load_1(object sender, EventArgs e)
        {
            LoadData();
            int numRows = DgvAnggota.Rows.Count;
            labeljumlahag.Text = " Jumlah Anggota : " + numRows.ToString();
        }

        private void BtnCetakAg_Click(object sender, EventArgs e)
        {
            Anggota ag = new Anggota();
            FrmLaporanAnggota rp = new FrmLaporanAnggota();
            rp.Show();
        }


    }
}
