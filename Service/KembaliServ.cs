using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using peminjaman.Model;
using System.Data;


namespace peminjaman.Service
{
    class KembaliServ : KembaliCls
    {
        private Koneksi dbConn;
        private DataTable dtTbl;
        private String Query = "";

        public KembaliServ()
        {
            dbConn = new Koneksi();
            dtTbl = new DataTable();
        }

        public void Simpan_Kembali()
        {
            Query = "INSERT INTO kembali (id_peminjaman,id_anggota,nama,jumlah,tanggal_pinjam,tanggal_kembali) VALUES ('" + IdPeminjaman + "','" + IdAnggota + "','" + Nama + "','" + Jumlah + "','" + TanggalPinjam + "','" + TanggalKembali + "')";
            if (!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }

        public void Simpan_Detail_kembali()
        {
            Query = " INSERT INTO detail_kembali(id_peminjaman,id_pinjaman,nama_alat) VALUES ('" + IdPeminjaman + "','" + IdPinjaman + "','"  + NamaAlat + "')";
            if(!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }

        public void Hapus_Kembali(String id_peminjaman)
        {
            Query = "DELETE from kembali WHERE id_peminjaman = '" + id_peminjaman + "'";
            if (!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }

        public DataTable auto()
        {
            Query = "select count (*) from kembali";
            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }

        public DataTable TampilSemua()
        {
            Query = "SELECT * FROM kembali";
            dtTbl = dbConn.ExecQuery(Query);
            return dtTbl;
        }

        public bool isExist(String IdPeminjaman)
        {
            bool cek = false;

            Query = "SELECT * FROM kembali WHERE id_peminjaman = '" + IdPeminjaman + "'";
            dtTbl = dbConn.ExecQuery(Query);

            if (dtTbl.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public DataTable CariKembali(String a, String b)
        {
            Query = " SELECT * FROM kembali WHERE  " + b + " like '" + a + "%'";
            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }

        public DataTable HitungKembali()
        {
            Query = " Select count(*) from kembali";
            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }

        public DataTable CekKembali(String a)
        {
            Query = "SELECT * FROM kembali WHERE id_peminjaman like '%" + a + "%'";
            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }

    }
}
