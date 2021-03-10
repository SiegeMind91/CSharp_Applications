using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaesarCode
{
    public partial class FrmCaesarCode : Form
    {
        public FrmCaesarCode()
        {
            InitializeComponent();
        }

        string alphabet, translation;

        private void FrmCaesarCode_Load(object sender, EventArgs e)
        {
            alphabet = "abcdefghijklmnopqrstuvwxyz";
            translation = "zyxwvutsrqponmlkjihgfedcba";
        }

        private void BtnEncode_Click(object sender, EventArgs e)
        {
            string message;
            string codedmessage = "";
            string letter;

            string response;

            int pos;

            while (true)
            {

                while (true)
                {
                    response = Microsoft.VisualBasic.Interaction.InputBox("Do you have anymore entries y/n? ", "Continue?", "", 200, 200);
                    if (response == "y" || response == "n")
                        break;
                }

                if (response == "n")
                    break;

                message = Microsoft.VisualBasic.Interaction.InputBox("Enter message to encode ", "Caesar Code", "", 200, 200);
                
                for (int i=0;i<message.Length;i++)
                {
                    letter=message.Substring(i,1);
                    pos=alphabet.IndexOf(letter);
                
                    if (pos==-1)
                    {
                        codedmessage+=message.Substring(i,1);
                    }
                    else
                    {
                        codedmessage+=translation.Substring(pos,1);
                    }
                }
                
                MessageBox.Show("English message was " + message + "\n" + "Coded message is " + codedmessage);
                  

            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDecode_Click(object sender, EventArgs e)
        {
            string message="";
            string codedmessage ;
            string letter;

            string response;

            int pos;

            while (true)
            {

                while (true)
                {
                    response = Microsoft.VisualBasic.Interaction.InputBox("Do you have anymore entries y/n? ", "Continue?", "", 200, 200);
                    if (response == "y" || response == "n")
                        break;
                }

                if (response == "n")
                    break;

                codedmessage = Microsoft.VisualBasic.Interaction.InputBox("Enter message to encode ", "Caesar Code", "", 200, 200);

                for (int i = 0; i < codedmessage.Length; i++)
                {
                    letter = codedmessage.Substring(i, 1);
                    pos = translation.IndexOf(letter);

                    if (pos == -1)
                    {
                        message += codedmessage.Substring(i, 1);
                    }
                    else
                    {
                        message += alphabet.Substring(pos, 1);
                    }
                }

                MessageBox.Show("Coded message was " + codedmessage + "\n" + "Decoded message is " + message);
            }
                  
        }

        private void BtnShifted_Click(object sender, EventArgs e)
        {
            string message;
            string codedmessage;
            string letter;

            translation = alphabet; //initial state

            string response;

            int pos;

            while (true)
            {

                while (true)
                {
                    response = Microsoft.VisualBasic.Interaction.InputBox("Do you have anymore entries y/n? ", "Continue?", "", 200, 200);
                    if (response == "y" || response == "n")
                        break;
                }

                if (response == "n")
                    break;

                codedmessage = Microsoft.VisualBasic.Interaction.InputBox("Enter message to encode ", "Caesar Code", "", 200, 200);

                for (int shift = 1; shift <= 25; shift++)
                {

                    message = "";
                    translation = translation.Substring(1) + translation.Substring(0, 1);

                    for (int i = 0; i < codedmessage.Length; i++)
                    {
                        letter = codedmessage.Substring(i, 1);
                        pos = translation.IndexOf(letter);

                        if (pos == -1)
                        {
                            message += codedmessage.Substring(i, 1);
                        }
                        else
                        {
                            message += alphabet.Substring(pos, 1);
                        }
                    }

                    MessageBox.Show("Coded message was " + codedmessage + "\n" + "Decoded message is " + message);
                }
            }
        }
    }
}