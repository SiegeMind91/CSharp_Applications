namespace Albums
{
    partial class FrmAlbums
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
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albumStatusToolStripMenuItem,
            this.borrowAlbumToolStripMenuItem,
            this.returnAlbumToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // albumStatusToolStripMenuItem
            // 
            this.albumStatusToolStripMenuItem.Name = "albumStatusToolStripMenuItem";
            this.albumStatusToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.albumStatusToolStripMenuItem.Text = "Album Status";
            this.albumStatusToolStripMenuItem.Click += new System.EventHandler(this.albumStatusToolStripMenuItem_Click);
            // 
            // borrowAlbumToolStripMenuItem
            // 
            this.borrowAlbumToolStripMenuItem.Name = "borrowAlbumToolStripMenuItem";
            this.borrowAlbumToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.borrowAlbumToolStripMenuItem.Text = "Borrow Album";
            this.borrowAlbumToolStripMenuItem.Click += new System.EventHandler(this.borrowAlbumToolStripMenuItem_Click);
            // 
            // returnAlbumToolStripMenuItem
            // 
            this.returnAlbumToolStripMenuItem.Name = "returnAlbumToolStripMenuItem";
            this.returnAlbumToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.returnAlbumToolStripMenuItem.Text = "Return Album";
            this.returnAlbumToolStripMenuItem.Click += new System.EventHandler(this.returnAlbumToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FrmAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Albums.Properties.Resources.Music;
            this.ClientSize = new System.Drawing.Size(490, 329);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAlbums";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Album Lending Program";
            this.Load += new System.EventHandler(this.FrmAlbums_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

