namespace TMN_Fantasy_Application
{
	partial class About
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
			this.btnAboutBack = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnDone = new System.Windows.Forms.Button();
			this.lblTMN = new System.Windows.Forms.Label();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblCreated = new System.Windows.Forms.Label();
			this.lblDevelopers = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAboutBack
			// 
			this.btnAboutBack.BackColor = System.Drawing.Color.LightGray;
			this.btnAboutBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAboutBack.ForeColor = System.Drawing.Color.White;
			this.btnAboutBack.Location = new System.Drawing.Point(29, 24);
			this.btnAboutBack.Name = "btnAboutBack";
			this.btnAboutBack.Size = new System.Drawing.Size(35, 35);
			this.btnAboutBack.TabIndex = 80;
			this.btnAboutBack.Text = "<";
			this.btnAboutBack.UseVisualStyleBackColor = false;
			this.btnAboutBack.Click += new System.EventHandler(this.btnHelpBack_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(29, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(332, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 81;
			this.pictureBox1.TabStop = false;
			// 
			// btnDone
			// 
			this.btnDone.BackColor = System.Drawing.Color.LightGray;
			this.btnDone.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDone.Font = new System.Drawing.Font("Avenir Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDone.ForeColor = System.Drawing.Color.White;
			this.btnDone.Location = new System.Drawing.Point(178, 599);
			this.btnDone.Name = "btnDone";
			this.btnDone.Size = new System.Drawing.Size(647, 40);
			this.btnDone.TabIndex = 82;
			this.btnDone.Text = "Done";
			this.btnDone.UseVisualStyleBackColor = false;
			this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
			// 
			// lblTMN
			// 
			this.lblTMN.AutoSize = true;
			this.lblTMN.Font = new System.Drawing.Font("Avenir-Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTMN.ForeColor = System.Drawing.Color.White;
			this.lblTMN.Location = new System.Drawing.Point(357, 255);
			this.lblTMN.Name = "lblTMN";
			this.lblTMN.Size = new System.Drawing.Size(286, 32);
			this.lblTMN.TabIndex = 83;
			this.lblTMN.Text = "TMN Fantasy Application";
			// 
			// lblVersion
			// 
			this.lblVersion.AutoSize = true;
			this.lblVersion.Font = new System.Drawing.Font("Avenir-Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVersion.ForeColor = System.Drawing.Color.White;
			this.lblVersion.Location = new System.Drawing.Point(440, 287);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(124, 32);
			this.lblVersion.TabIndex = 84;
			this.lblVersion.Text = "version1.1";
			// 
			// lblCreated
			// 
			this.lblCreated.AutoSize = true;
			this.lblCreated.Font = new System.Drawing.Font("Avenir-Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCreated.ForeColor = System.Drawing.Color.White;
			this.lblCreated.Location = new System.Drawing.Point(378, 366);
			this.lblCreated.Name = "lblCreated";
			this.lblCreated.Size = new System.Drawing.Size(239, 32);
			this.lblCreated.TabIndex = 85;
			this.lblCreated.Text = "Created May 6, 2019";
			// 
			// lblDevelopers
			// 
			this.lblDevelopers.AutoSize = true;
			this.lblDevelopers.Font = new System.Drawing.Font("Avenir-Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDevelopers.ForeColor = System.Drawing.Color.White;
			this.lblDevelopers.Location = new System.Drawing.Point(172, 453);
			this.lblDevelopers.Name = "lblDevelopers";
			this.lblDevelopers.Size = new System.Drawing.Size(653, 32);
			this.lblDevelopers.TabIndex = 86;
			this.lblDevelopers.Text = "Developers: Tim Sprunger, Nolan Morawski, Michael Bethel";
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1028, 749);
			this.Controls.Add(this.lblDevelopers);
			this.Controls.Add(this.lblCreated);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.lblTMN);
			this.Controls.Add(this.btnDone);
			this.Controls.Add(this.btnAboutBack);
			this.Controls.Add(this.pictureBox1);
			this.Name = "About";
			this.Text = "About";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.About_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAboutBack;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnDone;
		private System.Windows.Forms.Label lblTMN;
		private System.Windows.Forms.Label lblVersion;
		private System.Windows.Forms.Label lblCreated;
		private System.Windows.Forms.Label lblDevelopers;
	}
}