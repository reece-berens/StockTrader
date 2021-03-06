﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Reflection;
using CoreLib;
using CoreLib.EventData;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Server
{
    class ServerController
    {
        ServerDelegates.UpdateActivityList updateActivityList;
        ServerDelegates.UpdateUserList updateUserList;
        ServerDelegates.UpdateStockList updateStockList;
        List<Account> accountList;
        List<Stock> stockList;
        private const string ACCOUNT_FILE_PATH = "./accounts.txt";
        private const string STOCK_FILE_PATH = "./stocks.txt";

        public ServerController(ServerDelegates.UpdateActivityList logMethod, ServerDelegates.UpdateUserList updateUserListMethod, ServerDelegates.UpdateStockList updateStockListMethod)
        {
            updateActivityList = logMethod;
            updateUserList = updateUserListMethod;
            updateStockList = updateStockListMethod;
            accountList = new List<Account>();
            stockList = new List<Stock>();
            ServerResponse.handleEvent += HandleMessage;

            ReadData();
            updateStockList(stockList);
            updateUserList(accountList);
        }

        ~ServerController()
        {
            foreach (Account a in accountList)
            {
                a.IsOnline = false;
            }
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
                    LoginEventData createAccData = JsonConvert.DeserializeObject<LoginEventData>(e.EventData.ToString());
                    bool canCreate = true;
                    if (accountList == null)
                    {
                        accountList = new List<Account>();
                    }
                    for (int i = 0; i < accountList.Count && canCreate; i++)
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
                        acc.IsOnline = true;
                        accountList.Add(acc);
                        updateActivityList("New user created: " + createAccData.Username);
                        updateUserList(accountList);

                        //Send success response
                        //sender.SendResponseToClient(new Event(Event.EventTypeEnum.ServerResponseSuccess, null));

                        //Send account data
                        sender.SendResponseToClient(new Event(Event.EventTypeEnum.ServerSendAccount, new AccountData(acc)));
                    }
                    else
                    {
                        updateActivityList("User attempted to create an account with the same username as one that exists.");
                        sender.SendResponseToClient(new Event(Event.EventTypeEnum.ServerResponseError, new ServerErrorData("Account already exists. Try again.")));
                    }
                    break;

                case Event.EventTypeEnum.LoginAttempt:
                    //Find if the username exits. If so, make sure the password is correct. Send account data
                    bool found = false;
                    LoginEventData loginData = JsonConvert.DeserializeObject<LoginEventData>(e.EventData.ToString());
                    for (int i = 0; i < accountList.Count && !found; i++)
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
                        updateActivityList("User " + loginData.Username + " has logged in");
                        acc.IsOnline = true;
                        updateUserList(accountList);
                        
                        sender.SendResponseToClient(new Event(Event.EventTypeEnum.ServerSendAccount, new AccountData(acc)));
                    }
                    else
                    {
                        //Unsuccessful login attempt
                        updateActivityList("User " + loginData.Username + " made bad login attempt");
                        sender.SendResponseToClient(new Event(Event.EventTypeEnum.ServerResponseError, new ServerErrorData("We couldn't find that username/password combo. Try again.")));
                    }
                    break;

                case Event.EventTypeEnum.UserLogOff:
                    LoginEventData logOffData = JsonConvert.DeserializeObject<LoginEventData>(e.EventData.ToString());
                    foreach (Account a in accountList)
                    {
                        if (a.Username == logOffData.Username)
                        {
                            updateActivityList(a.Username + " has logged off");
                            a.IsOnline = false;
                            updateUserList(accountList);
                            break;
                        }
                    }
                    break;

                case Event.EventTypeEnum.ClientStockRequest:
                    StockRequestData reqData = JsonConvert.DeserializeObject<StockRequestData>(e.EventData.ToString());
                    string reqSymbol = reqData.StockSymbol.ToUpper();
                    bool inStockList = false;
                    Stock reqStockToSend = new Stock("NULL");
                    for (int i = 0; i < stockList.Count; i++)
                    {
                        string tStock = stockList.ElementAt(i).TickerSymbol;
                        if (tStock == reqSymbol)
                        {
                            inStockList = true;
                            stockList.ElementAt(i).UpdateStock();
                            reqStockToSend = stockList.ElementAt(i);
                            break;
                        }
                    }
                    if (!inStockList)
                    {
                        Stock tStock = new Stock(reqSymbol);
                        reqStockToSend = tStock;
                        stockList.Add(tStock);
                    }
                    StockData sd = new StockData(reqStockToSend);
                    Event reqEventToSend = new Event(Event.EventTypeEnum.ServerSendStock, sd);
                    sender.SendResponseToClient(reqEventToSend);
                    updateStockList(stockList);
                    break;

                case Event.EventTypeEnum.NULLEVENTENUM:
                    updateActivityList("Null event received in ServerHandler.HandleMessage()");
                    break;
            }
        }

        public void AddStock(string StockSymbol)
        {
            Stock tempStock = new Stock(StockSymbol.ToUpper());
            stockList.Add(tempStock);
            //Get price of stock
            updateStockList(stockList);
        }

        private void ReadData()
        {
            try
            {
                //Read in text file of users
                StreamReader sr = new StreamReader(ACCOUNT_FILE_PATH);
                string data = sr.ReadToEnd();
                accountList = JsonConvert.DeserializeObject<List<Account>>(data, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    PreserveReferencesHandling = PreserveReferencesHandling.Objects,

                    ContractResolver = new MyContractResolver()
                });
                sr.Close();

                //Read in text file of stocks
                sr = new StreamReader(STOCK_FILE_PATH);
                stockList = JsonConvert.DeserializeObject<List<Stock>>(sr.ReadToEnd());
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("One or more files were not found. Creating blank lists now.");
                accountList = new List<Account>();
                stockList = new List<Stock>();
            }
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

    public class MyContractResolver : Newtonsoft.Json.Serialization.DefaultContractResolver
    {
        protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
        {
            var props = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                            .Select(p => base.CreateProperty(p, memberSerialization))
                        .Union(type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                                   .Select(f => base.CreateProperty(f, memberSerialization)))
                        .ToList();
            props.ForEach(p => { p.Writable = true; p.Readable = true; });
            return props;
        }
    }
}
