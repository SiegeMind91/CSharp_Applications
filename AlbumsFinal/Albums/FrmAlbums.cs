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

        string f = "";    //filename
        string fileOK;


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
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
            AlbumStatus();
        }

        private void borrowAlbumToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Borrow();
        }

        private void returnAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return();
        }

        private void changesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void deletionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void additionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void NewFile()
        {

        }

        private void OpenFile()
        {
            c = 0;
            n = 0;
            fileOK = "yes";

            StreamReader r = null;

            try
            {

                openFileDialog1.Reset();
                openFileDialog1.InitialDirectory = Application.ExecutablePath;
                openFileDialog1.Filter = "Text files (*.txt)|*.txt|" + "All files|*.*";
                openFileDialog1.FilterIndex = 1;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //string s = Application.StartupPath;
                    //string f = s + @"\albums.txt";

                    f = openFileDialog1.FileName;
                    r = new StreamReader(f);

                    string WholeLine;

                    while ((WholeLine = r.ReadLine()) != null)
                    {
                        c++;
                        lines = WholeLine.Split(',');
                        albumname[c] = lines[0];
                        borrower[c] = lines[1];
                    }

                    //r.Close();    In finally statement below
                    //n = c;

                    //add filename to statusbar
                    toolStripStatusLabel.Text = "File Loaded";

                    Search.Shell(albumname, borrower, n);
                }
                else
                {
                    MessageBox.Show("No File Chosen");
                }
            }

            catch (Exception exp)
            {
                MessageBox.Show("Error Occured during File IO " + exp.Message);
                fileOK = "no";
            }

            finally
            {
                if (r != null)
                {
                    r.Close();
                }

                if (fileOK == "yes")
                {
                    n = c;                    
                    toolStripStatusLabel.Text = "File Loaded";//add filename to statusbar
                }
                else
                {
                    c = 0;
                    n = 0;
                    toolStripStatusLabel.Text = "File Loading Error";

                }
            }
        }

        private void SaveFile()
        {

            if (fileOK == "yes")
            {

                StreamWriter w = null;

                try
                {

                    saveFileDialog1.Filter = "Text files (*.txt)|*.txt|" + "All files|*.*";
                    saveFileDialog1.FileName = f;           //prompt with current filename
                    saveFileDialog1.FilterIndex = 1;

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        //string StartUpPath = Application.StartupPath;
                        //string f = StartUpPath + @"\albums.txt";

                        f = saveFileDialog1.FileName;
                        w = new StreamWriter(f);

                        for (int i = 1; i <= n; i++)
                        {
                            w.Write(albumname[i]);
                            w.Write(",");
                            w.WriteLine(borrower[i]);
                        }

                        //w.Close();        closed below in finally statement
                    }
                    else
                    {
                        MessageBox.Show("you pressed cancel");
                    }
                }

                catch (Exception exp)
                {
                    MessageBox.Show("Error Occured during File IO " + exp.Message);


                }

                finally
                {
                    if (w != null)
                    {
                        w.Close();
                        n = c;
                    }
                }
            }
            else
            {
                MessageBox.Show("Cannot save this file " + "\n" + "program detected an error during loading" + "\n" + "try re-loading or create a new file");
            }

        }

        private void AlbumStatus()
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

        private void Borrow()
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

        private void Return()
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

        private void Change()
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

        private void Delete()
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

        private void Add()
        {
            if (fileOK == "yes")
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
            else
            {
                MessageBox.Show("You cannot add anything to this file " + "\n" +"during loading the program detected an error" + "\n" + "you need to either re-load or create a new file");
            }
        }

        private void Exit()
        {
            this.Close();
        }

        private void TbbOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void TbbSaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void TbbStatus_Click(object sender, EventArgs e)
        {
            AlbumStatus();
        }

        private void TbbBorrow_Click(object sender, EventArgs e)
        {
            Borrow();
        }

        private void TbbReturn_Click(object sender, EventArgs e)
        {
            Return();
        }

        private void TbbChange_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void TbbDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void TbbAdd_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void TbbExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void TbbNewFile_Click(object sender, EventArgs e)
        {
            DialogResult r  = MessageBox.Show("Are you sure you want to start a new file", "New File", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            
            if (r == DialogResult.Yes)
            {
                ReInitialize();
            }           
           
        }

        private void ReInitialize()
        {
            for (int i = 1; i <= n; i++)
            {
                albumname[i] = "";
                borrower[i] = "";
            }

            n = 0;
            c = 0;
            fileOK = "yes";
            toolStripStatusLabel.Text = "No Files Loaded";

        }


    }
}