using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace CoreLib
{
    public class Stock
    {
        private string _symbol;
        private double _amt;

        [JsonConstructor]
        public Stock() { }

        public Stock(string TickerSymbol)
        {
            _symbol = TickerSymbol;
            _amt = 0;
            if (_symbol != "NULL")
                UpdateStock();
        }

        public Stock(Stock stock)
        {
            _symbol = stock.TickerSymbol;
            _amt = stock.StockPrice;
        }

        public void UpdateStock()
        {
            _amt = NetworkHandlerStock.RequestPrice(_symbol);
        }

        public override string ToString()
        {
            return _symbol + ": " + _amt.ToString("C2");
        }

        #region Getters/Setters
        public string TickerSymbol
        {
            get
            {
                return _symbol;
            }
            set
            {
                _symbol = value;
            }
        }

        public double StockPrice
        {
            get
            {
                return _amt;
            }
            set
            {
                _amt = value;
            }
        }
        #endregion
    }
}
