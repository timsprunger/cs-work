namespace Lab_Assignment_2
{
	partial class Thermometer
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
			this.scrollTemp = new System.Windows.Forms.VScrollBar();
			this.lblFahrenheit = new System.Windows.Forms.Label();
			this.lblCentigrade = new System.Windows.Forms.Label();
			this.lblFahrenheitValue = new System.Windows.Forms.Label();
			this.lblCentigradeValue = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.btnFreezing = new System.Windows.Forms.Button();
			this.btnBoiling = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// scrollTemp
			// 
			this.scrollTemp.Location = new System.Drawing.Point(384, 105);
			this.scrollTemp.Maximum = 300;
			this.scrollTemp.Minimum = -100;
			this.scrollTemp.Name = "scrollTemp";
			this.scrollTemp.Size = new System.Drawing.Size(35, 196);
			this.scrollTemp.TabIndex = 3;
			this.scrollTemp.Value = 32;
			this.scrollTemp.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
			// 
			// lblFahrenheit
			// 
			this.lblFahrenheit.BackColor = System.Drawing.Color.Transparent;
			this.lblFahrenheit.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFahrenheit.ForeColor = System.Drawing.Color.White;
			this.lblFahrenheit.Location = new System.Drawing.Point(208, 101);
			this.lblFahrenheit.Name = "lblFahrenheit";
			this.lblFahrenheit.Size = new System.Drawing.Size(155, 24);
			this.lblFahrenheit.TabIndex = 4;
			this.lblFahrenheit.Text = "Fahrenheit";
			// 
			// lblCentigrade
			// 
			this.lblCentigrade.AutoSize = true;
			this.lblCentigrade.BackColor = System.Drawing.Color.Transparent;
			this.lblCentigrade.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCentigrade.ForeColor = System.Drawing.Color.White;
			this.lblCentigrade.Location = new System.Drawing.Point(442, 101);
			this.lblCentigrade.Name = "lblCentigrade";
			this.lblCentigrade.Size = new System.Drawing.Size(152, 27);
			this.lblCentigrade.TabIndex = 5;
			this.lblCentigrade.Text = "Centigrade";
			// 
			// lblFahrenheitValue
			// 
			this.lblFahrenheitValue.BackColor = System.Drawing.Color.MediumTurquoise;
			this.lblFahrenheitValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblFahrenheitValue.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFahrenheitValue.ForeColor = System.Drawing.Color.White;
			this.lblFahrenheitValue.Location = new System.Drawing.Point(241, 144);
			this.lblFahrenheitValue.Name = "lblFahrenheitValue";
			this.lblFahrenheitValue.Size = new System.Drawing.Size(112, 32);
			this.lblFahrenheitValue.TabIndex = 6;
			this.lblFahrenheitValue.Text = "-";
			this.lblFahrenheitValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCentigradeValue
			// 
			this.lblCentigradeValue.BackColor = System.Drawing.Color.MediumTurquoise;
			this.lblCentigradeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblCentigradeValue.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCentigradeValue.ForeColor = System.Drawing.Color.White;
			this.lblCentigradeValue.Location = new System.Drawing.Point(447, 144);
			this.lblCentigradeValue.Name = "lblCentigradeValue";
			this.lblCentigradeValue.Size = new System.Drawing.Size(112, 32);
			this.lblCentigradeValue.TabIndex = 7;
			this.lblCentigradeValue.Text = "-";
			this.lblCentigradeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 8;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
			// 
			// exitToolStripMenuItem1
			// 
			this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
			this.exitToolStripMenuItem1.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem1.Text = "Exit";
			// 
			// btnFreezing
			// 
			this.btnFreezing.BackColor = System.Drawing.Color.MediumTurquoise;
			this.btnFreezing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnFreezing.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFreezing.ForeColor = System.Drawing.Color.White;
			this.btnFreezing.Location = new System.Drawing.Point(241, 326);
			this.btnFreezing.Name = "btnFreezing";
			this.btnFreezing.Size = new System.Drawing.Size(112, 39);
			this.btnFreezing.TabIndex = 10;
			this.btnFreezing.Text = "Freezing";
			this.btnFreezing.UseVisualStyleBackColor = false;
			this.btnFreezing.Click += new System.EventHandler(this.btnFreezing_Click);
			// 
			// btnBoiling
			// 
			this.btnBoiling.BackColor = System.Drawing.Color.MediumTurquoise;
			this.btnBoiling.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBoiling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBoiling.ForeColor = System.Drawing.Color.White;
			this.btnBoiling.Location = new System.Drawing.Point(447, 326);
			this.btnBoiling.Name = "btnBoiling";
			this.btnBoiling.Size = new System.Drawing.Size(112, 39);
			this.btnBoiling.TabIndex = 11;
			this.btnBoiling.Text = "Boiling";
			this.btnBoiling.UseVisualStyleBackColor = false;
			this.btnBoiling.Click += new System.EventHandler(this.btnBoiling_Click);
			// 
			// Thermometer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnBoiling);
			this.Controls.Add(this.btnFreezing);
			this.Controls.Add(this.lblCentigradeValue);
			this.Controls.Add(this.lblFahrenheitValue);
			this.Controls.Add(this.lblCentigrade);
			this.Controls.Add(this.lblFahrenheit);
			this.Controls.Add(this.scrollTemp);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Thermometer";
			this.Text = "Thermometer";
			this.Load += new System.EventHandler(this.Thermometer_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.VScrollBar scrollTemp;
		private System.Windows.Forms.Label lblFahrenheit;
		private System.Windows.Forms.Label lblCentigrade;
		private System.Windows.Forms.Label lblFahrenheitValue;
		private System.Windows.Forms.Label lblCentigradeValue;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
		private System.Windows.Forms.Button btnFreezing;
		private System.Windows.Forms.Button btnBoiling;
	}
}

