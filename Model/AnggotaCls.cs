using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace peminjaman.Model
{
    class AnggotaCls
    {
        private String _id_anggota;
        private String _nis;
        private String _nama;
        private String _jenis_kelamin;
        private String _kelas;
        private String _jurusan;
        private int _no_hp;
        private String _alamat;
        private String _status;


        public AnggotaCls()
        {
            _id_anggota = "";
            _nis = "";
            _nama = "";
            _jenis_kelamin = "";
            _kelas = "";
            _jurusan = "";
            _no_hp = 0;
            _alamat = "";
            _status = "";
        }

        public String ID_Anggota
        {
            set { _id_anggota = value; }
            get { return _id_anggota; }
        }

        public String Nis
        {
            set { _nis = value; }
            get { return _nis; }
        }
        public String Nama
        {
            set { _nama = value; }
            get { return _nama; }
        }
        public String Jenis_Kelamin
        {
            set { _jenis_kelamin = value; }
            get { return _jenis_kelamin; }
        }
        public String Kelas
        {
            set;
            get;
        }
        public String Jurusan
        {
            set { _jurusan = value; }
            get { return _jurusan; }
        }
        public string No_Hp
        {
            set;
            get;
        }
        public String Alamat
        {
            set { _alamat = value; }
            get { return _alamat; }
        }
        public String Status
        {
            set { _status = value; }
            get { return _status; }
        }

    }
}
