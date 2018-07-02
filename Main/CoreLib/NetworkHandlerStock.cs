using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;

namespace CoreLib
{
    public static class NetworkHandlerStock
    {
        private static string _beginURL = "https://api.iextrading.com/1.0/stock/";
        private static string _endURL = "/price";

        public static double RequestPrice(string StockSymbol)
        {
            string fullURL = _beginURL + StockSymbol.ToLower() + _endURL;
            string response = new WebClient().DownloadString(fullURL);
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
