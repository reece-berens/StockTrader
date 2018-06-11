using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLib;
using CoreLib.EventData;

namespace ServerTester
{
    public class ServerDelegates
    {
        public delegate void ServerHandleEvent(ServerResponse s, Event e);
        public delegate void LoggerNormalMessage(ServerResponse s, Event e);
        public delegate void LoggerErrorMessage(ServerResponse s, Event e);
    }
}
