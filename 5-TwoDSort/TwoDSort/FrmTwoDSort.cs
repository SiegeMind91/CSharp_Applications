using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TwoDSort
{
    public partial class FrmTwoDSort : Form
    {
        public FrmTwoDSort()
        {
            InitializeComponent();
        }

        string [,] BusRec = new String [100,4];
        int [] pointers = new int [100]; 

        int r=0;
        int n=0;

        private void FrmTwoDSort_Load(object sender, EventArgs e)
        {
            DataFile();
            DisplayRecords();
            
        }

        private void DataFile()
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\business.txt";

            StreamReader read = new StreamReader(f);

            string line;

            while ((line = read.ReadLine()) != null)
            {
                r++;
                
                BusRec[r,1] = line;
                for (int c = 2; c <= 3; c++)
                {
                    BusRec[r, c] = read.ReadLine();
                }

            }
            n = r;
            read.Close();
        }

        private void PointerSort(int f)
        {

            int temp;

            for (int i = 1; i <= n; i++)
                pointers[i] = i;

            for (int j = 1; j <= n - 1; j++)
            {
                for (int k = j + 1; k <= n; k++)
                {
                    if (BusRec[pointers[j],f].CompareTo(BusRec[pointers[k],f]) > 0)
                    {
                        temp = pointers[j];
                        pointers[j] = pointers[k];
                        pointers[k] = temp;
                    }
                }
            }

            SortedDisplayRecords();
        }

        private void DisplayRecords()
        {
            TxtDisplay.Clear();
            TxtDisplay.Text = "Business" + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;

            TxtDisplay.Text += "Name" + "\t" + "\t" + "Telephone" + "\t"   + "Occupation";
            TxtDisplay.Text += Environment.NewLine;
            
            for (int r = 1; r <= n; r++)
            {
                for (int c = 1; c <= 3; c++)
                {
                    TxtDisplay.Text += (BusRec[r, c]) + "\t" + "\t";
                }
                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;
            TxtDisplay.Refresh();
                        
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SortedDisplayRecords()
        {
            TxtDisplay.Clear();
            TxtDisplay.Text = "Business" + Environment.NewLine;
            TxtDisplay.Text += Environment.NewLine;

            TxtDisplay.Text += "Name" + "\t" + "\t" + "Telephone" + "\t" + "Occupation";
            TxtDisplay.Text += Environment.NewLine;

            for (int r = 1; r <= n; r++)
            {
                for (int c = 1; c <= 3; c++)
                {
                    TxtDisplay.Text += (BusRec[pointers[r], c]) + "\t" + "\t";
                }
                TxtDisplay.Text += Environment.NewLine;
            }

            TxtDisplay.Text += Environment.NewLine;
            TxtDisplay.Refresh();

        }

        private void RdoName_CheckedChanged(object sender, EventArgs e)
        {
            PointerSort(1);
        }

        private void RdoTelephone_CheckedChanged(object sender, EventArgs e)
        {
            PointerSort(2);
        }

        private void RdoOccupation_CheckedChanged(object sender, EventArgs e)
        {
            PointerSort(3);
        }
        
    }
}