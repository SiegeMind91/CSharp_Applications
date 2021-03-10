using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Albums
{
    public partial class FrmAlbums : Form
    {
        public FrmAlbums()
        {
            InitializeComponent();
        }

        string [] albumname = new string[100];
        string[] borrower = new string[100];
        string[] lines;                 

        int c, n;

        private void FrmAlbums_Load(object sender, EventArgs e)
        {
            c = 0;
            n = 0;

            string s = Application.StartupPath;
            string f = s + @"\albums.txt";
            StreamReader r = new StreamReader(f);

            string WholeLine;

            while ((WholeLine = r.ReadLine()) != null)
            {
                c++;
                lines = WholeLine.Split(','); 
                albumname[c] = lines[0];
                borrower[c] = lines[1];
            }

            r.Close();
            n = c;

            Search.Shell(albumname, borrower, n);
                        
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string StartUpPath = Application.StartupPath;
            string f = StartUpPath + @"\albums.txt";

            StreamWriter w = new StreamWriter(f);

            for (int i = 1; i <= n; i++)
            {
                w.Write(albumname[i]);
                w.Write(",");
                w.WriteLine(borrower[i]);
            }

            w.Close();
            this.Close();
        }

               

        private void Transactions(string type, int loc)
        {
            if (type == "b")
            {
                if (borrower[loc] != "free")
                {
                    MessageBox.Show("Album already borrowed by " + borrower[loc]);
                }
                else
                {
                    FrmDataEntry d = new FrmDataEntry();
                    d.Title = "Enter Borrower's Name";

                    if (d.ShowDialog() == DialogResult.OK)
                    {
                        borrower[loc] = d.Borrow;
                    }
                }
            }
            else if (type == "r")
            {
                if (borrower[loc] == "free")
                {
                    MessageBox.Show("Album already returned");
                }
                else
                {
                    borrower[loc] = "free";
                }
            }

            
        }

        private void albumStatusToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmStatus s = new FrmStatus();

            string msg1 = "";
            string msg2 = "";

            for (int i = 1; i <= n; i++)
            {
                msg1 += i.ToString() + " " + albumname[i] + Environment.NewLine;
                msg2 += i.ToString() + " " + borrower[i] + Environment.NewLine;
            }

            s.Info = msg1;
            s.Borrow = msg2;

            if (s.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Returned from Album Status");
            }
        }

        private void borrowAlbumToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDataEntry d = new FrmDataEntry();
            d.Title = "Enter Album to Borrow";

            if (d.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("album to borrow " + d.Borrow);
                int location = Search.Linear(albumname, d.Borrow, n);
                //int location = Search.Binary(albumname, d.Borrow, n);
                //int location = Search.RecursiveBinary(albumname, 1, n, d.Borrow);


                if (location != -1)
                {
                    Transactions("b", location);
                }
                else
                {
                    MessageBox.Show("No such album you may have misspelled it");
                }
            }
            else
            {
                MessageBox.Show("you pressed cancel");
            }


        }

        private void returnAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDataEntry d = new FrmDataEntry();
            d.Title = "Enter Album to Return";

            if (d.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("album to return " + d.Borrow);
                int location = Search.Linear(albumname, d.Borrow, n);
                //int location = Search.Binary(albumname, d.Borrow, n);
                //int location = Search.RecursiveBinary(albumname, 1, n, d.Borrow);

                if (location != -1)
                {
                    Transactions("r", location);
                }
                else
                {
                    MessageBox.Show("No such album you may have misspelled it");
                }
            }
            else
            {
                MessageBox.Show("you pressed cancel");
            }
        }

        private void changesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDataEntry d = new FrmDataEntry();
            d.Title = "Enter Album Name To Change";

            if (d.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("album to change " + d.Borrow);
                int location = Search.Linear(albumname, d.Borrow, n);

                if (location != -1)
                {
                    
                    d.Title = "Enter New Album Name";

                    if (d.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("album name being changed to " + d.Borrow);
                        albumname[location] = d.Borrow;

                        Search.Shell(albumname, borrower, n);
                    }
                    else
                    {
                        MessageBox.Show("you pressed cancel");
                    }
                }
                else
                {
                    MessageBox.Show("No such album you may have misspelled it");
                }
            }
            else
            {
                MessageBox.Show("you pressed cancel");
            }
        }

        private void deletionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDataEntry d = new FrmDataEntry();
            d.Title = "Enter Album Name To Delete";

            if (d.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("album to delete " + d.Borrow);
                int location = Search.Linear(albumname, d.Borrow, n);
                
                if (location != -1)
                {
                    n--;
                    for (int i = location; i <= n; i++)
                    {
                        albumname[i] = albumname[i + 1];
                        borrower[i] = borrower[i + 1];

                        Search.Shell(albumname, borrower, n);
                    }
                }
                else
                {
                    MessageBox.Show("No such album you may have misspelled it");
                }
            }
            else
            {
                MessageBox.Show("you pressed cancel");
            }
        }

        private void additionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDataEntry d = new FrmDataEntry();
            d.Title = "Enter Album Name To Add";

            if (d.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("album to add " + d.Borrow);
                int location = Search.Linear(albumname, d.Borrow, n);

                if (location != -1)
                {
                    MessageBox.Show("Album already on File");
                }
                else
                {
                    n++;
                    albumname[n] = d.Borrow;
                    borrower[n] = "free";

                    Search.Shell(albumname, borrower, n);
                }

            }
            else
            {
                MessageBox.Show("you pressed cancel");
            }
        }
    }
}