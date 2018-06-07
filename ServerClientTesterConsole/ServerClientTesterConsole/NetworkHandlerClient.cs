using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using Newtonsoft.Json;
using EventLib;

namespace ServerClientTesterConsole
{
    class NetworkHandlerClient
    {
        private WebSocket clientSocket;
        public static event ClientDelegates.ClientHandleEvent ClientEventHandler;

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
            ClientEventHandler.Invoke(FromJson(e.Data));
        }

        public void SendMessage(Event e)
        {
            clientSocket.Send(ToJson(e));
        }

        private Event FromJson(string toConvert)
        {
            object e = JsonConvert.DeserializeObject<Event>(toConvert);
            if (e is Event)
            {
                return (Event)e;
            }
            else
            {
                return Event.NULLEVENT;
            }
        }

        private string ToJson(Event e)
        {
            return JsonConvert.SerializeObject(e);
        }
    }
}
