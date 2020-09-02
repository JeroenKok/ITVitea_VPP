using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rood_3_Versleutelen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string inputFileName = "";
        string outputFileName = "";
        string passwordKey = "";
        int passwordKeyHash;

        FileStream FSinputFile;
        FileStream FSoutputFile;

        private IEnumerable<byte> bitModGenerator(int password)
        {
            // I have absolutely no idea if this even remotely works correctly.
            // But it was a fun experiment to try out.
            int password_T = password;
            byte moddednumber = (byte)0;

            while (true)
            {
                while (password_T > 0)
                {
                    moddednumber = (byte)(password_T % 251); // NextPrime(256, -1) because why not?
                    password_T -= 255;
                    yield return moddednumber;
                }
                password_T = password;
            }
        }

        private void buttonDEncode_Click(object sender, EventArgs e)
        {
            //int passwordlength = passwordKey.Length;

            inputFileName = textBoxInputFileLoc.Text;
            outputFileName = textBoxOutputFilename.Text;
            passwordKey = textBoxPassword.Text;
            passwordKeyHash = Math.Abs(passwordKey.GetHashCode());

            // Make sure all the things are in order

            if (!File.Exists(inputFileName))
            {
                Console.WriteLine("inputfile doesn't exist!");
                return;
            }
            if (outputFileName == "")
            {
                Console.WriteLine("outputfilename unspecified!");
                return;
            }
            if (passwordKey == "")
            {
                Console.WriteLine("Password empty");
                return;
            }

            // run through inputfile untill EOF
            // write to outputfile with bitModGen

            Console.WriteLine(inputFileName);
            Console.WriteLine(outputFileName);

            FSinputFile = File.Open(inputFileName, FileMode.Open, FileAccess.Read);
            FSoutputFile = File.Open(outputFileName, FileMode.Create, FileAccess.Write);

            int readbyteblock_size = 126; // magic number

            byte[] readbyteblock = new byte[readbyteblock_size];
            byte[] writebyteblock = new byte[readbyteblock_size];
            int readbytes;

            long filesize = new FileInfo(inputFileName).Length;
            progressBar1.Maximum = (int)filesize;

            while ((readbytes = FSinputFile.Read(readbyteblock, 0, readbyteblock_size)) > 0)
            {
                //Console.WriteLine("0:" + readbytes.ToString());
                //Console.WriteLine("1:" + readbyteblock.ToString());
                //Console.WriteLine("2:" + writebyteblock.ToString());

                progressBar1.Value = (int)FSinputFile.Position;

                for (int i = 0; i != readbytes; i++)
                {


                    if (sender == buttonEncode)
                    {
                        writebyteblock[i] = (byte)(readbyteblock[i] + bitModGenerator(passwordKeyHash).First());
                    } else if (sender == buttonDecode)
                    {
                        writebyteblock[i] = (byte)(readbyteblock[i] - bitModGenerator(passwordKeyHash).First());
                    }
                }

                FSoutputFile.Write(writebyteblock, 0, readbytes);
            }

            FSinputFile.Close();
            FSoutputFile.Close();
            Console.WriteLine("Done");
        }

        private void buttonInputFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            textBoxInputFileLoc.Text = openFileDialog.FileName;
        }

        private void buttonOutputFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            textBoxOutputFilename.Text = openFileDialog.FileName;
        }
    }
}
