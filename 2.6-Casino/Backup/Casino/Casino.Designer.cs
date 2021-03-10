namespace Casino
{
    partial class Casino
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
            this.BtnCasino = new System.Windows.Forms.Button();
            this.LstDisplay = new System.Windows.Forms.ListBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCasino
            // 
            this.BtnCasino.Location = new System.Drawing.Point(170, 21);
            this.BtnCasino.Name = "BtnCasino";
            this.BtnCasino.Size = new System.Drawing.Size(120, 29);
            this.BtnCasino.TabIndex = 0;
            this.BtnCasino.Text = "Begin Simulation";
            this.BtnCasino.UseVisualStyleBackColor = true;
            this.BtnCasino.Click += new System.EventHandler(this.BtnCasino_Click);
            // 
            // LstDisplay
            // 
            this.LstDisplay.FormattingEnabled = true;
            this.LstDisplay.Location = new System.Drawing.Point(17, 74);
            this.LstDisplay.Name = "LstDisplay";
            this.LstDisplay.Size = new System.Drawing.Size(451, 147);
            this.LstDisplay.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(199, 228);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(65, 22);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Casino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 262);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LstDisplay);
            this.Controls.Add(this.BtnCasino);
            this.Name = "Casino";
            this.Text = "Casino";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCasino;
        private System.Windows.Forms.ListBox LstDisplay;
        private System.Windows.Forms.Button BtnExit;
    }
}

