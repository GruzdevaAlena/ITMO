using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_5
{
    public partial class Form2 : Form
    {
        public float p1
        {
            get { return float.Parse(textBox1.Text); }
            set { textBox1.Text = value.ToString(); }
        }
        public float p2
        {
            get { return float.Parse(textBox2.Text); }
            set { textBox2.Text = value.ToString(); }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44)
            {
                e.Handled = true;
                MessageBox.Show("Поле  не может содержать буквы");
            }

        }
    }
}
