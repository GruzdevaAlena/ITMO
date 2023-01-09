using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            label2.Text = await GoButt(textBox1.Text);
        }
        public async Task<string> GoButt(string maxValueText)
        {
            return await Task.Run(() => {
                Thread.Sleep(3000);
            int maxValue = 0;
                System.Text.StringBuilder resultText = new
               System.Text.StringBuilder();
                if (int.TryParse(maxValueText, out maxValue))
                {
                    for (int trial = 2; trial <= maxValue; trial++)
                    {
                        bool isPrime = true;
                        for (int divisor = 2; divisor <= Math.Sqrt(trial); divisor++)
                        {
                            if (trial % divisor == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime)
                        {
                            resultText.AppendFormat("{0} ", trial);
                        }
                    }
                }

                else
                {
                    resultText.Append("Unable to parse maximum value.");
                }
                return resultText.ToString();
            });
        }

    }
}
