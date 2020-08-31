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



            // Another thing that Python is *much* nicer about
            chrtoMorseConverter.Add('a', ".-");
            chrtoMorseConverter.Add('b', "-...");
            chrtoMorseConverter.Add('c', "-.-.");
            chrtoMorseConverter.Add('d', "-..");
            chrtoMorseConverter.Add('e', ".");
            chrtoMorseConverter.Add('f', "..-.");
            chrtoMorseConverter.Add('g', "--.");
            chrtoMorseConverter.Add('h', "....");
            chrtoMorseConverter.Add('i', "..");
            chrtoMorseConverter.Add('j', ".---");
            chrtoMorseConverter.Add('k', "-.-");
            chrtoMorseConverter.Add('l', ".-..");
            chrtoMorseConverter.Add('m', "--");
            chrtoMorseConverter.Add('n', "-.");
            chrtoMorseConverter.Add('o', "---");
            chrtoMorseConverter.Add('p', ".--.");
            chrtoMorseConverter.Add('q', "--.-");
            chrtoMorseConverter.Add('r', ".-.");
            chrtoMorseConverter.Add('s', "...");
            chrtoMorseConverter.Add('t', "-");
            chrtoMorseConverter.Add('u', "..-");
            chrtoMorseConverter.Add('v', "...-");
            chrtoMorseConverter.Add('w', ".--");
            chrtoMorseConverter.Add('x', "-..-");
            chrtoMorseConverter.Add('y', "-.--");
            chrtoMorseConverter.Add('z', "--..");


            chrtoMorseConverter.Add('1', ".----");
            chrtoMorseConverter.Add('2', "..---");
            chrtoMorseConverter.Add('3', "...--");
            chrtoMorseConverter.Add('4', "....-");
            chrtoMorseConverter.Add('5', ".....");
            chrtoMorseConverter.Add('6', "-....");
            chrtoMorseConverter.Add('7', "--...");
            chrtoMorseConverter.Add('8', "---..");
            chrtoMorseConverter.Add('9', "----.");
            chrtoMorseConverter.Add('0', "-----");

            chrtoMorseConverter.Add(' ', "......"); // between each word
            chrtoMorseConverter.Add('.', ".-.-.-");
            chrtoMorseConverter.Add(',', "--..--");
            chrtoMorseConverter.Add('?', "..--..");
            chrtoMorseConverter.Add('\'', ".----.");
            chrtoMorseConverter.Add('!', "-.-.--");

            // chrtoMorseConverter.Add('!'', "-.-.--");


            //chrtoMorseConverter.setDefault(" "); // would be nice if this exists.

            foreach (KeyValuePair<char, string> kvp in chrtoMorseConverter)
            {
                morsetoChrConverter.Add(kvp.Value, kvp.Key);
            }
        }

        string inputFileName = "";
        string outputFileName = "";
        string passwordKey = "";
        int passwordKeyHash;

        Dictionary<char, string> chrtoMorseConverter = new Dictionary<char, string>();
        Dictionary<string, char> morsetoChrConverter = new Dictionary<string, char>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonDEncode_Click(object sender, EventArgs e)
        {
            //int passwordlength = passwordKey.Length;

            inputFileName = textBoxInputFileLoc.Text;
            outputFileName = textBoxOutputFilename.Text;
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

            // run through inputfile untill EOF
            // write to outputfile with bitModGen

            Console.WriteLine(inputFileName);
            Console.WriteLine(outputFileName);

            int readbyteblock_size = 126; // magic number

            byte[] readbyteblock = new byte[readbyteblock_size];
            byte[] writebyteblock = new byte[readbyteblock_size];
            int readbytes;

            string changedLine = "";


            if (sender == buttonEncode)
            {
                string balue = "";
                using (StreamWriter SWoutputFile = new StreamWriter(outputFileName))
                {
                    foreach (string line in File.ReadLines(inputFileName))
                    {
                        string nline = line.ToLower();
                        changedLine = "";

                        foreach (char chr in nline)
                        {
                            if( chrtoMorseConverter.TryGetValue(chr, out balue) )
                            {
                                changedLine += balue;
                            }
                            changedLine += " ";
                        }

                        SWoutputFile.WriteLine(changedLine);
                    }
                }
            }
            else if (sender == buttonDecode)
            {
                // reach each line, then seperate string into parts based on space's
                // then convert each part
                char balue;

                using (StreamWriter SWoutputFile = new StreamWriter(outputFileName))
                {
                    foreach (string line in File.ReadLines(inputFileName))
                    {
                        string[] morseWords = line.Split(' ');
                        changedLine = "";

                        foreach (string morseWord in morseWords)
                        {
                            if (morsetoChrConverter.TryGetValue(morseWord, out balue))
                            {
                                changedLine += balue;
                            }
                        }

                        SWoutputFile.WriteLine(changedLine);
                    }
                }

            }

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
