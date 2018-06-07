﻿using System;
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
        public static event ServerDelegates.ServerHandleEvent handleEvent;

        protected override void OnMessage(MessageEventArgs eventArg)
        {
            Event e = FromJson(eventArg.Data);
            handleEvent.Invoke(this, e);
        }

        public void SendResponseToClient(Event e)
        {
            string toSend = ToJson(e);
            Send(toSend);
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
