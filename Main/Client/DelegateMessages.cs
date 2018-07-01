using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLib;

namespace Client
{
    public static class DelegateMessages
    {
        public static event ClientDelegates.ClientHandleEvent clientHandleEvent_Msg;
        public static event ClientDelegates.ClientStockRequest clientStockRequest_Msg;
        public static event ClientDelegates.ClientLogout clientLogout_Msg;

        public static void Handle_Call(Event ev)
        {
            clientHandleEvent_Msg?.Invoke(ev);
        }

        public static void StockRequest_Call(string symbol)
        {
            clientStockRequest_Msg?.Invoke(symbol);
        }

        public static void Logout_Call()
        {
            clientLogout_Msg?.Invoke();
        }
    }
}
