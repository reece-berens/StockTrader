using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLib.EventData
{
    class LoginEventData
    {
        private string _uname;
        private string _password;

        public LoginEventData(string u, string p)
        {
            _uname = u;
            _password = p;
        }

        #region Getters/Setters
        public string Username
        {
            get
            {
                return _uname;
            }
            set
            {
                _uname = value;
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
