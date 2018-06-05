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
        public enum RequestFunctionEnum { IntraDayInfo, DailyInfo, WeeklyInfo };
        private RequestFunctionEnum _requestFunction;
        private string _url;
        private List<string> _stockList;
        private string _singleStock;

        public NetworkHandler()
        {
            _stockList = new List<string>();
            _url = "https://www.alphavantage.co/query?";
            _requestFunction = RequestFunctionEnum.DailyInfo;
        }

        public string GetStockData()
        {
            //Build URL to send
            _url = BuildURL();
            Console.WriteLine(_url);


            //Send URL and return data
            string response;
            response = new WebClient().DownloadString(_url);
            return response;
        }

        private string BuildURL()
        {
            string ret = _url;
            switch (_requestFunction)
            {
                case RequestFunctionEnum.IntraDayInfo:
                    ret += "function=TIME_SERIES_INTRADAY";
                    ret += "&symbol=" + SingleStock;
                    break;
                case RequestFunctionEnum.DailyInfo:
                    ret += "function=TIME_SERIES_DAILY";
                    ret += "&symbol=" + SingleStock;
                    break;
                case RequestFunctionEnum.WeeklyInfo:
                    ret += "function=TIME_SERIES_WEEKLY";
                    ret += "&symbol=" + SingleStock;
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
        #endregion
    }
}
