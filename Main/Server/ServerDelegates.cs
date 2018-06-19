using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoreLib;

namespace Server
{
    public class ServerDelegates
    {
        public delegate void ServerHandleEvent(ServerResponse s, Event e);

        public delegate void UpdateActivityList(string activity);
        public delegate void UpdateUserList(List<Account> accList);
        public delegate void UpdateStockList(List<Stock> stockList);
    }
}
