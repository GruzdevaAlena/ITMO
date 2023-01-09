using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class nForm : Form
    {
        public nForm()
        {
            InitializeComponent();
        }
        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nclose) return;
            e.Cancel = true;
            Hide();
        }
        private bool nclose = false;


        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }
        public new void Close()
        {
            nclose = true;
            base.Close();
        }

    }
}
