using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        public enum GUIHandleEnum { AttemptingLogin, LoginSuccessful, OpenStockDetailWindow, CloseStockDetailWindow, Logout };
        public static GUIHandleEnum ClientGUIState;

        public static ClientController clientController;
        public static NetworkHandlerClient netHandler;

        public static Form toOpen;
        public static Form toClose;
        public static Form currentForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            netHandler = new NetworkHandlerClient();
            clientController = new ClientController();
            LoginForm startForm = new LoginForm();
            currentForm = startForm;
            Application.Run(startForm);
        }

        public static void GUIHandler()
        {
            switch (ClientGUIState)
            {
                case GUIHandleEnum.AttemptingLogin:
                    //Open login window
                    break;
                case GUIHandleEnum.LoginSuccessful:
                    //Close login and open main
                    toClose = currentForm;
                    if (toClose.InvokeRequired)
                    {
                        toClose.Invoke(new Action(toClose.Hide));
                    }
                    else
                    {
                        toClose.Hide();
                    }
                    toOpen = new MainForm();
                    currentForm = toOpen;
                    toOpen.FormClosed += (s, args) => toClose.Dispose();
                    toClose.Invoke(new Action(toOpen.Show));
                    break;
                case GUIHandleEnum.OpenStockDetailWindow:
                    //Open a new detail window
                    break;
                case GUIHandleEnum.CloseStockDetailWindow:
                    //Remove detail window from list and close window
                    break;
                case GUIHandleEnum.Logout:
                    //Close menu and all detail windows and open login window
                    toOpen = new LoginForm();
                    toClose = currentForm;
                    currentForm = toOpen;
                    if (toClose.InvokeRequired)
                    {
                        toClose.Invoke(new Action(toClose.Hide));
                    }
                    else
                    {
                        toClose.Hide();
                    }
                    toOpen.FormClosed += (s, args) => toClose.Dispose();
                    toClose.Invoke(new Action(toOpen.Show));
                    break;
            }
        }
    }
}
