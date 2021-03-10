using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PathLength
{
    public partial class FrmPathLength : Form
    {
        public FrmPathLength()
        {
            InitializeComponent();
        }

        //  Find the length of the path   
        //  *****************************************************************
        //  Create a text file containing a field of x's and an path of 0's 
        //  starting in the top row. Let the field be a 20 rows x 30 columns.
        //  Looking something like the array of x's and o's below.
        //  Find the length of the path, knowing that the path starts 
        //  in the upper left hand corner, and that it will always 
        //  either go right or down. 
        //  *****************************************************************
        //     20 
        //     30
        //     0000000xxxxxxxxxxxxxxxxxxxxxxx
        //     xxxxxx000xxxxxxxxxxxxxxxxxxxxx
        //     xxxxxxxx0xxxxxxxxxxxxxxxxxxxxx
        //     xxxxxxxx0000xxxxxxxxxxxxxxxxxx
        //     xxxxxxxxxxx0xxxxxxxxxxxxxxxxxx
        //     xxxxxxxxxxx0xxxxxxxxxxxxxxxxxx
        //     xxxxxxxxxxx0xxxxxxxxxxxxxxxxxx
        //     xxxxxxxxxxx000xxxxxxxxxxxxxxxx
        //     xxxxxxxxxxxxx0xxxxxxxxxxxxxxxx
        //     xxxxxxxxxxxxx0xxxxxxxxxxxxxxxx
        //     xxxxxxxxxxxxx0xxxxxxxxxxxxxxxx
        //     xxxxxxxxxxxxx00000000xxxxxxxxx
        //     xxxxxxxxxxxxxxxxxxxx0xxxxxxxxx
        //     xxxxxxxxxxxxxxxxxxxx00xxxxxxxx
        //     xxxxxxxxxxxxxxxxxxxxx0xxxxxxxx
        //     xxxxxxxxxxxxxxxxxxxxx0xxxxxxxx
        //     xxxxxxxxxxxxxxxxxxxxx0xxxxxxxx
        //     xxxxxxxxxxxxxxxxxxxxx0xxxxxxxx
        //     xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        //     xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        // 
        // 
        // Find the length of a path that can go right and down only


        int rows = 0;
        int cols = 0;
        int steps=0;
        string[,] grid = new string[100,100];

        private void BtnPath_Click(object sender, EventArgs e)
        {
            DataFile(grid, ref rows,ref cols);
            Display(grid, rows,cols);
            PathFinder(1, 1, 1);
            TxtPath.Text += "The Length of the Path is :  " + steps.ToString();
        }

        private void DataFile(string[,] m, ref int r, ref int c)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\maze1.txt";

            StreamReader read = new StreamReader(f);

            r = Convert.ToInt32(read.ReadLine());
            c = Convert.ToInt32(read.ReadLine());
                        
            for (int x = 1; x <= r; x++)
            {
                string oneLine = read.ReadLine();
                
                for (int y = 1; y <= c; y++)
                {
                    m[x, y] = oneLine.Substring(y-1,1);
                }
            }            

            read.Close();
        }

        private void Display(string[,] m, int rows, int cols)
        {
            TxtPath.Clear();
            TxtPath.Text = "Original Grid" + Environment.NewLine;
            TxtPath.Text += Environment.NewLine;

            
            for (int r = 1; r <= rows; r++)
            {
                
                for (int c = 1; c <= cols; c++)
                {
                    TxtPath.Text += Convert.ToString(m[r, c]) ;
                }
                TxtPath.Text += Environment.NewLine;
            }

            TxtPath.Text += Environment.NewLine;
        }

        private void PathFinder(int r, int c,int pathSoFar)
        {
            if (validLoc(r, c))
            {
                steps = pathSoFar;

                PathFinder(r + 1, c, pathSoFar + 1);
                PathFinder(r, c + 1, pathSoFar + 1);
            }
        }

        private bool validLoc(int r, int c)
        {
            bool valid = false;

            if (r >= 1 && r <= rows && c >= 1 && c <= cols)
            {
                if (grid[r, c] == "0")
                {
                    valid = true;
                }
            }
            return valid;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPathLength_Load(object sender, EventArgs e)
        {

        }
    }
}