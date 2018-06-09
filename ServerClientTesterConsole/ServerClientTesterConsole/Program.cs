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
            ClientController clientHandler = new ClientController();

            Console.WriteLine("Back in program");
            Console.ReadLine();
        }
    }
}
