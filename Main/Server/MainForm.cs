using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoreLib;

namespace Server
{
    public partial class MainForm : Form
    {
        public List<string> activityList;

        public MainForm()
        {
            InitializeComponent();
            activityList = new List<string>();
        }

        public void AddActivity(string activity)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateActivity(activity)));
            }
            else
            {
                UpdateActivity(activity);
            }
        }

        private void UpdateActivity(string activity)
        {
            activityList.Add(activity.ToString());
            uxLB_Activity.DataSource = new List<string>(activityList);
        }
    }
}
