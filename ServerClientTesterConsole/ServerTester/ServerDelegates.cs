using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventLib;
using EventLib.EventData;

namespace ServerTester
{
    class ServerDelegates
    {
        protected delegate void ServerHandleEvent(ServerResponse s, Event e);
        protected delegate void LoggerNormalMessage(ServerResponse s, Event e);
        protected delegate void LoggerErrorMessage(ServerResponse s, Event e);
    }
}
