using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Inventory
{
    public partial class FrmInventory : Form
    {
        public FrmInventory()
        {
            InitializeComponent();
        }

        string[] partnumber = new string[11];
        string[] partsize = new string[4];
        int[,] inventory = new int[11, 4];
        int ur, uc;

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            DataFile(inventory, partnumber, partsize, 10, 3);
            ur = 10;
            uc = 3;
        }

        private void DataFile(int[,] inv, string[] pn, string[] ps, int rows, int cols)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\inventory.txt";

            StreamReader read = new StreamReader(f);

            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= cols; c++)
                {
                    inv[r, c] = Convert.ToInt32(read.ReadLine());
                }
            }

            for (int r = 1; r <= rows; r++)
            {
                pn[r] = read.ReadLine();
            }

            for (int c = 1; c <= cols; c++)
            {
                ps[c] = read.ReadLine();
            }
                        
            read.Close();


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteData(10, 3);  
        }

        private void WriteData(int rows, int cols)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\inventory.txt";

            StreamWriter w = new StreamWriter(f);

            for (int pnumber = 1; pnumber <= rows; pnumber++)
            {
                for (int psize = 1; psize <= cols; psize++)
                {
                    w.WriteLine(inventory[pnumber, psize]);
                }
            }

            for (int pnumber=1;pnumber<=rows;pnumber++)
            {
                w.WriteLine(partnumber[pnumber]);
            }

            for (int psize=1;psize<=cols;psize++)
            {
                w.WriteLine(partsize[psize]);
            }
            
            w.Close();
            this.Close();

        }

        private void displayTotalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayInventoryTotals(10,3);
        }

        private void DisplayInventoryTotals(int rows, int cols)
        {
            int[] PartTotal = new int[11];

            for (int pn = 1; pn <= rows; pn++)
            {
                PartTotal[pn] = 0;
            }

            for (int pn = 1; pn <= rows; pn++)
            {
                for (int ps = 1; ps <= cols; ps++)
                {
                    PartTotal[pn] = PartTotal[pn] + inventory[pn, ps];
                }
            }

            FrmDisplay invent = new FrmDisplay();

            string msg = "";

            msg += "\t";

            for (int c = 1; c <= cols; c++)
            {
                msg += partsize[c] + "\t";
            }

            msg += "Totals";
            msg += Environment.NewLine;


            for (int r = 1; r <= rows; r++)
            {
                msg += partnumber[r] + "\t";
                for (int c = 1; c <= cols; c++)
                {
                    msg += Convert.ToString(inventory[r, c]) + "\t";
                }
                msg += PartTotal[r];
                msg += Environment.NewLine;
            }

            msg += Environment.NewLine;

            invent.Info = msg;

            if (invent.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Returned from Inventory Totals");
            }
        }

        private void receivingPartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDataEntry d = new FrmDataEntry();
            d.Title = "Receiving Parts";

            if (d.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("back from Receiving Parts");

                string pn = d.PartNumber;
                int q = Convert.ToInt32(d.Quantity);

                string s="";

                if (d.Small == true)
                {
                    s = "small";
                }
                else if (d.Medium == true)
                {
                    s = "medium";
                }
                else if (d.Large == true)
                {
                    s = "large";
                }

                int pnpicked = Search.Linear(partnumber, pn,ur);
                int spicked = Search.Linear(partsize, s,uc);

                if (pnpicked != -1 && spicked != -1)
                {
                    inventory[pnpicked, spicked] += q;
                }
                else
                {
                    MessageBox.Show("Invalid Selection");
                }

            }
            else
            {
                MessageBox.Show("You pressed cancel");
            }
        }
            
       

        private void issuingPartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDataEntry d = new FrmDataEntry();
            d.Title = "Issuing Parts";

            if (d.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Back from Issuing Parts");

                string pn = d.PartNumber;
                int q = Convert.ToInt32(d.Quantity);

                string s = "";

                if (d.Small == true)
                {
                    s = "small";
                }
                else if (d.Medium == true)
                {
                    s = "medium";
                }
                else if (d.Large == true)
                {
                    s = "large";
                }

                int pnpicked = Search.Linear(partnumber, pn, ur);
                int spicked = Search.Linear(partsize, s, uc);

                if (pnpicked != -1 && spicked != -1)
                {
                    if (inventory[pnpicked, spicked] < q)
                    {
                        MessageBox.Show("Not enough stock to fill order" + "\n" + "Present Stock " + inventory[pnpicked, spicked]);
                    }
                    else
                    {
                        inventory[pnpicked, spicked] -= q;
                        MessageBox.Show("Inventory Stock is now " + inventory[pnpicked, spicked]);

                    }
                }
                else
                {
                    MessageBox.Show("Invalid Selection");
                }


            }
        }           

    }
}