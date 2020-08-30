namespace Rood_3_Versleutelen
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
            this.textBoxInputFileLoc = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOutputFilename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonInputFileDialog = new System.Windows.Forms.Button();
            this.buttonOutputFileDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInputFileLoc
            // 
            this.textBoxInputFileLoc.Location = new System.Drawing.Point(85, 37);
            this.textBoxInputFileLoc.Name = "textBoxInputFileLoc";
            this.textBoxInputFileLoc.Size = new System.Drawing.Size(622, 20);
            this.textBoxInputFileLoc.TabIndex = 0;
            this.textBoxInputFileLoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.InitialDirectory = "\".\"";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(85, 347);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(85, 301);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonEncode.TabIndex = 3;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Decode";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input File Location";
            // 
            // textBoxOutputFilename
            // 
            this.textBoxOutputFilename.Location = new System.Drawing.Point(85, 126);
            this.textBoxOutputFilename.Name = "textBoxOutputFilename";
            this.textBoxOutputFilename.Size = new System.Drawing.Size(622, 20);
            this.textBoxOutputFilename.TabIndex = 0;
            this.textBoxOutputFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output Filename";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(85, 223);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(173, 20);
            this.textBoxPassword.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // buttonInputFileDialog
            // 
            this.buttonInputFileDialog.Location = new System.Drawing.Point(85, 63);
            this.buttonInputFileDialog.Name = "buttonInputFileDialog";
            this.buttonInputFileDialog.Size = new System.Drawing.Size(75, 23);
            this.buttonInputFileDialog.TabIndex = 5;
            this.buttonInputFileDialog.Text = "Browse";
            this.buttonInputFileDialog.UseVisualStyleBackColor = true;
            this.buttonInputFileDialog.Click += new System.EventHandler(this.buttonInputFileDialog_Click);
            // 
            // buttonOutputFileDialog
            // 
            this.buttonOutputFileDialog.Location = new System.Drawing.Point(85, 157);
            this.buttonOutputFileDialog.Name = "buttonOutputFileDialog";
            this.buttonOutputFileDialog.Size = new System.Drawing.Size(75, 23);
            this.buttonOutputFileDialog.TabIndex = 5;
            this.buttonOutputFileDialog.Text = "Browse";
            this.buttonOutputFileDialog.UseVisualStyleBackColor = true;
            this.buttonOutputFileDialog.Click += new System.EventHandler(this.buttonOutputFileDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOutputFileDialog);
            this.Controls.Add(this.buttonInputFileDialog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.textBoxOutputFilename);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxInputFileLoc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputFileLoc;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOutputFilename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonInputFileDialog;
        private System.Windows.Forms.Button buttonOutputFileDialog;
    }
}

