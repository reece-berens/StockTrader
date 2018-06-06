using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    class Portfolio
    {
        private double _cash;
        private double _investments;
        private double _overallAmt;

        public Portfolio(double cashAmt)
        {
            _cash = cashAmt;
            _investments = 0;
            _overallAmt = cashAmt;
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
        #endregion
    }
}
