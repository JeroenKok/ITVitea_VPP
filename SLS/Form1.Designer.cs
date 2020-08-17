namespace SLS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InsertCoal = new System.Windows.Forms.Button();
            this.TextBoxWaterFlow = new System.Windows.Forms.TextBox();
            this.textBoxSteamDump = new System.Windows.Forms.TextBox();
            this.textBoxWaterDump = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxAirGrate = new System.Windows.Forms.TextBox();
            this.barCoalAmountTender_Current = new System.Windows.Forms.Button();
            this.barCoalAmountTender_Max = new System.Windows.Forms.Button();
            this.barCoalAmountFirebox_Current = new System.Windows.Forms.Button();
            this.barCoalAmountFirebox_Max = new System.Windows.Forms.Button();
            this.buttonLightFirebox = new System.Windows.Forms.Button();
            this.barWaterAmountBoiler_Current = new System.Windows.Forms.Button();
            this.barWaterAmountBoiler_Max = new System.Windows.Forms.Button();
            this.barWaterAmountTender_Current = new System.Windows.Forms.Button();
            this.barWaterAmountTender_Max = new System.Windows.Forms.Button();
            this.hScrollBarWaterFlow = new System.Windows.Forms.HScrollBar();
            this.hScrollBarSteamDump = new System.Windows.Forms.HScrollBar();
            this.hScrollBarWaterDump = new System.Windows.Forms.HScrollBar();
            this.hScrollBarBlower = new System.Windows.Forms.HScrollBar();
            this.hScrollBarAirGrate = new System.Windows.Forms.HScrollBar();
            this.barTempFirePit_Current = new System.Windows.Forms.Button();
            this.barTempFirePit_Max = new System.Windows.Forms.Button();
            this.labelFirePitTemp_Current = new System.Windows.Forms.Label();
            this.barSteamAmountBoiler_Current = new System.Windows.Forms.Button();
            this.barSteamAmountBoiler_Max = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InsertCoal
            // 
            this.InsertCoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertCoal.Location = new System.Drawing.Point(180, 256);
            this.InsertCoal.Name = "InsertCoal";
            this.InsertCoal.Size = new System.Drawing.Size(119, 34);
            this.InsertCoal.TabIndex = 6;
            this.InsertCoal.Text = "Insert Coal";
            this.InsertCoal.UseVisualStyleBackColor = true;
            this.InsertCoal.Click += new System.EventHandler(this.InsertCoal_Click);
            // 
            // TextBoxWaterFlow
            // 
            this.TextBoxWaterFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxWaterFlow.Location = new System.Drawing.Point(83, 320);
            this.TextBoxWaterFlow.Name = "TextBoxWaterFlow";
            this.TextBoxWaterFlow.Size = new System.Drawing.Size(136, 29);
            this.TextBoxWaterFlow.TabIndex = 11;
            this.TextBoxWaterFlow.Text = "Water";
            this.TextBoxWaterFlow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxWaterFlow.TextChanged += new System.EventHandler(this.TextBoxWaterLevel_TextChanged);
            // 
            // textBoxSteamDump
            // 
            this.textBoxSteamDump.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSteamDump.Location = new System.Drawing.Point(83, 388);
            this.textBoxSteamDump.Name = "textBoxSteamDump";
            this.textBoxSteamDump.Size = new System.Drawing.Size(136, 29);
            this.textBoxSteamDump.TabIndex = 12;
            this.textBoxSteamDump.Text = "Steam Dump";
            this.textBoxSteamDump.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxWaterDump
            // 
            this.textBoxWaterDump.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWaterDump.Location = new System.Drawing.Point(83, 433);
            this.textBoxWaterDump.Name = "textBoxWaterDump";
            this.textBoxWaterDump.Size = new System.Drawing.Size(136, 29);
            this.textBoxWaterDump.TabIndex = 13;
            this.textBoxWaterDump.Text = "Water Dump";
            this.textBoxWaterDump.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(83, 504);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(136, 29);
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "Blower";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAirGrate
            // 
            this.textBoxAirGrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAirGrate.Location = new System.Drawing.Point(83, 556);
            this.textBoxAirGrate.Name = "textBoxAirGrate";
            this.textBoxAirGrate.Size = new System.Drawing.Size(136, 29);
            this.textBoxAirGrate.TabIndex = 15;
            this.textBoxAirGrate.Text = "Air Grate";
            this.textBoxAirGrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // barCoalAmountTender_Current
            // 
            this.barCoalAmountTender_Current.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barCoalAmountTender_Current.Location = new System.Drawing.Point(127, 60);
            this.barCoalAmountTender_Current.Name = "barCoalAmountTender_Current";
            this.barCoalAmountTender_Current.Size = new System.Drawing.Size(104, 40);
            this.barCoalAmountTender_Current.TabIndex = 16;
            this.barCoalAmountTender_Current.UseVisualStyleBackColor = false;
            // 
            // barCoalAmountTender_Max
            // 
            this.barCoalAmountTender_Max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.barCoalAmountTender_Max.Location = new System.Drawing.Point(127, 60);
            this.barCoalAmountTender_Max.Name = "barCoalAmountTender_Max";
            this.barCoalAmountTender_Max.Size = new System.Drawing.Size(206, 40);
            this.barCoalAmountTender_Max.TabIndex = 17;
            this.barCoalAmountTender_Max.UseVisualStyleBackColor = false;
            // 
            // barCoalAmountFirebox_Current
            // 
            this.barCoalAmountFirebox_Current.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.barCoalAmountFirebox_Current.Location = new System.Drawing.Point(724, 60);
            this.barCoalAmountFirebox_Current.Name = "barCoalAmountFirebox_Current";
            this.barCoalAmountFirebox_Current.Size = new System.Drawing.Size(104, 40);
            this.barCoalAmountFirebox_Current.TabIndex = 18;
            this.barCoalAmountFirebox_Current.UseVisualStyleBackColor = false;
            // 
            // barCoalAmountFirebox_Max
            // 
            this.barCoalAmountFirebox_Max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.barCoalAmountFirebox_Max.Location = new System.Drawing.Point(724, 60);
            this.barCoalAmountFirebox_Max.Name = "barCoalAmountFirebox_Max";
            this.barCoalAmountFirebox_Max.Size = new System.Drawing.Size(206, 40);
            this.barCoalAmountFirebox_Max.TabIndex = 19;
            this.barCoalAmountFirebox_Max.UseVisualStyleBackColor = false;
            // 
            // buttonLightFirebox
            // 
            this.buttonLightFirebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLightFirebox.Location = new System.Drawing.Point(529, 60);
            this.buttonLightFirebox.Name = "buttonLightFirebox";
            this.buttonLightFirebox.Size = new System.Drawing.Size(128, 40);
            this.buttonLightFirebox.TabIndex = 20;
            this.buttonLightFirebox.Text = "Light Firebox";
            this.buttonLightFirebox.UseVisualStyleBackColor = true;
            this.buttonLightFirebox.Click += new System.EventHandler(this.buttonLightFirebox_Click);
            // 
            // barWaterAmountBoiler_Current
            // 
            this.barWaterAmountBoiler_Current.BackColor = System.Drawing.Color.Blue;
            this.barWaterAmountBoiler_Current.Location = new System.Drawing.Point(724, 125);
            this.barWaterAmountBoiler_Current.Name = "barWaterAmountBoiler_Current";
            this.barWaterAmountBoiler_Current.Size = new System.Drawing.Size(104, 40);
            this.barWaterAmountBoiler_Current.TabIndex = 23;
            this.barWaterAmountBoiler_Current.UseVisualStyleBackColor = false;
            // 
            // barWaterAmountBoiler_Max
            // 
            this.barWaterAmountBoiler_Max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.barWaterAmountBoiler_Max.Location = new System.Drawing.Point(724, 125);
            this.barWaterAmountBoiler_Max.Name = "barWaterAmountBoiler_Max";
            this.barWaterAmountBoiler_Max.Size = new System.Drawing.Size(206, 40);
            this.barWaterAmountBoiler_Max.TabIndex = 24;
            this.barWaterAmountBoiler_Max.UseVisualStyleBackColor = false;
            // 
            // barWaterAmountTender_Current
            // 
            this.barWaterAmountTender_Current.BackColor = System.Drawing.Color.Blue;
            this.barWaterAmountTender_Current.Location = new System.Drawing.Point(127, 125);
            this.barWaterAmountTender_Current.Name = "barWaterAmountTender_Current";
            this.barWaterAmountTender_Current.Size = new System.Drawing.Size(104, 40);
            this.barWaterAmountTender_Current.TabIndex = 21;
            this.barWaterAmountTender_Current.UseVisualStyleBackColor = false;
            // 
            // barWaterAmountTender_Max
            // 
            this.barWaterAmountTender_Max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.barWaterAmountTender_Max.Location = new System.Drawing.Point(127, 125);
            this.barWaterAmountTender_Max.Name = "barWaterAmountTender_Max";
            this.barWaterAmountTender_Max.Size = new System.Drawing.Size(206, 40);
            this.barWaterAmountTender_Max.TabIndex = 22;
            this.barWaterAmountTender_Max.UseVisualStyleBackColor = false;
            // 
            // hScrollBarWaterFlow
            // 
            this.hScrollBarWaterFlow.Location = new System.Drawing.Point(222, 320);
            this.hScrollBarWaterFlow.Name = "hScrollBarWaterFlow";
            this.hScrollBarWaterFlow.Size = new System.Drawing.Size(294, 29);
            this.hScrollBarWaterFlow.TabIndex = 25;
            // 
            // hScrollBarSteamDump
            // 
            this.hScrollBarSteamDump.Location = new System.Drawing.Point(222, 388);
            this.hScrollBarSteamDump.Name = "hScrollBarSteamDump";
            this.hScrollBarSteamDump.Size = new System.Drawing.Size(294, 29);
            this.hScrollBarSteamDump.TabIndex = 26;
            // 
            // hScrollBarWaterDump
            // 
            this.hScrollBarWaterDump.Location = new System.Drawing.Point(222, 433);
            this.hScrollBarWaterDump.Name = "hScrollBarWaterDump";
            this.hScrollBarWaterDump.Size = new System.Drawing.Size(294, 29);
            this.hScrollBarWaterDump.TabIndex = 27;
            // 
            // hScrollBarBlower
            // 
            this.hScrollBarBlower.Location = new System.Drawing.Point(222, 504);
            this.hScrollBarBlower.Name = "hScrollBarBlower";
            this.hScrollBarBlower.Size = new System.Drawing.Size(294, 29);
            this.hScrollBarBlower.TabIndex = 28;
            // 
            // hScrollBarAirGrate
            // 
            this.hScrollBarAirGrate.Location = new System.Drawing.Point(222, 556);
            this.hScrollBarAirGrate.Name = "hScrollBarAirGrate";
            this.hScrollBarAirGrate.Size = new System.Drawing.Size(294, 29);
            this.hScrollBarAirGrate.TabIndex = 29;
            // 
            // barTempFirePit_Current
            // 
            this.barTempFirePit_Current.BackColor = System.Drawing.Color.Red;
            this.barTempFirePit_Current.Location = new System.Drawing.Point(724, 209);
            this.barTempFirePit_Current.Name = "barTempFirePit_Current";
            this.barTempFirePit_Current.Size = new System.Drawing.Size(104, 40);
            this.barTempFirePit_Current.TabIndex = 30;
            this.barTempFirePit_Current.UseVisualStyleBackColor = false;
            // 
            // barTempFirePit_Max
            // 
            this.barTempFirePit_Max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.barTempFirePit_Max.Location = new System.Drawing.Point(724, 209);
            this.barTempFirePit_Max.Name = "barTempFirePit_Max";
            this.barTempFirePit_Max.Size = new System.Drawing.Size(206, 40);
            this.barTempFirePit_Max.TabIndex = 31;
            this.barTempFirePit_Max.UseVisualStyleBackColor = false;
            // 
            // labelFirePitTemp_Current
            // 
            this.labelFirePitTemp_Current.AutoSize = true;
            this.labelFirePitTemp_Current.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirePitTemp_Current.Location = new System.Drawing.Point(770, 276);
            this.labelFirePitTemp_Current.Name = "labelFirePitTemp_Current";
            this.labelFirePitTemp_Current.Size = new System.Drawing.Size(70, 25);
            this.labelFirePitTemp_Current.TabIndex = 32;
            this.labelFirePitTemp_Current.Text = "label1";
            // 
            // barSteamAmountBoiler_Current
            // 
            this.barSteamAmountBoiler_Current.BackColor = System.Drawing.Color.Blue;
            this.barSteamAmountBoiler_Current.Location = new System.Drawing.Point(724, 364);
            this.barSteamAmountBoiler_Current.Name = "barSteamAmountBoiler_Current";
            this.barSteamAmountBoiler_Current.Size = new System.Drawing.Size(104, 40);
            this.barSteamAmountBoiler_Current.TabIndex = 33;
            this.barSteamAmountBoiler_Current.UseVisualStyleBackColor = false;
            // 
            // barSteamAmountBoiler_Max
            // 
            this.barSteamAmountBoiler_Max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.barSteamAmountBoiler_Max.Location = new System.Drawing.Point(724, 364);
            this.barSteamAmountBoiler_Max.Name = "barSteamAmountBoiler_Max";
            this.barSteamAmountBoiler_Max.Size = new System.Drawing.Size(206, 40);
            this.barSteamAmountBoiler_Max.TabIndex = 34;
            this.barSteamAmountBoiler_Max.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 653);
            this.Controls.Add(this.barSteamAmountBoiler_Current);
            this.Controls.Add(this.barSteamAmountBoiler_Max);
            this.Controls.Add(this.labelFirePitTemp_Current);
            this.Controls.Add(this.barTempFirePit_Current);
            this.Controls.Add(this.barTempFirePit_Max);
            this.Controls.Add(this.hScrollBarAirGrate);
            this.Controls.Add(this.hScrollBarBlower);
            this.Controls.Add(this.hScrollBarWaterDump);
            this.Controls.Add(this.hScrollBarSteamDump);
            this.Controls.Add(this.hScrollBarWaterFlow);
            this.Controls.Add(this.barWaterAmountBoiler_Current);
            this.Controls.Add(this.barWaterAmountBoiler_Max);
            this.Controls.Add(this.barWaterAmountTender_Current);
            this.Controls.Add(this.barWaterAmountTender_Max);
            this.Controls.Add(this.buttonLightFirebox);
            this.Controls.Add(this.barCoalAmountFirebox_Current);
            this.Controls.Add(this.barCoalAmountFirebox_Max);
            this.Controls.Add(this.barCoalAmountTender_Current);
            this.Controls.Add(this.textBoxAirGrate);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxWaterDump);
            this.Controls.Add(this.textBoxSteamDump);
            this.Controls.Add(this.TextBoxWaterFlow);
            this.Controls.Add(this.InsertCoal);
            this.Controls.Add(this.barCoalAmountTender_Max);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button InsertCoal;
        private System.Windows.Forms.TextBox TextBoxWaterFlow;
        private System.Windows.Forms.TextBox textBoxSteamDump;
        private System.Windows.Forms.TextBox textBoxWaterDump;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxAirGrate;
        private System.Windows.Forms.Button barCoalAmountTender_Current;
        private System.Windows.Forms.Button barCoalAmountTender_Max;
        private System.Windows.Forms.Button barCoalAmountFirebox_Current;
        private System.Windows.Forms.Button barCoalAmountFirebox_Max;
        private System.Windows.Forms.Button buttonLightFirebox;
        private System.Windows.Forms.Button barWaterAmountBoiler_Current;
        private System.Windows.Forms.Button barWaterAmountBoiler_Max;
        private System.Windows.Forms.Button barWaterAmountTender_Current;
        private System.Windows.Forms.Button barWaterAmountTender_Max;
        private System.Windows.Forms.HScrollBar hScrollBarWaterFlow;
        private System.Windows.Forms.HScrollBar hScrollBarSteamDump;
        private System.Windows.Forms.HScrollBar hScrollBarWaterDump;
        private System.Windows.Forms.HScrollBar hScrollBarBlower;
        private System.Windows.Forms.HScrollBar hScrollBarAirGrate;
        private System.Windows.Forms.Button barTempFirePit_Current;
        private System.Windows.Forms.Button barTempFirePit_Max;
        private System.Windows.Forms.Label labelFirePitTemp_Current;
        private System.Windows.Forms.Button barSteamAmountBoiler_Current;
        private System.Windows.Forms.Button barSteamAmountBoiler_Max;
    }
}

