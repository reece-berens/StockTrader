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
        public enum GUIHandleEnum { AttemptingLogin, LoginSuccessful, OpenStockDetailWindow, CloseStockDetailWindow, Logout };
        public GUIHandleEnum ClientGUIState;

        public event ClientDelegates.ClientSwitchGUI GUISwitchEvent;

        Logger logger;
        Account account;
        NetworkHandlerClient networkHandler;
        public Form curForm;
        public Form toOpen;
        public Form toClose;

        public ClientController()
        {
            account = null;
            logger = new Logger();
            networkHandler = new NetworkHandlerClient();
            NetworkHandlerClient.ClientEventHandler += HandleMessage;
            GUISwitchEvent += GUIHandler;

            ClientGUIState = GUIHandleEnum.AttemptingLogin;
            GUIHandler(null);
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
                    account = e.GetData<Account>();
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

        public void GUIHandler(Form curForm)
        {
            switch (ClientGUIState)
            {
                case GUIHandleEnum.AttemptingLogin:
                    //Open login window
                    curForm = new LoginForm();
                    curForm.ShowDialog();
                    break;
                case GUIHandleEnum.LoginSuccessful:
                    //Close login and open main
                    break;
                case GUIHandleEnum.OpenStockDetailWindow:
                    //Open a new detail window
                    break;
                case GUIHandleEnum.CloseStockDetailWindow:
                    //Remove detail window from list and close window
                    break;
                case GUIHandleEnum.Logout:
                    //Close menu and all detail windows and open login window
                    break;
            }
        }
    }
}
