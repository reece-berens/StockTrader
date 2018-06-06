using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;
using Newtonsoft.Json;

namespace ServerTester
{
    class ServerResponse : WebSocketBehavior
    {
        protected override void OnMessage(MessageEventArgs e)
        {
            Console.WriteLine("Received from Client: " + e.Data);
            Send(e.Data + " from Server");
        }

        private string ToJson(Event toConvert)
        {
            return JsonConvert.SerializeObject(toConvert);
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
    }
}
