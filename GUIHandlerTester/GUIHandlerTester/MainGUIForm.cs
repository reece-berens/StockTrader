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
    public partial class MainGUIForm : Form
    {
        List<string> stockList;
        public MainGUIForm()
        {
            InitializeComponent();
            stockList = new List<string>();
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        {
            //Open Details thread
            Program.DetailSymbol = uxLB_StockList.SelectedItem.ToString();
            Program.ProgramGUIState = Program.GUIStateEnum.OpenDetail;
            Program.SwitchGUI();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            //Close main menu and open login screen
            Program.toClose = this;
            Program.ProgramGUIState = Program.GUIStateEnum.Logout;
            Program.SwitchGUI();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Add symbol to list
            stockList.Add(uxTB_SymbolToAdd.Text);
            UpdateLB();
        }

        private void UpdateLB()
        {
            uxLB_StockList.DataSource = new List<string>(stockList);
        }
    }
}
