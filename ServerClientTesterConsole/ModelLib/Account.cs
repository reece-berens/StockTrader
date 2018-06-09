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
        private Portfolio _portfolio;

        public Account(string u, string p)
        {
            _username = u;
            _password = p;
            _portfolio = new Portfolio(1000);
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
