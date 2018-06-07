using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventLib.EventData;

namespace ServerTester
{
    class Logger
    {
        public Logger()
        {
            Console.WriteLine("SERVER");
        }

        public void NormalMessage(string s)
        {
            Console.WriteLine(s);
        }

        public void ErrorMessage(string s)
        {
            Console.WriteLine("ERROR: " + s);
        }
    }
}
