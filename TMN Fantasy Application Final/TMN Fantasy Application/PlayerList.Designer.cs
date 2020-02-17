namespace TMN_Fantasy_Application
{
	partial class PlayerList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerList));
			this.lblPosition = new System.Windows.Forms.Label();
			this.btnAddPlayer = new System.Windows.Forms.Button();
			this.lblRating = new System.Windows.Forms.Label();
			this.btnPlayerListLogOut = new System.Windows.Forms.Button();
			this.lblChangingPosition = new System.Windows.Forms.Label();
			this.lblPlayerName = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.lblRating1 = new System.Windows.Forms.Label();
			this.lblRating2 = new System.Windows.Forms.Label();
			this.lblRating3 = new System.Windows.Forms.Label();
			this.btnPlayerDetails = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblUsername = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblPosition
			// 
			this.lblPosition.Font = new System.Drawing.Font("Avenir Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPosition.ForeColor = System.Drawing.Color.White;
			this.lblPosition.Location = new System.Drawing.Point(176, 207);
			this.lblPosition.Name = "lblPosition";
			this.lblPosition.Size = new System.Drawing.Size(245, 64);
			this.lblPosition.TabIndex = 11;
			this.lblPosition.Text = "Position:";
			this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAddPlayer
			// 
			this.btnAddPlayer.BackColor = System.Drawing.Color.LightGray;
			this.btnAddPlayer.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnAddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddPlayer.Font = new System.Drawing.Font("Avenir Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddPlayer.ForeColor = System.Drawing.Color.White;
			this.btnAddPlayer.Location = new System.Drawing.Point(194, 611);
			this.btnAddPlayer.Name = "btnAddPlayer";
			this.btnAddPlayer.Size = new System.Drawing.Size(608, 40);
			this.btnAddPlayer.TabIndex = 15;
			this.btnAddPlayer.Text = "Add Player";
			this.btnAddPlayer.UseVisualStyleBackColor = false;
			this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
			// 
			// lblRating
			// 
			this.lblRating.AutoSize = true;
			this.lblRating.Font = new System.Drawing.Font("Avenir-Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRating.ForeColor = System.Drawing.Color.White;
			this.lblRating.Location = new System.Drawing.Point(549, 296);
			this.lblRating.Name = "lblRating";
			this.lblRating.Size = new System.Drawing.Size(83, 32);
			this.lblRating.TabIndex = 17;
			this.lblRating.Text = "Rating";
			// 
			// btnPlayerListLogOut
			// 
			this.btnPlayerListLogOut.BackColor = System.Drawing.Color.LightGray;
			this.btnPlayerListLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlayerListLogOut.ForeColor = System.Drawing.Color.White;
			this.btnPlayerListLogOut.Location = new System.Drawing.Point(25, 22);
			this.btnPlayerListLogOut.Name = "btnPlayerListLogOut";
			this.btnPlayerListLogOut.Size = new System.Drawing.Size(35, 35);
			this.btnPlayerListLogOut.TabIndex = 19;
			this.btnPlayerListLogOut.Text = "<";
			this.btnPlayerListLogOut.UseVisualStyleBackColor = false;
			this.btnPlayerListLogOut.Click += new System.EventHandler(this.btnPlayerListLogOut_Click);
			// 
			// lblChangingPosition
			// 
			this.lblChangingPosition.Font = new System.Drawing.Font("Avenir Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblChangingPosition.ForeColor = System.Drawing.Color.White;
			this.lblChangingPosition.Location = new System.Drawing.Point(411, 207);
			this.lblChangingPosition.Name = "lblChangingPosition";
			this.lblChangingPosition.Size = new System.Drawing.Size(535, 64);
			this.lblChangingPosition.TabIndex = 22;
			this.lblChangingPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblPlayerName
			// 
			this.lblPlayerName.AutoSize = true;
			this.lblPlayerName.Font = new System.Drawing.Font("Avenir-Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayerName.ForeColor = System.Drawing.Color.White;
			this.lblPlayerName.Location = new System.Drawing.Point(193, 296);
			this.lblPlayerName.Name = "lblPlayerName";
			this.lblPlayerName.Size = new System.Drawing.Size(151, 32);
			this.lblPlayerName.TabIndex = 16;
			this.lblPlayerName.Text = "Player Name";
			// 
			// radioButton1
			// 
			this.radioButton1.Font = new System.Drawing.Font("Avenir-Book", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton1.ForeColor = System.Drawing.SystemColors.Control;
			this.radioButton1.Location = new System.Drawing.Point(199, 357);
			this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(340, 35);
			this.radioButton1.TabIndex = 23;
			this.radioButton1.TabStop = true;
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Font = new System.Drawing.Font("Avenir-Book", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton2.ForeColor = System.Drawing.SystemColors.Control;
			this.radioButton2.Location = new System.Drawing.Point(198, 408);
			this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(340, 36);
			this.radioButton2.TabIndex = 26;
			this.radioButton2.TabStop = true;
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.Font = new System.Drawing.Font("Avenir-Book", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioButton3.ForeColor = System.Drawing.SystemColors.Control;
			this.radioButton3.Location = new System.Drawing.Point(198, 454);
			this.radioButton3.Margin = new System.Windows.Forms.Padding(2);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(340, 37);
			this.radioButton3.TabIndex = 27;
			this.radioButton3.TabStop = true;
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// lblRating1
			// 
			this.lblRating1.Font = new System.Drawing.Font("Avenir-Book", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRating1.ForeColor = System.Drawing.SystemColors.Control;
			this.lblRating1.Location = new System.Drawing.Point(549, 357);
			this.lblRating1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRating1.Name = "lblRating1";
			this.lblRating1.Size = new System.Drawing.Size(70, 35);
			this.lblRating1.TabIndex = 28;
			// 
			// lblRating2
			// 
			this.lblRating2.Font = new System.Drawing.Font("Avenir-Book", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRating2.ForeColor = System.Drawing.SystemColors.Control;
			this.lblRating2.Location = new System.Drawing.Point(549, 408);
			this.lblRating2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRating2.Name = "lblRating2";
			this.lblRating2.Size = new System.Drawing.Size(70, 37);
			this.lblRating2.TabIndex = 29;
			// 
			// lblRating3
			// 
			this.lblRating3.Font = new System.Drawing.Font("Avenir-Book", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRating3.ForeColor = System.Drawing.SystemColors.Control;
			this.lblRating3.Location = new System.Drawing.Point(549, 454);
			this.lblRating3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblRating3.Name = "lblRating3";
			this.lblRating3.Size = new System.Drawing.Size(70, 37);
			this.lblRating3.TabIndex = 30;
			// 
			// btnPlayerDetails
			// 
			this.btnPlayerDetails.BackColor = System.Drawing.Color.LightGray;
			this.btnPlayerDetails.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnPlayerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPlayerDetails.Font = new System.Drawing.Font("Avenir Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlayerDetails.ForeColor = System.Drawing.Color.White;
			this.btnPlayerDetails.Location = new System.Drawing.Point(194, 549);
			this.btnPlayerDetails.Name = "btnPlayerDetails";
			this.btnPlayerDetails.Size = new System.Drawing.Size(608, 40);
			this.btnPlayerDetails.TabIndex = 31;
			this.btnPlayerDetails.Text = "Player Details";
			this.btnPlayerDetails.UseVisualStyleBackColor = false;
			this.btnPlayerDetails.Click += new System.EventHandler(this.btnPlayerDetails_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(25, 22);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(332, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 32;
			this.pictureBox1.TabStop = false;
			// 
			// lblUsername
			// 
			this.lblUsername.Location = new System.Drawing.Point(740, 22);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(264, 23);
			this.lblUsername.TabIndex = 33;
			this.lblUsername.Text = "label1";
			this.lblUsername.Visible = false;
			// 
			// PlayerList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(1028, 749);
			this.Controls.Add(this.lblUsername);
			this.Controls.Add(this.btnPlayerDetails);
			this.Controls.Add(this.lblRating3);
			this.Controls.Add(this.lblRating2);
			this.Controls.Add(this.lblRating1);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.lblChangingPosition);
			this.Controls.Add(this.btnPlayerListLogOut);
			this.Controls.Add(this.lblRating);
			this.Controls.Add(this.lblPlayerName);
			this.Controls.Add(this.btnAddPlayer);
			this.Controls.Add(this.lblPosition);
			this.Controls.Add(this.pictureBox1);
			this.Name = "PlayerList";
			this.Text = "Player List";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayerList_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayerList_FormClosed);
			this.Load += new System.EventHandler(this.PlayerList_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPosition;
		private System.Windows.Forms.Button btnAddPlayer;
		private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Button btnPlayerListLogOut;
        public System.Windows.Forms.Label lblChangingPosition;
        private System.Windows.Forms.Label lblPlayerName;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton3;
        public System.Windows.Forms.Label lblRating1;
        public System.Windows.Forms.Label lblRating2;
        public System.Windows.Forms.Label lblRating3;
        private System.Windows.Forms.Button btnPlayerDetails;
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Label lblUsername;
	}
}