using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
//konelsi data base mysql
using MySql.Data.MySqlClient;


namespace peminjaman.Service
{
    class Koneksi : ServiceConfig
    {
        private MySqlConnection SqlConn;
        private MySqlCommand SqlComm;
        private MySqlDataAdapter SqlDataAdap;

        private String serv = "server=localhost;port=3306;database=peminjaman;username=root;password=;";

        public Koneksi()
        {
            SqlConn = new MySqlConnection(serv);
            SqlComm = new MySqlCommand();
            SqlDataAdap = new MySqlDataAdapter();
        }

        public void Bukakoneksi()
        {
            if (SqlConn.State == ConnectionState.Closed)
            {
                try
                {
                    SqlConn.Open();
                }
                catch (Exception Ex)
                { }
            }
        }

        public void Tutupkoneksi()
        {
            SqlConn.Close();
        }

         public override int ExecNonQuery(string query)
        {
            int hasil = -1;
            //throw new NotImplementedException();
            try
            {
                Bukakoneksi();
                SqlComm.Connection = SqlConn;
                SqlComm.CommandText = query;
                hasil = SqlComm.ExecuteNonQuery();
            }
            catch (Exception Ex)
            { }
            finally
            {
                Tutupkoneksi();
            }
            return hasil;
        }

        public override DataTable ExecQuery(string query)
        {
            DataTable hasil = new DataTable();

            try
            {
                Bukakoneksi();
                SqlComm.Connection = SqlConn;
                SqlComm.CommandText = query;
                SqlDataAdap.SelectCommand = SqlComm;
                SqlDataAdap.Fill(hasil);
            }
            catch (Exception Ex)
            { }
            finally
            { Tutupkoneksi(); }

            return hasil;
        }
    }
}
