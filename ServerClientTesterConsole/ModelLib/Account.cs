using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class Account
    {
        private string _username;
        private string _password;

        public Account(string u, string p)
        {
            _username = u;
            _password = p;
        }

        #region Getters/Setters
        public string Username
        {
            get
            {
                return _username;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        #endregion
    }
}
