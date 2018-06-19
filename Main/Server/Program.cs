using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    static class Program
    {
        public static MainForm MainForm;
        public static ServerController serverController;
        public static NetworkHandlerServer networkHandler;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new MainForm();
            serverController = new ServerController(MainForm.InvokeActivity, MainForm.InvokeUserList, MainForm.InvokeStockList);
            networkHandler = new NetworkHandlerServer();
            Application.Run(MainForm);
        }
    }
}
