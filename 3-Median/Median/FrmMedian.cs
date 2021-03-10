using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Median
{
    public partial class FrmMedian : Form
    {
        public FrmMedian()
        {
            InitializeComponent();
        }

        int c;
        int n;
        int[] marks = new int[100];


        private void BtnMedian_Click(object sender, EventArgs e)
        {
                                    
            LstSorted.Items.Clear();
                        
            ShellSort();            
            DisplaySortedList();
            Median();

        }

        

        private void DataFile()
        {

            c = 0;
            n = 0;

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\median.txt";

            StreamReader r = new StreamReader(f);

            string line;

            while ((line = r.ReadLine()) != null)
            {
                c++;
                marks[c] = Convert.ToInt32(line);
            }
            r.Close();
            n = c;
        }

        private void DisplayOriginalList()
        {
            for (int i = 1; i <= n; i++)
            {
                LstOriginal.Items.Add(marks[i].ToString());
            }
        }

        private void DisplaySortedList()
        {
            for (int i = 1; i <= n; i++)
            {
                LstSorted.Items.Add(marks[i].ToString());
            }
        }

        private void Swap(int[] list, int a, int b)
        {
            int temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }

        private void ShellSort()
        {
            int gap = n;
            int maximum, iplusg, ex;

            do
            {
                gap = gap / 2;
                maximum = n - gap;

                do
                {
                    ex = 0;

                    for (int i = 1; i <= maximum; i++)
                    {
                        iplusg = i + gap;

                        if (marks[i]> marks[iplusg])
                        {
                            Swap(marks, i, iplusg);
                            ex = ex + 1;
                        }
                    }
                }
                while (ex != 0);

            }
            while (gap >= 1);


        }

        private void FrmMedian_Load(object sender, EventArgs e)
        {
            DataFile();
            DisplayOriginalList();
        }

        private void Median()
        {
            MessageBox.Show("The median mark is " + median(marks,n).ToString("n2"));
        }

        private double median(int [] array, int u)
        {
            if (u%2==0)
            {
             return ( array[u/2] + array[(u+2)/2] )/2;
            }
            else
            {           
             return array[(u+1)/2];
            }
        }
        
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}