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
            Console.WriteLine("CLIENT");
            NetworkHandlerClient clientInstance = new NetworkHandlerClient();

            Console.Write("Send message: ");
            string toSend = Console.ReadLine();

            clientInstance.SendMessage(toSend);
            Console.ReadLine();
        }
    }
}
