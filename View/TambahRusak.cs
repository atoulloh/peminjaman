﻿using System;
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
    public partial class TambahRusak : Form
    {
        public TambahRusak()
        {
            InitializeComponent();
        }

        void Bersihkan()
        {
            AlatServ al = new AlatServ();
            TxtKodeRusak.Text = "";
            TxtNama_alat_Rusak.Text = "";
            TxtJenis_Alat_Rusak.Text = "";
            TxtLetakRusak.Text = "";
            TxtJumlah.Text = "";

        }


        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            AlatServ asv = new AlatServ();

            if (string.IsNullOrEmpty(TxtKodeRusak.Text) || string.IsNullOrEmpty
                (TxtNama_alat_Rusak.Text) || string.IsNullOrEmpty
                (TxtJenis_Alat_Rusak.Text) || string.IsNullOrEmpty
                (TxtLetakRusak.Text) || string.IsNullOrEmpty
                (TxtJumlah.Text))
            {
                MessageBox.Show("mohon data di isi semua \nTidak boleh ada yang kosong ",
                   "Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                asv.Kode_Alat = TxtKodeRusak.Text.Trim();
                asv.Nama_Alat = TxtNama_alat_Rusak.Text.Trim();
                asv.Jenis_Alat = TxtJenis_Alat_Rusak.Text.Trim();
                asv.Letak = TxtLetakRusak.Text.Trim();
                asv.Jumlah = int.Parse(TxtJumlah.Text.Trim());
              //  asv.SimpanRusak();
             //   asv.updaterusak();
                {
                    MessageBox.Show("Data berhasil di simpan, ",
                        "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                Bersihkan();
                
                Close();
            }
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
