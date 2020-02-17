namespace TMN_Fantasy_Application
{
	partial class PlayerDetail
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerDetail));
			this.picBoxPlayerDetail = new System.Windows.Forms.PictureBox();
			this.btnPlayerDetailBack = new System.Windows.Forms.Button();
			this.lblPlayerInformation = new System.Windows.Forms.Label();
			this.lblPlayerCountry = new System.Windows.Forms.Label();
			this.lblOverallRating = new System.Windows.Forms.Label();
			this.lblPlayerDetailRating = new System.Windows.Forms.Label();
			this.lblPlayerAssists = new System.Windows.Forms.Label();
			this.lblStats = new System.Windows.Forms.Label();
			this.lblPlayerGoals = new System.Windows.Forms.Label();
			this.lblAssists = new System.Windows.Forms.Label();
			this.lblPlayerDetailName = new System.Windows.Forms.Label();
			this.lblCountry = new System.Windows.Forms.Label();
			this.lblPlayerName = new System.Windows.Forms.Label();
			this.lblGoals = new System.Windows.Forms.Label();
			this.playerDetailAddPlayer = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblUsername2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picBoxPlayerDetail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// picBoxPlayerDetail
			// 
			this.picBoxPlayerDetail.Location = new System.Drawing.Point(91, 219);
			this.picBoxPlayerDetail.Name = "picBoxPlayerDetail";
			this.picBoxPlayerDetail.Size = new System.Drawing.Size(300, 377);
			this.picBoxPlayerDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.picBoxPlayerDetail.TabIndex = 20;
			this.picBoxPlayerDetail.TabStop = false;
			// 
			// btnPlayerDetailBack
			// 
			this.btnPlayerDetailBack.BackColor = System.Drawing.Color.LightGray;
			this.btnPlayerDetailBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnPlayerDetailBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPlayerDetailBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPlayerDetailBack.ForeColor = System.Drawing.Color.White;
			this.btnPlayerDetailBack.Location = new System.Drawing.Point(27, 25);
			this.btnPlayerDetailBack.Name = "btnPlayerDetailBack";
			this.btnPlayerDetailBack.Size = new System.Drawing.Size(35, 35);
			this.btnPlayerDetailBack.TabIndex = 21;
			this.btnPlayerDetailBack.Text = "<";
			this.btnPlayerDetailBack.UseVisualStyleBackColor = false;
			this.btnPlayerDetailBack.Click += new System.EventHandler(this.btnPlayerDetailBack_Click);
			// 
			// lblPlayerInformation
			// 
			this.lblPlayerInformation.AutoSize = true;
			this.lblPlayerInformation.Font = new System.Drawing.Font("Avenir Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayerInformation.ForeColor = System.Drawing.Color.White;
			this.lblPlayerInformation.Location = new System.Drawing.Point(447, 219);
			this.lblPlayerInformation.Name = "lblPlayerInformation";
			this.lblPlayerInformation.Size = new System.Drawing.Size(201, 28);
			this.lblPlayerInformation.TabIndex = 23;
			this.lblPlayerInformation.Text = "Player Information";
			// 
			// lblPlayerCountry
			// 
			this.lblPlayerCountry.AutoSize = true;
			this.lblPlayerCountry.Font = new System.Drawing.Font("Avenir-Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayerCountry.ForeColor = System.Drawing.Color.White;
			this.lblPlayerCountry.Location = new System.Drawing.Point(612, 296);
			this.lblPlayerCountry.Name = "lblPlayerCountry";
			this.lblPlayerCountry.Size = new System.Drawing.Size(113, 21);
			this.lblPlayerCountry.TabIndex = 24;
			this.lblPlayerCountry.Text = "Player Country";
			// 
			// lblOverallRating
			// 
			this.lblOverallRating.AutoSize = true;
			this.lblOverallRating.Font = new System.Drawing.Font("Avenir-Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOverallRating.ForeColor = System.Drawing.Color.White;
			this.lblOverallRating.Location = new System.Drawing.Point(448, 330);
			this.lblOverallRating.Name = "lblOverallRating";
			this.lblOverallRating.Size = new System.Drawing.Size(114, 21);
			this.lblOverallRating.TabIndex = 25;
			this.lblOverallRating.Text = "Overall Rating:";
			// 
			// lblPlayerDetailRating
			// 
			this.lblPlayerDetailRating.AutoSize = true;
			this.lblPlayerDetailRating.Font = new System.Drawing.Font("Avenir-Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayerDetailRating.ForeColor = System.Drawing.Color.White;
			this.lblPlayerDetailRating.Location = new System.Drawing.Point(612, 330);
			this.lblPlayerDetailRating.Name = "lblPlayerDetailRating";
			this.lblPlayerDetailRating.Size = new System.Drawing.Size(55, 21);
			this.lblPlayerDetailRating.TabIndex = 26;
			this.lblPlayerDetailRating.Text = "Rating";
			// 
			// lblPlayerAssists
			// 
			this.lblPlayerAssists.AutoSize = true;
			this.lblPlayerAssists.Font = new System.Drawing.Font("Avenir-Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayerAssists.ForeColor = System.Drawing.Color.White;
			this.lblPlayerAssists.Location = new System.Drawing.Point(612, 472);
			this.lblPlayerAssists.Name = "lblPlayerAssists";
			this.lblPlayerAssists.Size = new System.Drawing.Size(143, 21);
			this.lblPlayerAssists.TabIndex = 27;
			this.lblPlayerAssists.Text = "Number Of Assists";
			// 
			// lblStats
			// 
			this.lblStats.AutoSize = true;
			this.lblStats.Font = new System.Drawing.Font("Avenir Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStats.ForeColor = System.Drawing.Color.White;
			this.lblStats.Location = new System.Drawing.Point(447, 394);
			this.lblStats.Name = "lblStats";
			this.lblStats.Size = new System.Drawing.Size(241, 28);
			this.lblStats.TabIndex = 28;
			this.lblStats.Text = "Previous Season Stats";
			// 
			// lblPlayerGoals
			// 
			this.lblPlayerGoals.AutoSize = true;
			this.lblPlayerGoals.Font = new System.Drawing.Font("Avenir-Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayerGoals.ForeColor = System.Drawing.Color.White;
			this.lblPlayerGoals.Location = new System.Drawing.Point(612, 438);
			this.lblPlayerGoals.Name = "lblPlayerGoals";
			this.lblPlayerGoals.Size = new System.Drawing.Size(131, 21);
			this.lblPlayerGoals.TabIndex = 29;
			this.lblPlayerGoals.Text = "Number of Goals";
			// 
			// lblAssists
			// 
			this.lblAssists.AutoSize = true;
			this.lblAssists.Font = new System.Drawing.Font("Avenir-Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAssists.ForeColor = System.Drawing.Color.White;
			this.lblAssists.Location = new System.Drawing.Point(448, 472);
			this.lblAssists.Name = "lblAssists";
			this.lblAssists.Size = new System.Drawing.Size(62, 21);
			this.lblAssists.TabIndex = 30;
			this.lblAssists.Text = "Assists:";
			// 
			// lblPlayerDetailName
			// 
			this.lblPlayerDetailName.AutoSize = true;
			this.lblPlayerDetailName.Font = new System.Drawing.Font("Avenir-Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayerDetailName.ForeColor = System.Drawing.Color.White;
			this.lblPlayerDetailName.Location = new System.Drawing.Point(612, 262);
			this.lblPlayerDetailName.Name = "lblPlayerDetailName";
			this.lblPlayerDetailName.Size = new System.Drawing.Size(53, 21);
			this.lblPlayerDetailName.TabIndex = 31;
			this.lblPlayerDetailName.Text = "Name";
			// 
			// lblCountry
			// 
			this.lblCountry.AutoSize = true;
			this.lblCountry.Font = new System.Drawing.Font("Avenir-Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCountry.ForeColor = System.Drawing.Color.White;
			this.lblCountry.Location = new System.Drawing.Point(448, 296);
			this.lblCountry.Name = "lblCountry";
			this.lblCountry.Size = new System.Drawing.Size(70, 21);
			this.lblCountry.TabIndex = 32;
			this.lblCountry.Text = "Country:";
			// 
			// lblPlayerName
			// 
			this.lblPlayerName.AutoSize = true;
			this.lblPlayerName.Font = new System.Drawing.Font("Avenir-Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayerName.ForeColor = System.Drawing.Color.White;
			this.lblPlayerName.Location = new System.Drawing.Point(448, 262);
			this.lblPlayerName.Name = "lblPlayerName";
			this.lblPlayerName.Size = new System.Drawing.Size(104, 21);
			this.lblPlayerName.TabIndex = 33;
			this.lblPlayerName.Text = "Player Name:";
			// 
			// lblGoals
			// 
			this.lblGoals.AutoSize = true;
			this.lblGoals.Font = new System.Drawing.Font("Avenir-Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGoals.ForeColor = System.Drawing.Color.White;
			this.lblGoals.Location = new System.Drawing.Point(448, 438);
			this.lblGoals.Name = "lblGoals";
			this.lblGoals.Size = new System.Drawing.Size(54, 21);
			this.lblGoals.TabIndex = 34;
			this.lblGoals.Text = "Goals:";
			// 
			// playerDetailAddPlayer
			// 
			this.playerDetailAddPlayer.BackColor = System.Drawing.Color.LightGray;
			this.playerDetailAddPlayer.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.playerDetailAddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.playerDetailAddPlayer.Font = new System.Drawing.Font("Avenir Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playerDetailAddPlayer.ForeColor = System.Drawing.Color.White;
			this.playerDetailAddPlayer.Location = new System.Drawing.Point(452, 556);
			this.playerDetailAddPlayer.Name = "playerDetailAddPlayer";
			this.playerDetailAddPlayer.Size = new System.Drawing.Size(509, 40);
			this.playerDetailAddPlayer.TabIndex = 35;
			this.playerDetailAddPlayer.Text = "Add Player";
			this.playerDetailAddPlayer.UseVisualStyleBackColor = false;
			this.playerDetailAddPlayer.Click += new System.EventHandler(this.playerDetailAddPlayer_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(27, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(332, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 36;
			this.pictureBox1.TabStop = false;
			// 
			// lblUsername2
			// 
			this.lblUsername2.Location = new System.Drawing.Point(724, 37);
			this.lblUsername2.Name = "lblUsername2";
			this.lblUsername2.Size = new System.Drawing.Size(280, 23);
			this.lblUsername2.TabIndex = 38;
			this.lblUsername2.Visible = false;
			// 
			// PlayerDetail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(1028, 749);
			this.Controls.Add(this.lblUsername2);
			this.Controls.Add(this.playerDetailAddPlayer);
			this.Controls.Add(this.lblGoals);
			this.Controls.Add(this.lblPlayerName);
			this.Controls.Add(this.lblCountry);
			this.Controls.Add(this.lblPlayerDetailName);
			this.Controls.Add(this.lblAssists);
			this.Controls.Add(this.lblPlayerGoals);
			this.Controls.Add(this.lblStats);
			this.Controls.Add(this.lblPlayerAssists);
			this.Controls.Add(this.lblPlayerDetailRating);
			this.Controls.Add(this.lblOverallRating);
			this.Controls.Add(this.lblPlayerCountry);
			this.Controls.Add(this.lblPlayerInformation);
			this.Controls.Add(this.btnPlayerDetailBack);
			this.Controls.Add(this.picBoxPlayerDetail);
			this.Controls.Add(this.pictureBox1);
			this.Name = "PlayerDetail";
			this.Text = "PlayerDetail";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayerDetail_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayerDetail_FormClosed);
			this.Load += new System.EventHandler(this.PlayerDetail_Load);
			((System.ComponentModel.ISupportInitialize)(this.picBoxPlayerDetail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
        public System.Windows.Forms.PictureBox picBoxPlayerDetail;
        public System.Windows.Forms.Button btnPlayerDetailBack;
        public System.Windows.Forms.Label lblPlayerInformation;
        public System.Windows.Forms.Label lblPlayerCountry;
        public System.Windows.Forms.Label lblOverallRating;
        public System.Windows.Forms.Label lblPlayerDetailRating;
        public System.Windows.Forms.Label lblPlayerAssists;
        public System.Windows.Forms.Label lblStats;
        public System.Windows.Forms.Label lblPlayerGoals;
        public System.Windows.Forms.Label lblAssists;
        public System.Windows.Forms.Label lblPlayerDetailName;
        public System.Windows.Forms.Label lblCountry;
        public System.Windows.Forms.Label lblPlayerName;
        public System.Windows.Forms.Label lblGoals;
        public System.Windows.Forms.Button playerDetailAddPlayer;
		private System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Label lblUsername2;
	}
}