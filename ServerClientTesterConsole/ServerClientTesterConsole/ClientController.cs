using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EventLib;
using EventLib.EventData;
using ModelLib;
using Newtonsoft.Json;

namespace ServerClientTesterConsole
{
    public class ClientController
    {
        Logger logger;
        Account account;
        NetworkHandlerClient networkHandler;

        public ClientController()
        {
            account = null;
            logger = new Logger();
            networkHandler = new NetworkHandlerClient();
            NetworkHandlerClient.ClientEventHandler += HandleMessage;
            MainLoop();
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

                case Event.EventTypeEnum.ServerSendAccount:
                    //Get user's data from the server
                    account = JsonConvert.DeserializeObject<Account>(e.EventData.ToString());
                    break;

                case Event.EventTypeEnum.NULLEVENTENUM:
                    logger.ErrorMessage("Null event received in ClientHandler.HandleMessage");
                    break;
            }
            //MainLoop();
        }

        public void CreateAccount()
        {
            string u = logger.PromptUser("Enter Username: ");
            string p = logger.PromptUser("Enter Password: ");
            networkHandler.SendMessage(new Event(Event.EventTypeEnum.CreateAccount, new LoginEventData(u, p)));
        }

        public void Login()
        {
            string u = logger.PromptUser("Enter Username: ");
            string p = logger.PromptUser("Enter Password: ");
            networkHandler.SendMessage(new Event(Event.EventTypeEnum.LoginAttempt, new LoginEventData(u, p)));
        }

        public void MainLoop()
        {
            while (account == null)
            {
                string createOrLogin = logger.PromptUser("(C)reate Account or (L)ogin: ").ToUpper();
                if (createOrLogin == "C")
                {
                    CreateAccount();
                }
                else if (createOrLogin == "L")
                {
                    Login();
                }
                else
                {
                    logger.ErrorMessage("Invalid command. Try again");
                }
                Thread.Sleep(1000);
            }
            logger.NormalMessage("You got an account! username is " + account.Username);
        }
    }
}
