using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RecursiveMazeProblem
{
    public partial class FrmRecursiveMaze : Form
    {
        public FrmRecursiveMaze()
        {
            InitializeComponent();
        }

        int rows;
        int cols;
        int startrow, startcolumn, endrow, endcolumn;

        string[,] grid = new string[100, 100];
               

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBegin_Click(object sender, EventArgs e)
        {
            DataFile(grid, ref rows, ref cols);

            TxtDisplay.Clear();
            
            Display(grid, rows, cols, "Original Grid");
            TxtDisplay.Text += "Starting position is row: " + startrow.ToString() + " column :" + startcolumn.ToString() + Environment.NewLine;
            TxtDisplay.Text += "Ending position is row: " + endrow.ToString() + " column :" + endcolumn.ToString() + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;
            
            if (FindPath(startrow, startcolumn))
            {
                TxtDisplay.Text += "Goal Reached !!" + Environment.NewLine;
                Display(grid, rows, cols, "Here is the Path");
            }
            else
            {
                TxtDisplay.Text += "Goal not reached";
            }
        }

        private void DataFile(string[,] m, ref int r, ref int c)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\rmaze.txt";

            StreamReader read = new StreamReader(f);

            c = Convert.ToInt32(read.ReadLine());
            r = Convert.ToInt32(read.ReadLine());

            for (int x = 1; x <= r; x++)
            {
                string oneLine = read.ReadLine();

                for (int y = 1; y <= c; y++)
                {
                    m[x, y] = oneLine.Substring(y - 1, 1);
                    
                    if (m[x, y] == "S")
                    {
                        startrow = x;
                        startcolumn = y;
                    }

                    if (m[x, y] == "G")
                    {
                        endrow = x;
                        endcolumn = y;
                    }
                }
            }

            read.Close();
        }

        private bool validLoc(int r, int c)
        {
            bool valid = false;

            if (r >= 1 && r <= rows && c >= 1 && c <= cols)
            {
                if (grid[r, c] == "." || grid[r,c]=="S" || grid[r,c]=="G")
                {
                    valid = true;
                }
            }
            return valid;
        }

        private void Display(string[,] m, int rows, int cols, string text)
        {

            TxtDisplay.Text += text + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;


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

        private bool FindPath(int r, int c)
        {
            bool done = false;

            // method first checks to see if the current location is valid
            // If it is , the program marks the current position with the symbol '-'
            // This ensures that the method will not wander around the maze forever
            // if it is forced to back up.

            if (validLoc(r, c))
            {
                grid[r, c] = "-";

                if (r == endrow && c == endcolumn)
                {
                    done = true;
                }
                else
                {
                    done = FindPath(r + 1, c);
                    if (!done)
                        done = FindPath(r, c + 1);
                    if (!done)
                        done = FindPath(r - 1, c);
                    if (!done)
                        done = FindPath(r, c - 1);
                }

                //mark this as part of a correct path
                if (done)
                    grid[r, c] = "P";

            }

            return done;
        }

    }
}