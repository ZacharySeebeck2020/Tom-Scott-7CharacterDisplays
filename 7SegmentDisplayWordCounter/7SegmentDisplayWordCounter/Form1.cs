﻿using System;
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

            try
            {
                StreamReader sr;
                sr = File.OpenText("words.txt");
                string strWords = "";
                string[] words = new string[500000];
                char[] BADCHARS = new char[] { 'g', 'k', 'm', 'q', 'v', 'w', 'x', 'z', 'i', 'o' }; // Added I and O to finish up with the end of Tom Scott's video. If you want it to be 'origonal' then you can go ahead and remove them.
                bool isFailed = false;
                string strLongestAcceptableWord = "";


                while (!sr.EndOfStream)
                {
                    strWords = sr.ReadToEnd();
                }

                words = strWords.Split();

                if (sr.EndOfStream)
                {
                    sr.Close();
                }

                totalWordCount.Text = words.Length.ToString();

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
                            longestWordLength.Text = strLongestAcceptableWord.Length.ToString();
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
