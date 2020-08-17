using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Groen_Taxikosten
{
    public partial class Form1 : Form
    {

        // euro's per kilometer = 1
        const Decimal cfloatEurosPerKm = 1;

        // euro's met minuut = 0.25
        const Decimal cfloatEurosPerM = 0.25m;

        // anders = 0.45
        const Decimal cfloatEurosPerM2 = 0.45m;

        // tussen vrijdag 22.0
        const Decimal cfloatWeekendStartTijd = 22.0m;
        //  , maandag 7.0
        const Decimal cfloatWeekendEindTijd = 7.0m;
        // *15%\
        const Decimal cfloatWeekendMult = 1.15m;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listboxStartDay.TopIndex = 6;
            listboxEndDay.TopIndex = 6;
            textBoxPrijs.Text = "€ 0.00";
        }

        private void buttonRekenPrijs_Click(object sender, EventArgs e)
        {
            RekenPrijs();


            //Console.WriteLine(listboxStartDay.GetItemText(listboxStartDay.SelectedItem));
            //textBoxPrijs.Text = listboxStartDay.GetItemText(listboxStartDay.Items[listboxStartDay.TopIndex]);


        }

        const decimal max_min = 7*24*60 + 24*60 + 60;
        private void RekenPrijs()
        {
            Decimal prijs = 0;

            Decimal geredenKM;


            geredenKM = numericUpDownGeredenKM.Value;

            // listboxEndDay.TopIndex
            // 0 = Zondag
            // 1 = Zaterdag
            // 2 = Vrijdag
            // 3 = Donderdag
            // 4 = Woensdag
            // 5 = Dinsdag
            // 6 = Maandag

            // 7-listboxStartDay.TopIndex because the list is inverted for UI/UX
            Decimal sum_min_start = (7-listboxStartDay.TopIndex) * 24 * 60 +
                numericUpDownStartTimeHours.Value * 60 +
                numericUpDownStartTimeMinutes.Value;


            Decimal sum_min_end = (7 - listboxEndDay.TopIndex) * 24 * 60 +
                numericUpDownEndTimeHours.Value * 60 +
                numericUpDownEndTimeMinutes.Value;

            Decimal dif_sum_min = ((sum_min_end+max_min)-sum_min_start)% max_min;




            prijs = geredenKM; // * 1€ per gereden kilometer

            if (numericUpDownStartTimeHours.Value >= 8 && numericUpDownStartTimeHours.Value < 18)
            {
                prijs += dif_sum_min * 0.25M;
                checkBoxDagTarief.Checked = true;
                checkBoxNachtTarief.Checked = false;
            } else
            {
                checkBoxDagTarief.Checked = false;
                checkBoxNachtTarief.Checked = true;
                prijs += dif_sum_min * 0.45M;
            }

            // Prijsverhooging tijdens het weekend
            if ((listboxStartDay.TopIndex == 0) || (listboxStartDay.TopIndex == 1) || // for sun- and saturday the whole day counts
                (listboxStartDay.TopIndex == 2 && numericUpDownStartTimeHours.Value >= 22) || // for friday only post 22:00
                (listboxStartDay.TopIndex == 6 && numericUpDownStartTimeHours.Value < 7))// for monday only before 7:00
            {
                checkBoxWeekendTarief.Checked = true;
                prijs *= 1.15M;
            } else
            {
                checkBoxWeekendTarief.Checked = false;
            }

            // Laat de prijs zien
            textBoxPrijs.Text = "€ " + Math.Round(prijs, 2);
        }

        private void buttonMoveDateUp_Click(object sender, EventArgs e)
        {
            // move end time to start time
            numericUpDownStartTimeHours.Value = numericUpDownEndTimeHours.Value;
            numericUpDownStartTimeMinutes.Value = numericUpDownEndTimeMinutes.Value;
            listboxStartDay.TopIndex = listboxEndDay.TopIndex;
            RekenPrijs();
        }

        private void buttonMoveDateDown_Click(object sender, EventArgs e)
        {
            // move start time to end time
            numericUpDownEndTimeHours.Value = numericUpDownStartTimeHours.Value;
            numericUpDownEndTimeMinutes.Value = numericUpDownStartTimeMinutes.Value;
            listboxEndDay.TopIndex = listboxStartDay.TopIndex;
            RekenPrijs();
        }




        private void OverflowCheckStart()
        {
            // test minutes for overflow and then change minutes & hours
            if (numericUpDownStartTimeMinutes.Value > 59)
            {
                numericUpDownStartTimeMinutes.Value = 0;
                numericUpDownStartTimeHours.Value = (numericUpDownStartTimeHours.Value + 1) % 60;
            }
            else if (numericUpDownStartTimeMinutes.Value < 0)
            {
                numericUpDownStartTimeMinutes.Value = 59;
                numericUpDownStartTimeHours.Value = (numericUpDownStartTimeHours.Value - 1) % 60;
            }
            // test hours for overflow and then change hours & days
            if (numericUpDownStartTimeHours.Value > 23)
            {
                numericUpDownStartTimeHours.Value = 0;
                // +7 because x%y is not actually modulus but remainder and, of course, C#
                //    doesn't have math.mod() for some... 'silly' reason. ?!?!?!
                listboxStartDay.TopIndex = (listboxStartDay.TopIndex - 1 + 7) % 7;
            }
            else if (numericUpDownStartTimeHours.Value < 0)
            {
                numericUpDownStartTimeHours.Value = 23;
                listboxStartDay.TopIndex = (listboxStartDay.TopIndex + 1) % 7;
            }
            // days doesn't support overflow atm when using listBox.
        }

        private void OverflowCheckEnd()
        {
            // test minutes for overflow and then change minutes & hours
            if(numericUpDownEndTimeMinutes.Value > 59) {
                numericUpDownEndTimeMinutes.Value = 0;
                numericUpDownEndTimeHours.Value = (numericUpDownEndTimeHours.Value + 1) % 60;
            } else if (numericUpDownEndTimeMinutes.Value < 0)
            {
                numericUpDownEndTimeMinutes.Value = 59;
                numericUpDownEndTimeHours.Value = (numericUpDownEndTimeHours.Value - 1) % 60;
            }
            // test hours for overflow and then change hours & days
            if (numericUpDownEndTimeHours.Value > 23)
            {
                numericUpDownEndTimeHours.Value = 0;
                // +7 because x%y is not actually modulus but remainder and, of course, C#
                //    doesn't have math.mod() for some... 'silly' reason. ?!?!?!
                // and no, I can't move this to a 3th if statement because listboxEndDay.TopIndex can't be -1,
                //    so I'd need to write a temp value to store it in and then add 7 *anyway*.
                listboxEndDay.TopIndex = (listboxEndDay.TopIndex - 1 +7) % 7;
            }
            else if (numericUpDownEndTimeHours.Value < 0)
            {
                numericUpDownEndTimeHours.Value = 23;
                listboxEndDay.TopIndex = (listboxEndDay.TopIndex + 1) % 7;
            }
            // days doesn't support overflow atm when using listBox.
        }
        private void genericClickStart_Event(object sender, EventArgs e)
        {
            OverflowCheckStart();
            RekenPrijs();
        }
        private void genericClickEnd_Event(object sender, EventArgs e)
        {
            OverflowCheckEnd();
            RekenPrijs();
        }
        private void genericClick_Event(object sender, EventArgs e)
        {
            RekenPrijs();
        }
    }
}
