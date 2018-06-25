using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockNetworkTester
{
    public class Stock
    {
        private string _symbol;
        private double _price;
        private int _shares;

        public Stock()
        {

        }

        #region Getters/Setters
        public string Symbol
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

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public int Shares
        {
            get
            {
                return _shares;
            }
            set
            {
                _shares = value;
            }
        }
        #endregion
    }
}
