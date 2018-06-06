using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLib.EventData
{
    public class ServerResponseErrorData : EventData
    {
        private string _message;

        public ServerResponseErrorData(string s)
        {
            _message = s;
        }

        #region Getters/Setters
        public string ErrorMessage
        {
            get
            {
                return _message;
            }
        }
        #endregion
    }
}
