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
                if(Result_Box.Text == "Not divide by zero")
                {
                    Result_Box.Text = "";
                }

                Button button = (Button)sender;

                if(button.Text == ",")
                {
                    if (!Result_Box.Text.Contains("."))
                    {
                        Result_Box.Text = Result_Box.Text + button.Text;
                    }
                }
                else
                {
                    Result_Box.Text += button.Text;
                }
            }
            else
            {
                throw new Exception("sender not Button");
            }
        }


        private void Solve_Button_Click(object sender, EventArgs e)
        {
            decimal answer = -1;

            switch (_act)
            {
                case '+':
                    answer = Convert.ToDecimal(_tmp) + Convert.ToDecimal(Result_Box.Text);
                    Result_Box.Text = Convert.ToString(answer);
                    break;
                case '-':
                    answer = Convert.ToDecimal(_tmp) - Convert.ToDecimal(Result_Box.Text);
                    Result_Box.Text = Convert.ToString(answer);
                    break;
                case '*':
                    //answer = Double.Parse(_tmp) * Double.Parse(Result_Box.Text);
                    //Result_Box.Text = Convert.ToString(answer);

                    Result_Box.Text = (Decimal.Parse(_tmp) * Decimal.Parse(Result_Box.Text)).ToString();
                    break;
                case '/':
                    if(Convert.ToDecimal(Result_Box.Text) == 0)
                    {
                        Result_Box.Text = "Not divide by zero";
                    }
                    else
                    {
                        answer = Convert.ToDecimal(_tmp) / Convert.ToDecimal(Result_Box.Text);
                        Result_Box.Text = Convert.ToString(answer);
                    }
                    break;
                default:
                    break;
            }

        }

        private void Plus_Button_Click(object sender, EventArgs e)
        {
            _tmp = Result_Box.Text;
            Result_Box.Text = ""; 
            Operaion_Label.Text = "+";
            _act = '+';
        }

        private void Minus_Button_Click(object sender, EventArgs e)
        {
            _tmp = Result_Box.Text;
            Result_Box.Text = "";
            Operaion_Label.Text = "-";
            _act = '-';
        }

        private void Multiply_Button_Click(object sender, EventArgs e)
        {
            _tmp = Result_Box.Text;
            Result_Box.Text = "";
            Operaion_Label.Text = "*";
            _act = '*';
        }

        private void Divide_Button_Click(object sender, EventArgs e)
        {
            _tmp = Result_Box.Text;
            Result_Box.Text = "";
            Operaion_Label.Text = "/";
            _act = '/';
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // Result_Box.Text = "0";
        }

        private void C_Button_Click(object sender, EventArgs e)
        {
            Result_Box.Text = "";
        }

        private void Backspace_Button_Click(object sender, EventArgs e)
        {
            string s = Result_Box.Text.ToString().Remove(Result_Box.Text.Length - 1, 0);
            Operaion_Label.Text = s;

        }
    }
}
