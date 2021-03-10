namespace IntermediateSorting
{
    partial class FrmIntermediateSorting
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
            this.BtnBubble = new System.Windows.Forms.Button();
            this.BtnModifiedBubble = new System.Windows.Forms.Button();
            this.BtnExchange = new System.Windows.Forms.Button();
            this.BtnShell = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LstOriginal = new System.Windows.Forms.ListBox();
            this.LstSorted = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnQuickSort = new System.Windows.Forms.Button();
            this.BtnArrayClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBubble
            // 
            this.BtnBubble.Location = new System.Drawing.Point(420, 12);
            this.BtnBubble.Name = "BtnBubble";
            this.BtnBubble.Size = new System.Drawing.Size(78, 36);
            this.BtnBubble.TabIndex = 0;
            this.BtnBubble.Text = "Bubble";
            this.BtnBubble.UseVisualStyleBackColor = true;
            this.BtnBubble.Click += new System.EventHandler(this.BtnBubble_Click);
            // 
            // BtnModifiedBubble
            // 
            this.BtnModifiedBubble.Location = new System.Drawing.Point(421, 54);
            this.BtnModifiedBubble.Name = "BtnModifiedBubble";
            this.BtnModifiedBubble.Size = new System.Drawing.Size(76, 36);
            this.BtnModifiedBubble.TabIndex = 1;
            this.BtnModifiedBubble.Text = "Modified Bubble";
            this.BtnModifiedBubble.UseVisualStyleBackColor = true;
            this.BtnModifiedBubble.Click += new System.EventHandler(this.BtnModifiedBubble_Click);
            // 
            // BtnExchange
            // 
            this.BtnExchange.Location = new System.Drawing.Point(420, 96);
            this.BtnExchange.Name = "BtnExchange";
            this.BtnExchange.Size = new System.Drawing.Size(76, 40);
            this.BtnExchange.TabIndex = 2;
            this.BtnExchange.Text = "Exchange";
            this.BtnExchange.UseVisualStyleBackColor = true;
            this.BtnExchange.Click += new System.EventHandler(this.BtnExchange_Click);
            // 
            // BtnShell
            // 
            this.BtnShell.Location = new System.Drawing.Point(422, 142);
            this.BtnShell.Name = "BtnShell";
            this.BtnShell.Size = new System.Drawing.Size(74, 42);
            this.BtnShell.TabIndex = 3;
            this.BtnShell.Text = "Shell";
            this.BtnShell.UseVisualStyleBackColor = true;
            this.BtnShell.Click += new System.EventHandler(this.BtnShell_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(39, 247);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 28);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LstOriginal
            // 
            this.LstOriginal.FormattingEnabled = true;
            this.LstOriginal.Location = new System.Drawing.Point(39, 46);
            this.LstOriginal.Name = "LstOriginal";
            this.LstOriginal.Size = new System.Drawing.Size(160, 160);
            this.LstOriginal.TabIndex = 5;
            // 
            // LstSorted
            // 
            this.LstSorted.FormattingEnabled = true;
            this.LstSorted.Location = new System.Drawing.Point(227, 45);
            this.LstSorted.Name = "LstSorted";
            this.LstSorted.Size = new System.Drawing.Size(163, 160);
            this.LstSorted.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Original List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sorted List";
            // 
            // TxtTime
            // 
            this.TxtTime.Location = new System.Drawing.Point(188, 255);
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.Size = new System.Drawing.Size(55, 20);
            this.TxtTime.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Elapsed Time In Milliseconds";
            // 
            // BtnQuickSort
            // 
            this.BtnQuickSort.Location = new System.Drawing.Point(421, 190);
            this.BtnQuickSort.Name = "BtnQuickSort";
            this.BtnQuickSort.Size = new System.Drawing.Size(74, 38);
            this.BtnQuickSort.TabIndex = 11;
            this.BtnQuickSort.Text = "QuickSort";
            this.BtnQuickSort.UseVisualStyleBackColor = true;
            this.BtnQuickSort.Click += new System.EventHandler(this.BtnQuickSort_Click);
            // 
            // BtnArrayClass
            // 
            this.BtnArrayClass.Location = new System.Drawing.Point(420, 243);
            this.BtnArrayClass.Name = "BtnArrayClass";
            this.BtnArrayClass.Size = new System.Drawing.Size(74, 36);
            this.BtnArrayClass.TabIndex = 12;
            this.BtnArrayClass.Text = "Using Array Class Sort";
            this.BtnArrayClass.UseVisualStyleBackColor = true;
            this.BtnArrayClass.Click += new System.EventHandler(this.BtnArrayClass_Click);
            // 
            // FrmIntermediateSorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 299);
            this.Controls.Add(this.BtnArrayClass);
            this.Controls.Add(this.BtnQuickSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstSorted);
            this.Controls.Add(this.LstOriginal);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnShell);
            this.Controls.Add(this.BtnExchange);
            this.Controls.Add(this.BtnModifiedBubble);
            this.Controls.Add(this.BtnBubble);
            this.Name = "FrmIntermediateSorting";
            this.Text = "Sorting Techniques";
            this.Load += new System.EventHandler(this.FrmIntermediateSorting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBubble;
        private System.Windows.Forms.Button BtnModifiedBubble;
        private System.Windows.Forms.Button BtnExchange;
        private System.Windows.Forms.Button BtnShell;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ListBox LstOriginal;
        private System.Windows.Forms.ListBox LstSorted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnQuickSort;
        private System.Windows.Forms.Button BtnArrayClass;
    }
}

