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
	public partial class LoginScreen : Form
	{
		public string username = "";

		public LoginScreen()
		{
			InitializeComponent();
			lblTMN.ForeColor = Color.FromArgb(255, 145, 70);
			lblFantasy.ForeColor = Color.FromArgb(61, 134, 125);
			this.BackColor = Color.FromArgb(2, 59, 86);
			txtUsername1.BackColor = Color.FromArgb(2, 59, 86);
			txtPassword1.BackColor = Color.FromArgb(2, 59, 86);
			btnLogIn.BackColor = Color.FromArgb(61, 134, 125);
			btnHelp.BackColor = Color.FromArgb(61, 134, 125);
			btnAbout.BackColor = Color.FromArgb(61, 134, 125);

		}

		private void LoginScreen_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblNoAccount_Click(object sender, EventArgs e)
		{
			this.Hide();
			NewAccount na = new NewAccount();
			na.Show();
		}

		private void txtUsername1_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblSignIn_Click(object sender, EventArgs e)
		{

		}

		private void btnLogIn_Click(object sender, EventArgs e)
		{
			bool checkAccountUsername = false;
			bool checkAccountPassword = false;


			if (txtUsername1.Text.Length == 0)
			{
				MessageBox.Show("Please Enter a Username.");
				txtUsername1.Focus();
				txtUsername1.SelectAll();
			}

			if (txtPassword1.Text.Length == 0)
			{
				MessageBox.Show("Please Enter a Password.");
				txtPassword1.Focus();
				txtPassword1.SelectAll();
			}


			StreamReader readUserAccounts = new StreamReader("useraccounts.txt");

			String line;

			while ((line = readUserAccounts.ReadLine()) != null)
			{
				string[] accounts = line.Split(',');

				if (txtUsername1.Text == accounts[0])
				{
					if (txtPassword1.Text == accounts[1])
					{
						checkAccountUsername = true;
						checkAccountPassword = true;
						username = txtUsername1.Text;
						break;
					}
					else if (txtPassword1.Text != accounts[1])
					{
						MessageBox.Show("Incorrect Password. Please Try Again.");
						txtPassword1.Focus();
						txtPassword1.SelectAll();
						return;
					}
				}
			}
			readUserAccounts.Close();

			if (checkAccountUsername == false)
			{
				MessageBox.Show("Username not found. Please try again.");
				txtUsername1.SelectAll();
				txtUsername1.Focus();
				return;
			}

			if ((checkAccountUsername == true) && (checkAccountPassword == true))
			{
				this.Hide();
				Team newTeamForm = new Team();

				//read user data
				StreamReader readUserAccounts2 = new StreamReader("useraccounts.txt");

				String line2;
				while ((line2 = readUserAccounts2.ReadLine()) != null)
				{
					string[] accounts = line2.Split(',');

					if (accounts[0] == txtUsername1.Text)
					{
						//goalie
						newTeamForm.lblGPlayer.Text = accounts[2];

						//right defender
						newTeamForm.lblRDPlayer.Text = accounts[3];

						//center defender
						newTeamForm.lblCDPlayer.Text = accounts[4];

						//left defender
						newTeamForm.lblLDPlayer.Text = accounts[5];

						//right midfield
						newTeamForm.lblRMPlayer.Text = accounts[6];

						//center midfield 1
						newTeamForm.lblCMPlayer1.Text = accounts[7];

						//center midfield 2
						newTeamForm.lblCMPlayer2.Text = accounts[8];

						//left midfield
						newTeamForm.lblLMPlayer.Text = accounts[9];

						//right forward
						newTeamForm.lblRFPlayer.Text = accounts[10];

						//center forward
						newTeamForm.lblCFPlayer.Text = accounts[11];

						//left forward
						newTeamForm.lblLFPlayer.Text = accounts[12];

						newTeamForm.lblPersonHello.Text = txtUsername1.Text;
					}
				}	
				readUserAccounts2.Close();

				username = txtUsername1.Text;
				newTeamForm.Show();
			}
		}

        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

		private void btnHelp_Click(object sender, EventArgs e)
		{
			this.Hide();
			Help help = new Help();
			help.Show();
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			this.Hide();
			About aboutForm = new About();
			aboutForm.Show();
		}
	}
}
