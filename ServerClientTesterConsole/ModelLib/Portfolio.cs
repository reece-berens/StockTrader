using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class Portfolio
    {
        private double _cash;
        private double _investments;
        private double _overallAmt;
        private List<Stock> _stockList;

        public Portfolio(double cashAmt)
        {
            _cash = cashAmt;
            _investments = 0;
            _overallAmt = cashAmt;
            _stockList = new List<Stock>();
        }

        #region Getters/Setters
        public double CashAmount
        {
            get
            {
                return _cash;
            }
            set
            {
                _cash = value;
            }
        }

        public double InvestmentAmount
        {
            get
            {
                return _investments;
            }
        }

        public double OverallAmount
        {
            get
            {
                return _cash + _investments;
            }
        }

        public List<Stock> StockList
        {
            get
            {
                return _stockList;
            }
        }
        #endregion
    }
}
