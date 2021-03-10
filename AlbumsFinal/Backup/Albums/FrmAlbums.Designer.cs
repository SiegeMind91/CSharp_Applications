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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlbums));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.albumStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumStatusToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowAlbumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.returnAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.TbrMain = new System.Windows.Forms.ToolStrip();
            this.TbbNewFile = new System.Windows.Forms.ToolStripButton();
            this.TbbOpenFile = new System.Windows.Forms.ToolStripButton();
            this.TbbSaveFile = new System.Windows.Forms.ToolStripButton();
            this.TbbStatus = new System.Windows.Forms.ToolStripButton();
            this.TbbBorrow = new System.Windows.Forms.ToolStripButton();
            this.TbbReturn = new System.Windows.Forms.ToolStripButton();
            this.TbbChange = new System.Windows.Forms.ToolStripButton();
            this.TbbDelete = new System.Windows.Forms.ToolStripButton();
            this.TbbAdd = new System.Windows.Forms.ToolStripButton();
            this.TbbExit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.TbrMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.albumStatusToolStripMenuItem,
            this.borrowAlbumToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.transactionsToolStripMenuItem.Text = "File Operations";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 22);
            this.toolStripMenuItem2.Text = "Open";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // albumStatusToolStripMenuItem
            // 
            this.albumStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albumStatusToolStripMenuItem1,
            this.borrowAlbumToolStripMenuItem1,
            this.returnAlbumToolStripMenuItem});
            this.albumStatusToolStripMenuItem.Name = "albumStatusToolStripMenuItem";
            this.albumStatusToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.albumStatusToolStripMenuItem.Text = "Transactions";
            // 
            // albumStatusToolStripMenuItem1
            // 
            this.albumStatusToolStripMenuItem1.Name = "albumStatusToolStripMenuItem1";
            this.albumStatusToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.albumStatusToolStripMenuItem1.Text = "Album Status";
            this.albumStatusToolStripMenuItem1.Click += new System.EventHandler(this.albumStatusToolStripMenuItem1_Click);
            // 
            // borrowAlbumToolStripMenuItem1
            // 
            this.borrowAlbumToolStripMenuItem1.Name = "borrowAlbumToolStripMenuItem1";
            this.borrowAlbumToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.borrowAlbumToolStripMenuItem1.Text = "Borrow Album";
            this.borrowAlbumToolStripMenuItem1.Click += new System.EventHandler(this.borrowAlbumToolStripMenuItem1_Click);
            // 
            // returnAlbumToolStripMenuItem
            // 
            this.returnAlbumToolStripMenuItem.Name = "returnAlbumToolStripMenuItem";
            this.returnAlbumToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.returnAlbumToolStripMenuItem.Text = "Return Album";
            this.returnAlbumToolStripMenuItem.Click += new System.EventHandler(this.returnAlbumToolStripMenuItem_Click);
            // 
            // borrowAlbumToolStripMenuItem
            // 
            this.borrowAlbumToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changesToolStripMenuItem,
            this.deletionsToolStripMenuItem,
            this.additionsToolStripMenuItem});
            this.borrowAlbumToolStripMenuItem.Name = "borrowAlbumToolStripMenuItem";
            this.borrowAlbumToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.borrowAlbumToolStripMenuItem.Text = "Updates";
            // 
            // changesToolStripMenuItem
            // 
            this.changesToolStripMenuItem.Name = "changesToolStripMenuItem";
            this.changesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.changesToolStripMenuItem.Text = "Changes";
            this.changesToolStripMenuItem.Click += new System.EventHandler(this.changesToolStripMenuItem_Click);
            // 
            // deletionsToolStripMenuItem
            // 
            this.deletionsToolStripMenuItem.Name = "deletionsToolStripMenuItem";
            this.deletionsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.deletionsToolStripMenuItem.Text = "Deletions";
            this.deletionsToolStripMenuItem.Click += new System.EventHandler(this.deletionsToolStripMenuItem_Click);
            // 
            // additionsToolStripMenuItem
            // 
            this.additionsToolStripMenuItem.Name = "additionsToolStripMenuItem";
            this.additionsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.additionsToolStripMenuItem.Text = "Additions";
            this.additionsToolStripMenuItem.Click += new System.EventHandler(this.additionsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Save ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TbrMain
            // 
            this.TbrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TbbNewFile,
            this.TbbOpenFile,
            this.TbbSaveFile,
            this.TbbStatus,
            this.TbbBorrow,
            this.TbbReturn,
            this.TbbChange,
            this.TbbDelete,
            this.TbbAdd,
            this.TbbExit});
            this.TbrMain.Location = new System.Drawing.Point(0, 24);
            this.TbrMain.Name = "TbrMain";
            this.TbrMain.Size = new System.Drawing.Size(490, 25);
            this.TbrMain.TabIndex = 1;
            this.TbrMain.Text = "toolStrip1";
            // 
            // TbbNewFile
            // 
            this.TbbNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TbbNewFile.Image = ((System.Drawing.Image)(resources.GetObject("TbbNewFile.Image")));
            this.TbbNewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbbNewFile.Name = "TbbNewFile";
            this.TbbNewFile.Size = new System.Drawing.Size(23, 22);
            this.TbbNewFile.Text = "New File";
            this.TbbNewFile.ToolTipText = "Create a New File";
            this.TbbNewFile.Click += new System.EventHandler(this.TbbNewFile_Click);
            // 
            // TbbOpenFile
            // 
            this.TbbOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TbbOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("TbbOpenFile.Image")));
            this.TbbOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbbOpenFile.Name = "TbbOpenFile";
            this.TbbOpenFile.Size = new System.Drawing.Size(23, 22);
            this.TbbOpenFile.Text = "Open File";
            this.TbbOpenFile.Click += new System.EventHandler(this.TbbOpenFile_Click);
            // 
            // TbbSaveFile
            // 
            this.TbbSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TbbSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("TbbSaveFile.Image")));
            this.TbbSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbbSaveFile.Name = "TbbSaveFile";
            this.TbbSaveFile.Size = new System.Drawing.Size(23, 22);
            this.TbbSaveFile.Text = "Save File";
            this.TbbSaveFile.Click += new System.EventHandler(this.TbbSaveFile_Click);
            // 
            // TbbStatus
            // 
            this.TbbStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TbbStatus.Image = ((System.Drawing.Image)(resources.GetObject("TbbStatus.Image")));
            this.TbbStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbbStatus.Name = "TbbStatus";
            this.TbbStatus.Size = new System.Drawing.Size(23, 22);
            this.TbbStatus.Text = "Album Status";
            this.TbbStatus.Click += new System.EventHandler(this.TbbStatus_Click);
            // 
            // TbbBorrow
            // 
            this.TbbBorrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TbbBorrow.Image = ((System.Drawing.Image)(resources.GetObject("TbbBorrow.Image")));
            this.TbbBorrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbbBorrow.Name = "TbbBorrow";
            this.TbbBorrow.Size = new System.Drawing.Size(23, 22);
            this.TbbBorrow.Text = "Borrow An Album";
            this.TbbBorrow.Click += new System.EventHandler(this.TbbBorrow_Click);
            // 
            // TbbReturn
            // 
            this.TbbReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TbbReturn.Image = ((System.Drawing.Image)(resources.GetObject("TbbReturn.Image")));
            this.TbbReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbbReturn.Name = "TbbReturn";
            this.TbbReturn.Size = new System.Drawing.Size(23, 22);
            this.TbbReturn.Text = "Return An Album";
            this.TbbReturn.Click += new System.EventHandler(this.TbbReturn_Click);
            // 
            // TbbChange
            // 
            this.TbbChange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TbbChange.Image = ((System.Drawing.Image)(resources.GetObject("TbbChange.Image")));
            this.TbbChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbbChange.Name = "TbbChange";
            this.TbbChange.Size = new System.Drawing.Size(23, 22);
            this.TbbChange.Text = "Change An Album Name";
            this.TbbChange.Click += new System.EventHandler(this.TbbChange_Click);
            // 
            // TbbDelete
            // 
            this.TbbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TbbDelete.Image = ((System.Drawing.Image)(resources.GetObject("TbbDelete.Image")));
            this.TbbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbbDelete.Name = "TbbDelete";
            this.TbbDelete.Size = new System.Drawing.Size(23, 22);
            this.TbbDelete.Text = "Delete An Album";
            this.TbbDelete.Click += new System.EventHandler(this.TbbDelete_Click);
            // 
            // TbbAdd
            // 
            this.TbbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TbbAdd.Image = ((System.Drawing.Image)(resources.GetObject("TbbAdd.Image")));
            this.TbbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbbAdd.Name = "TbbAdd";
            this.TbbAdd.Size = new System.Drawing.Size(23, 22);
            this.TbbAdd.Text = "Add An Album";
            this.TbbAdd.Click += new System.EventHandler(this.TbbAdd_Click);
            // 
            // TbbExit
            // 
            this.TbbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TbbExit.Image = ((System.Drawing.Image)(resources.GetObject("TbbExit.Image")));
            this.TbbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TbbExit.Name = "TbbExit";
            this.TbbExit.Size = new System.Drawing.Size(23, 22);
            this.TbbExit.Text = "Exit";
            this.TbbExit.Click += new System.EventHandler(this.TbbExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 307);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(490, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel.Text = "No Files Loaded";
            // 
            // FrmAlbums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Albums.Properties.Resources.Music;
            this.ClientSize = new System.Drawing.Size(490, 329);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TbrMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAlbums";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Album Lending Program";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TbrMain.ResumeLayout(false);
            this.TbrMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumStatusToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrowAlbumToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem returnAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem additionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip TbrMain;
        private System.Windows.Forms.ToolStripButton TbbNewFile;
        private System.Windows.Forms.ToolStripButton TbbOpenFile;
        private System.Windows.Forms.ToolStripButton TbbSaveFile;
        private System.Windows.Forms.ToolStripButton TbbStatus;
        private System.Windows.Forms.ToolStripButton TbbBorrow;
        private System.Windows.Forms.ToolStripButton TbbReturn;
        private System.Windows.Forms.ToolStripButton TbbChange;
        private System.Windows.Forms.ToolStripButton TbbDelete;
        private System.Windows.Forms.ToolStripButton TbbAdd;
        private System.Windows.Forms.ToolStripButton TbbExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

