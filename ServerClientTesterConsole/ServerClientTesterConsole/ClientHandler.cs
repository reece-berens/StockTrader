using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventLib;
using ModelLib;

namespace ServerClientTesterConsole
{
    class ClientHandler
    {
        Logger logger;

        public ClientHandler()
        {
            logger = new Logger();
        }

        public void HandleMessage(Event e)
        {

        }
    }
}
