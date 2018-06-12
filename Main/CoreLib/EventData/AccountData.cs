using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.EventData
{
    public class AccountData : IEventData
    {
        public string Username;
        public string Password;
        public Portfolio AccPortfolio;

        public AccountData(Account a)
        {
            Username = a.Username;
            Password = a.Password;
            AccPortfolio = a.AccountPortfolio;
        }
    }
}
