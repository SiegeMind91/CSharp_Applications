namespace EngClass
{
    partial class FrmEngClass
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
            this.BtnSort = new System.Windows.Forms.Button();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnFileSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(46, 47);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(97, 28);
            this.BtnSort.TabIndex = 0;
            this.BtnSort.Text = "Sort1";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(46, 110);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.Size = new System.Drawing.Size(246, 98);
            this.TxtDisplay.TabIndex = 1;
            // 
            // BtnFileSort
            // 
            this.BtnFileSort.Location = new System.Drawing.Point(195, 49);
            this.BtnFileSort.Name = "BtnFileSort";
            this.BtnFileSort.Size = new System.Drawing.Size(97, 26);
            this.BtnFileSort.TabIndex = 2;
            this.BtnFileSort.Text = "Sort2";
            this.BtnFileSort.UseVisualStyleBackColor = true;
            this.BtnFileSort.Click += new System.EventHandler(this.BtnFileSort_Click);
            // 
            // FrmEngClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 262);
            this.Controls.Add(this.BtnFileSort);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.BtnSort);
            this.Name = "FrmEngClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Using An Array of Objects";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnFileSort;
    }
}

