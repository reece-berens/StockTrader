using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace StockNetworkTester
{
    class NetworkHandler
    {
        private string _apiKey = "MN8CB1O488THB5K2";
        public enum RequestFunctionEnum { IntraDayInfo, DailyInfo, WeeklyInfo, BatchInfo };
        private RequestFunctionEnum _requestFunction;
        private string _url;
        private List<string> _stockList;
        private string _singleStock;
        private string response;

        public NetworkHandler()
        {
            _stockList = new List<string>();
            _url = "https://www.alphavantage.co/query?";
            _requestFunction = RequestFunctionEnum.DailyInfo;
        }

        public string GetStockData()
        {
            //Build URL to send
            string toSend = BuildURL();
            //Console.WriteLine(_url);


            //Send URL and return data
            response = new WebClient().DownloadString("https://api.iextrading.com/1.0/stock/msft/price");
            return response;
        }

        private string BuildURL()
        {
            string ret = _url;
            switch (RequestFunction)
            {
                case RequestFunctionEnum.IntraDayInfo:
                    ret += "function=TIME_SERIES_INTRADAY";
                    ret += "&symbol=" + SingleStock;
                    ret += "&interval=5min";
                    break;
                case RequestFunctionEnum.DailyInfo:
                    ret += "function=TIME_SERIES_DAILY";
                    ret += "&symbol=" + SingleStock;
                    break;
                case RequestFunctionEnum.WeeklyInfo:
                    ret += "function=TIME_SERIES_WEEKLY";
                    ret += "&symbol=" + SingleStock;
                    break;
                case RequestFunctionEnum.BatchInfo:
                    ret += "function=BATCH_STOCK_QUOTES";
                    ret += "&symbols=";
                    int num = 0;
                    foreach (string s in StockList)
                    {
                        if (num > 100) //The API can't have more than 100 entries in 1 call
                            break;
                        if (num == StockList.Count - 1)
                            ret += s;
                        else
                            ret += s + ",";
                        num++;
                    }
                    break;
            }
            ret += "&apikey=" + _apiKey;
            return ret;
        }

        

        #region Getters/Setters
        public List<string> StockList
        {
            get
            {
                return _stockList;
            }
        }

        public string SingleStock
        {
            get
            {
                return _singleStock;
            }
            set
            {
                _singleStock = value;
            }
        }

        public RequestFunctionEnum RequestFunction
        {
            get
            {
                return _requestFunction;
            }
            set
            {
                _requestFunction = value;
            }
        }
        #endregion
    }
}
