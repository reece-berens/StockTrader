using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MainForm : Form
    {
        private NetworkHandlerClient netHandler = Program.netHandler;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            CoreLib.EventData.LoginEventData l = new CoreLib.EventData.LoginEventData(Program.clientController.userAccount.Username, "");
            CoreLib.Event ev = new CoreLib.Event(CoreLib.Event.EventTypeEnum.UserLogOff, l);
            netHandler.SendMessage(ev);
            Program.GUIHandler(Program.GUIHandleEnum.Logout);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            CoreLib.EventData.LoginEventData l = new CoreLib.EventData.LoginEventData(Program.clientController.userAccount.Username, "");
            CoreLib.Event ev = new CoreLib.Event(CoreLib.Event.EventTypeEnum.UserLogOff, l);
            netHandler.SendMessage(ev);
            Program.GUIHandler(Program.GUIHandleEnum.Logout);
        }
    }
}
