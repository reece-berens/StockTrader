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

        ~MainForm()
        {

        }

        private void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            DelegateMessages.Logout_Call();
            Program.GUIHandler(Program.GUIHandleEnum.Logout);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            DelegateMessages.Logout_Call();
            Program.GUIHandler(Program.GUIHandleEnum.Logout);
        }

        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            string tempSym = uxTB_StockSym.Text;
            DelegateMessages.StockRequest_Call(tempSym);
        }
    }
}
