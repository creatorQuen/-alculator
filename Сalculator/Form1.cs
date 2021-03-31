using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сalculator
{
    public partial class Form1 : Form
    {
        string _tmp = "";
        char _act = ' ';

        public Form1()
        {
            InitializeComponent();
        }

        private void NumericButton_Click(object sender, EventArgs e)
        {
            if(sender is Button)
            {
                Button button = (Button)sender;
                Result_Box.Text += button.Text;
            }
            else
            {
                throw new Exception();
            }
        }

        private void Plus_Button_Click(object sender, EventArgs e)
        {
            _tmp = Result_Box.Text;
            Result_Box.Text = "";
            _act = '+';
        }

        private void Solve_Button_Click(object sender, EventArgs e)
        {
            double answer = 0;
            switch (_act)
            {
                case '+':
                    answer = Convert.ToDouble(_tmp) + Convert.ToDouble(Result_Box.Text);
                    break;
                case '-':
                    answer = Convert.ToDouble(_tmp) - Convert.ToDouble(Result_Box.Text);
                    break;
            }

            Result_Box.Text = answer + "";
        }

        private void Minus_Button_Click(object sender, EventArgs e)
        {
            _tmp = Result_Box.Text;
            Result_Box.Text = "";
            _act = '-';
        }
    }
}
