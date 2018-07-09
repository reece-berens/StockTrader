using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
    public class Portfolio
    {
        private double _cash;
        private double _investments;
        private double _overallAmt;
        private List<KeyValuePair<Stock, int>> _investmentList;
        private List<Stock> _watchList;

        public Portfolio(double cashAmt)
        {
            _cash = cashAmt;
            _investments = 0;
            _overallAmt = cashAmt;
            _investmentList = new List<KeyValuePair<Stock, int>>();
        }

        public override string ToString()
        {
            return _overallAmt.ToString("C2");
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
            set
            {
                _investments = value;
            }
        }

        public double OverallAmount
        {
            get
            {
                _overallAmt = _cash + _investments;
                return _overallAmt;
            }
            set
            {
                //_overallAmt = value;
            }
        }

        public List<KeyValuePair<Stock, int>> InvestmentList
        {
            get
            {
                return _investmentList;
            }
            set
            {
                _investmentList = value;
            }
        }

        public List<Stock> WatchList
        {
            get
            {
                return _watchList;
            }
            set
            {
                _watchList = value;
            }
        }
        #endregion
    }
}
