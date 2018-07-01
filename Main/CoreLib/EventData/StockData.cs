using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib.EventData
{
    public class StockData : IEventData
    {
        public Stock stock;

        public StockData(Stock stock)
        {
            this.stock = stock;
        }
    }
}
