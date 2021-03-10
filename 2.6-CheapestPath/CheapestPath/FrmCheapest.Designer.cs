namespace CheapestPath
{
    partial class FrmCheapest
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
            this.BtnCheapestPath = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCheapestPath
            // 
            this.BtnCheapestPath.Location = new System.Drawing.Point(187, 34);
            this.BtnCheapestPath.Name = "BtnCheapestPath";
            this.BtnCheapestPath.Size = new System.Drawing.Size(143, 32);
            this.BtnCheapestPath.TabIndex = 0;
            this.BtnCheapestPath.Text = "Determine Cheapest Path";
            this.BtnCheapestPath.UseVisualStyleBackColor = true;
            this.BtnCheapestPath.Click += new System.EventHandler(this.BtnCheapestPath_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay.Location = new System.Drawing.Point(12, 94);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(503, 192);
            this.TxtDisplay.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(234, 309);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(61, 25);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmCheapest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 358);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnCheapestPath);
            this.Name = "FrmCheapest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheapest Path Problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCheapestPath;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnExit;
    }
}

