using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DelimitedTextFileReading
{
    public partial class FrmDelimited : Form
    {
        public FrmDelimited()
        {
            InitializeComponent();
        }

        struct student
        {
            public string fn;
            public string ln;
            public int age;
        }

        student[] st = new student[10];                
        string[] lines;                 //needed for split command

        int c, n;

        private void BtnRead_Click(object sender, EventArgs e)
        {
            c = 0;
            n = 0;

            string s = Application.StartupPath;
            string f = s+ @"\names.txt";
            StreamReader r = new StreamReader(f);

            string WholeLine;

            while ( (WholeLine=r.ReadLine())!=null )
            {
                c++;
                lines = WholeLine.Split(' '); //contents of WholeLine separated based
                                              //on blank space and each part stored
                st[c].fn = lines[0];
                st[c].ln = lines[1];
                st[c].age = Convert.ToInt32(lines[2]);
            }

            r.Close();
            n=c;

            DisplayResults();
            Sort();
            DisplaySortedResults();
        }

        private void DisplayResults()
        {
            LstDisplay.Items.Clear();
            LstDisplay.Items.Add("Unsorted List");
            
            for (int i=1;i<=n;i++)
            {
                LstDisplay.Items.Add(st[i].fn+ "\t" + st[i].ln + "\t" + st[i].age.ToString());
            }

            LstDisplay.Items.Add("");
        }

        private void DisplaySortedResults()
        {
            LstDisplay.Items.Add("Sorted List");

            for (int i = 1; i <= n; i++)
            {
                LstDisplay.Items.Add(st[i].fn + "\t" + st[i].ln+ "\t" + st[i].age.ToString());
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sort()
        {
            student temp;

            for (int j=1;j<=n-1;j++)
            {
                for (int k=j+1;k<=n;k++)
                {
                    if ( st[j].ln.CompareTo(st[k].ln) > 0)
                    {
                        temp=st[j];
                        st[j]=st[k];
                        st[k]=temp;
                    }
                }
            }
        }
        
    }
}