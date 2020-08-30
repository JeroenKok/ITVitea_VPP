namespace Groen_Taxikosten
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
            this.listboxStartDay = new System.Windows.Forms.ListBox();
            this.listboxEndDay = new System.Windows.Forms.ListBox();
            this.numericUpDownGeredenKM = new System.Windows.Forms.NumericUpDown();
            this.textBoxPrijs = new System.Windows.Forms.TextBox();
            this.numericUpDownStartTimeHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStartTimeMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEndTimeMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEndTimeHours = new System.Windows.Forms.NumericUpDown();
            this.buttonMoveDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxDagTarief = new System.Windows.Forms.CheckBox();
            this.checkBoxNachtTarief = new System.Windows.Forms.CheckBox();
            this.checkBoxWeekendTarief = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGeredenKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartTimeHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartTimeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndTimeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndTimeHours)).BeginInit();
            this.SuspendLayout();
            // 
            // listboxStartDay
            // 
            this.listboxStartDay.AccessibleName = "";
            this.listboxStartDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxStartDay.FormattingEnabled = true;
            this.listboxStartDay.ItemHeight = 24;
            this.listboxStartDay.Items.AddRange(new object[] {
            "Zondag",
            "Zaterdag",
            "Vrijdag",
            "Donderdag",
            "Woensdag",
            "Dinsdag",
            "Maandag"});
            this.listboxStartDay.Location = new System.Drawing.Point(65, 82);
            this.listboxStartDay.Name = "listboxStartDay";
            this.listboxStartDay.Size = new System.Drawing.Size(140, 28);
            this.listboxStartDay.TabIndex = 1;
            this.listboxStartDay.MouseCaptureChanged += new System.EventHandler(this.genericClick_Event);
            // 
            // listboxEndDay
            // 
            this.listboxEndDay.AccessibleName = "";
            this.listboxEndDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxEndDay.FormattingEnabled = true;
            this.listboxEndDay.ItemHeight = 24;
            this.listboxEndDay.Items.AddRange(new object[] {
            "Zondag",
            "Zaterdag",
            "Vrijdag",
            "Donderdag",
            "Woensdag",
            "Dinsdag",
            "Maandag"});
            this.listboxEndDay.Location = new System.Drawing.Point(65, 145);
            this.listboxEndDay.Name = "listboxEndDay";
            this.listboxEndDay.Size = new System.Drawing.Size(140, 28);
            this.listboxEndDay.TabIndex = 3;
            this.listboxEndDay.MouseCaptureChanged += new System.EventHandler(this.genericClick_Event);
            // 
            // numericUpDownGeredenKM
            // 
            this.numericUpDownGeredenKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownGeredenKM.Location = new System.Drawing.Point(393, 82);
            this.numericUpDownGeredenKM.Name = "numericUpDownGeredenKM";
            this.numericUpDownGeredenKM.Size = new System.Drawing.Size(120, 29);
            this.numericUpDownGeredenKM.TabIndex = 5;
            this.numericUpDownGeredenKM.ValueChanged += new System.EventHandler(this.genericClick_Event);
            // 
            // textBoxPrijs
            // 
            this.textBoxPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrijs.Location = new System.Drawing.Point(65, 254);
            this.textBoxPrijs.Name = "textBoxPrijs";
            this.textBoxPrijs.Size = new System.Drawing.Size(140, 29);
            this.textBoxPrijs.TabIndex = 7;
            // 
            // numericUpDownStartTimeHours
            // 
            this.numericUpDownStartTimeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownStartTimeHours.Location = new System.Drawing.Point(213, 82);
            this.numericUpDownStartTimeHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownStartTimeHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownStartTimeHours.Name = "numericUpDownStartTimeHours";
            this.numericUpDownStartTimeHours.Size = new System.Drawing.Size(63, 29);
            this.numericUpDownStartTimeHours.TabIndex = 9;
            this.numericUpDownStartTimeHours.ValueChanged += new System.EventHandler(this.genericClickStart_Event);
            // 
            // numericUpDownStartTimeMinutes
            // 
            this.numericUpDownStartTimeMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownStartTimeMinutes.Location = new System.Drawing.Point(282, 81);
            this.numericUpDownStartTimeMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownStartTimeMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownStartTimeMinutes.Name = "numericUpDownStartTimeMinutes";
            this.numericUpDownStartTimeMinutes.Size = new System.Drawing.Size(63, 29);
            this.numericUpDownStartTimeMinutes.TabIndex = 10;
            this.numericUpDownStartTimeMinutes.ValueChanged += new System.EventHandler(this.genericClickStart_Event);
            // 
            // numericUpDownEndTimeMinutes
            // 
            this.numericUpDownEndTimeMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownEndTimeMinutes.Location = new System.Drawing.Point(282, 145);
            this.numericUpDownEndTimeMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownEndTimeMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownEndTimeMinutes.Name = "numericUpDownEndTimeMinutes";
            this.numericUpDownEndTimeMinutes.Size = new System.Drawing.Size(63, 29);
            this.numericUpDownEndTimeMinutes.TabIndex = 12;
            this.numericUpDownEndTimeMinutes.ValueChanged += new System.EventHandler(this.genericClickEnd_Event);
            // 
            // numericUpDownEndTimeHours
            // 
            this.numericUpDownEndTimeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownEndTimeHours.Location = new System.Drawing.Point(213, 145);
            this.numericUpDownEndTimeHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownEndTimeHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownEndTimeHours.Name = "numericUpDownEndTimeHours";
            this.numericUpDownEndTimeHours.Size = new System.Drawing.Size(63, 29);
            this.numericUpDownEndTimeHours.TabIndex = 11;
            this.numericUpDownEndTimeHours.ValueChanged += new System.EventHandler(this.genericClickEnd_Event);
            // 
            // buttonMoveDate
            // 
            this.buttonMoveDate.Location = new System.Drawing.Point(158, 116);
            this.buttonMoveDate.Name = "buttonMoveDate";
            this.buttonMoveDate.Size = new System.Drawing.Size(27, 23);
            this.buttonMoveDate.TabIndex = 13;
            this.buttonMoveDate.Text = "Λ";
            this.buttonMoveDate.UseVisualStyleBackColor = true;
            this.buttonMoveDate.Click += new System.EventHandler(this.buttonMoveDateUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Uren";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Minuten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gereden KM.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Prijs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "V";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonMoveDateDown_Click);
            // 
            // checkBoxDagTarief
            // 
            this.checkBoxDagTarief.AutoCheck = false;
            this.checkBoxDagTarief.AutoSize = true;
            this.checkBoxDagTarief.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDagTarief.Location = new System.Drawing.Point(334, 195);
            this.checkBoxDagTarief.Name = "checkBoxDagTarief";
            this.checkBoxDagTarief.Size = new System.Drawing.Size(203, 28);
            this.checkBoxDagTarief.TabIndex = 20;
            this.checkBoxDagTarief.Text = "Dag Tarief (0.25/min)";
            this.checkBoxDagTarief.UseVisualStyleBackColor = true;
            // 
            // checkBoxNachtTarief
            // 
            this.checkBoxNachtTarief.AutoCheck = false;
            this.checkBoxNachtTarief.AutoSize = true;
            this.checkBoxNachtTarief.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNachtTarief.Location = new System.Drawing.Point(334, 229);
            this.checkBoxNachtTarief.Name = "checkBoxNachtTarief";
            this.checkBoxNachtTarief.Size = new System.Drawing.Size(218, 28);
            this.checkBoxNachtTarief.TabIndex = 21;
            this.checkBoxNachtTarief.Text = "Nacht Tarief (0.45/min)";
            this.checkBoxNachtTarief.UseVisualStyleBackColor = true;
            // 
            // checkBoxWeekendTarief
            // 
            this.checkBoxWeekendTarief.AutoCheck = false;
            this.checkBoxWeekendTarief.AutoSize = true;
            this.checkBoxWeekendTarief.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxWeekendTarief.Location = new System.Drawing.Point(334, 263);
            this.checkBoxWeekendTarief.Name = "checkBoxWeekendTarief";
            this.checkBoxWeekendTarief.Size = new System.Drawing.Size(225, 28);
            this.checkBoxWeekendTarief.TabIndex = 22;
            this.checkBoxWeekendTarief.Text = "Weekend Tarief (x1.15)";
            this.checkBoxWeekendTarief.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 323);
            this.Controls.Add(this.checkBoxWeekendTarief);
            this.Controls.Add(this.checkBoxNachtTarief);
            this.Controls.Add(this.checkBoxDagTarief);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMoveDate);
            this.Controls.Add(this.numericUpDownEndTimeMinutes);
            this.Controls.Add(this.numericUpDownEndTimeHours);
            this.Controls.Add(this.numericUpDownStartTimeMinutes);
            this.Controls.Add(this.numericUpDownStartTimeHours);
            this.Controls.Add(this.textBoxPrijs);
            this.Controls.Add(this.numericUpDownGeredenKM);
            this.Controls.Add(this.listboxEndDay);
            this.Controls.Add(this.listboxStartDay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGeredenKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartTimeHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartTimeMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndTimeMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndTimeHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listboxStartDay;
        private System.Windows.Forms.ListBox listboxEndDay;
        private System.Windows.Forms.NumericUpDown numericUpDownGeredenKM;
        private System.Windows.Forms.TextBox textBoxPrijs;
        private System.Windows.Forms.NumericUpDown numericUpDownStartTimeHours;
        private System.Windows.Forms.NumericUpDown numericUpDownStartTimeMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownEndTimeMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownEndTimeHours;
        private System.Windows.Forms.Button buttonMoveDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxDagTarief;
        private System.Windows.Forms.CheckBox checkBoxNachtTarief;
        private System.Windows.Forms.CheckBox checkBoxWeekendTarief;
    }
}

