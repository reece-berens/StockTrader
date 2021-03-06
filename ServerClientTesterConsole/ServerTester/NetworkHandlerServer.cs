﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp.Server;
using Newtonsoft.Json;

namespace ServerTester
{
    class NetworkHandlerServer
    {
        private WebSocketServer wss;

        public NetworkHandlerServer()
        {
            wss = new WebSocketServer("ws://localhost:2411");
            wss.AddWebSocketService<ServerResponse>("/Tester");
            wss.Start();
        }

        public void EndServer()
        {
            wss.Stop();
        }
    }
}
