namespace Lab_Assignment_3
{
	partial class GuessingGame
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
			this.lblInstructions = new System.Windows.Forms.Label();
			this.txtNumber = new System.Windows.Forms.TextBox();
			this.btnCheckGuess = new System.Windows.Forms.Button();
			this.btnNewGame = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.lblMessage = new System.Windows.Forms.Label();
			this.lblNumTries = new System.Windows.Forms.Label();
			this.txtNumTries = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblInstructions
			// 
			this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
			this.lblInstructions.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInstructions.ForeColor = System.Drawing.Color.White;
			this.lblInstructions.Location = new System.Drawing.Point(59, 38);
			this.lblInstructions.Name = "lblInstructions";
			this.lblInstructions.Size = new System.Drawing.Size(415, 31);
			this.lblInstructions.TabIndex = 0;
			this.lblInstructions.Text = "Enter a whole number between 1 and 100.";
			// 
			// txtNumber
			// 
			this.txtNumber.BackColor = System.Drawing.Color.Black;
			this.txtNumber.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumber.ForeColor = System.Drawing.Color.White;
			this.txtNumber.Location = new System.Drawing.Point(201, 82);
			this.txtNumber.Name = "txtNumber";
			this.txtNumber.Size = new System.Drawing.Size(125, 34);
			this.txtNumber.TabIndex = 1;
			this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnCheckGuess
			// 
			this.btnCheckGuess.BackColor = System.Drawing.Color.Black;
			this.btnCheckGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCheckGuess.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCheckGuess.ForeColor = System.Drawing.Color.White;
			this.btnCheckGuess.Location = new System.Drawing.Point(532, 38);
			this.btnCheckGuess.Name = "btnCheckGuess";
			this.btnCheckGuess.Size = new System.Drawing.Size(212, 41);
			this.btnCheckGuess.TabIndex = 2;
			this.btnCheckGuess.Text = "Check Guess";
			this.btnCheckGuess.UseVisualStyleBackColor = false;
			this.btnCheckGuess.Click += new System.EventHandler(this.btnCheckGuess_Click);
			// 
			// btnNewGame
			// 
			this.btnNewGame.BackColor = System.Drawing.Color.Black;
			this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewGame.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewGame.ForeColor = System.Drawing.Color.White;
			this.btnNewGame.Location = new System.Drawing.Point(532, 118);
			this.btnNewGame.Name = "btnNewGame";
			this.btnNewGame.Size = new System.Drawing.Size(212, 40);
			this.btnNewGame.TabIndex = 3;
			this.btnNewGame.Text = "New Game";
			this.btnNewGame.UseVisualStyleBackColor = false;
			this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.Color.Black;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.Color.White;
			this.btnExit.Location = new System.Drawing.Point(532, 195);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(212, 39);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// lblMessage
			// 
			this.lblMessage.BackColor = System.Drawing.Color.Transparent;
			this.lblMessage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMessage.ForeColor = System.Drawing.Color.Red;
			this.lblMessage.Location = new System.Drawing.Point(12, 124);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(514, 92);
			this.lblMessage.TabIndex = 5;
			this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumTries
			// 
			this.lblNumTries.BackColor = System.Drawing.Color.Transparent;
			this.lblNumTries.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumTries.ForeColor = System.Drawing.Color.White;
			this.lblNumTries.Location = new System.Drawing.Point(21, 234);
			this.lblNumTries.Name = "lblNumTries";
			this.lblNumTries.Size = new System.Drawing.Size(149, 23);
			this.lblNumTries.TabIndex = 6;
			this.lblNumTries.Text = "Number of Tries:";
			this.lblNumTries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNumTries
			// 
			this.txtNumTries.BackColor = System.Drawing.Color.Black;
			this.txtNumTries.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumTries.ForeColor = System.Drawing.Color.White;
			this.txtNumTries.Location = new System.Drawing.Point(176, 231);
			this.txtNumTries.Name = "txtNumTries";
			this.txtNumTries.ReadOnly = true;
			this.txtNumTries.Size = new System.Drawing.Size(34, 30);
			this.txtNumTries.TabIndex = 7;
			this.txtNumTries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// GuessingGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Lab_Assignment_3.Properties.Resources.dark_wood_texture;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(809, 276);
			this.Controls.Add(this.txtNumTries);
			this.Controls.Add(this.lblNumTries);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnNewGame);
			this.Controls.Add(this.btnCheckGuess);
			this.Controls.Add(this.txtNumber);
			this.Controls.Add(this.lblInstructions);
			this.Name = "GuessingGame";
			this.Text = "Number Guessing Game";
			this.Load += new System.EventHandler(this.GuessingGame_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblInstructions;
		private System.Windows.Forms.TextBox txtNumber;
		private System.Windows.Forms.Button btnCheckGuess;
		private System.Windows.Forms.Button btnNewGame;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.TextBox txtNumTries;
		private System.Windows.Forms.Label lblNumTries;
	}
}

