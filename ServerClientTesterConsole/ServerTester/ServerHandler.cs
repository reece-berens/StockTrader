using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventLib;
using EventLib.EventData;

namespace ServerTester
{
    class ServerHandler
    {
        Logger logger;
        
        public ServerHandler()
        {
            logger = new Logger();
            ServerResponse.handleEvent += HandleMessage;
        }

        public void HandleMessage(ServerResponse sender, Event e)
        {
            Event.EventTypeEnum enumType = e.EventType;
            switch (enumType)
            {
                case Event.EventTypeEnum.CreateAccount:
                    //Check list of all accounts and make sure the username isn't taken. If not, send new account
                    break;
                case Event.EventTypeEnum.LoginAttempt:
                    //Find if the username exits. If so, make sure the password is correct. Send account data
                    break;
                case Event.EventTypeEnum.NULLEVENTENUM:
                    logger.ErrorMessage("Null event received in ServerHandler.HandleMessage()");
                    break;
            }
        }
    }
}
