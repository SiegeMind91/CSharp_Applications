namespace PathLength
{
    partial class FrmPathLength
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
            this.BtnPath = new System.Windows.Forms.Button();
            this.TxtPath = new System.Windows.Forms.TextBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPath
            // 
            this.BtnPath.Location = new System.Drawing.Point(148, 28);
            this.BtnPath.Name = "BtnPath";
            this.BtnPath.Size = new System.Drawing.Size(89, 31);
            this.BtnPath.TabIndex = 0;
            this.BtnPath.Text = "Determine Path Length";
            this.BtnPath.UseVisualStyleBackColor = true;
            this.BtnPath.Click += new System.EventHandler(this.BtnPath_Click);
            // 
            // TxtPath
            // 
            this.TxtPath.Location = new System.Drawing.Point(35, 77);
            this.TxtPath.Multiline = true;
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtPath.Size = new System.Drawing.Size(317, 152);
            this.TxtPath.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(150, 249);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(85, 28);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmPathLength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 289);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.TxtPath);
            this.Controls.Add(this.BtnPath);
            this.Name = "FrmPathLength";
            this.Text = "Recursive Path Length";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPath;
        private System.Windows.Forms.TextBox TxtPath;
        private System.Windows.Forms.Button BtnExit;
    }
}

