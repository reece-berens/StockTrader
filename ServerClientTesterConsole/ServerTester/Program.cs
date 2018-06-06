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
            Logger logger = new Logger();
            logger.LogMessage("SERVER");
            NetworkHandlerServer serverInstance = new NetworkHandlerServer();


            Console.ReadLine();
            serverInstance.EndServer();
        }
    }
}
