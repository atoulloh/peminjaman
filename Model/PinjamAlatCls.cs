using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace peminjaman.Model
{
    class PinjamAlatCls
    {
        private String _id_peminjaman;
        private String _id_pinjaman;
        private String _id_anggota;
        private String _nama;
        private String _kode_alat;
        private String _nama_alat;
        private int _jumlah;
        private int _jumlah_tot;
        private String _jam_pinjam;
        private String _tanggal_pinjam;

        public PinjamAlatCls()
        {
            _id_peminjaman = "";
            _id_pinjaman = "";
            _id_anggota = "";
            _nama = "";
            _kode_alat = "";
            _nama_alat = "";
            _jumlah_tot = 0;
            _jumlah = 0;
            _jam_pinjam = "";
            _tanggal_pinjam = "";
        }

        public String IdPeminjaman
        {
            set { _id_peminjaman = value; }
            get { return _id_peminjaman; }
        }

        public string IdPinjaman
        {
            set { _id_pinjaman = value; }
            get { return _id_pinjaman; }
        }

        public String IdAnggota
        {
            set { _id_anggota = value; }
            get { return _id_anggota; }
        }

        public String Nama
        {
            set { _nama = value; }
            get { return _nama; }
        }

        public String Kode_Alat
        {
            set { _kode_alat = value; }
            get { return _kode_alat; }
        }

        public String Nama_Alat
        {
            set { _nama_alat = value; }
            get { return _nama_alat; }
        }

        public int Jumlah
        {
            set { _jumlah = value; }
            get { return _jumlah; }
        }
        public int Jumlah_Tot
        {
            set { _jumlah_tot = value; }
            get { return _jumlah_tot; }
        }

        public String Jam_Pinjam
        {
            set { _jam_pinjam = value; }
            get { return _jam_pinjam; }
        }

        public String Tanggal_Pinjam
        {
            set { _tanggal_pinjam = value; }
            get { return _tanggal_pinjam; }
        }

    }
}
