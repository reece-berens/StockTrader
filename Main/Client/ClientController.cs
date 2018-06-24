using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoreLib;
using CoreLib.EventData;

namespace Client
{
    public class ClientController
    {
        Logger logger;
        public Account userAccount;
        NetworkHandlerClient networkHandler;
        public Form curForm;
        public Form toOpen;
        public Form toClose;

        public ClientController()
        {
            userAccount = null;
            logger = new Logger();
            networkHandler = Program.netHandler;
            NetworkHandlerClient.clientHandleEvent += HandleMessage;

            Program.GUIHandler(Program.GUIHandleEnum.AttemptingLogin);
        }

        ~ClientController()
        {
            Event e = new Event(Event.EventTypeEnum.UserLogOff, new LoginEventData(userAccount.Username, ""));
            networkHandler.SendMessage(e);
        }

        public void HandleMessage(Event e)
        {
            switch (e.EventType)
            {
                case Event.EventTypeEnum.ServerResponseSuccess:
                    //Something you passed get back correctly
                    break;

                case Event.EventTypeEnum.ServerResponseError:
                    logger.ErrorMessage(e.EventData.ToString());
                    break;

                case Event.EventTypeEnum.ServerSendAccount:
                    //Get user's data from the server
                    userAccount = e.GetData<Account>();
                    Program.GUIHandler(Program.GUIHandleEnum.LoginSuccessful);
                    break;

                case Event.EventTypeEnum.NULLEVENTENUM:
                    logger.ErrorMessage("Null event received in ClientHandler.HandleMessage");
                    break;
            }
        }

        public void HandleLogout()
        {

        }

        public void CloseLogin(LoginForm lForm)
        {
            
        }
    }
}
