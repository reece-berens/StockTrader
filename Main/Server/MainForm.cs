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

namespace Server
{
    public partial class MainForm : Form
    {
        public List<string> activityList;
        public List<Account> userList;
        public List<Stock> stockList;

        public MainForm()
        {
            InitializeComponent();
            activityList = new List<string>();
        }

        public void InvokeActivity(string activity)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateActivity(activity)));
            }
            else
            {
                UpdateActivity(activity);
            }
        }

        public void InvokeUserList(List<Account> accList)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateUserList(accList)));
            }
            else
            {
                UpdateUserList(accList);
            }
        }

        public void InvokeStockList(List<Stock> stockList)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateStockList(stockList)));
            }
            else
            {
                UpdateStockList(stockList);
            }
        }

        private void UpdateUserList(List<Account> accList)
        {
            uxLB_UserList.DataSource = new List<Account>(accList);
        }

        private void UpdateStockList(List<Stock> stockList)
        {
            uxLB_StockList.DataSource = new List<Stock>(stockList);
        }

        private void UpdateActivity(string activity)
        {
            activityList.Add(activity.ToString());
            uxLB_Activity.DataSource = new List<string>(activityList);
        }

        private void BtnMoreActivity_Click(object sender, EventArgs e)
        {
            MessageBox.Show(uxLB_Activity.SelectedItem.ToString());
        }

        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            string sym = uxTB_AddStock.Text;
            Program.serverController.AddStock(sym);
        }
    }
}
