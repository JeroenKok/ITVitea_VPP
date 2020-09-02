using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            radioEditNumber1.Checked = true;
            radioEditNumber2.Checked = false;
            updateText();
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
            power,
            log,
            root,
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
            // get the second number
            // get operator
            // show result

            decimal gottenNumber = -1; // can do because this is the button, not the number used in the sum

            // I'd love to have used a switch, but switch doesn't like button as a variable for some reason.
            // In the later code you'll see I know how to use it. Maybe it's confused as it's trying to hash sender or so?
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

            // Operator buttons
            else if (sender == buttonAdd)
            {
                chosenOperator = enumOperator.add;
            }
            else if (sender == buttonSub)
            {
                chosenOperator = enumOperator.sub;
            }
            else if (sender == buttonMult)
            {
                chosenOperator = enumOperator.multiply;
            }
            else if (sender == buttonDiv)
            {
                chosenOperator = enumOperator.divide;
            }
            else if (sender == buttonPower)
            {
                chosenOperator = enumOperator.power;
            }
            else if (sender == buttonLog)
            {
                chosenOperator = enumOperator.log;
            }
            else if (sender == buttonRoot)
            {
                chosenOperator = enumOperator.root;
            }

            // Fuctional buttons
            else if (sender == buttonDecimalPoint)
            {
                // if xNumber, make xNumberDecimal
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
                radioEditNumber1.Checked = true;
                radioEditNumber2.Checked = false;
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
            updateText();
        }

        void updateText()
        {
            // Format the textfield with the sum

            textBoxFirstNumber.Text = Convert.ToString(firstNumber);
            textBoxSecondNumber.Text = Convert.ToString(secondNumber);

            switch (chosenOperator)
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
                case enumOperator.power:
                    textBoxOperator.Text = "^";
                    break;
                case enumOperator.log:
                    textBoxOperator.Text = "Log";
                    break;
                case enumOperator.root:
                    textBoxOperator.Text = "√";
                    break;
                case enumOperator.none:
                    textBoxOperator.Text = "";
                    break;
            }

            textBoxAnswer.Text = Convert.ToString(lastAnswer);
        }

        void calculateSum()
        {
            //if(firstNumber != 0M && secondNumber != 0M && chosenOperator != enumOperator.none) {

            // don't calc if you don't know the operator
            // big question, if the user does things like x/0, am I the one to catch that?
            // would be neat, I suppose.
            if(chosenOperator != enumOperator.none) {
                try {
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
                            // I'm really starting to get annoyed with a lot of stuff not having a decimal overload
                            //    If anyone comlpains about "loss of precision", it'd like to know how working with exclusivly doubles
                            //    is more precise
                            //    Ok, it technically is because it prevents the mantise from changing during conversion.
                        case enumOperator.power:
                            lastAnswer = (decimal)Math.Pow((double)firstNumber, (double)secondNumber);
                            break;
                        case enumOperator.log:
                            // not entirely sure if I want to do it in this order.
                            lastAnswer = (decimal)Math.Log((double)secondNumber, (double)firstNumber);
                            break;
                        case enumOperator.root:
                            // It's also a bit weird that Math root doesn't come with one that takes 2 parameters, but log did
                            // Even the Witcher 2 isn't this incosistent.
                            lastAnswer = (decimal)Math.Sqrt((double)firstNumber);
                            break;
                    }
                }
                catch (DivideByZeroException e)
                {
                    textBoxAnswer.Text = "Div/0!";
                }
                catch (OverflowException e)
                {
                    textBoxAnswer.Text = "Number's to big!";
                }
            }
        }

        private void radioEditNumber1_Clicked(object sender, MouseEventArgs e)
        {
            radioEditNumber1.Checked = true;
            radioEditNumber2.Checked = false;
            calcState = enumState.getFirstNumber;
            firstNumber = 0;
            updateText();
        }

        private void radioEditNumber2_Clicked(object sender, MouseEventArgs e)
        {
            radioEditNumber1.Checked = false;
            radioEditNumber2.Checked = true;
            calcState = enumState.getSecondNumber;
            secondNumber = 0;
            updateText();
        }

    }
}
