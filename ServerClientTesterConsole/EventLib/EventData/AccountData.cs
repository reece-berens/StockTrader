using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLib;

namespace EventLib.EventData
{
    public class AccountData : EventData
    {
        private Account _a;

        public AccountData(Account a)
        {
            _a = a;
        }

        #region Getters/Setters
        public Account AccData
        {
            get
            {
                return _a;
            }
        }
        #endregion
    }
}
