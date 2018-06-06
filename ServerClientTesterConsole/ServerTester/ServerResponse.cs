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
        public static event ServerDelegateHandler.LoggerNormalMessage srvRespLogNormMsg;
        public static event ServerDelegateHandler.LoggerErrorMessage srvRespLogErrMsg;
        protected override void OnMessage(MessageEventArgs eventArg)
        {
            Event e = FromJson(eventArg.Data);
            if (e == Event.NULLEVENT)
            {
                srvRespLogErrMsg.Invoke(e);
            }
            //Send(e.Data + " from Server");
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
