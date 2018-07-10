using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace peminjaman.Service
{
   abstract class ServiceConfig
    {
        public abstract int ExecNonQuery(String query);
        public abstract DataTable ExecQuery(String query);
    }
}
