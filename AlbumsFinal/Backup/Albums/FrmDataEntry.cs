using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Albums
{
    public partial class FrmDataEntry : Form
    {
        public FrmDataEntry()
        {
            InitializeComponent();
        }

        public string Title
        {
            set { LblPrompt.Text=value ; }
        }

        public string Borrow
        {
            get { return TxtInfo.Text; }
        }

        private void TxtInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //note the use of single quotes for char type data and ascii 8 for the backspace key
            if ((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')|| e.KeyChar==' ' || e.KeyChar==8)  
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            //If an unacceptable key is detected, we set 
            //e.Handled to true.  This ‘tricks’ Visual C# Express
            //into thinking the KeyPress event has already been
            //handled and the pressed key is ignored. 
            //If a pressed key is acceptable, we set
            //the e.Handled property to false. 
            //This tells Visual C# Express that this
            //method has not been handled and the
            //KeyPress should be allowed 
            //(by default, e.Handled is false, allowing 
            //all keystrokes).
        }
        
    }
}