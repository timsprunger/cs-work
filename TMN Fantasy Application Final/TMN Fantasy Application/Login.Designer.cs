namespace TMN_Fantasy_Application
{

	partial class LoginScreen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
			this.lblTMN = new System.Windows.Forms.Label();
			this.lblSignIn = new System.Windows.Forms.Label();
			this.txtUsername1 = new System.Windows.Forms.TextBox();
			this.lblNoAccount = new System.Windows.Forms.Label();
			this.txtPassword1 = new System.Windows.Forms.TextBox();
			this.btnLogIn = new System.Windows.Forms.Button();
			this.lblFantasy = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnHelp = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTMN
			// 
			this.lblTMN.AutoSize = true;
			this.lblTMN.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTMN.Location = new System.Drawing.Point(137, 32);
			this.lblTMN.Name = "lblTMN";
			this.lblTMN.Size = new System.Drawing.Size(0, 55);
			this.lblTMN.TabIndex = 0;
			// 
			// lblSignIn
			// 
			this.lblSignIn.AutoSize = true;
			this.lblSignIn.Font = new System.Drawing.Font("Avenir Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSignIn.ForeColor = System.Drawing.Color.White;
			this.lblSignIn.Location = new System.Drawing.Point(237, 237);
			this.lblSignIn.Name = "lblSignIn";
			this.lblSignIn.Size = new System.Drawing.Size(579, 64);
			this.lblSignIn.TabIndex = 1;
			this.lblSignIn.Text = "Sign In To Your Account";
			this.lblSignIn.Click += new System.EventHandler(this.lblSignIn_Click);
			// 
			// txtUsername1
			// 
			this.txtUsername1.BackColor = System.Drawing.Color.LightGray;
			this.txtUsername1.Font = new System.Drawing.Font("Avenir-Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername1.ForeColor = System.Drawing.Color.White;
			this.txtUsername1.Location = new System.Drawing.Point(248, 333);
			this.txtUsername1.Name = "txtUsername1";
			this.txtUsername1.Size = new System.Drawing.Size(525, 40);
			this.txtUsername1.TabIndex = 2;
			this.txtUsername1.Text = "Username";
			this.txtUsername1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtUsername1.TextChanged += new System.EventHandler(this.txtUsername1_TextChanged);
			// 
			// lblNoAccount
			// 
			this.lblNoAccount.AutoSize = true;
			this.lblNoAccount.Font = new System.Drawing.Font("Avenir-Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNoAccount.ForeColor = System.Drawing.Color.White;
			this.lblNoAccount.Location = new System.Drawing.Point(590, 453);
			this.lblNoAccount.Name = "lblNoAccount";
			this.lblNoAccount.Size = new System.Drawing.Size(182, 21);
			this.lblNoAccount.TabIndex = 5;
			this.lblNoAccount.Text = "Don\'t Have an Account?";
			this.lblNoAccount.Click += new System.EventHandler(this.lblNoAccount_Click);
			// 
			// txtPassword1
			// 
			this.txtPassword1.BackColor = System.Drawing.Color.LightGray;
			this.txtPassword1.Font = new System.Drawing.Font("Avenir-Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword1.ForeColor = System.Drawing.Color.White;
			this.txtPassword1.Location = new System.Drawing.Point(247, 401);
			this.txtPassword1.Name = "txtPassword1";
			this.txtPassword1.Size = new System.Drawing.Size(526, 40);
			this.txtPassword1.TabIndex = 6;
			this.txtPassword1.Text = "Password";
			this.txtPassword1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtPassword1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// btnLogIn
			// 
			this.btnLogIn.BackColor = System.Drawing.Color.LightGray;
			this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogIn.Font = new System.Drawing.Font("Avenir Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogIn.ForeColor = System.Drawing.Color.White;
			this.btnLogIn.Location = new System.Drawing.Point(248, 530);
			this.btnLogIn.Name = "btnLogIn";
			this.btnLogIn.Size = new System.Drawing.Size(525, 40);
			this.btnLogIn.TabIndex = 7;
			this.btnLogIn.Text = "Log In";
			this.btnLogIn.UseVisualStyleBackColor = false;
			this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
			// 
			// lblFantasy
			// 
			this.lblFantasy.AutoSize = true;
			this.lblFantasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFantasy.Location = new System.Drawing.Point(91, 83);
			this.lblFantasy.Name = "lblFantasy";
			this.lblFantasy.Size = new System.Drawing.Size(0, 37);
			this.lblFantasy.TabIndex = 8;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(23, 22);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(332, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			// 
			// btnHelp
			// 
			this.btnHelp.BackColor = System.Drawing.Color.LightGray;
			this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHelp.Font = new System.Drawing.Font("Avenir-Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHelp.ForeColor = System.Drawing.Color.White;
			this.btnHelp.Location = new System.Drawing.Point(828, 32);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(75, 25);
			this.btnHelp.TabIndex = 61;
			this.btnHelp.Text = "Help";
			this.btnHelp.UseVisualStyleBackColor = false;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// btnAbout
			// 
			this.btnAbout.BackColor = System.Drawing.Color.LightGray;
			this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAbout.Font = new System.Drawing.Font("Avenir-Book", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAbout.ForeColor = System.Drawing.Color.White;
			this.btnAbout.Location = new System.Drawing.Point(914, 32);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(75, 25);
			this.btnAbout.TabIndex = 62;
			this.btnAbout.Text = "About";
			this.btnAbout.UseVisualStyleBackColor = false;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// LoginScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1028, 749);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnLogIn);
			this.Controls.Add(this.txtPassword1);
			this.Controls.Add(this.lblNoAccount);
			this.Controls.Add(this.txtUsername1);
			this.Controls.Add(this.lblSignIn);
			this.Controls.Add(this.lblTMN);
			this.Controls.Add(this.lblFantasy);
			this.Name = "LoginScreen";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginScreen_FormClosed);
			this.Load += new System.EventHandler(this.LoginScreen_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTMN;
		private System.Windows.Forms.Label lblSignIn;
		private System.Windows.Forms.TextBox txtUsername1;
		private System.Windows.Forms.Label lblNoAccount;
		private System.Windows.Forms.TextBox txtPassword1;
		private System.Windows.Forms.Button btnLogIn;
		private System.Windows.Forms.Label lblFantasy;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.Button btnAbout;
	}
}

