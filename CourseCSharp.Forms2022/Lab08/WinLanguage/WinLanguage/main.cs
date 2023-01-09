using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WinLanguage
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
