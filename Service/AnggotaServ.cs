using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using peminjaman.Model;


namespace peminjaman.Service
{
    class AnggotaServ : AnggotaCls
    {
        private Koneksi dbConn;
        private DataTable dtTbl;
        private String Query = "";

        public AnggotaServ()
        {
            dbConn = new Koneksi();
            dtTbl = new DataTable();
        }


        public void Simpan_Anggota()
        {
            Query = "INSERT INTO anggota VALUES ('" + ID_Anggota + "','" + Nis + "','" + Nama + "','" + Jenis_Kelamin + "','" + Kelas + "','" + Jurusan + "','" + No_Hp + "','" + Alamat + "')";
            if (!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }

        public void HapusAnggota(String nis)
        {
            Query = "DELETE from anggota WHERE nis='" + nis + "'";
            if (!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception("Gagal Merubah");
            }
        }

        public void Ubah(String id_anggota)
        {
            Query = "UPDATE anggota SET nis='" + Nis + "', nama='" + Nama + "', jenis_kelamin ='" + Jenis_Kelamin + "', kelas = '" + Kelas + "', jurusan='" + Jurusan + "', no_hp='" + No_Hp + "', alamat='" + Alamat + "' where id_anggota = '" + id_anggota + "'";
            if (!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception("Gagal Merubah");
            }
        }

        public DataTable auto()
        {
            Query = "Select count(*) from anggota";
            dtTbl = dbConn.ExecQuery(Query);
            return dtTbl;
        }

        public DataTable TampilSemua()
        {
            Query = "SELECT * FROM anggota";
            dtTbl = dbConn.ExecQuery(Query);
            return dtTbl;
        }

        public bool isExist(String Nis)
        {
            bool cek = false;

            Query = "SELECT * FROM anggota WHERE nis = '" + Nis + "'";
            dtTbl = dbConn.ExecQuery(Query);

            if (dtTbl.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public void kode()
        {
            Query = "select id_anggota from anggota where id)anggota in(select max(id_anggota) from anggota) order by id_anggota desc";

            if (!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception("Gagal ");
            }
        }

        public DataTable CariAnggota(String a, String b)
        {
            Query = " SELECT * FROM anggota WHERE  " + b + " like '" + a + "%'";
            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }

        public DataTable HitungAnggota()
        {
            Query = " Select count(*) from anggota";
            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }

        public String IDAnggotaOtomatis()
        {
            String kode = "";
            int ida = 0;

            Query = " select ifnull(max(substring(id_anggota,5,4)),0) as idp from anggota";
            dtTbl = dbConn.ExecQuery(Query);

            if (dtTbl.Rows.Count > 0)
            {
                foreach (DataRow tmp in dtTbl.Rows)
                {
                    ida = Convert.ToInt32(tmp["idp"].ToString());
                }
            }

            if (ida >= 0 && ida <= 8)
            {
                kode = "IDA-" + "000" + Convert.ToString(ida + 1);
            }
            else if (ida >= 9 && ida <= 98)
            {
                kode = "IDA-" + "00" + Convert.ToString(ida + 1);
            }
            else if (ida >= 99 && ida <= 998)
            {
                kode = "IDA-" + "0" + Convert.ToString(ida + 1);
            }
            else if (ida >= 999 && ida <= 9998)
            {
                kode = "IDA-" + Convert.ToString(ida + 1);
            }

            return kode;
        }

        public DataTable CariIDAg(String a)
        {
            Query = "SELECT id_anggota FROM anggota WHERE nama='" + a + "'";
            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }
        public DataTable CekAnggota(String a)
        {
            Query = "SELECT * FROM anggota WHERE nama like '%" + a + "%'";
            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }

       // internal object CariAnggota(string p)
        //{
          //  throw new NotImplementedException();
        //}
    }
}
