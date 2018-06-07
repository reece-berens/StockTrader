using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerClientTesterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            NetworkHandlerClient clientInstance = new NetworkHandlerClient();
            ClientHandler clientHandler = new ClientHandler();

            Console.ReadLine();
        }
    }
}
