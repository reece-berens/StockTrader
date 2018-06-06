using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventLib.EventData;

namespace ServerTester
{
    class Logger
    {
        public Logger()
        {
            ServerResponse.srvRespLogNormMsg += NormalMessage;
            ServerResponse.srvRespLogErrMsg += ErrorMessage;
        }

        public void NormalMessage(Event e)
        {
            switch (e.EventType)
            {
                case Event.EventTypeEnum.CreateAccount:
                    LoginEventData dataCreate = (LoginEventData)e.EventData;
                    Console.WriteLine("Account created for " + dataCreate.Username);
                    break;
                case Event.EventTypeEnum.LoginAttempt:
                    LoginEventData dataLogin = (LoginEventData)e.EventData;
                    Console.WriteLine(dataLogin.Username + " has logged in successfully");
                    break;
            }
        }

        public void ErrorMessage(Event e)
        {
            if (e.EventType == Event.EventTypeEnum.ServerResponseError)
            {
                Console.WriteLine("ERROR: " + ((ServerResponseErrorData)e.EventData).ErrorMessage);
            }
            else if (e.EventType == Event.EventTypeEnum.NULLEVENTENUM)
            {
                Console.WriteLine("Null Event Passed");
            }
        }

        public void LogMessage(string s)
        {
            Console.WriteLine(s);
        }
    }
}
