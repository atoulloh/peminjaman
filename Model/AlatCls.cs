using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace peminjaman.Model
{
    class AlatCls
    {
        private String _kode_alat;
        private String _nama_alat;
        private String _jenis_alat;
        private String _letak;
        private int _harga_pembelian;
        private int _tahun_pembelian;
        private int _jumlah;
        private int _jumlah_tersedia;
        private String _kondisi;

        public AlatCls()
        {
            _kode_alat = "";
            _nama_alat = "";
            _jenis_alat = "";
            _letak = "";
            _harga_pembelian = 0;
            _tahun_pembelian = 0;
            _jumlah = 0;
            _jumlah_tersedia = 0;
            _kondisi = "";
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
        public String Jenis_Alat
        {
            set { _jenis_alat = value; }
            get { return _jenis_alat; }
        }
        public String Letak
        {
            set { _letak = value; }
            get { return _letak; }
        }

        public int Harga_Pembelian
        {
            set { _harga_pembelian = value; }
            get { return _harga_pembelian; }
        }

        public int Tahun_Pembelian
        {
            set { _tahun_pembelian = value; }
            get { return _tahun_pembelian; }
        }
        public int Jumlah
        {
            set { _jumlah = value; }
            get { return _jumlah; }
        }

        public int Jumlah_Tersedia
        {
            set { _jumlah_tersedia = value; }
            get { return _jumlah_tersedia; }
        }


        public String Kondisi
        {
            set { _kondisi = value; }
            get { return _kondisi; }
        }

    }
}
