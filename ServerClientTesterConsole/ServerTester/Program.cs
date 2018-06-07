using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTester
{
    class Program
    {
        static void Main(string[] args)
        {
            NetworkHandlerServer serverInstance = new NetworkHandlerServer();
            ServerHandler serverHandler = new ServerHandler();


            Console.ReadLine();
            serverInstance.EndServer();
        }
    }
}
