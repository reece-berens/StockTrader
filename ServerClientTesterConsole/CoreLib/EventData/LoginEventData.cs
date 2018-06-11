using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.EventData
{
    public class LoginEventData : EventData
    {
        public string Username;
        public string Password;

        public LoginEventData(string uname, string pword)
        {
            Username = uname;
            Password = pword;
        }
    }
}
