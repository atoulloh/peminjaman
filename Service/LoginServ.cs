using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using peminjaman.Model;
using peminjaman.Service;

namespace peminjaman.Services
{
    class LoginServ : LoginCls
    {
        private Koneksi dbConn;
        private DataTable dtTbl;
        private String Query = "";

        public LoginServ()
        {
            dbConn = new Koneksi();
            dtTbl = new DataTable();
        }

        public DataTable ManagerLogin()
        {
            Query = "SELECT * FROM login";
            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }

        public bool LoginCek(String us, String ps)
        {
            bool cek = false;

            Query = "SELECT * FROM login WHERE username='" + us + "'and password= '" + ps + "'";
            dtTbl = dbConn.ExecQuery(Query);

            if (dtTbl.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public DataTable CekStat(String stat)
        {
            Query = "select status from login where username= '" + stat + "'";

            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }

        public DataTable CekLevel(String lvl)
        {
            Query = "select level from login where username='" + lvl + "'";

            dtTbl = dbConn.ExecQuery(Query);

            return dtTbl;
        }

        public void Ubah(string id, string stat)
        {
            Query = "update login set status='" + stat + "' where username='" + id + "';";

            if (!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception("Gagal");
            }
        }

        public void Simpan()
        {
            Query = "INSERT INTO login VALUES ('" + Username + "','" + Password + "','"
                   + Status + "','" + Level + "')";

            if (!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception("Gagal Menyimpan");
            }
        }

        public bool isExistData(String user)
        {
            bool cek = false;

            Query = "SELECT * FROM login WHERE username='" + user + "'";
            dtTbl = dbConn.ExecQuery(Query);

            if (dtTbl.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;

        }

        public void Hapus(String kode)
        {
            Query = "delete from login where username='" + kode + "'";

            if (!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception("Gagal Menghapus");
            }
        }

        public void UbahData(String ubah)
        {
            Query = "UPDATE login SET username='" + Username + "', password='" + Password + "', level='" + Level + "' where username='" + ubah + "'";

            if (!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception("Gagal Merubah");
            }
        }

        public void UbahDataIsExist(String ubah)
        {
            Query = "UPDATE login SET password='" + Password + "', level='" + Level + "' where username='" + ubah + "'";

            if (!(dbConn.ExecNonQuery(Query) > 0))
            {
                throw new Exception("Gagal Merubah");
            }
        }
    }
}
