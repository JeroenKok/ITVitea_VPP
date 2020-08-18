using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rood_Rekenmachine
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        enum enumState
        {
            getFirstNumber,
            getSecondNumber
        }

        enum enumOperator
        {
            add,
            sub,
            multiply,
            divide
        }
                  

        decimal lastAnswer = 0; // so it doesn't crash when using Ans before Calc
        decimal firstNumber;
        decimal secondNumber;

        enumOperator chosenOperator;

        private void buttonNumeric_Click(object sender, EventArgs e)
        {
            // get the first number
            //    untill getting an operator
            // get the second number
            //    untill getting calc command
            // show result


            // would use switch, but switch doesn't like button as a variable
            // Numeric buttons
            if (sender == button0)
            {
                textBox.Text = "0";
            }
            else if(sender == button1)
            {
                textBox.Text = "1";
            }
            else if (sender == button2)
            {
                textBox.Text = "2";
            }
            else if (sender == button3)
            {
                textBox.Text = "3";
            }
            else if (sender == button4)
            {
                textBox.Text = "4";
            }
            else if (sender == button5)
            {
                textBox.Text = "5";
            }
            else if (sender == button6)
            {
                textBox.Text = "6";
            }
            else if (sender == button7)
            {
                textBox.Text = "7";
            }
            else if (sender == button8)
            {
                textBox.Text = "8";
            }
            else if (sender == button9)
            {
                textBox.Text = "9";
            }

            // Calculus buttons
            else if (sender == buttonAdd)
            {

            }
            else if (sender == buttonSub)
            {

            }
            else if (sender == buttonMult)
            {

            }
            else if (sender == buttonDiv)
            {

            }

            // Fuctional buttons
            else if (sender == buttonDecimalPoint)
            {

            }
            else if (sender == buttonAns)
            {

            }
            else if (sender == buttonCalc)
            {

            }
            else if (sender == buttonDel)
            {

            }
            else if (sender == buttonClear)
            {

            }
        }
    }
}
