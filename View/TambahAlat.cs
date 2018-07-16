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
    public partial class TambahAlat : Form
    {
        public TambahAlat()
        {
            InitializeComponent();
        }


        //membersihkan textbox

        void Bersihkan()
        {
            AlatServ asv = new AlatServ();
            TxtKode.Text = asv.KodeAlatOtomatis();
            TxtNama_alat.Text = "";
            TxtJenis_Alat.Text = "";
            TxtLetak.Text = "";
            TxtHarga.Text = "";
            TxtTahunPembelian.Text = "";
           // TxtJumlah.Text = "";
            TxtKondisi.Text = "";
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
           
            AlatServ asv = new AlatServ();

            if (string.IsNullOrEmpty(TxtKode.Text) || string.IsNullOrEmpty
                (TxtNama_alat.Text) || string.IsNullOrEmpty
                (TxtJenis_Alat.Text) || string.IsNullOrEmpty
                (TxtLetak.Text) || string.IsNullOrEmpty
                (TxtHarga.Text) || string.IsNullOrEmpty
                (TxtTahunPembelian.Text) || string.IsNullOrEmpty
               // (TxtJumlah.Text) || string.IsNullOrEmpty
                (TxtKondisi.Text))
            {
                MessageBox.Show("mohon data di isi semua \nTidak boleh ada yang kosong ",
                    "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Bersihkan();
            }

            else
            {
                asv.Kode_Alat = TxtKode.Text.Trim();
                asv.Nama_Alat = TxtNama_alat.Text.Trim();
                asv.Jenis_Alat = TxtJenis_Alat.Text.Trim();
                asv.Letak = TxtLetak.Text.Trim();
                asv.Harga_Pembelian = int.Parse(TxtHarga.Text.Trim());
                asv.Tahun_Pembelian = int.Parse(TxtTahunPembelian.Text.Trim());
               // asv.Jumlah = int.Parse(TxtJumlah.Text.Trim());
                asv.Kondisi = TxtKondisi.Text.Trim();
                asv.SimpanAlat();
                {

                    MessageBox.Show("Data berhasil di simpan, ",
                        "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                Bersihkan();
                Close();
                Alat al = new Alat();
                al.LoadData();
                al.Close();
                
            }

        }

        //keluar
        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TambahAlat_Load(object sender, EventArgs e)
        {
            AlatServ asv = new AlatServ();

            TxtKode.Text = asv.KodeAlatOtomatis();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
