using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Inventory
{
    public partial class FrmDataEntry : Form
    {
        public FrmDataEntry()
        {
            InitializeComponent();
        }

        public string PartNumber
        {
            get { return CboPartNumbers.Text; }
        }

        public bool Small
        {
            get { return RdoSmall.Checked; }
        }

        public bool Medium
        {
            get { return RdoMedium.Checked; }
        }

        public bool Large
        {
            get { return RdoLarge.Checked; }
        }

        public string Quantity
        {
            get { return TxtQuantity.Text; }
        }

        public string Title
        {
            set { LblTitle.Text = value; }
        }

        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //note the use of single quotes for char type data and ascii 8 for the backspace key
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}