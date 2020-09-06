using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;

namespace Rood_4_Letterfrequenties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string inputFileName;
        Dictionary<char, int> letterFrequency;

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            textBoxInputFilename.Text = openFileDialog.FileName;
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {

            // setup a dictionary of chars
            // read through the whole file in strings (ReadLines)
            // sort chars into the dictionary
            // output a .txt file?

            inputFileName = textBoxInputFilename.Text;
            letterFrequency = new Dictionary<char, int>(255);


            if (!File.Exists(inputFileName))
            {
                Console.WriteLine("inputfile doesn't exist!");
                return;
            }

            using ( StreamReader SRinputFile = new StreamReader(inputFileName) )
            {

                long filesize = new FileInfo(inputFileName).Length;
                progressBar1.Maximum = (int)filesize;

                string line;
                while( (line = SRinputFile.ReadLine()) != null){

                    progressBar1.Value += (int)line.Length;

                    foreach (char chr in line)
                    {
                        if (letterFrequency.ContainsKey(chr))
                        {
                            letterFrequency[chr] += 1;
                        }
                        else
                        {
                            letterFrequency.Add(chr, 1);
                        }
                    }
                }
            }

            SortedDictionary<char, int> sortedLetterFrequency = new SortedDictionary<char, int>(letterFrequency);


            foreach ( char key in sortedLetterFrequency.Keys ){
                Console.WriteLine(key + "\t" + sortedLetterFrequency[key].ToString());
            }


            // letter
            using (StreamWriter SWoutputFile = new StreamWriter("letterFrequency.txt"))
            {
                foreach (char key in sortedLetterFrequency.Keys)
                {
                    SWoutputFile.WriteLine(key + "\t" + sortedLetterFrequency[key].ToString());
                }
            }

            // This is way to hacky. But I can't figure out the descrepancy between the maximum and read pointer.
            progressBar1.Value = progressBar1.Maximum;
        }
    }
}
