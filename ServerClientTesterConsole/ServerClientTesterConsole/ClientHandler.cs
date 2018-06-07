using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventLib;
using ModelLib;
using Newtonsoft.Json;

namespace ServerClientTesterConsole
{
    public class ClientHandler
    {
        Logger logger;

        public ClientHandler()
        {
            logger = new Logger();
            NetworkHandlerClient.ClientEventHandler += HandleMessage;
        }

        public void HandleMessage(Event e)
        {
            switch (e.EventType)
            {
                case Event.EventTypeEnum.ServerResponseSuccess:
                    //Something you passed get back correctly
                    break;

                case Event.EventTypeEnum.ServerResponseError:
                    //Something didn't go too well
                    break;

                case Event.EventTypeEnum.NULLEVENTENUM:
                    logger.ErrorMessage("Null event received in ClientHandler.HandleMessage");
                    break;
            }
        }
    }
}
