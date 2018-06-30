using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;

namespace Server
{
    public class NetworkHandlerStock
    {
        private string _beginURL = "https://api.iextrading.com/1.0/stock/";
        private string _endURL = "/price";

        public NetworkHandlerStock()
        {

        }

        public double RequestPrice(string StockSymbol)
        {
            string response = new WebClient().DownloadString(_beginURL + StockSymbol.ToLower() + _endURL);
            double temp = -1;
            try
            {
                temp = Convert.ToDouble(response);
            }
            catch (Exception)
            {
                return temp;
            }
            return temp;
        }
    }
}
