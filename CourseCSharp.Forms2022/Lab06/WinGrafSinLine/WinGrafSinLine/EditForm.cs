using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGrafSinLine
{
    public partial class edit : Form
    {
        public edit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main frm1 = this.Owner as main;
            try
            {
                frm1.a = double.Parse(textBox1.Text);
                frm1.b = double.Parse(textBox2.Text);
                frm1.DataA = textBox1.Text;
                frm1.DataB = textBox2.Text;
                this.Close();
                frm1.Refresh();
            }
            catch (Exception er)
            {
                MessageBox.Show("При выполнении ввода исходных данныхвозникла ошибка: \n" + er.Message,"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
