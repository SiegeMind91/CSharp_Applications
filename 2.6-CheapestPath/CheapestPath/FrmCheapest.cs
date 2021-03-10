using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

// Find the cheapest path through a rectangular grid:

//Searching in two dimensions: Find the best route:

//    4
//    5
//    12 10 33 21
//    15 20 14 24
//    18 15 52  5
//    22 21 30 41
//    12 14 20 33

//Imagine you are at the bottom left corner, 
//and want to go to the top right of this array. 
//You may only move east or north, and therefore must make
//7 moves altogether. At each point you must pay a toll: 
//the indicated amount of dollars. Write a program that will find 
//the minimum amount of money you must spend.

namespace CheapestPath
{
    public partial class FrmCheapest : Form
    {
        public FrmCheapest()
        {
            InitializeComponent();
        }

        int[,] grid = new int[100, 100];
        string[] lines;

        int gridXrow,gridYcolumn ;
        
        int cheapest;
        string path;

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCheapestPath_Click(object sender, EventArgs e)
        {
            DataFile(grid, ref gridXrow, ref gridYcolumn);
            TxtDisplay.Clear();
            Display(grid, gridXrow, gridYcolumn, "Original Grid");

            cheapest = 10000;
            
            BestPath(gridXrow, 1, grid[gridXrow,1], "" + grid[gridXrow,1]);

            TxtDisplay.Text+= "The cheapest path is: " + cheapest.ToString("c") + ".- through " + path;
        }

        private void DataFile(int[,] m, ref int r, ref int c)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\cheap.txt";

            StreamReader read = new StreamReader(f);

            c = Convert.ToInt32(read.ReadLine());
            r = Convert.ToInt32(read.ReadLine());

            string WholeLine;
            
            for (int x = 1; x <= r; x++)
            {
                WholeLine = read.ReadLine();

                lines=WholeLine.Split(' ');
                
                //Alternate Solution
                //where the number of data per row varies
                //***************************************
                //int u = lines.Length;
                //for(int y=1;y<=u;y++)

                for (int y=1;y<=c;y++)
                {
                    m[x, y] = int.Parse(lines[y-1]);
                }            
            }

            read.Close();
        }

        

        private void Display(int[,] m, int rows, int cols, string text)
        {

            TxtDisplay.Text += text + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;


            for (int r = 1; r <= rows; r++)
            {

                for (int c = 1; c <= cols; c++)
                {
                    TxtDisplay.Text += Convert.ToString(m[r, c]) + "\t" ;
                }
                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;
        }

        private void BestPath (int x, int y, int cost, String p)
        {
     
            if (x > 1)
            {
                BestPath (x -1 , y, cost + grid [x - 1,y], p + " " + grid [x - 1,y]);
            }

     
            if (y < gridYcolumn)
            {
                BestPath (x, y + 1, cost + grid [x,y + 1], p + " " + grid [x,y + 1]);
            }
     
            if (x == 1 && y== gridYcolumn   && cost < cheapest)
            {
                cheapest = cost;
                path = p;
                
            }
        }
         
     }

        
    
}