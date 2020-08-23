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
            getFirstNumberDecimal,
            getSecondNumber,
            getSecondNumberDecimal
        }

        enum enumOperator
        {
            add,
            sub,
            multiply,
            divide,
            none
        }
                  

        decimal lastAnswer = 0; // so it doesn't crash when using Ans before Calc
        decimal firstNumber = 0;
        decimal secondNumber = 0;
        string strOperator = "";

        enumOperator chosenOperator = enumOperator.none;
        enumState calcState = enumState.getFirstNumber;

        private void buttonGeneric_Click(object sender, EventArgs e)
        {
            // get the first number
            //    untill getting an operator
            // get the second number
            //    untill getting calc command
            // show result

            decimal gottenNumber = -1;


            // would use switch, but switch doesn't like button as a variable
            // Numeric buttons
            if (sender == button0)
            {
                gottenNumber = 0;
            }
            else if(sender == button1)
            {
                gottenNumber = 1;
            }
            else if (sender == button2)
            {
                gottenNumber = 2;
            }
            else if (sender == button3)
            {
                gottenNumber = 3;
            }
            else if (sender == button4)
            {
                gottenNumber = 4;
            }
            else if (sender == button5)
            {
                gottenNumber = 5;
            }
            else if (sender == button6)
            {
                gottenNumber = 6;
            }
            else if (sender == button7)
            {
                gottenNumber = 7;
            }
            else if (sender == button8)
            {
                gottenNumber = 8;
            }
            else if (sender == button9)
            {
                gottenNumber = 9;
            }

            // Calculus buttons
            else if (sender == buttonAdd)
            {
                chosenOperator = enumOperator.add;
                calcState = enumState.getSecondNumber;
            }
            else if (sender == buttonSub)
            {
                chosenOperator = enumOperator.sub;
                calcState = enumState.getSecondNumber;
            }
            else if (sender == buttonMult)
            {
                chosenOperator = enumOperator.multiply;
                calcState = enumState.getSecondNumber;
            }
            else if (sender == buttonDiv)
            {
                chosenOperator = enumOperator.divide;
                calcState = enumState.getSecondNumber;
            }

            // Fuctional buttons
            else if (sender == buttonDecimalPoint)
            {
                if( calcState == enumState.getFirstNumber)
                {
                    calcState = enumState.getFirstNumberDecimal;
                } else if (calcState == enumState.getSecondNumber)
                {
                    calcState = enumState.getSecondNumberDecimal;
                }
            }
            else if (sender == buttonAns)
            {
                if (calcState == enumState.getFirstNumber)
                {
                    firstNumber = lastAnswer;
                }
                else if (calcState == enumState.getSecondNumber)
                {
                    secondNumber = lastAnswer;
                }
            }
            else if (sender == buttonNegate)
            {
                if (calcState == enumState.getFirstNumber ||
                    calcState == enumState.getFirstNumberDecimal)
                {
                    firstNumber *= -1;
                }
                else if (calcState == enumState.getSecondNumber ||
                         calcState == enumState.getSecondNumberDecimal)
                {
                    secondNumber *= -1;
                }
            }
            else if (sender == buttonCalc)
            {
                // sending this to another function cause it's gonna be a big one.
                calculateSum();
            }
            else if (sender == buttonDel)
            {
                if (calcState == enumState.getFirstNumber)
                {
                    firstNumber = 0;
                }
                else if (calcState == enumState.getFirstNumberDecimal)
                {
                    firstNumber = 0;
                    calcState = enumState.getFirstNumber;
                }
                else if (calcState == enumState.getSecondNumber)
                {
                    secondNumber = 0;
                }
                else if (calcState == enumState.getSecondNumberDecimal)
                {
                    secondNumber = 0;
                    calcState = enumState.getSecondNumber;
                }
            }
            else if (sender == buttonClear)
            {
                firstNumber = 0;
                secondNumber = 0;
                chosenOperator = enumOperator.none;
                lastAnswer = 0;
                calcState = enumState.getFirstNumber;
            }


            if(gottenNumber != -1)
            {
                if (calcState == enumState.getFirstNumber)
                {
                    firstNumber *= 10;
                    firstNumber += gottenNumber;
                } else if(calcState == enumState.getFirstNumberDecimal)
                {
                    // while loop where I figure out how many decimal places the number has
                    //     gottenNumber*10**-iterations;
                    decimal tempFirstNumber = firstNumber%1; // get the remainder of firstnumber
                    int num_iterations = 1;
                    while( tempFirstNumber != 0M)
                    {
                        tempFirstNumber *= 10M;
                        tempFirstNumber %= 1;
                        num_iterations += 1;
                    }
                    firstNumber += gottenNumber * (decimal)Math.Pow(10, -num_iterations);
                }
                else if (calcState == enumState.getSecondNumber)
                {
                    secondNumber *= 10;
                    secondNumber += gottenNumber;
                }
                else if (calcState == enumState.getSecondNumberDecimal)
                {
                    // while loop where I figure out how many decimal places the number has
                    //     gottenNumber*10**-iterations;
                    decimal tempSecondNumber = secondNumber % 1; // get the remainder of firstnumber
                    int num_iterations = 1;
                    while (tempSecondNumber != 0M)
                    {
                        tempSecondNumber *= 10M;
                        tempSecondNumber %= 1;
                        num_iterations += 1;
                    }
                    secondNumber += gottenNumber * (decimal)Math.Pow(10, -num_iterations);
                }
            }

            // Format the textfield with the sum

            textBoxFirstNumber.Text = Convert.ToString(firstNumber);
            textBoxSecondNumber.Text = Convert.ToString(secondNumber);

            switch(chosenOperator)
            {
                case enumOperator.add:
                    textBoxOperator.Text = "+";
                    break;
                case enumOperator.sub:
                    textBoxOperator.Text = "-";
                    break;
                case enumOperator.multiply:
                    textBoxOperator.Text = "*";
                    break;
                case enumOperator.divide:
                    textBoxOperator.Text = "/";
                    break;
                case enumOperator.none:
                    textBoxOperator.Text = "";
                    break;
            }

            textBoxAnswer.Text = Convert.ToString(lastAnswer);
        }

        void calculateSum()
        {
            if(firstNumber != 0M && secondNumber != 0M && chosenOperator != enumOperator.none) {

                switch (chosenOperator)
                {
                    case enumOperator.add:
                        lastAnswer = firstNumber + secondNumber;
                        break;
                    case enumOperator.sub:
                        lastAnswer = firstNumber - secondNumber;
                        break;
                    case enumOperator.multiply:
                        lastAnswer = firstNumber * secondNumber;
                        break;
                    case enumOperator.divide:
                        lastAnswer = firstNumber / secondNumber;
                        break;
                }
            }
        }
    }
}
