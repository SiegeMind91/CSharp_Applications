namespace TwoDSort
{
    partial class FrmTwoDSort
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
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.GrpSort = new System.Windows.Forms.GroupBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.RdoName = new System.Windows.Forms.RadioButton();
            this.RdoTelephone = new System.Windows.Forms.RadioButton();
            this.RdoOccupation = new System.Windows.Forms.RadioButton();
            this.GrpSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(54, 126);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDisplay.Size = new System.Drawing.Size(399, 135);
            this.TxtDisplay.TabIndex = 0;
            // 
            // GrpSort
            // 
            this.GrpSort.Controls.Add(this.RdoOccupation);
            this.GrpSort.Controls.Add(this.RdoTelephone);
            this.GrpSort.Controls.Add(this.RdoName);
            this.GrpSort.Location = new System.Drawing.Point(129, 12);
            this.GrpSort.Name = "GrpSort";
            this.GrpSort.Size = new System.Drawing.Size(242, 98);
            this.GrpSort.TabIndex = 1;
            this.GrpSort.TabStop = false;
            this.GrpSort.Text = "Choose Field to Sort By";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(199, 267);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(92, 27);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // RdoName
            // 
            this.RdoName.AutoSize = true;
            this.RdoName.Location = new System.Drawing.Point(8, 19);
            this.RdoName.Name = "RdoName";
            this.RdoName.Size = new System.Drawing.Size(90, 17);
            this.RdoName.TabIndex = 0;
            this.RdoName.TabStop = true;
            this.RdoName.Text = "Sort By Name";
            this.RdoName.UseVisualStyleBackColor = true;
            this.RdoName.CheckedChanged += new System.EventHandler(this.RdoName_CheckedChanged);
            // 
            // RdoTelephone
            // 
            this.RdoTelephone.AutoSize = true;
            this.RdoTelephone.Location = new System.Drawing.Point(8, 47);
            this.RdoTelephone.Name = "RdoTelephone";
            this.RdoTelephone.Size = new System.Drawing.Size(113, 17);
            this.RdoTelephone.TabIndex = 1;
            this.RdoTelephone.TabStop = true;
            this.RdoTelephone.Text = "Sort By Telephone";
            this.RdoTelephone.UseVisualStyleBackColor = true;
            this.RdoTelephone.CheckedChanged += new System.EventHandler(this.RdoTelephone_CheckedChanged);
            // 
            // RdoOccupation
            // 
            this.RdoOccupation.AutoSize = true;
            this.RdoOccupation.Location = new System.Drawing.Point(9, 75);
            this.RdoOccupation.Name = "RdoOccupation";
            this.RdoOccupation.Size = new System.Drawing.Size(117, 17);
            this.RdoOccupation.TabIndex = 2;
            this.RdoOccupation.TabStop = true;
            this.RdoOccupation.Text = "Sort By Occupation";
            this.RdoOccupation.UseVisualStyleBackColor = true;
            this.RdoOccupation.CheckedChanged += new System.EventHandler(this.RdoOccupation_CheckedChanged);
            // 
            // FrmTwoDSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 305);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.GrpSort);
            this.Controls.Add(this.TxtDisplay);
            this.Name = "FrmTwoDSort";
            this.Text = "Multi-Field Sort";
            this.Load += new System.EventHandler(this.FrmTwoDSort_Load);
            this.GrpSort.ResumeLayout(false);
            this.GrpSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.GroupBox GrpSort;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.RadioButton RdoOccupation;
        private System.Windows.Forms.RadioButton RdoTelephone;
        private System.Windows.Forms.RadioButton RdoName;
    }
}

