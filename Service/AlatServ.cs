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

        public AlatServ()
        {
            dbConn = new Koneksi();
            dtTbl = new DataTable();
        }

        public DataTable CekAlat(String a)
        {

            query = "SELECT * FROM alat WHERE nama_alat like '%" + a + "%'";
            dtTbl = dbConn.ExecQuery(query);

            return dtTbl;
        }

        public bool SimpanAlat()
        {
           // query = "INSERT INTO alat VALUES ('" + Kode_Alat + "','" + Nama_Alat + "','" + Jenis_Alat + "','" + Letak + "','"
                //+ Harga_Pembelian + "','" + Tahun_Pembelian + "','" + Jumlah + "','" + Kondisi + "')";

            var datas = new Dictionary<string, object>();
            datas.Add("kode_alat", Kode_Alat);
            datas.Add("nama_alat", Nama_Alat);
            datas.Add("jenis_alat", Jenis_Alat);
            datas.Add("letak", Letak);
            datas.Add("harga_pembelian", Harga_Pembelian);
            datas.Add("tahun_pembelian", Tahun_Pembelian);
            datas.Add("jumlah", Jumlah);
            datas.Add("kondisi",Kondisi);
            return Query.Insert(tabel, datas);


            //if (!(dbConn.ExecNonQuery(query) > 0))
            //{
            //    throw new Exception(" Gagal Menyimpan");
            //}
        }

        public void UbahAlat(String kode_alat)
        {
            query = "UPDATE alat SET nama_alat='" + Nama_Alat + "', jenis_alat='" + Jenis_Alat + "', letak='" + Letak + "', harga_pembelian='" + Harga_Pembelian + "', tahun_pembelian='" + Tahun_Pembelian + "', jumlah='" +Jumlah + "', kondisi='" + Kondisi + "' WHERE kode_alat='" + kode_alat + "'";

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

        public DataTable TampilSemua()
        {
            query = "SELECT * FROM alat";
            dtTbl = dbConn.ExecQuery(query);
            return dtTbl;
        }

        public DataTable CariAlat(String a)
        {

            query = "SELECT * FROM alat WHERE nama_alat like '%" + a + "%'"+
                                        " OR kode_alat like '%" + a + "%'" +
                                        " OR jenis_alat like '%" + a + "%'" +
                                        " OR letak like '%" + a + "%'" +
                                        " OR harga_pembelian like '%" + a + "%'" +
                                        " OR tahun_pembelian like '%" + a + "%'"+
                                        " OR kondisi like '%" + a + "%'";
            dtTbl = dbConn.ExecQuery(query); 


            return dtTbl;
        }

        public DataTable CariAl(String p, String q)
        {

            query = "SELECT * FROM alat WHERE " + q + " like '" + p + "%'";
            dtTbl = dbConn.ExecQuery(query);


            return dtTbl;
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
