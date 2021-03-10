namespace Median
{
    partial class FrmMedian
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
            this.BtnMedian = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LstOriginal = new System.Windows.Forms.ListBox();
            this.LstSorted = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnMedian
            // 
            this.BtnMedian.Location = new System.Drawing.Point(412, 97);
            this.BtnMedian.Name = "BtnMedian";
            this.BtnMedian.Size = new System.Drawing.Size(67, 37);
            this.BtnMedian.TabIndex = 0;
            this.BtnMedian.Text = "Determine Median";
            this.BtnMedian.UseVisualStyleBackColor = true;
            this.BtnMedian.Click += new System.EventHandler(this.BtnMedian_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(414, 152);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(64, 33);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LstOriginal
            // 
            this.LstOriginal.FormattingEnabled = true;
            this.LstOriginal.Location = new System.Drawing.Point(33, 57);
            this.LstOriginal.Name = "LstOriginal";
            this.LstOriginal.Size = new System.Drawing.Size(166, 134);
            this.LstOriginal.TabIndex = 2;
            // 
            // LstSorted
            // 
            this.LstSorted.FormattingEnabled = true;
            this.LstSorted.Location = new System.Drawing.Point(220, 56);
            this.LstSorted.Name = "LstSorted";
            this.LstSorted.Size = new System.Drawing.Size(164, 134);
            this.LstSorted.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Original List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sorted List";
            // 
            // FrmMedian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstSorted);
            this.Controls.Add(this.LstOriginal);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnMedian);
            this.Name = "FrmMedian";
            this.Text = "Median Problem";
            this.Load += new System.EventHandler(this.FrmMedian_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMedian;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ListBox LstOriginal;
        private System.Windows.Forms.ListBox LstSorted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

