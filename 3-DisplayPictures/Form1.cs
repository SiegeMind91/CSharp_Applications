using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DisplayPictures
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Label lblWidth;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label lblHeight;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.PictureBox PictureBox1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblWidth = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.lblHeight = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// lblWidth
			// 
			this.lblWidth.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.lblWidth.BackColor = System.Drawing.Color.White;
			this.lblWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblWidth.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblWidth.Location = new System.Drawing.Point(104, 200);
			this.lblWidth.Name = "lblWidth";
			this.lblWidth.Size = new System.Drawing.Size(64, 23);
			this.lblWidth.TabIndex = 9;
			this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label3
			// 
			this.Label3.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.Label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label3.Location = new System.Drawing.Point(104, 168);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(64, 23);
			this.Label3.TabIndex = 8;
			this.Label3.Text = "Width";
			// 
			// lblHeight
			// 
			this.lblHeight.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.lblHeight.BackColor = System.Drawing.Color.White;
			this.lblHeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblHeight.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblHeight.Location = new System.Drawing.Point(16, 200);
			this.lblHeight.Name = "lblHeight";
			this.lblHeight.Size = new System.Drawing.Size(64, 23);
			this.lblHeight.TabIndex = 7;
			this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label1
			// 
			this.Label1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.Label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label1.Location = new System.Drawing.Point(16, 168);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(64, 23);
			this.Label1.TabIndex = 6;
			this.Label1.Text = "Height";
			// 
			// PictureBox1
			// 
			this.PictureBox1.Location = new System.Drawing.Point(8, 8);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(248, 136);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex = 5;
			this.PictureBox1.TabStop = false;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3});
			this.menuItem1.Text = "&File";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "&Open";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "E&xit";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(288, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.lblWidth,
																		  this.Label3,
																		  this.lblHeight,
																		  this.Label1,
																		  this.PictureBox1});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Display Pictures";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			openFileDialog1.InitialDirectory = Application.ExecutablePath ;
			openFileDialog1.Filter = "Picture Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*" ;
			openFileDialog1.FilterIndex = 1 ;
			openFileDialog1.RestoreDirectory = true ;

			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				int oldWidth = PictureBox1.Width;
				int oldHeight = PictureBox1.Height;
				int deltaWidth, deltaHeight;

				PictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
				deltaWidth = PictureBox1.Width - oldWidth;
				deltaHeight = PictureBox1.Height - oldHeight;
				if (PictureBox1.Left+PictureBox1.Width > this.Width)
					this.Width += deltaWidth;
				if (PictureBox1.Top+PictureBox1.Height> Label1.Top)
					this.Height += deltaHeight;
				lblWidth.Text = PictureBox1.Width.ToString();
				lblHeight.Text = PictureBox1.Height.ToString();
			}
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
	}
}
