namespace Hello_World_Application
{
	partial class Form1
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
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblColor = new System.Windows.Forms.Label();
			this.radioBlack = new System.Windows.Forms.RadioButton();
			this.radioBlue = new System.Windows.Forms.RadioButton();
			this.radioRed = new System.Windows.Forms.RadioButton();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(139, 72);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(83, 23);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name:";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(244, 66);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(417, 29);
			this.txtName.TabIndex = 1;
			// 
			// lblColor
			// 
			this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblColor.Location = new System.Drawing.Point(152, 143);
			this.lblColor.Name = "lblColor";
			this.lblColor.Size = new System.Drawing.Size(60, 23);
			this.lblColor.TabIndex = 2;
			this.lblColor.Text = "Color:";
			// 
			// radioBlack
			// 
			this.radioBlack.AutoSize = true;
			this.radioBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioBlack.Location = new System.Drawing.Point(275, 140);
			this.radioBlack.Name = "radioBlack";
			this.radioBlack.Size = new System.Drawing.Size(73, 28);
			this.radioBlack.TabIndex = 3;
			this.radioBlack.TabStop = true;
			this.radioBlack.Text = "Black";
			this.radioBlack.UseVisualStyleBackColor = true;
			// 
			// radioBlue
			// 
			this.radioBlue.AutoSize = true;
			this.radioBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioBlue.ForeColor = System.Drawing.Color.Blue;
			this.radioBlue.Location = new System.Drawing.Point(431, 140);
			this.radioBlue.Name = "radioBlue";
			this.radioBlue.Size = new System.Drawing.Size(66, 28);
			this.radioBlue.TabIndex = 4;
			this.radioBlue.TabStop = true;
			this.radioBlue.Text = "Blue";
			this.radioBlue.UseVisualStyleBackColor = true;
			this.radioBlue.CheckedChanged += new System.EventHandler(this.radioBlue_CheckedChanged);
			// 
			// radioRed
			// 
			this.radioRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioRed.ForeColor = System.Drawing.Color.Red;
			this.radioRed.Location = new System.Drawing.Point(578, 142);
			this.radioRed.Name = "radioRed";
			this.radioRed.Size = new System.Drawing.Size(71, 24);
			this.radioRed.TabIndex = 5;
			this.radioRed.TabStop = true;
			this.radioRed.Text = "Red";
			this.radioRed.UseVisualStyleBackColor = true;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSubmit.Location = new System.Drawing.Point(211, 202);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(174, 48);
			this.btnSubmit.TabIndex = 6;
			this.btnSubmit.Text = "Submit";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.Location = new System.Drawing.Point(446, 202);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(170, 48);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// lblResult
			// 
			this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResult.Location = new System.Drawing.Point(130, 280);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(581, 86);
			this.lblResult.TabIndex = 8;
			this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.radioRed);
			this.Controls.Add(this.radioBlue);
			this.Controls.Add(this.radioBlack);
			this.Controls.Add(this.lblColor);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblName);
			this.Name = "Form1";
			this.Text = "Hello World Application";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblColor;
		private System.Windows.Forms.RadioButton radioBlack;
		private System.Windows.Forms.RadioButton radioBlue;
		private System.Windows.Forms.RadioButton radioRed;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label lblResult;
	}
}

