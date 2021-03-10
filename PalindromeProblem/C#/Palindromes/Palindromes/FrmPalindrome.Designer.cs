namespace Palindromes
{
    partial class FrmPalindrome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnPalindrome = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnPalindrome
            // 
            this.BtnPalindrome.Location = new System.Drawing.Point(175, 39);
            this.BtnPalindrome.Name = "BtnPalindrome";
            this.BtnPalindrome.Size = new System.Drawing.Size(106, 43);
            this.BtnPalindrome.TabIndex = 0;
            this.BtnPalindrome.Text = "Determine Palindrome";
            this.BtnPalindrome.UseVisualStyleBackColor = true;
            this.BtnPalindrome.Click += new System.EventHandler(this.BtnPalindrome_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(40, 148);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(378, 230);
            this.TxtDisplay.TabIndex = 1;
            // 
            // FrmPalindrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 438);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnPalindrome);
            this.Name = "FrmPalindrome";
            this.Text = "Palindrome Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPalindrome;
        private System.Windows.Forms.TextBox TxtDisplay;
    }
}

