namespace Factorials
{
    partial class FrmFactorials
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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.LstFactorials = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(106, 25);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(116, 31);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Generate Factorials";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // LstFactorials
            // 
            this.LstFactorials.FormattingEnabled = true;
            this.LstFactorials.Location = new System.Drawing.Point(63, 99);
            this.LstFactorials.Name = "LstFactorials";
            this.LstFactorials.Size = new System.Drawing.Size(209, 69);
            this.LstFactorials.TabIndex = 1;
            // 
            // FrmFactorials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 262);
            this.Controls.Add(this.LstFactorials);
            this.Controls.Add(this.BtnGenerate);
            this.Name = "FrmFactorials";
            this.Text = "Recursive Factorials";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.ListBox LstFactorials;
    }
}

