using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GCD
{
    public partial class FrmGCD : Form
    {
        public FrmGCD()
        {
            InitializeComponent();
        }

        private void BtnGCD_Click(object sender, EventArgs e)
        {
            long first = Convert.ToInt64(Microsoft.VisualBasic.Interaction.InputBox("Enter the first number", "Triangle Numbers", "", 200, 200));
            long second = Convert.ToInt64(Microsoft.VisualBasic.Interaction.InputBox("Enter the second number", "Triangle Numbers", "", 200, 200));

            MessageBox.Show("The GCD of " + first.ToString() + " and " + second.ToString() + "\n" + "is " + GCD(first, second));

        }

        private long GCD(long m, long n)
        {
            if (n == 0)
                return m;
            else
                return GCD(n, m % n);
        }


        
    }
}