using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoreLib;
using WebSocketSharp;
using Newtonsoft.Json;

namespace Client
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
            DelegateMessages.Handle_Call(FromJson(e.Data));
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
            return JsonConvert.SerializeObject(e, Formatting.None);
        }
    }
}
