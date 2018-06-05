using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockNetworkTester
{
    public partial class Form1 : Form
    {
        NetworkHandler stockNetworkHandler;
        public Form1()
        {
            InitializeComponent();
            stockNetworkHandler = new NetworkHandler();
            uxRBIntraday.Checked = true;

            uxRBBatch.CheckedChanged += new EventHandler(CheckChangedRB);
            uxRBDaily.CheckedChanged += new EventHandler(CheckChangedRB);
            uxRBWeekly.CheckedChanged += new EventHandler(CheckChangedRB);
            uxRBIntraday.CheckedChanged += new EventHandler(CheckChangedRB);
        }

        private void GetPrices_Click(object sender, EventArgs e)
        {
            
            stockNetworkHandler.SingleStock = uxTBAddStock.Text.ToUpper();
            string resp = stockNetworkHandler.GetStockData();
            MessageBox.Show(resp);
        }

        private void UpdateLB()
        {
            uxLBStocks.DataSource = new List<string>(stockNetworkHandler.StockList);
        }

        private void AddStock_Click(object sender, EventArgs e)
        {
            stockNetworkHandler.StockList.Add(uxTBAddStock.Text.ToUpper());
            UpdateLB();
        }

        private void CheckChangedRB(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton rb = (RadioButton)sender;
                if (rb.Checked)
                {
                    switch (rb.Text)
                    {
                        case "Daily":
                            Console.WriteLine("To Daily");
                            stockNetworkHandler.RequestFunction = NetworkHandler.RequestFunctionEnum.DailyInfo;
                            break;
                        case "Intra Day":
                            Console.WriteLine("To Intra");
                            stockNetworkHandler.RequestFunction = NetworkHandler.RequestFunctionEnum.IntraDayInfo;
                            break;
                        case "Weekly":
                            Console.WriteLine("Weekly");
                            stockNetworkHandler.RequestFunction = NetworkHandler.RequestFunctionEnum.WeeklyInfo;
                            break;
                        case "Batch":
                            Console.WriteLine("Batch");
                            stockNetworkHandler.RequestFunction = NetworkHandler.RequestFunctionEnum.BatchInfo;
                            break;
                    }
                }
            }
        }
    }
}
