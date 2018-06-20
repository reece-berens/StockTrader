using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoreLib;

namespace Client
{
    public class ClientDelegates
    {
        public delegate void ClientHandleEvent(Event e);
        public delegate void ClientSwitchGUI();
    }
}
