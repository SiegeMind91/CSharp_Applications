using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inventory
{
    public partial class FrmDisplay : Form
    {
        public FrmDisplay()
        {
            InitializeComponent();
        }

        public string Info
        {
            set { TxtDisplay.Text = value; }
        }
    }
}