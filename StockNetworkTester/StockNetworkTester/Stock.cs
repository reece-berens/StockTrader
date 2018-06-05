using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockNetworkTester
{
    class Stock
    {
        private double _price;
        private int _shares;


        #region Getters/Setters
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
