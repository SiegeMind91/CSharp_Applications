namespace GCD
{
    partial class FrmGCD
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
            this.BtnGCD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGCD
            // 
            this.BtnGCD.Location = new System.Drawing.Point(96, 55);
            this.BtnGCD.Name = "BtnGCD";
            this.BtnGCD.Size = new System.Drawing.Size(87, 35);
            this.BtnGCD.TabIndex = 0;
            this.BtnGCD.Text = "Determine the GCD";
            this.BtnGCD.UseVisualStyleBackColor = true;
            this.BtnGCD.Click += new System.EventHandler(this.BtnGCD_Click);
            // 
            // FrmGCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.BtnGCD);
            this.Name = "FrmGCD";
            this.Text = "Recursive GCD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGCD;
    }
}

