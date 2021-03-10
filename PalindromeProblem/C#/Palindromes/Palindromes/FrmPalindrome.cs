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

namespace Palindromes
{
    public partial class FrmPalindrome : Form
    {
        public FrmPalindrome()
        {
            InitializeComponent();
        }

        private void BtnPalindrome_Click(object sender, EventArgs e)
        {
            TxtDisplay.Clear();

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\palindromes.txt";

            StreamReader r = new StreamReader(f);

            string line;
            bool finished = false;

            while (!finished)
            {
                line = r.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    if (isPalindrome(Strip(line))) //note here how  we have embedded a method inside another method
                    {
                        TxtDisplay.Text += line +  " YES" + Environment.NewLine;
                    }
                    else
                    {
                        TxtDisplay.Text += line + " NO" + Environment.NewLine;
                    }                    
                    
                }
            }
        }

        private bool isPalindrome(string s)
        {
            // empty strings are not palindromes
            if (s.Length == 0)
                return false;

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                string l = s.Substring(left, 1);
                string r = s.Substring(right, 1);

                if (l != r)
                    return false;

                left++;
                right--;
            }

            return true;
        }

        private string Strip(string s)
        {
            string result = "";
            s = s.ToUpper();

            for (int i = 0; i < s.Length; i++)
            {
                string character = s.Substring(i, 1);
                char tempchar = Convert.ToChar(character);

                //cant say character>="a" must convert it to type char first
                if ((tempchar >= 'a' && tempchar <= 'z') || (tempchar >='A' && tempchar <='Z'))
                {
                    result += character;
                }
            }
                       
            return result;
        }
    }
}
