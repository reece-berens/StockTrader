using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using EventLib;
using EventLib.EventData;
using ModelLib;
using Newtonsoft.Json;

namespace ServerTester
{
    class ServerHandler
    {
        Logger logger;
        List<Account> accountList;
        List<Stock> stockList;
        private const string ACCOUNT_FILE_PATH = "./accounts.txt";
        private const string STOCK_FILE_PATH = "./stocks.txt";
        
        public ServerHandler()
        {
            logger = new Logger();
            accountList = new List<Account>();
            stockList = new List<Stock>();
            ServerResponse.handleEvent += HandleMessage;

            ReadData();
        }

        ~ServerHandler()
        {
            WriteData();
        }

        public void HandleMessage(ServerResponse sender, Event e)
        {
            Event.EventTypeEnum enumType = e.EventType;
            Account acc = new Account("NULL", "NULL");
            switch (enumType)
            {
                case Event.EventTypeEnum.CreateAccount:
                    //Check list of all accounts and make sure the username isn't taken. If not, send new account
                    
                    LoginEventData createAccData = (LoginEventData)e.EventData;
                    bool canCreate = true;
                    for (int i = 0; i < accountList.Count - 1 && canCreate; i++)
                    {
                        string s = accountList.ElementAt(i).Username;
                        if (s == createAccData.Username)
                        {
                            canCreate = false;
                        }
                    }
                    if (canCreate)
                    {
                        acc = new Account(createAccData.Username, createAccData.Password);
                        accountList.Add(acc);
                        logger.NormalMessage("New user created: " + createAccData.Username);

                        //Send success response
                        sender.SendResponseToClient(new Event(Event.EventTypeEnum.ServerResponseSuccess, null));

                        //Send account data
                        sender.SendResponseToClient(new Event(Event.EventTypeEnum.ServerSendAccount, new AccountData(acc)));
                    }
                    else
                    {
                        logger.ErrorMessage("User attempted to create an account with the same username as one that exists.");
                        sender.SendResponseToClient(new Event(Event.EventTypeEnum.ServerResponseError, "Account already exists. Try again."));
                    }
                    break;
                case Event.EventTypeEnum.LoginAttempt:
                    //Find if the username exits. If so, make sure the password is correct. Send account data
                    bool found = false;
                    LoginEventData loginData = (LoginEventData)e.EventData;
                    for (int i = 0; i < accountList.Count - 1 && !found; i++)
                    {
                        string u = accountList.ElementAt(i).Username;
                        if (u == loginData.Username)
                        {
                            found = true;
                            acc = accountList.ElementAt(i);
                        }
                    }
                    if (loginData.Password == acc.Password)
                    {
                        //Successful login attempt
                        logger.NormalMessage("User " + loginData.Username + " has logged in");
                        sender.SendResponseToClient(new Event(Event.EventTypeEnum.ServerResponseSuccess, null));
                        sender.SendResponseToClient(new Event(Event.EventTypeEnum.ServerSendAccount, acc));
                    }
                    else
                    {
                        //Unsuccessful login attempt
                        logger.ErrorMessage("User " + loginData.Username + " made bad login attempt");
                        sender.SendResponseToClient(new Event(Event.EventTypeEnum.ServerResponseError, "We couldn't find that username/password combo. Try again."));
                    }
                    break;
                case Event.EventTypeEnum.NULLEVENTENUM:
                    logger.ErrorMessage("Null event received in ServerHandler.HandleMessage()");
                    break;
            }
        }

        private void ReadData()
        {
            //Read in text file of users
            StreamReader sr = new StreamReader(ACCOUNT_FILE_PATH);
            accountList = JsonConvert.DeserializeObject<List<Account>>(sr.ReadToEnd());
            sr.Close();

            //Read in text file of stocks
            sr = new StreamReader(STOCK_FILE_PATH);
            stockList = JsonConvert.DeserializeObject<List<Stock>>(sr.ReadToEnd());
            sr.Close();
        }

        private void WriteData()
        {
            StreamWriter sw = new StreamWriter(ACCOUNT_FILE_PATH);
            sw.WriteLine(JsonConvert.SerializeObject(accountList));
            sw.Close();

            sw = new StreamWriter(STOCK_FILE_PATH);
            sw.WriteLine(JsonConvert.SerializeObject(stockList));
            sw.Close();
        }
    }
}
