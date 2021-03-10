namespace CaesarCode
{
    partial class FrmCaesarCode
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
            this.BtnEncode = new System.Windows.Forms.Button();
            this.BtnDecode = new System.Windows.Forms.Button();
            this.BtnShifted = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEncode
            // 
            this.BtnEncode.Location = new System.Drawing.Point(103, 22);
            this.BtnEncode.Name = "BtnEncode";
            this.BtnEncode.Size = new System.Drawing.Size(83, 28);
            this.BtnEncode.TabIndex = 0;
            this.BtnEncode.Text = "Encode";
            this.BtnEncode.UseVisualStyleBackColor = true;
            this.BtnEncode.Click += new System.EventHandler(this.BtnEncode_Click);
            // 
            // BtnDecode
            // 
            this.BtnDecode.Location = new System.Drawing.Point(104, 77);
            this.BtnDecode.Name = "BtnDecode";
            this.BtnDecode.Size = new System.Drawing.Size(81, 28);
            this.BtnDecode.TabIndex = 1;
            this.BtnDecode.Text = "Decode";
            this.BtnDecode.UseVisualStyleBackColor = true;
            this.BtnDecode.Click += new System.EventHandler(this.BtnDecode_Click);
            // 
            // BtnShifted
            // 
            this.BtnShifted.Location = new System.Drawing.Point(104, 135);
            this.BtnShifted.Name = "BtnShifted";
            this.BtnShifted.Size = new System.Drawing.Size(80, 35);
            this.BtnShifted.TabIndex = 2;
            this.BtnShifted.Text = "Shifted Caesar";
            this.BtnShifted.UseVisualStyleBackColor = true;
            this.BtnShifted.Click += new System.EventHandler(this.BtnShifted_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(107, 209);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(76, 28);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmCaesarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnShifted);
            this.Controls.Add(this.BtnDecode);
            this.Controls.Add(this.BtnEncode);
            this.Name = "FrmCaesarCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caesar Code";
            this.Load += new System.EventHandler(this.FrmCaesarCode_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEncode;
        private System.Windows.Forms.Button BtnDecode;
        private System.Windows.Forms.Button BtnShifted;
        private System.Windows.Forms.Button BtnExit;
    }
}

