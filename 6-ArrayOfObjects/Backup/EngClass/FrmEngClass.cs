using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EngClass
{
    public partial class FrmEngClass : Form
    {
        public FrmEngClass()
        {
            InitializeComponent();
        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            StudentRecord[] r = new StudentRecord[100];

            r[1] = new StudentRecord();
            r[1].sname = "Anthony";
            r[1].mark = 95;

            r[2] = new StudentRecord();
            r[2].sname = "Charlie";
            r[2].mark = 90;

            r[3] = new StudentRecord();
            r[3].sname = "Angela";
            r[3].mark = 92;

            r[4] = new StudentRecord();
            r[4].sname = "Rosemary";
            r[4].mark = 56;

            Sort(r, 4);
            Display(r, 4);

        }

        private void Sort(StudentRecord [] rec, int u)
        {
            StudentRecord temp;
            
            for (int j = 1; j <= u - 1; j++)
            {
                for (int k = j + 1; k <= u; k++)
                {
                    if (rec[j].mark < rec[k].mark)
                    {
                        temp = rec[j];
                        rec[j] = rec[k];
                        rec[k] = temp;
                    }
                }
            }
        }

        private void Display(StudentRecord[] rec, int u)
        {
            TxtDisplay.Clear();
            
            for (int i = 1; i <= u; i++)
            {
                TxtDisplay.Text += rec[i].sname + "\t" + rec[i].mark + Environment.NewLine;
            }


        }

        private void BtnFileSort_Click(object sender, EventArgs e)
        {
            int c = 0;
            
            string [] lines = new string[2];
            
            string s = Application.StartupPath;
            string f = s + @"\marks.txt";
                        
            StreamReader r = new StreamReader(f);

            StudentRecord[] rec = new StudentRecord[100];
            
            string WholeLine;
                        
            while ((WholeLine = r.ReadLine()) != null)
            {
                c++;
                lines = WholeLine.Split(',');

                rec[c] = new StudentRecord();
                rec[c].sname = lines[0];
                rec[c].mark = int.Parse(lines[1]);
            }

            r.Close();    
            int n = c;

            Sort(rec, n);
            Display(rec, n);

        }


    }
}