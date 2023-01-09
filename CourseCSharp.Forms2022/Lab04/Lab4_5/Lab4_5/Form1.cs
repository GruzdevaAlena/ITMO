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
    public partial class Form1 : Form
    {
        public float p1;
        public float p2;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (f2.ShowDialog() != DialogResult.OK)
                return;
            p1 = f2.p1;
            p2 = f2.p2;
            label2.Text = "Левая граница "+p1+", правая граница: " + p2;
            StringBuilder sb = new StringBuilder();
            for(float i = p1; i <= p2; i += 0.1f)
            {
                sb.Append("\n" + Math.Round(i,1) + " : "+Math.Round(Math.Sin(i),2));
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
