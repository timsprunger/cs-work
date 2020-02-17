using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TMN_Fantasy_Application
{
	public partial class NewAccount : Form
	{
		public NewAccount()
		{
			InitializeComponent();
			lblTMN.ForeColor = Color.FromArgb(255, 145, 70);
			lblFantasy.ForeColor = Color.FromArgb(61, 134, 125);
			this.BackColor = Color.FromArgb(2, 59, 86);
			txtUsername2.BackColor = Color.FromArgb(2, 59, 86);
			txtPassword3.BackColor = Color.FromArgb(2, 59, 86);
			txtPassword3Check.BackColor = Color.FromArgb(2, 59, 86);
			btnCreateAccount.BackColor = Color.FromArgb(61, 134, 125);
            btnNewAcountBack.BackColor = Color.FromArgb(61, 134, 125);

        }

		private void NewAccount_Load(object sender, EventArgs e)
		{

		}

		private void btnCreateAccount_Click(object sender, EventArgs e)
		{
			txtUsername2.Text.TrimStart();
			txtUsername2.Text.TrimEnd();

			txtPassword3.Text.TrimStart();
			txtPassword3.Text.TrimEnd();

			txtPassword3Check.Text.TrimStart();
			txtPassword3Check.Text.TrimEnd();


			if (txtUsername2.Text.Length == 0)
			{
				MessageBox.Show("Please Enter a Username.");
				txtUsername2.Focus();
				txtUsername2.SelectAll();
				return;
			}

			if (txtPassword3.Text.Length == 0)
			{
				MessageBox.Show("Please Enter a Password.");
				txtPassword3.Focus();
				txtPassword3.SelectAll();
				return;
			}

			if (txtPassword3Check.Text.Length == 0)
			{
				MessageBox.Show("Please Re-Enter Your Password.");
				txtPassword3Check.Focus();
				txtPassword3Check.SelectAll();
				return;
			}

			//ensure username is not already taken.
			StreamReader readData = new StreamReader("useraccounts.txt");

			String line;

			while ((line = readData.ReadLine()) != null)
			{
				string[] accounts = line.Split(',');

				if (txtUsername2.Text == accounts[0])
				{
					MessageBox.Show("Username " + txtUsername2.Text + " already in use. Please try another username");
					txtUsername2.Focus();
					txtUsername2.SelectAll();
				}
			}
			readData.Close();
			// ***** //

			if (txtPassword3.Text != txtPassword3Check.Text)
			{
				MessageBox.Show("Passwords Do Not Match. Please Try Again.");
				txtPassword3.Focus();
				txtPassword3.SelectAll();
				return;
			}

			//write data to user accounts file
			StreamWriter writeUsers = new StreamWriter("useraccounts.txt", true);

			writeUsers.WriteLine(txtUsername2.Text + "," + txtPassword3.Text + "," + "Player: ," + "Player: ," + "Player: ," + "Player: ," + "Player: ," + "Player: ," + "Player: ," + "Player: ," + "Player: ," + "Player: ," + "Player: ");
			writeUsers.Close();

			// *************************************** //


			this.Hide();
			Team t = new Team();
			t.lblPersonHello.Text = txtUsername2.Text;
			t.Show();
			// ***** //
		}
	
        private void NewAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

		private void btnNewAcountBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			LoginScreen newLogin = new LoginScreen();
			newLogin.ShowDialog();
		}
	}
}
