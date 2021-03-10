using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PointerSort
{
    public partial class FrmPointerSort : Form
    {
        public FrmPointerSort()
        {
            InitializeComponent();
        }

        int c;
        int n;
        string[] names = new string[20];
        string[] cities = new string[20];
        int[] homeruns = new int[20];
        int[] pointers = new int[20];

        private void DataFile()
        {

            c = 0;
            n = 0;

            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\pointersorting.txt";

            StreamReader r = new StreamReader(f);

            string line;

            while ((line = r.ReadLine()) != null)
            {
                c++;
                names[c] = line;
                cities[c] = r.ReadLine();
                homeruns[c] = Convert.ToInt32(r.ReadLine());

            }
            r.Close();
            n = c;
        }

        private void FrmPointerSort_Load(object sender, EventArgs e)
        {
            DataFile();
            DisplayOriginalList();
        }

        private void DisplayOriginalList()
        {
            TxtOriginal.Clear();
            TxtOriginal.Text = "Home Run Leaders" + Environment.NewLine;
            TxtOriginal.Text += Environment.NewLine;

            
            for (int i = 1; i <=n; i++)
            {
                TxtOriginal.Text += names[i] + "\t" + cities[i] + "\t" + homeruns[i].ToString() + Environment.NewLine;
            }

            TxtOriginal.Text += Environment.NewLine;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnExchange_Click(object sender, EventArgs e)
        {
            //re-load unsorted list
            DataFile();
            TxtSorted.Clear();
            
            ExchangeSort();
            DisplaySortedList();
        }

        private void DisplaySortedList()
        {
            TxtSorted.Clear();
            TxtSorted.Text = "Home Run Leaders" + Environment.NewLine;
            TxtSorted.Text += Environment.NewLine;


            for (int i = 1; i <= n; i++)
            {
                TxtSorted.Text += names[i] + "\t" + cities[i] + "\t" + homeruns[i].ToString() + Environment.NewLine;
            }

            TxtSorted.Text += Environment.NewLine;
        }

        private void ExchangeSort()
        {
            string tempn = "";
            string tempc = "";
            int temph;

            for (int j = 1; j <= n - 1; j++)
            {
                for (int k = j + 1; k <= n; k++)
                {
                    if (homeruns[j] < homeruns[k])
                    {
                        tempn = names[j];
                        names[j] = names[k];
                        names[k] = tempn;
                        tempc = cities[j];
                        cities[j] = cities[k];
                        cities[k] = tempc;
                        temph = homeruns[j];
                        homeruns[j] = homeruns[k];
                        homeruns[k] = temph;
                    }

                }
            }
        }

        private void PointerExchangeSort()
        {
            int temp;

            for (int i = 1; i <= n; i++)
                pointers[i] = i;

            for (int j = 1; j <= n - 1; j++)
            {
                for (int k = j + 1; k <= n; k++)
                {
                    if (homeruns[pointers[j]] < homeruns[pointers[k]])
                    {
                        temp = pointers[j];
                        pointers[j] = pointers[k];
                        pointers[k] = temp;
                    }
                }
            }
        }

        private void BtnPointerExchange_Click(object sender, EventArgs e)
        {
            //re-load unsorted list
            DataFile();
            TxtSorted.Clear();

            PointerExchangeSort();
            DisplayPointerSortedList();
        }

        private void ShellSort()
        {
            int gap = n;
            int maximum, iplusg, ex;
            int temp;

            for (int i = 1; i <= n; i++)
                pointers[i] = i;

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

                        if (homeruns[pointers[i]] < homeruns[pointers[iplusg]])
                        {
                            temp = pointers[i];
                            pointers[i] = pointers[iplusg];
                            pointers[iplusg] = temp;
                            ex = ex + 1;
                        }
                    }
                }
                while (ex != 0);

            }
            while (gap >= 1);


        }

        private void DisplayPointerSortedList()
        {
            TxtSorted.Clear();
            TxtSorted.Text = "Home Run Leaders" + Environment.NewLine;
            TxtSorted.Text += Environment.NewLine;


            for (int i = 1; i <= n; i++)
            {
                TxtSorted.Text += names[pointers[i]] + "\t" + cities[pointers[i]] + "\t" + homeruns[pointers[i]].ToString() + Environment.NewLine;
            }

            TxtSorted.Text += Environment.NewLine;
        }

        private void BtnPointerShell_Click(object sender, EventArgs e)
        {
            //re-load unsorted list
            DataFile();
            TxtSorted.Clear();

            ShellSort();
            DisplayPointerSortedList();
        }
    }
}