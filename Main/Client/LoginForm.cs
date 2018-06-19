using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoreLib;
using CoreLib.EventData;

namespace Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            LoginEventData eData = new LoginEventData(uxTB_Username.Text, uxTB_Password.Text);
            Program.netHandler.SendMessage(new Event(Event.EventTypeEnum.CreateAccount, eData));
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginEventData eData = new LoginEventData(uxTB_Username.Text, uxTB_Password.Text);
            Program.netHandler.SendMessage(new Event(Event.EventTypeEnum.LoginAttempt, eData));
        }
    }
}
