using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class Stock
    {
        private string _symbol;
        private double _amt;

        public Stock(string TickerSymbol)
        {
            _symbol = TickerSymbol;
        }

        public void UpdateStock()
        {
            //Do an update with StockNetworkTester items, probably just current data for now
        }

        #region Getters/Setters
        public string TickerSymbol
        {
            get
            {
                return _symbol;
            }
        }

        public double StockPrice
        {
            get
            {
                return _amt;
            }
        }
        #endregion
    }
}
