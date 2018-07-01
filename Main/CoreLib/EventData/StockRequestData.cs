using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.EventData
{
    public class StockRequestData : IEventData
    {
        public string StockSymbol;

        public StockRequestData(string symbol)
        {
            StockSymbol = symbol;
        }
    }
}
