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

namespace _7SegmentDisplayWordCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           // try
           // {
                // Open the Dictionary file.
                StreamReader sr;
                sr = File.OpenText("words.txt");
                string strWords = "";
                string[] words = new string[500000];

                bool isFailed = false;

                while (!sr.EndOfStream)
                {
                    strWords = sr.ReadToEnd();
                }

                words = strWords.Split();

                if (sr.EndOfStream)
                {
                    sr.Close();
                }

                // Declare unuseable letters.
                char[] BADCHARS = new char[] { 'g', 'k', 'm', 'q', 'v', 'w', 'x', 'z' };

                string strLongestAcceptableWord = "";


                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length > strLongestAcceptableWord.Length)
                    {
                        isFailed = false;
                        char[] characters = words[i].ToCharArray();

                        for (int b = 0; b < characters.Length; b++)
                        {
                            for (int v = 0; v < BADCHARS.Length; v++)
                            {
                                if (characters[b] == BADCHARS[v])
                                {
                                    // fail the word
                                    isFailed = true;
                                }
                                
                            }
                        }

                        if (isFailed)
                        {
                            continue;
                        }
                        else if (!isFailed)
                        {
                            strLongestAcceptableWord = words[i];
                            longestAccepableWord.Text = strLongestAcceptableWord;
                        }

                    }
                }
/*
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.Data);
            }
            */
        }
    }
}
