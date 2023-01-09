using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsControlLibrary
{
    public partial class UserControlTimer : UserControl
    {
        public bool TimeEnabled
        {
            get { return timer1.Enabled; }
            set { timer1.Enabled = value; }
        }

        public UserControlTimer()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
