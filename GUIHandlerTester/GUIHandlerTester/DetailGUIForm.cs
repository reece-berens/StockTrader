﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIHandlerTester
{
    public partial class DetailGUIForm : Form
    {
        string symbol;

        public DetailGUIForm()
        {
            InitializeComponent();
            symbol = "NULL";
            UpdateTB();
        }

        public DetailGUIForm(string _symbol)
        {
            InitializeComponent();
            symbol = _symbol;
            UpdateTB();
        }

        private void UpdateTB()
        {
            uxTB_DetailBox.Text = "Details for stock: " + symbol;
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form_Closed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
