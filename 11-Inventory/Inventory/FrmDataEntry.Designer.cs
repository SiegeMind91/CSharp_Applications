namespace Inventory
{
    partial class FrmDataEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.CboPartNumbers = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoSmall = new System.Windows.Forms.RadioButton();
            this.RdoMedium = new System.Windows.Forms.RadioButton();
            this.RdoLarge = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a Part Number";
            // 
            // CboPartNumbers
            // 
            this.CboPartNumbers.FormattingEnabled = true;
            this.CboPartNumbers.Items.AddRange(new object[] {
            "1001",
            "2002",
            "3003",
            "4004",
            "5005",
            "6006",
            "7007",
            "8008",
            "9009",
            "9876"});
            this.CboPartNumbers.Location = new System.Drawing.Point(29, 95);
            this.CboPartNumbers.Name = "CboPartNumbers";
            this.CboPartNumbers.Size = new System.Drawing.Size(108, 21);
            this.CboPartNumbers.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoLarge);
            this.groupBox1.Controls.Add(this.RdoMedium);
            this.groupBox1.Controls.Add(this.RdoSmall);
            this.groupBox1.Location = new System.Drawing.Point(170, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 158);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick a Size";
            // 
            // RdoSmall
            // 
            this.RdoSmall.AutoSize = true;
            this.RdoSmall.Location = new System.Drawing.Point(14, 30);
            this.RdoSmall.Name = "RdoSmall";
            this.RdoSmall.Size = new System.Drawing.Size(50, 17);
            this.RdoSmall.TabIndex = 0;
            this.RdoSmall.TabStop = true;
            this.RdoSmall.Text = "Small";
            this.RdoSmall.UseVisualStyleBackColor = true;
            // 
            // RdoMedium
            // 
            this.RdoMedium.AutoSize = true;
            this.RdoMedium.Location = new System.Drawing.Point(14, 67);
            this.RdoMedium.Name = "RdoMedium";
            this.RdoMedium.Size = new System.Drawing.Size(62, 17);
            this.RdoMedium.TabIndex = 1;
            this.RdoMedium.TabStop = true;
            this.RdoMedium.Text = "Medium";
            this.RdoMedium.UseVisualStyleBackColor = true;
            // 
            // RdoLarge
            // 
            this.RdoLarge.AutoSize = true;
            this.RdoLarge.Location = new System.Drawing.Point(14, 106);
            this.RdoLarge.Name = "RdoLarge";
            this.RdoLarge.Size = new System.Drawing.Size(52, 17);
            this.RdoLarge.TabIndex = 2;
            this.RdoLarge.TabStop = true;
            this.RdoLarge.Text = "Large";
            this.RdoLarge.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(124, 217);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(108, 20);
            this.TxtQuantity.TabIndex = 5;
            this.TxtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantity_KeyPress);
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(57, 267);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(67, 22);
            this.BtnOK.TabIndex = 6;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(177, 265);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(68, 23);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(34, 20);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(0, 13);
            this.LblTitle.TabIndex = 8;
            // 
            // FrmDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 305);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CboPartNumbers);
            this.Controls.Add(this.label1);
            this.Name = "FrmDataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Entry Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboPartNumbers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdoLarge;
        private System.Windows.Forms.RadioButton RdoMedium;
        private System.Windows.Forms.RadioButton RdoSmall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblTitle;
    }
}