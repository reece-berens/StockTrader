using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    class Stock
    {
        private string _symbol;
        private double _amt;

        public Stock(string TickerSymbol)
        {
            _symbol = TickerSymbol;
        }

        #region Getters/Setters
        public string TickerSymbol
        {
            get
            {
                return _symbol;
            }
        }
        #endregion
    }
}
