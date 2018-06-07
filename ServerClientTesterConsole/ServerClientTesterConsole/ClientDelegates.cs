using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventLib;

namespace ServerClientTesterConsole
{
    public class ClientDelegates
    {
        public delegate void ClientHandleEvent(Event e);
    }
}
