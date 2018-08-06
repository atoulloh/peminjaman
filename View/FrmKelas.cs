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
                //grpAlat.Visible = false;
            }
        }

        private void FrmKelas_Load(object sender, EventArgs e)
        {
            AlatServ al = new AlatServ();
            DGVKelas.DataSource = al.TampilKelas();
        }
    }
}
