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
    public partial class UbahAlat : Form
    {
        AlatServ asv = new AlatServ();

        public UbahAlat()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        //bersihkan textbox
        void Bersihkan()
        {
            //AlatServ asv = new AlatServ();
            TxtKode.Text = "";
            TxtNama_alat.Text = "";
            TxtJenis_Alat.Text = "";
            TxtLetak.Text = "";
            TxtHarga.Text = "";
            TxtTahunPembelian.Text = "";
           // TxtJumlah.Text = "";
            //TxtKondisi.Text = "";
        }
        //ubah data
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtKode.Text) || string.IsNullOrEmpty
               (TxtNama_alat.Text) || string.IsNullOrEmpty
               (TxtJenis_Alat.Text) || string.IsNullOrEmpty
               (TxtLetak.Text) || string.IsNullOrEmpty
               (TxtHarga.Text) || string.IsNullOrEmpty
               (TxtTahunPembelian.Text)) //|| string.IsNullOrEmpty
              // (TxtJumlah.Text) || string.IsNullOrEmpty
             //  (TxtKondisi.Text))
            {
                MessageBox.Show("mohon data di isi semua \nTidak boleh ada yang kosong ",
                    "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (asv.isExistAlat(TxtKode.Text))
            {
                asv.Kode_Alat = TxtKode.Text.Trim();
                asv.Nama_Alat = TxtNama_alat.Text.Trim();
                asv.Jenis_Alat = TxtJenis_Alat.Text.Trim();
                asv.Letak = TxtLetak.Text.Trim();
                asv.Harga_Pembelian = int.Parse(TxtHarga.Text.Trim());
                asv.Tahun_Pembelian = int.Parse(TxtTahunPembelian.Text.Trim());
                //asv.Jumlah = int.Parse(TxtJumlah.Text.Trim());
               // asv.Kondisi = TxtKondisi.Text.Trim();
                asv.UbahAlat(TxtKode.Text.Trim());

                MessageBox.Show("Data Berhasil di Ubah. ",
                 "Information", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                Bersihkan();
                Close();
            }

            else
            {
                MessageBox.Show("Mohon data di isi semua \nTidak boleh ada yang kosong ",
                   "Information", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
        }

        private void UbahAlat_Load(object sender, EventArgs e)
        {

        }
    }
}
