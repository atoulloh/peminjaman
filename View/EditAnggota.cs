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
    public partial class EditAnggota : Form
    {
        public EditAnggota()
        {
            InitializeComponent();
        }


        //untuk membersihkan textbox
        void Bersihkan()
        {
            TxtIdAnggota.Text = "";
            TxtNIM.Text = "";
            TxtNama.Text = "";
            TxtJenisKelamin.Text = "";
            TxtKelas.Text = "";
            TxtJurusan.Text = "";
            txtNoHp.Text = "";
            TxtAlamat.Text = "";
        }

        //refres data
        void LoadData()
        {
            AnggotaServ agg = new AnggotaServ();
            Anggota ga = new Anggota();
           // ga.DgvAnggota.DataSource = agg.TampilSemua();
        }
        private void TxtAlamatDaf_TextChanged(object sender, EventArgs e)
        {

        }
        //edit data anggota
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            AnggotaServ ps = new AnggotaServ();
            Anggota a = new Anggota();

            if (string.IsNullOrEmpty(TxtIdAnggota.Text) ||
                string.IsNullOrEmpty(TxtNIM.Text) ||
                string.IsNullOrEmpty(TxtNama.Text) ||
                string.IsNullOrEmpty(TxtJenisKelamin.Text) ||
                string.IsNullOrEmpty(TxtKelas.Text) ||
                string.IsNullOrEmpty(TxtJurusan.Text) ||
                string.IsNullOrEmpty(txtNoHp.Text) ||
                string.IsNullOrEmpty(TxtAlamat.Text))
            {
                MessageBox.Show("Mohon data di isi semua \nTidak ada yang kosong",
                    "Informtion", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                ps.Nis = TxtNIM.Text.Trim();
                ps.Nama = TxtNama.Text.Trim();
                ps.Jenis_Kelamin = TxtJenisKelamin.Text.Trim();
                    ps.Kelas = TxtKelas.Text.Trim();
                ps.Jurusan = TxtJurusan.Text.Trim();
                ps.No_Hp = txtNoHp.Text.Trim();
                ps.Alamat = TxtAlamat.Text.Trim();
                ps.Ubah(TxtIdAnggota.Text.Trim());

                if (MessageBox.Show("Data Berhasil di Simpan. ",
                    "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Bersihkan();
                    Close();
                }
            }

        }
    }
}
