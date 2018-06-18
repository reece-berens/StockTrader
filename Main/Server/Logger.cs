using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Server
{
    class Logger
    {
        MainForm mainForm = (MainForm)Program.MainForm;
        public Logger()
        {
            mainForm.AddActivity("SERVER");
        }

        public void NormalMessage(string msg)
        {
            mainForm.AddActivity(msg);
        }

        public void ErrorMessage(string errorMsg)
        {
            mainForm.AddActivity("ERROR: " + errorMsg);
        }
    }
}
