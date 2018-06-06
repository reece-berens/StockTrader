using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventLib.EventData;

namespace ServerTester
{
    class ServerDelegateHandler
    {
        public delegate void ServerHandleMessage(Event e);
        public delegate void LoggerNormalMessage(Event e);
        public delegate void LoggerErrorMessage(Event e);
    }
}
