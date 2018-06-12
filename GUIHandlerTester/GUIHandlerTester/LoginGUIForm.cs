using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIHandlerTester
{
    public partial class LoginGUIForm : Form
    {
        public LoginGUIForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string _uAttempt = uxTB_Username.Text;
            string _pAttempt = uxTB_Password.Text;

            if (_uAttempt == "test" && _pAttempt == "test")
            {
                Program.toClose = this;
                Program.ProgramGUIState = Program.GUIStateEnum.LoginSuccessful;
                Program.SwitchGUI();
            }
            else
            {
                MessageBox.Show("Incorrect login attempt. Try again.\nHint: test");
            }
        }

        private void CloseForm(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
