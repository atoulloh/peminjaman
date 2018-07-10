using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace peminjaman.Model
{
    class LoginCls
    {
        private String _username;
        private String _password;
        private string _status;
        private string _level;

        public LoginCls()
        {
            _username = "";
            _password = "";
            _status = "";
            _level = "";
        }

        public String Username
        {
            set { _username = value; }
            get { return _username; }
        }

        public String Password
        {
            set { _password = value; }
            get { return _password; }
        }

        public String Status
        {
            set { _status = value; }
            get { return _status; }
        }

        public String Level
        {
            set { _level = value; }
            get { return _level; }
        }
    }
}
