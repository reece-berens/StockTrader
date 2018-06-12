using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Logger
    {
        public Logger()
        {
            Console.WriteLine("CLIENT");
        }

        public string PromptUser(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public void NormalMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void ErrorMessage(string message)
        {
            Console.WriteLine("ERROR: " + message);
        }
    }
}
