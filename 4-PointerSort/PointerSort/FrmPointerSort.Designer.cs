namespace PointerSort
{
    partial class FrmPointerSort
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
            this.BtnExchange = new System.Windows.Forms.Button();
            this.BtnPointerExchange = new System.Windows.Forms.Button();
            this.BtnPointerShell = new System.Windows.Forms.Button();
            this.TxtOriginal = new System.Windows.Forms.TextBox();
            this.TxtSorted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnExchange
            // 
            this.BtnExchange.Location = new System.Drawing.Point(359, 48);
            this.BtnExchange.Name = "BtnExchange";
            this.BtnExchange.Size = new System.Drawing.Size(82, 54);
            this.BtnExchange.TabIndex = 0;
            this.BtnExchange.Text = "Exchange Sort";
            this.BtnExchange.UseVisualStyleBackColor = true;
            this.BtnExchange.Click += new System.EventHandler(this.BtnExchange_Click);
            // 
            // BtnPointerExchange
            // 
            this.BtnPointerExchange.Location = new System.Drawing.Point(359, 108);
            this.BtnPointerExchange.Name = "BtnPointerExchange";
            this.BtnPointerExchange.Size = new System.Drawing.Size(80, 53);
            this.BtnPointerExchange.TabIndex = 1;
            this.BtnPointerExchange.Text = "Exchange Sort with Pointers";
            this.BtnPointerExchange.UseVisualStyleBackColor = true;
            this.BtnPointerExchange.Click += new System.EventHandler(this.BtnPointerExchange_Click);
            // 
            // BtnPointerShell
            // 
            this.BtnPointerShell.Location = new System.Drawing.Point(359, 167);
            this.BtnPointerShell.Name = "BtnPointerShell";
            this.BtnPointerShell.Size = new System.Drawing.Size(82, 52);
            this.BtnPointerShell.TabIndex = 2;
            this.BtnPointerShell.Text = "Shell Sort with Pointers";
            this.BtnPointerShell.UseVisualStyleBackColor = true;
            this.BtnPointerShell.Click += new System.EventHandler(this.BtnPointerShell_Click);
            // 
            // TxtOriginal
            // 
            this.TxtOriginal.Location = new System.Drawing.Point(13, 51);
            this.TxtOriginal.Multiline = true;
            this.TxtOriginal.Name = "TxtOriginal";
            this.TxtOriginal.Size = new System.Drawing.Size(157, 140);
            this.TxtOriginal.TabIndex = 3;
            // 
            // TxtSorted
            // 
            this.TxtSorted.Location = new System.Drawing.Point(193, 51);
            this.TxtSorted.Multiline = true;
            this.TxtSorted.Name = "TxtSorted";
            this.TxtSorted.Size = new System.Drawing.Size(149, 144);
            this.TxtSorted.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Original List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "List Sorted by HR";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(143, 215);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(80, 26);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmPointerSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 262);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSorted);
            this.Controls.Add(this.TxtOriginal);
            this.Controls.Add(this.BtnPointerShell);
            this.Controls.Add(this.BtnPointerExchange);
            this.Controls.Add(this.BtnExchange);
            this.Name = "FrmPointerSort";
            this.Text = "Sorting Using Pointers";
            this.Load += new System.EventHandler(this.FrmPointerSort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExchange;
        private System.Windows.Forms.Button BtnPointerExchange;
        private System.Windows.Forms.Button BtnPointerShell;
        private System.Windows.Forms.TextBox TxtOriginal;
        private System.Windows.Forms.TextBox TxtSorted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnExit;
    }
}

