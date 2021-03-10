using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Casino
{
    public partial class Casino : Form
    {
        public Casino()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCasino_Click(object sender, EventArgs e)
        {
            double GameWinsLosses;
            double TotalWinsLosses = 0;

            int numberSpun;

            int[] flag = new int[37];

            string GameString;

            Random r = new Random();

            LstDisplay.Items.Clear();

            for (int simulation = 1; simulation <= 1000; simulation++)
            {

                for (int number = 1; number <= 36; number++)
                {
                    flag[number] = 0;
                }

                GameWinsLosses = -7.5;
                TotalWinsLosses = TotalWinsLosses - 7.5;
                GameString = "";

                while (true)
                {
                    numberSpun = r.Next(1, 37);

                    if (flag[numberSpun] == 1)
                        break;

                    flag[numberSpun] = 1;
                    GameString += Convert.ToString(numberSpun) + "/";
                    GameWinsLosses++;
                    TotalWinsLosses++;
                }

                GameString += Convert.ToString(numberSpun) + "/";
                LstDisplay.Items.Add(GameString + " --> " + GameWinsLosses.ToString("c2"));
            }
            MessageBox.Show("The grand total amount of wins or losses after 1000 simulations is " + TotalWinsLosses.ToString("c2"));
        }
           
    }
}