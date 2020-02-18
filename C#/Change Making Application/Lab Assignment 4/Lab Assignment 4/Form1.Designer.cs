namespace Lab_Assignment_4
{
	partial class Changemaker
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Changemaker));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblTotalCost = new System.Windows.Forms.Label();
			this.lblMoneyPresented = new System.Windows.Forms.Label();
			this.txtTotalCost = new System.Windows.Forms.TextBox();
			this.txtMoneyPresented = new System.Windows.Forms.TextBox();
			this.btnMakeChange = new System.Windows.Forms.Button();
			this.lblChange = new System.Windows.Forms.Label();
			this.lsbChange = new System.Windows.Forms.ListBox();
			this.lblChangeTest = new System.Windows.Forms.Label();
			this.contextMenuStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(384, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem1
			// 
			this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
			this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem1.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// lblTotalCost
			// 
			this.lblTotalCost.BackColor = System.Drawing.Color.Transparent;
			this.lblTotalCost.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalCost.ForeColor = System.Drawing.Color.White;
			this.lblTotalCost.Location = new System.Drawing.Point(72, 66);
			this.lblTotalCost.Name = "lblTotalCost";
			this.lblTotalCost.Size = new System.Drawing.Size(67, 45);
			this.lblTotalCost.TabIndex = 2;
			this.lblTotalCost.Text = "Total Cost";
			this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMoneyPresented
			// 
			this.lblMoneyPresented.BackColor = System.Drawing.Color.Transparent;
			this.lblMoneyPresented.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMoneyPresented.ForeColor = System.Drawing.Color.White;
			this.lblMoneyPresented.Location = new System.Drawing.Point(212, 70);
			this.lblMoneyPresented.Name = "lblMoneyPresented";
			this.lblMoneyPresented.Size = new System.Drawing.Size(142, 42);
			this.lblMoneyPresented.TabIndex = 3;
			this.lblMoneyPresented.Text = "Money Presented";
			this.lblMoneyPresented.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtTotalCost
			// 
			this.txtTotalCost.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalCost.Location = new System.Drawing.Point(32, 114);
			this.txtTotalCost.Name = "txtTotalCost";
			this.txtTotalCost.Size = new System.Drawing.Size(140, 33);
			this.txtTotalCost.TabIndex = 4;
			this.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtMoneyPresented
			// 
			this.txtMoneyPresented.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMoneyPresented.Location = new System.Drawing.Point(212, 114);
			this.txtMoneyPresented.Name = "txtMoneyPresented";
			this.txtMoneyPresented.Size = new System.Drawing.Size(142, 33);
			this.txtMoneyPresented.TabIndex = 5;
			this.txtMoneyPresented.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnMakeChange
			// 
			this.btnMakeChange.BackColor = System.Drawing.Color.White;
			this.btnMakeChange.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnMakeChange.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMakeChange.ForeColor = System.Drawing.Color.White;
			this.btnMakeChange.Location = new System.Drawing.Point(32, 176);
			this.btnMakeChange.Name = "btnMakeChange";
			this.btnMakeChange.Size = new System.Drawing.Size(140, 30);
			this.btnMakeChange.TabIndex = 6;
			this.btnMakeChange.Text = "Make Change";
			this.btnMakeChange.UseVisualStyleBackColor = false;
			this.btnMakeChange.Click += new System.EventHandler(this.btnMakeChange_Click);
			// 
			// lblChange
			// 
			this.lblChange.BackColor = System.Drawing.Color.Transparent;
			this.lblChange.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChange.ForeColor = System.Drawing.Color.White;
			this.lblChange.Location = new System.Drawing.Point(212, 180);
			this.lblChange.Name = "lblChange";
			this.lblChange.Size = new System.Drawing.Size(142, 23);
			this.lblChange.TabIndex = 7;
			this.lblChange.Text = "Change";
			this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lsbChange
			// 
			this.lsbChange.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lsbChange.FormattingEnabled = true;
			this.lsbChange.ItemHeight = 21;
			this.lsbChange.Location = new System.Drawing.Point(212, 214);
			this.lsbChange.Name = "lsbChange";
			this.lsbChange.Size = new System.Drawing.Size(142, 172);
			this.lsbChange.TabIndex = 8;
			// 
			// lblChangeTest
			// 
			this.lblChangeTest.AutoSize = true;
			this.lblChangeTest.ForeColor = System.Drawing.Color.White;
			this.lblChangeTest.Location = new System.Drawing.Point(141, 42);
			this.lblChangeTest.Name = "lblChangeTest";
			this.lblChangeTest.Size = new System.Drawing.Size(0, 13);
			this.lblChangeTest.TabIndex = 12;
			// 
			// Changemaker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(384, 411);
			this.Controls.Add(this.lblChangeTest);
			this.Controls.Add(this.lsbChange);
			this.Controls.Add(this.lblChange);
			this.Controls.Add(this.btnMakeChange);
			this.Controls.Add(this.txtMoneyPresented);
			this.Controls.Add(this.txtTotalCost);
			this.Controls.Add(this.lblMoneyPresented);
			this.Controls.Add(this.lblTotalCost);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Changemaker";
			this.Text = "Changemaker";
			this.contextMenuStrip1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Label lblTotalCost;
		private System.Windows.Forms.Label lblMoneyPresented;
		private System.Windows.Forms.TextBox txtTotalCost;
		private System.Windows.Forms.TextBox txtMoneyPresented;
		private System.Windows.Forms.Button btnMakeChange;
		private System.Windows.Forms.Label lblChange;
		private System.Windows.Forms.ListBox lsbChange;
		private System.Windows.Forms.Label lblChangeTest;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
	}
}

