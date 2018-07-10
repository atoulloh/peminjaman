using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using peminjaman.Model;

namespace peminjaman.Service
{
    class AlatServ : AlatCls
    {
        private Koneksi dbConn;
        private DataTable dtTbl;
        private String Query = "";

        public AlatServ()
        {
            dbConn = new Koneksi();
            dtTbl = new DataTable();
        }

        public DataTable CekAlat(String a)
        {

            Query = "SELECT * FROM alat WHERE nama_alat like '%" + a + "%'";
            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }

        public void SimpanAlat()
        {
            Query = "INSERT INTO alat VALUES ('" + Kode_Alat + "','" + Nama_Alat + "','" + Jenis_Alat + "','" + Letak + "','"
                + Harga_Pembelian + "','" + Tahun_Pembelian + "','" + Jumlah + "','" + Kondisi + "')";

            if (!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception(" Gagal Menyimpan");
            }
        }

        public void UbahAlat(String kode_alat)
        {
            Query = "UPDATE alat SET nama_alat='" + Nama_Alat + "', jenis_alat='" + Jenis_Alat + "', letak='" + Letak + "', harga_pembelian='" + Harga_Pembelian + "', tahun_pembelian='" + Tahun_Pembelian + "', jumlah='" +Jumlah + "', kondisi='" + Kondisi + "' WHERE kode_alat='" + kode_alat + "'";

            if (!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception("Gagal Merubah");
            }
        }

        public void HapusAlat(String kode_alat)
        {
            Query = "delete from alat where kode_alat='" + kode_alat + "'";
            if (!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception("Gagal Menghapus");
            }
        }

        public bool isExistAlat(String kode_alat)
        {
            bool cek = false;

            Query = "SELECT * FROM alat WHERE kode_alat ='" + kode_alat + "'";
            dtTbl = dbConn.ExecQuery(Query);

            if (dtTbl.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public DataTable TampilSemua()
        {
            Query = "SELECT * FROM alat";
            dtTbl = dbConn.ExecQuery(Query);
            return dtTbl;
        }

        public DataTable CariAlat(String a)
        {

            Query = "SELECT * FROM alat WHERE nama_alat like '%" + a + "%'"+
                                        " OR kode_alat like '%" + a + "%'" +
                                        " OR jenis_alat like '%" + a + "%'" +
                                        " OR letak like '%" + a + "%'" +
                                        " OR harga_pembelian like '%" + a + "%'" +
                                        " OR tahun_pembelian like '%" + a + "%'"+
                                        " OR kondisi like '%" + a + "%'";
            dtTbl = dbConn.ExecQuery(Query); 


            return dtTbl;
        }

        public DataTable CariAl(String p, String q)
        {

            Query = "SELECT * FROM alat WHERE " + q + " like '" + p + "%'";
            dtTbl = dbConn.ExecQuery(Query);


            return dtTbl;
        }

        public DataTable HitungAlat()
        {
            Query = "select count(*) from alat";
            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }

        public String KodeAlatOtomatis()
        {
            String kode = "";
            int alat = 0;

            Query = "select ifnull(max(substring(kode_alat,5,4)),0) as idp from alat";
            dtTbl = dbConn.ExecQuery(Query);

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
