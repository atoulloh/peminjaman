using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using peminjaman.Model;

namespace peminjaman.Service
{
    class PinjamServ : PinjamAlatCls
    {
        private Koneksi dbConn;
        private DataTable dtTbl;
        private String Query = "";

        public PinjamServ()
        {
            dbConn = new Koneksi();
            dtTbl = new DataTable();
        }

        public bool isExistPeminjam(String id_peminjaman)
        {
            bool cek = false;

            Query = "SELECT * FROM peminjam WHERE id_peminjaman = '" + id_peminjaman + "'";
            dtTbl = dbConn.ExecQuery(Query);

            if (dtTbl.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public DataTable TampilPinjaman(String id_peminjaman)
        {
            Query = "select * from pinjaman where id_peminjaman = '" + id_peminjaman + "'";
            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }


        public DataTable TampilSemuaPeminjam()
        {
            Query = "SELECT * FROM peminjam";
            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }

        public DataTable CariIDp(String a)
        {
            Query = "SELECT id_peminjaman FROM peminjam WHERE nama='" + a + "'";
            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;

        }
        public DataTable CekP(String a)
        {

            Query = "SELECT * FROM peminjam WHERE nama like '%" + a + "%'";
            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }

        public DataTable CariPeminjam(String a, String b)
        {
            Query = "SELECT * FROM peminjam WHERE " + b + " like '" + a + "%'";
            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }


        public String KDPinjamOtomatis()
        {
            String kode = "";
            int idx = 0;

            Query = "select ifnull(max(substring(id_peminjaman,5,4)),0) as idp from peminjam";
            dtTbl = dbConn.ExecQuery(Query);

            if (dtTbl.Rows.Count > 0)
            {
                foreach(DataRow tmp in dtTbl.Rows)
                {
                    idx = Convert.ToInt32(tmp["idp"].ToString());
                }
            }

            if (idx >= 0 && idx <=8)
            {
                kode = "PJM-" + "000" + Convert.ToString(idx  + 1);
            }

            else if (idx >= 9 && idx <=98)
            {
                kode = "PJM-" + "00" + Convert.ToString(idx + 1);
            }

            else if (idx >= 99 && idx <=998)
            {
                kode = "PJM-" + "0" + Convert.ToString(idx + 1);
            }

            else if (idx >=999 && idx <=9998)
            {
                kode = "PJM-" + Convert.ToString(idx + 1);
            }

            return kode;
        }

        public void SimpanPeminjam()
        {
            Query = "insert into peminjam (id_peminjaman,id_anggota,nama,jumlah) values ('" + IdPeminjaman + "','" + IdAnggota + "','" + Nama + "','" + Jumlah + "')";

            if (!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }

        public void SimpanPinjaman()
        {
            Query = "insert into pinjaman (id_peminjaman,id_pinjaman,nama_alat) values ('" + IdPeminjaman + "','" + IdPinjaman + "','" + Nama_Alat + "')";
            if (!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }

        public void HapusPeminjam(String id_peminjaman)
        {
            Query = "delete from peminjam where id_peminjaman = '" + id_peminjaman + "'";
            if (!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception("Gagal Menghapus");
            }
        }

        
        
        public DataTable HitungPeminjam()
        {
            Query = "select count(*) from peminjam";
            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }

        public DataTable TampilDetailPinjam(String id_peminjaman)
        {
            Query = "select * from pinjaman where id_pinjaman='" + id_peminjaman +"%'";
            //Query = "select kode_pinjam,kode_buku from detail_pinjam where kode_pinjam = '"+ dp +"'";

            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;

        }

        public String PinjamOtomatis()
        {
            String code = "";
            int idp = 0 ;

            Query = "select ifnull(max(substring(id_pinjaman,6,5)),0) as idx from pinjaman";
            dtTbl = dbConn.ExecQuery(Query);

            if (dtTbl.Rows.Count > 0)
            {
                foreach (DataRow tmp in dtTbl.Rows)
                {
                    idp = Convert.ToInt32(tmp["idx"].ToString());
                }

            }
            if (idp >= 0 && idp <= 8)
            {
                code = "pjmn-" + "000" + Convert.ToString(idp + 1);
            }

            else if (idp >= 9 && idp <= 98)
            {
                code = "pjmn-" + "00" + Convert.ToString(idp + 1);
            }
            else if (idp >= 99 && idp <= 998)
            {
                code = "pjmn-" + "0" + Convert.ToString(idp + 1);
            }

            else if (idp >= 999 && idp <= 9998)
            {
                code = "pjmn-" + Convert.ToString(idp + 1);
            }
            return code;
 
        }
             

        
    }
}
