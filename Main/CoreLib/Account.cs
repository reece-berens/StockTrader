using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoreLib
{
    public class Account
    {
        private string _username;
        private string _password;
        private bool _isOnline;
        private Portfolio _portfolio;

        [JsonConstructor]
        public Account()
        {

        }

        public Account(string uname, string pword)
        {
            _username = uname;
            _password = pword;
            _portfolio = new Portfolio(1000);
        }

        public Account(string uname, string pword, Portfolio port)
        {
            _username = uname;
            _password = pword;
            _portfolio = port;
        }

        public override string ToString()
        {
            if (_isOnline)
            {
                return _username + " - Online";
            }
            else
            {
                return _username + " - Offline";
            }
        }

        #region Getters/Setters
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
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

        public bool IsOnline
        {
            get
            {
                return _isOnline;
            }
            set
            {
                _isOnline = value;
            }
        }

        public Portfolio AccountPortfolio
        {
            get
            {
                return _portfolio;
            }
            set
            {
                _portfolio = value;
            }
        }
        #endregion
    }
}
