using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using WebSocketSharp;
using WebSocketSharp.Server;
using CoreLib;

namespace Server
{
    public class ServerResponse : WebSocketBehavior
    {
        public static event ServerDelegates.ServerHandleEvent handleEvent;

        protected override void OnMessage(MessageEventArgs eventArg)
        {
            handleEvent?.Invoke(this, FromJson(eventArg.Data));
        }

        protected override void OnClose(CloseEventArgs e)
        {
            Console.WriteLine("Client closed");
        }

        public void SendResponseToClient(Event e)
        {
            string toSend = ToJson(e);
            Send(toSend);
        }

        private string ToJson(Event toConvert)
        {
            return JsonConvert.SerializeObject(toConvert, Formatting.None);
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
