using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(userInput1.getLetters.Length>0)
                label1.Text = "Введенные буквы: " + userInput1.getLetters;
            if (userInput1.getNumbers.Length > 0)
                label2.Text = "Введенные цифры: " + userInput1.getNumbers;
        }
    }
}
