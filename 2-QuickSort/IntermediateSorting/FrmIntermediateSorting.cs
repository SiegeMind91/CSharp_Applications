using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IntermediateSorting
{
    public partial class FrmIntermediateSorting : Form
    {
        public FrmIntermediateSorting()
        {
            InitializeComponent();
        }

        int c ;
        int n ;
        string [] names = new string [2000];
        
        private void FrmIntermediateSorting_Load(object sender, EventArgs e)
        {
            DataFile();
            DisplayOriginalList();
        }

        private void DataFile()
        {

            c = 0;
            n = 0;
            
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\names.txt";

            StreamReader r = new StreamReader(f);

            string line;

            while ((line = r.ReadLine()) != null)
            {
                c++;
                names[c] = line;
            }                        
            r.Close();
            n = c;
        }

        private void DisplayOriginalList()
        {
            for (int i = 1; i <= n; i++)
            {
                LstOriginal.Items.Add(names[i]);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBubble_Click(object sender, EventArgs e)
        {
            int start, elapsed;

            //re-load unsorted list
            DataFile();
            
            LstSorted.Items.Clear();

            start = Environment.TickCount;              
            BubbleSort();        
            elapsed = Environment.TickCount - start;

            TxtTime.Text = elapsed.ToString();

            DisplaySortedList();
        }

        private void DisplaySortedList()
        {
            for (int i = 1; i <= n; i++)
            {
                LstSorted.Items.Add(names[i]);
            }
        }

        private void BubbleSort()
        {
            string flag;
            
            do
            {
                flag = "yes";
                for (int k = 1; k <= n - 1; k++)
                {
                    if (names[k].CompareTo(names[k + 1])> 0)
                    {
                        Swap(names, k, k + 1);
                        flag = "no";
                    }
                }
            }
            while (flag != "yes");
        }

        private void Swap(string[] list, int a, int b)
        {
            string temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }

        private void BtnModifiedBubble_Click(object sender, EventArgs e)
        {
            int start, elapsed;
            
            //re-load unsorted list
            DataFile();

            LstSorted.Items.Clear();

            start = Environment.TickCount;
            ModifiedBubbleSort();
            elapsed = Environment.TickCount - start;

            TxtTime.Text = elapsed.ToString();

            DisplaySortedList();
        }

        private void BtnExchange_Click(object sender, EventArgs e)
        {
            int start, elapsed;

            //re-load unsorted list
            DataFile();
            
            LstSorted.Items.Clear();

            start = Environment.TickCount;
            ExchangeSort();
            elapsed = Environment.TickCount - start;

            TxtTime.Text = elapsed.ToString();

            DisplaySortedList();
        }

        private void BtnShell_Click(object sender, EventArgs e)
        {
            int start, elapsed;

            //re-load unsorted list
            DataFile();
            
            LstSorted.Items.Clear();

            start = Environment.TickCount;
            ShellSort();
            elapsed = Environment.TickCount - start;

            TxtTime.Text = elapsed.ToString();

            DisplaySortedList();
        }

        private void ModifiedBubbleSort()
        {
            int h = n;
            int u;
            

            do
            {

                u = h - 1;
                h = 1;

                for (int k = 1; k <= u; k++)
                {
                    // Swap pair (k, k + 1) if out of order.
                    if (names[k].CompareTo(names[k + 1]) > 0)
                    {
                        Swap(names, k, k + 1);
                        h = k;
                    }

                }

            }
            while (h > 1);


        }

        private void ExchangeSort()
        {
            for (int j = 1; j <= n - 1; j++)
            {
                for (int k = j + 1; k <= n; k++)
                {
                    if (names[j].CompareTo(names[k]) > 0)
                    {
                        Swap(names, j, k);
                    }

                }
            }   


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

                        if (names[i].CompareTo(names[iplusg]) > 0)
                        {
                            Swap(names, i, iplusg);
                            ex = ex + 1;
                        }
                    }
                }
                while (ex != 0);

            }
            while (gap >= 1);


        }

        private void BtnQuickSort_Click(object sender, EventArgs e)
        {
            int start, elapsed;

            //re-load unsorted list
            DataFile();
            
            LstSorted.Items.Clear();

            start = Environment.TickCount;
            QuickSort();
            elapsed = Environment.TickCount - start;

            TxtTime.Text = elapsed.ToString();

            DisplaySortedList();
        }

        private void QuickSort()
        {
            SortSubArray(names, 1, n);
        }

        private  void SortSubArray( string [] array, int l, int u )
        {
                if( l >= u ) 
                        return;

                // find the pivot value
                // use the array[l] point as the pivot
                string pivot = array[l];

                int m = l;

                // scan the sub-array from l to u,
                //      partitioning it to 2 groups.
                // move values < p to positions <=m in the array
                // keep values >= p to positions >m in the array
                for( int i=l+1; i <= u; i++ )
                {
                        if( array[i].CompareTo(pivot) < 0 )
                        {
                                m++;
                                Swap( array, m, i );
                        }
                }

                // move the pivot to the correct position
                Swap(  array, l, m );

                // recursively sort the partitions
                SortSubArray( array, l, m-1 );
                SortSubArray( array, m+1, u );
        }

        private void BtnArrayClass_Click(object sender, EventArgs e)
        {
            int start, elapsed;

            //re-load unsorted list
            DataFile();

            LstSorted.Items.Clear();

            start = Environment.TickCount;
            Array.Sort(names);
            elapsed = Environment.TickCount - start;

            TxtTime.Text = elapsed.ToString();

            //DisplaySortedList();

            //Must check for null entry when using Array 
            //class 
            foreach (string x in names)
            {
                if (x!=null)
                    LstSorted.Items.Add(x);
            }

            //  This is the equivalent display using
            //  a regular for loop
            //  for (int i = 1; i <= n; i++)
            //  {
            //      if (names[i]!=null)
            //      LstSorted.Items.Add(names[i]);
            //  }

        }
    }
}