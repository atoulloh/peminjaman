using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using peminjaman.Model;
using SIPWB.Service;

namespace peminjaman.Service
{
    class AlatServ : AlatCls
    {
        private Koneksi dbConn;
        private DataTable dtTbl;
        private String query = "";
        private string tabel = "alat";
        private string tabelrusak = "alat_rusak";

        public AlatServ()
        {
            dbConn = new Koneksi();
            dtTbl = new DataTable();
        }

        public DataTable CekStatus(String lvl)
        {
            query = "select status from alat where nama_alat='" + lvl + "'";

            dtTbl = dbConn.ExecQuery(query);

            return dtTbl;
        }

       

        public void updatealat()
        {
            query =" update alat set jumlah = jumlah +'"+ Jumlah +"', jumlah_tersedia = jumlah_tersedia +'" + Jumlah +"' where kode_alat = '"+ Kode_Alat +"'";
             if (!(dbConn.ExecNonQuery(query) > 0))
            {
                throw new Exception("Gagal Memperbarui jumlah");
            }
        }

        public DataTable tampilcari()
        {
            query = "select a.kode_alat,a.nama_alat,a.jenis_alat,a.letak,a.harga_pembelian,a.tahun_pembelian,a.kondisi,dp.status from alat a, pinjaman dp where a.nama_alat = dp.nama_alat";
            dtTbl = dbConn.ExecQuery(query);

            return dtTbl;
        }

        public DataTable CekAlat(String a)
        {

            query = "SELECT * FROM alat WHERE nama_alat like '%" + a + "%'";
            dtTbl = dbConn.ExecQuery(query);

            return dtTbl;
        }

       
        public void SimpanAlat()
        {
           query = "INSERT INTO alat VALUES ('" + Kode_Alat + "','" + Nama_Alat + "','" + Jenis_Alat + "','" + Letak + "','"+ Jumlah + "','" + Jumlah_Tersedia + "','"
                + Harga_Pembelian + "','" + Tahun_Pembelian +  "')";

            if (!(dbConn.ExecNonQuery(query) > 0))
            {
                throw new Exception(" Gagal Menyimpan");
            }
        }

        public void SimpanKelas()
        {
            query = "insert into kelas values ('" + Kelas + "','" + Jurusan + "')";
            if (!(dbConn.ExecNonQuery(query) > 0))
            {
                throw new Exception("gagal menyimpan");
            }
        }

        public DataTable TampilKelas()
        {
            query = "select * from kelas";
            dtTbl = dbConn.ExecQuery(query);

            return dtTbl;
        }

        public DataTable Cekkelas(String a)
        {
            query = "SELECT * FROM kelas WHERE kelas like '%" + a + "%'";
            dtTbl = dbConn.ExecQuery(query);

            return dtTbl;
        }

        public void HapusKelas(String kelas)
        {
            query = "delete from kelas where kelas = '" + kelas + "'";
            if (!(dbConn.ExecNonQuery(query) > 0))
            {
                throw new Exception("Gagal Menghapus");
            }
        }

        public bool IsKelas(String Kelas)
        {
            bool cek = false;

            query = "SELECT * FROM kelas WHERE kelas = '" + Kelas + "'";
            dtTbl = dbConn.ExecQuery(query);

            if (dtTbl.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public void UbahAlat(String kode_alat)
        {
            query = "UPDATE alat SET nama_alat='" + Nama_Alat + "', jenis_alat='" + Jenis_Alat + "', letak='" + Letak + "', harga_pembelian='" + Harga_Pembelian + "', tahun_pembelian='" + Tahun_Pembelian + "' WHERE kode_alat='" + kode_alat + "'";

            if (!(dbConn.ExecNonQuery(query) > 0))
            {
                throw new Exception("Gagal Merubah");
            }
        }

        public void HapusAlat(String kode_alat)
        {
            query = "delete from alat where kode_alat='" + kode_alat + "'";
            if (!(dbConn.ExecNonQuery(query) > 0))
            {
                throw new Exception("Gagal Menghapus");
            }
        }

        public void HapusRusak(String nama_alat)
        {
            query = " delete from alat_rusak where nama_alat='" + nama_alat + "'";
            if (!(dbConn.ExecNonQuery(query) > 0))
            {
                throw new Exception("Gagal menghapus");
            }
        }

        public bool isExistAlat(String kode_alat)
        {
            bool cek = false;

            query = "SELECT * FROM alat WHERE kode_alat ='" + kode_alat + "'";
            dtTbl = dbConn.ExecQuery(query);

            if (dtTbl.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public bool isExistRusak(String nama_alat)
        {
            bool cek = false;

            query = "SELECT * FROM alat_rusak WHERE nama_alat ='" + nama_alat + "'";
            dtTbl = dbConn.ExecQuery(query);

            if (dtTbl.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }


        public DataTable TampilRusak()
        {
            query = "Select * from alat_rusak";
            dtTbl = dbConn.ExecQuery(query);
            return dtTbl;
        }

        public DataTable TampilSemua()
        {
            query = "SELECT *, jumlah-jumlah_tersedia as dipinjam FROM alat";
            dtTbl = dbConn.ExecQuery(query);
            return dtTbl;
        }

       

        public DataTable CariAlat(String a)
        {

            query = "SELECT * FROM alat WHERE nama_alat like '%" + a + "%'" +
                                        " OR kode_alat like '%" + a + "%'" +
                                        " OR jenis_alat like '%" + a + "%'" +
                                        " OR letak like '%" + a + "%'" +
                                        " OR harga_pembelian like '%" + a + "%'" +
                                        " OR tahun_pembelian like '%" + a + "%'";
                                       
            dtTbl = dbConn.ExecQuery(query); 


            return dtTbl;
        }

        public DataTable CariAl(String p, String q)
        {

            query = "SELECT * FROM alat WHERE " + q + " like '" + p + "%'";
            dtTbl = dbConn.ExecQuery(query);


            return dtTbl;
        }

        public DataTable CariRusak(String a)
        {
            return Query.Select(tabelrusak, a);
        }

        public DataTable HitungAlat()
        {
            query = "select count(*) from alat";
            dtTbl = dbConn.ExecQuery(query);

            return dtTbl;
        }

        public String KodeAlatOtomatis()
        {
            String kode = "";
            int alat = 0;

            query = "select ifnull(max(substring(kode_alat,5,4)),0) as idp from alat";
            dtTbl = dbConn.ExecQuery(query);

            if (dtTbl.Rows.Count > 0)
            {
                foreach (DataRow tmp in dtTbl.Rows)
                {
                    alat = Convert.ToInt32(tmp["idp"].ToString());
                }
            }

            if (alat >= 0 && alat <= 8)
            {
                kode = "ALT-" + "000" + Convert.ToString(alat + 1);
            }

            if (alat >= 9 && alat <= 98)
            {
                kode = "ALT-" + "00" + Convert.ToString(alat + 1);
            }

            if (alat >= 99 && alat <= 998)
            {
                kode = "ALT-" + "0" + Convert.ToString(alat + 1);
            }

            if (alat >= 999 && alat <= 9998)
            {
                kode = "ALT-" + "0" + Convert.ToString(alat + 1);
            }

            return kode;

        }

      
    }
}
