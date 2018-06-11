using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CoreLib.EventData;

namespace CoreLib
{
    public class Account
    {
        private string _username;
        private string _password;
        private Portfolio _portfolio;

        public Account(object obj)
        {
            Account temp = (Account)obj;
            _username = temp.Username;
            _password = temp.Password;
            _portfolio = temp.AccountPortfolio;
        }

        public Account(string uname, string pword)
        {
            _username = uname;
            _password = pword;
            _portfolio = new Portfolio(1000);
        }

        [JsonConstructor]
        public Account (string uname, string pword, Portfolio port)
        {
            _username = uname;
            _password = pword;
            _portfolio = port;
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
