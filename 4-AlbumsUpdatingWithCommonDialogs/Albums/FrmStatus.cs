using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Albums
{
    public partial class FrmStatus : Form
    {
        public FrmStatus()
        {
            InitializeComponent();
        }

        public string Info
        {
            set { TxtDisplay.Text = value; }
        }

        public string Borrow
        {
            set { TxtBorrower.Text = value; }
        }
    }
}