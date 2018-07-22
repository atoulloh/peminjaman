using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using peminjaman.Model;
using SIPWB.Service;

namespace peminjaman.Service
{
    class AnggotaServ : AnggotaCls
    {
        private Koneksi dbConn;
        private DataTable dtTbl;
        private String query = "";
        private string tabelanggota = "anggota";

        public AnggotaServ()
        {
            dbConn = new Koneksi();
            dtTbl = new DataTable();
        }


        public void Simpan_Anggota()
        {
            query = "INSERT INTO anggota VALUES ('" + ID_Anggota + "','" + Nis + "','" + Nama + "','" + Jenis_Kelamin + "','" + Kelas + "','" + Jurusan + "','" + No_Hp + "','" + Alamat + "')";
            if (!(dbConn.ExecNonQuery(query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }

        public void HapusAnggota(String nis)
        {
            query = "DELETE from anggota WHERE nis='" + nis + "'";
            if (!(dbConn.ExecNonQuery(query) > 0))
            {
                throw new Exception("Gagal Merubah");
            }
        }

        public void Ubah(String id_anggota)
        {
            query = "UPDATE anggota SET nis='" + Nis + "', nama='" + Nama + "', jenis_kelamin ='" + Jenis_Kelamin + "', kelas = '" + Kelas + "', jurusan='" + Jurusan + "', no_hp='" + No_Hp + "', alamat='" + Alamat + "' where id_anggota = '" + id_anggota + "'";
            if (!(dbConn.ExecNonQuery(query) > 0))
            {
                throw new Exception("Gagal Merubah");
            }
        }

        public DataTable auto()
        {
            query = "Select count(*) from anggota";
            dtTbl = dbConn.ExecQuery(query);
            return dtTbl;
        }

        public DataTable TampilSemua()
        {
            query = "SELECT * FROM anggota";
            dtTbl = dbConn.ExecQuery(query);
            return dtTbl;
        }

        public bool isExist(String Nis)
        {
            bool cek = false;

            query = "SELECT * FROM anggota WHERE nis = '" + Nis + "'";
            dtTbl = dbConn.ExecQuery(query);

            if (dtTbl.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public void kode()
        {
            query = "select id_anggota from anggota where id)anggota in(select max(id_anggota) from anggota) order by id_anggota desc";

            if (!(dbConn.ExecNonQuery(query) > 0))
            {
                throw new Exception("Gagal ");
            }
        }

        public DataTable CariAnggota(String a, String b)
        {
            query = " SELECT * FROM anggota WHERE  " + b + " like '" + a + "%'";
            dtTbl = dbConn.ExecQuery(query);

            return dtTbl;
        }

        public DataTable HitungAnggota()
        {
            query = " Select count(*) from anggota";
            dtTbl = dbConn.ExecQuery(query);

            return dtTbl;
        }

        public String IDAnggotaOtomatis()
        {
            String kode = "";
            int ida = 0;

            query = " select ifnull(max(substring(id_anggota,5,4)),0) as idp from anggota";
            dtTbl = dbConn.ExecQuery(query);

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
            query = "SELECT id_anggota FROM anggota WHERE nama='" + a + "'";
            dtTbl = dbConn.ExecQuery(query);

            return dtTbl;
        }
        public DataTable CekAnggota(String a)
        {
            query = "SELECT * FROM anggota WHERE nama like '%" + a + "%'";
            dtTbl = dbConn.ExecQuery(query);

            return dtTbl;
        }

        public bool UbahStatusAnggota()
        {
            var data = new Dictionary<string, object>();
           // data.Add("tanggal_kembali", TanggalKembali);
            data.Add("status", Status);

            var where = new Dictionary<string, object>();
            where.Add("id_anggota", ID_Anggota);

            return Query.Update(tabelanggota, data, where);
        }

        public string cek_ID(String ID_Anggota)
        {
            string status = "";
            query = "SELECT status from anggota WHERE id_anggota = '" + ID_Anggota + "'";
            dtTbl = dbConn.ExecQuery(query);
            if (dtTbl.Rows.Count > 0)
            {
                DataRow row = dtTbl.Rows[0];
            status = row["status"].ToString();
            }
            return status;
        }

  

       // internal object CariAnggota(string p)
        //{
          //  throw new NotImplementedException();
        //}
    }
}
