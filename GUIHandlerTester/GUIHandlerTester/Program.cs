using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIHandlerTester
{
    static class Program
    {
        public enum GUIStateEnum { AttemptingLogin, LoginSuccessful, OpenDetail, CloseDetail, Logout };

        public static GUIStateEnum ProgramGUIState;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ProgramGUIState = GUIStateEnum.AttemptingLogin;
            Application.Run(new LoginGUIForm());
        }

        public static void SwitchGUI()
        {
            switch (ProgramGUIState)
            {
                case GUIStateEnum.LoginSuccessful:
                    //Close login GUI and open main GUI
                    break;
                case GUIStateEnum.OpenDetail:
                    //Open detail GUI on new thread for a specific stock
                    break;
                case GUIStateEnum.CloseDetail:
                    //Close detail GUI
                    break;
                case GUIStateEnum.Logout:
                    //Close main GUI and open login GUI
                    break;
            }
        }
    }
}
