using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.EventData
{
    public class ServerErrorData : IEventData
    {
        public string ErrorMessage;

        public ServerErrorData(string errMsg)
        {
            ErrorMessage = errMsg;
        }
    }
}
