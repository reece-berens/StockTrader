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
            activityList.Add(activity);
            uxLB_Activity.DataSource = new List<string>(activityList);
        }
    }
}
