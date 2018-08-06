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
    public partial class FrmKelas : Form
    {
        public FrmKelas()
        {
            InitializeComponent();
        }

        void Bersihkan()
        {
            txtkelas.Text = "";
            txtjurusan.Text = "";
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            AlatServ al = new AlatServ();

            if (string.IsNullOrEmpty(txtkelas.Text) || string.IsNullOrEmpty
               (txtjurusan.Text)) 
            {
                MessageBox.Show("mohon data di isi semua \nTidak boleh ada yang kosong ",
                    "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Bersihkan();
            }

            else
            {
                al.Kelas = txtkelas.Text.Trim();
                al.Jurusan = txtjurusan.Text.Trim();
                al.SimpanKelas();
                {

                    MessageBox.Show("Data berhasil di simpan, ",
                        "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                Bersihkan();
                LoadData();
            }
        }

        public void LoadData()
        {
            AlatServ al = new AlatServ();
            DGVKelas.DataSource = al.TampilKelas();
        }

        private void FrmKelas_Load(object sender, EventArgs e)
        {
            AlatServ al = new AlatServ();
            DGVKelas.DataSource = al.TampilKelas();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            AlatServ AL = new AlatServ();
            try
            {
                if (AL.IsKelas(DGVKelas.Rows[DGVKelas.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                {
                    if (MessageBox.Show("Apakah data tersebut akan dihapus?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        AL.HapusKelas(DGVKelas.Rows[DGVKelas.CurrentCell.RowIndex].Cells[0].Value.ToString());
                        MessageBox.Show("Data Berhasil di hapus.  ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                else if (!AL.IsKelas(DGVKelas.Rows[DGVKelas.CurrentCell.RowIndex].Cells[1].Value.ToString()))
                {
                    MessageBox.Show("Delum ada data yg dipilih.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Terjadi Kesalahan tidak dapat menghapus data !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
