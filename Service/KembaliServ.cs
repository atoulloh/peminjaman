using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using peminjaman.Model;
using System.Data;
using SIPWB.Service;

namespace peminjaman.Service
{
    class KembaliServ : KembaliCls
    {
        private Koneksi dbConn;
        private DataTable dtTbl;
        private String query = "";
        private string tabelPinj = "pinjaman";
        private string tabelPeminjaman = " peminjam";
        private string tabel = "kembali";
        public KembaliServ()
        {
            dbConn = new Koneksi();
            dtTbl = new DataTable();
        }

        public void jumlahhilang()
        {
            string[] qs = {
               // "update pinjaman set jumlah_tot = jumlah_tot -'" + Jumlah + "' where id_pinjaman = '"+IdPinjaman+ "'",
                "update alat set jumlah = jumlah - '" + AlatHilang +"' where nama_alat = '" + NamaAlat +"'",
            };
            foreach (string q in qs)
            {
                if (!(dbConn.ExecNonQuery(q) > 0))
                {
                    throw new Exception("Gagal Memperbarui jumlah");
                }
            }
        }

        public void perbaruijumlahkembali()
        {
            query = "update alat set jumlah_tersedia = jumlah_tersedia + " + Jumlah_Tot + " where nama_alat ='" + NamaAlat + "'";
            if (!(dbConn.ExecNonQuery(query) > 0))
            {
                throw new Exception("Gagal Memperbarui jumlah");
            }
        }

        public void Simpan_Hilang()
        {
            query = "INSERT INTO alat_hilang (id_peminjaman,id_anggota,nama,jumlah,id_pinjaman,nama_alat,letak) VALUES ('" + IdPeminjaman + "','" + IdAnggota + "','" + Nama + "','" + Jumlah +"','" + IdPinjaman + "',' " +NamaAlat+"','" +Letak+ "')";
            if (!(dbConn.ExecNonQuery(query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }
        public void Simpan_Kembali()
        {
            query = "INSERT INTO kembali (id_peminjaman,id_anggota,nama,jumlah,tanggal_pinjam,tanggal_kembali) VALUES ('" + IdPeminjaman + "','" + IdAnggota + "','" + Nama + "','" + Jumlah + "','" + TanggalPinjam + "','" + TanggalKembali + "')";
            if (!(dbConn.ExecNonQuery(query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }

        public void Simpan_Detail_kembali()
        {
            query = " INSERT INTO detail_kembali(id_peminjaman,id_pinjaman,nama_alat,status) VALUES ('" + IdPeminjaman + "','" + IdPinjaman + "','"  + NamaAlat + "'," + Status + "')";
            if(!(dbConn.ExecNonQuery(query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }

        public void Hapus_Kembali(String id_peminjaman)
        {
            query = "DELETE from kembali WHERE id_peminjaman = '" + id_peminjaman + "'";
            if (!(dbConn.ExecNonQuery(query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }

        public DataTable auto()
        {
            query = "select count (*) from kembali";
            dtTbl = dbConn.ExecQuery(query);

            return dtTbl;
        }

        public DataTable TampilSemua()
        {
            //Query = "SELECT * FROM kembali";
            //dtTbl = dbConn.ExecQuery(Query);
            //return dtTbl;
            return Query.Select("kembali","");
        }

        public DataTable TampilKembali(String id_peminjaman)
        {
            query = " select * from kembali where id_peminjaman = '" + id_peminjaman + "'";
            dtTbl = dbConn.ExecQuery(query);

          //  if (dtTbl.Rows.Count > 0)
           // {
           //     CekKembali = true;
          //  }

            return dtTbl;
        }

        public DataTable Hilang()
        {
            query = "SELECT * FROM alat_hilang";
            dtTbl = dbConn.ExecQuery(query);
            return dtTbl;
        }
        public bool isExist(String IdPeminjaman)
        {
            bool cek = false;

            query = "SELECT * FROM kembali WHERE id_peminjaman = '" + IdPeminjaman + "'";
            dtTbl = dbConn.ExecQuery(query);

            if (dtTbl.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public DataTable CariKembali(String a, String b)
        {
           // query = " SELECT * FROM kembali WHERE  " + b + " like '" + a + "%'";
           // dtTbl = dbConn.ExecQuery(query);
           // return dtTbl;
            return Query.Select(tabel, a);
        }

        public DataTable HitungKembali()
        {
            query = " Select count(*) from kembali";
            dtTbl = dbConn.ExecQuery(query);

            return dtTbl;
        }

        public DataTable HitungHilang()
        {
            query = "Select count(*) from alat_hilang";
            dtTbl = dbConn.ExecQuery(query);

            return dtTbl;
        }

        public DataTable CekKembali(String a)
        {
            query = "SELECT * FROM kembali WHERE id_peminjaman like '%" + a + "%'";
            dtTbl = dbConn.ExecQuery(query);

            return dtTbl;
        }


        internal object TampilKembali()
        {
            throw new NotImplementedException();
        }

        public bool UbahStatusPijaman()
        {
            var data = new Dictionary<string, object>();
            data.Add("tanggal_kembali", TanggalKembali);
            data.Add("status", Status);

            var where = new Dictionary<string, object>();
            where.Add("id_pinjaman", IdPinjaman);

            return Query.Update(tabelPinj, data, where);
        }

        public bool UbahStatusPeminjaman()
        {
            var data = new Dictionary<string, object>();
            data.Add("status", Status);

            var where = new Dictionary<string, object>();
            where.Add("id_peminjaman", IdPeminjaman);

            return Query.Update(tabelPeminjaman, data, where);
        }

    }
}
