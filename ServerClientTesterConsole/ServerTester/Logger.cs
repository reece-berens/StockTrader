using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTester
{
    class Logger
    {
        public Logger()
        {
            Console.WriteLine("SERVER");
        }

        public void NormalMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        public void ErrorMessage(string errorMsg)
        {
            Console.WriteLine("ERROR: " + errorMsg);
        }
    }
}
