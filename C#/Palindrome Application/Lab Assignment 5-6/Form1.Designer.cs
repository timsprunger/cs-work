namespace Lab_Assignment_5_6
{
	partial class Palindromes
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
			this.lblPalindrome = new System.Windows.Forms.Label();
			this.lblSize = new System.Windows.Forms.Label();
			this.txtPalindrome = new System.Windows.Forms.TextBox();
			this.txtSize = new System.Windows.Forms.TextBox();
			this.lsbPalindromes = new System.Windows.Forms.ListBox();
			this.btnFindPalindromes = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.endProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblTotalPalindromes = new System.Windows.Forms.Label();
			this.txtTotalPalindromes = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblPalindrome
			// 
			this.lblPalindrome.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPalindrome.ForeColor = System.Drawing.Color.White;
			this.lblPalindrome.Location = new System.Drawing.Point(74, 59);
			this.lblPalindrome.Name = "lblPalindrome";
			this.lblPalindrome.Size = new System.Drawing.Size(178, 23);
			this.lblPalindrome.TabIndex = 0;
			this.lblPalindrome.Text = "Possible Palindrome";
			this.lblPalindrome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSize
			// 
			this.lblSize.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSize.ForeColor = System.Drawing.Color.White;
			this.lblSize.Location = new System.Drawing.Point(74, 162);
			this.lblSize.Name = "lblSize";
			this.lblSize.Size = new System.Drawing.Size(247, 25);
			this.lblSize.TabIndex = 1;
			this.lblSize.Text = "Size of palindromes to find";
			// 
			// txtPalindrome
			// 
			this.txtPalindrome.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPalindrome.Location = new System.Drawing.Point(78, 91);
			this.txtPalindrome.Name = "txtPalindrome";
			this.txtPalindrome.Size = new System.Drawing.Size(530, 33);
			this.txtPalindrome.TabIndex = 2;
			// 
			// txtSize
			// 
			this.txtSize.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSize.Location = new System.Drawing.Point(331, 158);
			this.txtSize.Name = "txtSize";
			this.txtSize.Size = new System.Drawing.Size(53, 33);
			this.txtSize.TabIndex = 3;
			// 
			// lsbPalindromes
			// 
			this.lsbPalindromes.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lsbPalindromes.FormattingEnabled = true;
			this.lsbPalindromes.ItemHeight = 21;
			this.lsbPalindromes.Location = new System.Drawing.Point(78, 199);
			this.lsbPalindromes.Name = "lsbPalindromes";
			this.lsbPalindromes.Size = new System.Drawing.Size(235, 172);
			this.lsbPalindromes.TabIndex = 4;
			// 
			// btnFindPalindromes
			// 
			this.btnFindPalindromes.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFindPalindromes.ForeColor = System.Drawing.Color.White;
			this.btnFindPalindromes.Location = new System.Drawing.Point(434, 158);
			this.btnFindPalindromes.Name = "btnFindPalindromes";
			this.btnFindPalindromes.Size = new System.Drawing.Size(174, 51);
			this.btnFindPalindromes.TabIndex = 5;
			this.btnFindPalindromes.Text = "Find Palindromes";
			this.btnFindPalindromes.UseVisualStyleBackColor = true;
			this.btnFindPalindromes.Click += new System.EventHandler(this.btnFindPalindromes_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(684, 25);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.endProgramToolStripMenuItem});
			this.fileToolStripMenuItem.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// endProgramToolStripMenuItem
			// 
			this.endProgramToolStripMenuItem.Name = "endProgramToolStripMenuItem";
			this.endProgramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.endProgramToolStripMenuItem.Text = "End Program";
			this.endProgramToolStripMenuItem.Click += new System.EventHandler(this.endProgramToolStripMenuItem_Click);
			// 
			// lblTotalPalindromes
			// 
			this.lblTotalPalindromes.AutoSize = true;
			this.lblTotalPalindromes.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalPalindromes.ForeColor = System.Drawing.Color.White;
			this.lblTotalPalindromes.Location = new System.Drawing.Point(368, 312);
			this.lblTotalPalindromes.Name = "lblTotalPalindromes";
			this.lblTotalPalindromes.Size = new System.Drawing.Size(262, 21);
			this.lblTotalPalindromes.TabIndex = 7;
			this.lblTotalPalindromes.Text = "Total Number of Palindromes";
			// 
			// txtTotalPalindromes
			// 
			this.txtTotalPalindromes.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalPalindromes.Location = new System.Drawing.Point(472, 338);
			this.txtTotalPalindromes.Name = "txtTotalPalindromes";
			this.txtTotalPalindromes.Size = new System.Drawing.Size(62, 33);
			this.txtTotalPalindromes.TabIndex = 8;
			// 
			// Palindromes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(684, 411);
			this.Controls.Add(this.txtTotalPalindromes);
			this.Controls.Add(this.lblTotalPalindromes);
			this.Controls.Add(this.btnFindPalindromes);
			this.Controls.Add(this.lsbPalindromes);
			this.Controls.Add(this.txtSize);
			this.Controls.Add(this.txtPalindrome);
			this.Controls.Add(this.lblSize);
			this.Controls.Add(this.lblPalindrome);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Palindromes";
			this.Text = "Palindromes";
			this.Load += new System.EventHandler(this.Palindromes_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPalindrome;
		private System.Windows.Forms.Label lblSize;
		private System.Windows.Forms.TextBox txtPalindrome;
		private System.Windows.Forms.TextBox txtSize;
		private System.Windows.Forms.ListBox lsbPalindromes;
		private System.Windows.Forms.Button btnFindPalindromes;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem endProgramToolStripMenuItem;
		private System.Windows.Forms.Label lblTotalPalindromes;
		private System.Windows.Forms.TextBox txtTotalPalindromes;
	}
}

