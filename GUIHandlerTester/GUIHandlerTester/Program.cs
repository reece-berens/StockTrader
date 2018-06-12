using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIHandlerTester
{
    static class Program
    {
        public enum GUIStateEnum { AttemptingLogin, LoginSuccessful, OpenDetail, CloseDetail, Logout };

        public static GUIStateEnum ProgramGUIState;
        public static Form toClose;
        public static Form toOpen;
        public static string DetailSymbol;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ProgramGUIState = GUIStateEnum.AttemptingLogin;
            DetailSymbol = "";
            Application.Run(new LoginGUIForm());
        }

        public static void SwitchGUI()
        {
            switch (ProgramGUIState)
            {
                case GUIStateEnum.LoginSuccessful:
                    //Close login GUI and open main GUI
                    toOpen = new MainGUIForm();
                    if (toClose.InvokeRequired)
                    {
                        toClose.Invoke(new Action(toClose.Hide)); //need to ensure we set toClose to the login GUI currently open before calling this
                    }
                    else
                    {
                        toClose.Hide();
                    }
                    toOpen.FormClosed += (s, args) => toClose.Dispose();
                    toClose.Invoke(new Action(toOpen.Show));
                    break;
                case GUIStateEnum.OpenDetail:
                    //Open detail GUI on new thread for a specific stock
                    toOpen = new DetailGUIForm(DetailSymbol);
                    Thread detailThread = new Thread(StartDetailThread);
                    detailThread.Start();
                    break;
                case GUIStateEnum.CloseDetail:
                    //Close detail GUI
                    break;
                case GUIStateEnum.Logout:
                    //Close main GUI and open login GUI
                    toOpen = new LoginGUIForm();
                    if (toClose.InvokeRequired)
                    {
                        toClose.Invoke(new Action(toClose.Hide)); //need to ensure we set toClose to the main GUI currently open before calling this
                    }
                    else
                    {
                        toClose.Hide();
                    }
                    toClose.Dispose();
                    toOpen.ShowDialog();
                    break;
            }
        }

        static void StartDetailThread()
        {
            toOpen.ShowDialog();
        }

    }
}
