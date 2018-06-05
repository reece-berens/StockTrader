using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;

namespace ServerClientTesterConsole
{
    class NetworkHandlerClient
    {
        private WebSocket clientSocket;

        public NetworkHandlerClient()
        {
            clientSocket = new WebSocket("ws://localhost:2411/Tester");
            clientSocket.OnMessage += ReceiveMessage;
            clientSocket.Connect();
        }

        ~NetworkHandlerClient()
        {
            clientSocket.Close();
        }

        private void ReceiveMessage(object received, MessageEventArgs e)
        {
            Console.WriteLine("Received from server: " + e.Data);
        }

        public void SendMessage(string msg)
        {
            clientSocket.Send(msg);
        }
    }
}
