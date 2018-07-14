using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using peminjaman.Service;

namespace SIPWB.Service
{
    internal class Query
    {
        private static readonly Koneksi DbConn = new Koneksi();

        protected static string SqlEscape(object str)
        {
            return Regex.Replace(str.ToString(), @"[\x00'""\b\n\r\t\cZ\\%_]",
                delegate (Match match)
                {
                    var v = match.Value;
                    switch (v)
                    {
                        case "\x00": // ASCII NUL (0x00) character
                            return "\\0";

                        case "\b": // BACKSPACE character
                            return "\\b";

                        case "\n": // NEWLINE (linefeed) character
                            return "\\n";

                        case "\r": // CARRIAGE RETURN character
                            return "\\r";

                        case "\t": // TAB
                            return "\\t";

                        case "\u001A": // Ctrl-Z
                            return "\\Z";

                        default:
                            return "\\" + v;
                    }
                });
        }

        public static bool IsTableExist(string tabel)
        {
            var cek = false;

            var query = "SELECT * FROM " + tabel;
            var dTbl = DbConn.ExecQuery(query);

            if (dTbl.Rows.Count > 0) cek = true;

            return cek;
        }

        public static bool IsDataExist(string tabel, Dictionary<string, object> where)
        {
            var query = "SELECT * FROM {tabel} WHERE {where.First().Key} = \'{where.First().Value}\'";
            var dTbl = DbConn.ExecQuery(query);

            if (dTbl.Rows.Count > 0)
                return true;
            return false;
        }

        public static string BuatId(string tabel, string id, string prefix)
        {
            var kode = "";
            var idx = 0;
            var query = "SELECT IFNULL(MAX(SUBSTRING(" + id + ", 3, 4)), 0) as " + id + " from " + tabel;
            var dtTbl = DbConn.ExecQuery(query);

            if (dtTbl.Rows.Count > 0)
                foreach (DataRow tmp in dtTbl.Rows)
                    idx = Convert.ToInt32(tmp[id].ToString());

            if (idx >= 0 && idx <= 8)
                kode = prefix + "00" + Convert.ToInt32(idx + 1);
            else if (idx >= 9 && idx <= 98)
                kode = prefix + "0" + Convert.ToInt32(idx + 1);
            else if (idx >= 99 && idx <= 998) kode = prefix + Convert.ToInt32(idx + 1);

            return kode;
        }

        public static DataTable Select(string tabel, string cari)
        {
            var query1 = "SELECT GROUP_CONCAT(column_name ORDER BY ordinal_position) as concats" +
                         " FROM information_schema.columns" +
                         " WHERE table_schema = DATABASE() and table_name = '" + tabel + "'" +
                         " GROUP BY table_name ORDER BY table_name";
            var dTbl1 = DbConn.ExecQuery(query1);
            var concats = dTbl1.Rows[0];

            var query2 = "SELECT * FROM " + tabel + " WHERE concat(" + concats["concats"] + ") like '%" + cari + "%'";
            var dTbl2 = DbConn.ExecQuery(query2);

            if (dTbl2.Rows.Count > 0)
                return dTbl2;
            return new DataTable(null);
        }

        public static bool Insert(string tabel, Dictionary<string, object> data)
        {
            var insert = false;
            var kolom = "";
            var value = "";
            var hitung = 1;

            foreach (var val in data)
            {
                if (hitung != data.Count)
                {
                    kolom += val.Key + ",";
                    value += "'" + SqlEscape(val.Value.ToString()) + "',";
                }
                else
                {
                    kolom += val.Key;
                    value += "'" + SqlEscape(val.Value.ToString()) + "'";
                }

                hitung++;
            }

            var query = "INSERT INTO " + tabel + " (" + kolom + ") VALUES (" + value + ")";
            if (DbConn.ExecNonQuery(query) > 0) insert = true;

            return insert;
        }

        public static bool Update(string tabel, Dictionary<string, object> data, Dictionary<string, object> where)
        {
            var update = false;
            var kolom = "";
            var hitung = 1;

            foreach (var val in data)
            {
                if (hitung != data.Count)
                    kolom += val.Key + " = '" + SqlEscape(val.Value.ToString()) + "', ";
                else
                    kolom += val.Key + " = '" + SqlEscape(val.Value.ToString()) + "' ";
                hitung++;
            }

            var query = "UPDATE " + tabel + " SET " + kolom + " WHERE " + where.First().Key + " = \'" + where.First().Value + "\'";
            if (DbConn.ExecNonQuery(query) > 0) update = true;

            return update;
        }

        public static bool Delete(string tabel, Dictionary<string, object> where)
        {
            var hapus = false;

            var query = "DELETE FROM {tabel} WHERE {where.First().Key} = \'{where.First().Value}\'";
            if (DbConn.ExecNonQuery(query) > 0) hapus = true;

            return hapus;
        }

        public static DataTable GetQuery(string query)
        {
            var dTbl = DbConn.ExecQuery(query);

            if (dTbl.Rows.Count > 0)
                return dTbl;
            return new DataTable(null);
        }

        public static bool ExeQuery(string query)
        {
            if (DbConn.ExecNonQuery(query) > 0) return true;
            return false;
        }
    }
}