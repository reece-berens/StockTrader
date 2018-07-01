using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoreLib;
using CoreLib.EventData;

namespace Client
{
    public class ClientController
    {
        Logger logger;
        public Account userAccount;
        NetworkHandlerClient networkHandler;

        public ClientController()
        {
            userAccount = null;
            logger = new Logger();
            networkHandler = Program.netHandler;
            DelegateMessages.clientHandleEvent_Msg += HandleMessage;
            DelegateMessages.clientStockRequest_Msg += StockRequest;
            DelegateMessages.clientLogout_Msg += HandleLogout;

            Program.GUIHandler(Program.GUIHandleEnum.AttemptingLogin);
        }

        ~ClientController()
        {
            Event e = new Event(Event.EventTypeEnum.UserLogOff, new LoginEventData(userAccount.Username, ""));
            networkHandler.SendMessage(e);
        }

        public void HandleMessage(Event e)
        {
            switch (e.EventType)
            {
                case Event.EventTypeEnum.ServerResponseError:
                    logger.ErrorMessage(e.EventData.ToString());
                    break;

                case Event.EventTypeEnum.ServerSendAccount:
                    //Get user's data from the server
                    userAccount = e.GetData<Account>();
                    Program.GUIHandler(Program.GUIHandleEnum.LoginSuccessful);
                    break;

                case Event.EventTypeEnum.ServerSendStock:
                    List<Stock> sList = userAccount.AccountPortfolio.StockList;
                    string tempSym = ((StockData)e.EventData).stock.TickerSymbol;
                    for (int i = 0; i < sList.Count; i++)
                    {
                        Stock s = sList.ElementAt(i);
                        if (s.TickerSymbol == tempSym)
                        {
                            s = new Stock(((StockData)e.EventData).stock);
                            break;
                        }
                    }
                    break;

                case Event.EventTypeEnum.NULLEVENTENUM:
                    logger.ErrorMessage("Null event received in ClientHandler.HandleMessage");
                    break;
            }
        }

        public void StockRequest(string sym)
        {
            StockRequestData tempData = new StockRequestData(sym);
            Event e = new Event(Event.EventTypeEnum.ClientStockRequest, tempData);
            networkHandler.SendMessage(e);
        }

        private void HandleLogout()
        {
            LoginEventData l = new LoginEventData(Program.clientController.userAccount.Username, "");
            Event ev = new Event(CoreLib.Event.EventTypeEnum.UserLogOff, l);
            networkHandler.SendMessage(ev);
        }
    }
}
