using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace peminjaman.Model
{
    class KembaliCls
    {
        private String _id_peminjaman;
        private String _id_pinjaman;
        private String _id_anggota;
        private String _nama;
        private String _kode_alat;
        private String _nama_alat;
        private int _jumlah;
        private int _jumlah_tot;
        private String _tanggal_pinjam;
        private String _tanggal_kembali;
        private String _letak;

        public KembaliCls()
        {
            _id_peminjaman = "";
            _id_pinjaman = "";
            _id_anggota = "";
            _nama = "";
            _kode_alat = "";
            _nama_alat = "";
            _jumlah = 0;
            _jumlah_tot = 0;
            _tanggal_pinjam = "";
            _tanggal_kembali = "";
            _letak = "";
        }

        public String IdPeminjaman
        {
            set { _id_peminjaman = value; }
            get { return _id_peminjaman; }
        }

        public String IdPinjaman
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

        public String KodeAlat
        {
            set { _kode_alat = value; }
            get { return _kode_alat; }
        }

        public String NamaAlat
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

        public String TanggalPinjam
        {
            set { _tanggal_pinjam = value; }
            get { return _tanggal_pinjam; }
        }

        public String TanggalKembali
        {
            set { _tanggal_kembali = value; }
            get { return _tanggal_kembali; }
        }

        public string Status { get; set; }

        public int AlatHilang { get; set; }

        public int HilangAlat { get; set; }

        public String Letak
        {
            set { _letak = value; }
            get { return _letak; }
        }
    }
}