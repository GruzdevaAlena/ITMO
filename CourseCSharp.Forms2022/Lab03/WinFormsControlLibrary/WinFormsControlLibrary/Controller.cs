using System;
using System.Windows.Forms;

namespace WinFormsControlLibrary
{
    public partial class Controller : UserControl
    {
        public Controller()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Enabled = true)
            {
                userControlTimer1.TimeEnabled = false;
            }
            else
            {
                userControlTimer1.TimeEnabled = true;
            }
        }
    }
}
