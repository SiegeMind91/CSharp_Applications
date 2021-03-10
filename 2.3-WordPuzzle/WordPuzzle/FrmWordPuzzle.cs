using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WordPuzzle
{
    public partial class FrmWordPuzzle : Form
    {
        public FrmWordPuzzle()
        {
            InitializeComponent();
        }

        string[,] grid = new string[11, 11];
        string[] word = new string[6];

        int startr, startc;

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            DataFile(grid,10,10,4);
            
            Display(grid, 10, 10, word, 4, "Original Info");

            for (int i = 1; i <= 4; i++)
            {
                Find(word[i],10,10);
            }

        }

        private void DataFile(string[,] m, int r, int c,int u)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\puzzle.txt";

            StreamReader read = new StreamReader(f);

            for (int i = 1; i <= u; i++)
            {
                word[i] = read.ReadLine();
            }


            for (int x = 1; x <= r; x++)
            {
                string oneLine = read.ReadLine();

                for (int y = 1; y <= c; y++)
                {
                    m[x, y] = oneLine.Substring(y - 1, 1);
                }
            }

            read.Close();
        }

        private void Display(string[,] m, int rows, int cols, string [] w,int u,string text)
        {

            TxtDisplay.Clear();
            TxtDisplay.Text += text + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;

            TxtDisplay.Text += "Words to Find" + Environment.NewLine;

            for (int i = 1; i <= u; i++)
            {
                TxtDisplay.Text += w[i] + Environment.NewLine;
            }
              
            TxtDisplay.Text += Environment.NewLine;
            TxtDisplay.Text += "Puzzle" + Environment.NewLine;

            
            for (int r = 1; r <= rows; r++)
            {

                for (int c = 1; c <= cols; c++)
                {
                    TxtDisplay.Text += Convert.ToString(m[r, c]);
                }
                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;
        }

        private void Find(string theword,int row,int col)
        {
            TxtDisplay.Text+= theword + " is located at ....";

            for (int r = 1; r <= row; r++)
            {
                for (int c = 1; c <= col; c++)
                {
                    startr = r;
                    startc = c;
                    SearchPuzzle(theword, 1, r, c);
                }
            }
           
        }

        private bool validLoc(int r, int c,int pr,int pc)
        {
            bool valid = false;

            if (r >= 1 && r <= pr && c >= 1 && c <= pc)
            {                
                    valid = true;                
            }
            return valid;
        }

        private void SearchPuzzle(string name, int letter, int row, int col)  //letter is current postion in name
        {

            if (validLoc(row, col,10,10))
            {
                if (name.Substring(letter - 1, 1)==(grid[row,col]))
                {
                    if (name.Length == letter)
                    {
                        TxtDisplay.Text += "(" + startr.ToString() + " - " + startc.ToString() + ")  " + Environment.NewLine; ;
                    }
                    else
                    {
                        SearchPuzzle(name, letter + 1, row + 1, col);
                        SearchPuzzle(name, letter + 1, row - 1, col);
                        SearchPuzzle(name, letter + 1, row, col + 1);
                        SearchPuzzle(name, letter + 1, row, col - 1);
                    }
                }
            }
        }
    }
}