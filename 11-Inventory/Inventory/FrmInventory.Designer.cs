namespace Inventory
{
    partial class FrmInventory
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inventoryTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivingPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issuingPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTotalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventoryTransactionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(390, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inventoryTransactionsToolStripMenuItem
            // 
            this.inventoryTransactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receivingPartsToolStripMenuItem,
            this.issuingPartsToolStripMenuItem,
            this.displayTotalsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.inventoryTransactionsToolStripMenuItem.Name = "inventoryTransactionsToolStripMenuItem";
            this.inventoryTransactionsToolStripMenuItem.Size = new System.Drawing.Size(150, 20);
            this.inventoryTransactionsToolStripMenuItem.Text = "Inventory Transactions";
            // 
            // receivingPartsToolStripMenuItem
            // 
            this.receivingPartsToolStripMenuItem.Name = "receivingPartsToolStripMenuItem";
            this.receivingPartsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.receivingPartsToolStripMenuItem.Text = "Receiving Parts";
            this.receivingPartsToolStripMenuItem.Click += new System.EventHandler(this.receivingPartsToolStripMenuItem_Click);
            // 
            // issuingPartsToolStripMenuItem
            // 
            this.issuingPartsToolStripMenuItem.Name = "issuingPartsToolStripMenuItem";
            this.issuingPartsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.issuingPartsToolStripMenuItem.Text = "Issuing Parts";
            this.issuingPartsToolStripMenuItem.Click += new System.EventHandler(this.issuingPartsToolStripMenuItem_Click);
            // 
            // displayTotalsToolStripMenuItem
            // 
            this.displayTotalsToolStripMenuItem.Name = "displayTotalsToolStripMenuItem";
            this.displayTotalsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.displayTotalsToolStripMenuItem.Text = "Display Totals";
            this.displayTotalsToolStripMenuItem.Click += new System.EventHandler(this.displayTotalsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Lookup Application";
            this.Load += new System.EventHandler(this.FrmInventory_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inventoryTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivingPartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issuingPartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayTotalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

