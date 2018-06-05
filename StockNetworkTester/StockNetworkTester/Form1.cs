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
        }

        private void GetPrices_Click(object sender, EventArgs e)
        {
            stockNetworkHandler.SingleStock = "AAPL";
            string resp = stockNetworkHandler.GetStockData();
            MessageBox.Show(resp);
        }
    }
}
