using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLS
{
    public partial class Form1 : Form
    {

        Decimal CoalAmountTender_Max = 10000;
        Decimal CoalAmountTender_Current = 10000;

        Decimal CoalAmountFirePit_Max = 100;
        Decimal CoalAmountFirePit_Current = 0;

        Decimal WaterAmountTender_Max = 10000;
        Decimal WaterAmountTender_Current = 10000;

        Decimal WaterAmountBoiler_Max = 100;
        Decimal WaterAmountBoiler_Current = 0;

        Decimal maxWaterFlow = 5;

        Decimal FirePitTemprature_Current = 0; // Kelvin or celcius?
        Decimal FirePitTemprature_Max = 1200; // Kelvin or celcius?
        bool isFirePitBurning = false;

        decimal FirePitTemprature_Pot;

        Decimal SteamAmountBoiler_Max = 200;
        Decimal SteamAmountBoiler_Current = 0;

        Decimal Speed = 0;

        private Timer simClock;
        static readonly Decimal timeStep = 1M/10M; //FPS

        public Form1()
        {
            simClock = new Timer();
            simClock.Tick += new EventHandler(updatesim);
            simClock.Interval = (int)(1000*timeStep);
            simClock.Start();

            InitializeComponent();
        }

        private void updatesim(object sender, EventArgs e)
        {


            moveWater();
            burnCoal();
            generateSteam();


            barCoalAmountTender_Current.Width = (int)((CoalAmountTender_Current / CoalAmountTender_Max) * barCoalAmountTender_Max.Width);
            barCoalAmountFirebox_Current.Width = (int)((CoalAmountFirePit_Current / CoalAmountFirePit_Max) * barCoalAmountFirebox_Max.Width);

            barWaterAmountTender_Current.Width = (int)((WaterAmountTender_Current / WaterAmountTender_Max) * barWaterAmountTender_Max.Width);
            barWaterAmountBoiler_Current.Width = (int)((WaterAmountBoiler_Current / WaterAmountBoiler_Max) * barWaterAmountBoiler_Max.Width);
            
            barTempFirePit_Current.Width = (int)((FirePitTemprature_Current / FirePitTemprature_Max) * barTempFirePit_Max.Width);
            labelFirePitTemp_Current.Text = Convert.ToString(Math.Round(FirePitTemprature_Current, 0));

            barSteamAmountBoiler_Current.Width = (int)((SteamAmountBoiler_Current / SteamAmountBoiler_Max) * barSteamAmountBoiler_Max.Width);

        }

        private void generateSteam()
        {
            decimal moveAmount = FirePitTemprature_Current/100;

            decimal BoP_Dif = SteamAmountBoiler_Max - SteamAmountBoiler_Current;
            decimal WaB_Dif = WaterAmountBoiler_Max - WaterAmountBoiler_Current;

            decimal movedAmount = Math.Min(moveAmount, Math.Min(BoP_Dif, WaB_Dif));

            WaterAmountBoiler_Current -= movedAmount * timeStep;
            SteamAmountBoiler_Current += movedAmount * timeStep;
        }

        private void burnCoal()
        {
            if (isFirePitBurning == true && FirePitTemprature_Current > 50M)
            {
                decimal airgrate_airflow = 1M;
                decimal blower_airflow = 1M;

                if (hScrollBarBlower.Value > 0M)
                {
                    decimal consumedSteam_Current = SteamAmountBoiler_Current * 0.05M * (hScrollBarBlower.Value / 100M);
                    SteamAmountBoiler_Current -= consumedSteam_Current;
                    blower_airflow = consumedSteam_Current/(SteamAmountBoiler_Current * 0.05M);
                }

                if(hScrollBarAirGrate.Value > 0M)
                {
                    airgrate_airflow = hScrollBarAirGrate.Value / 100M * 1M;// speed;
                }

                //decimal sum_airflow = blower_airflow + airgrate_airflow;
                decimal sum_airflow = 1 + Math.Min(2M, airgrate_airflow + blower_airflow + 1M);

                decimal FirePitTemprature_Pot = CoalAmountFirePit_Current * 3M * sum_airflow;

                decimal FirePitTemprature_Dif = (FirePitTemprature_Pot - FirePitTemprature_Current) / 8M * sum_airflow;

                FirePitTemprature_Current += FirePitTemprature_Dif * timeStep;

                decimal burnAmount = (FirePitTemprature_Current / 100M ) / 3M; // half a coal per 100c
                CoalAmountFirePit_Current -= burnAmount * timeStep;
            } else
            {
                FirePitTemprature_Current = 0;
                isFirePitBurning = false;
            }
        }

        private void InsertCoal_Click(object sender, EventArgs e)
        {
            moveCoal();
        }

        private void moveCoal()
        {
            decimal moveAmount = 25;

            decimal CAT_Dif = CoalAmountTender_Current;
            decimal CFP_Dif = CoalAmountFirePit_Max - CoalAmountFirePit_Current;

            decimal movedAmount = Math.Min(moveAmount, Math.Min(CAT_Dif, CFP_Dif));

            CoalAmountTender_Current -= movedAmount;
            CoalAmountFirePit_Current += movedAmount;
        }

        private void moveWater()
        {
            decimal moveAmount = hScrollBarWaterFlow.Value/maxWaterFlow;

            decimal WAT_Dif = WaterAmountTender_Current;
            decimal WaB_Dif = WaterAmountBoiler_Max - WaterAmountBoiler_Current;

            decimal movedAmount = Math.Min(moveAmount, Math.Min(WAT_Dif, WaB_Dif));

            WaterAmountTender_Current -= movedAmount * timeStep;
            WaterAmountBoiler_Current += movedAmount * timeStep;
        }

        private void buttonLightFirebox_Click(object sender, EventArgs e)
        {
            // Apply a small amount of heat to the firebox to get the temprature going.
            FirePitTemprature_Current = Math.Max(51, FirePitTemprature_Current);
            isFirePitBurning = true;
        }

        private void TextBoxWaterLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
