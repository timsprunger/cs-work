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
	public partial class Team : Form
	{
		public void lineChanger(string newText, string fileName, int line_to_edit)
		{
			string[] arrLine = File.ReadAllLines("useraccounts.txt");
			arrLine[line_to_edit - 1] = newText;
			File.WriteAllLines(fileName, arrLine);
		}

		public string username;
		public string password;
		public int lineNumber = 1;
		public int count = 1;
		public string newString = ";";
			

		public Team()
		{
			InitializeComponent();
			this.BackColor = Color.FromArgb(2, 59, 86);
			btnRFClear.BackColor = Color.FromArgb(61, 134, 125);
			btnRFReplace.BackColor = Color.FromArgb(61, 134, 125);
            btnCDClear.BackColor = Color.FromArgb(61, 134, 125);
            btnCDReplace.BackColor = Color.FromArgb(61, 134, 125);
            btnCFClear.BackColor = Color.FromArgb(61, 134, 125);
            btnCFReplace.BackColor = Color.FromArgb(61, 134, 125);
            btnCMCLear1.BackColor = Color.FromArgb(61, 134, 125);
            btnCMClear2.BackColor = Color.FromArgb(61, 134, 125);
            btnCMReplace.BackColor = Color.FromArgb(61, 134, 125);
            btnCMReplace2.BackColor = Color.FromArgb(61, 134, 125);
            btnGClear.BackColor = Color.FromArgb(61, 134, 125);
            btnGReplace.BackColor = Color.FromArgb(61, 134, 125);
            btnLDClear.BackColor = Color.FromArgb(61, 134, 125);
            btnLDReplace.BackColor = Color.FromArgb(61, 134, 125);
            btnLFClear.BackColor = Color.FromArgb(61, 134, 125);
            btnLFReplace.BackColor = Color.FromArgb(61, 134, 125);
            btnLMClear.BackColor = Color.FromArgb(61, 134, 125);
            btnLMReplace.BackColor = Color.FromArgb(61, 134, 125);
            btnRDClear.BackColor = Color.FromArgb(61, 134, 125);
            btnRDReplace.BackColor = Color.FromArgb(61, 134, 125);
            btnRFClear.BackColor = Color.FromArgb(61, 134, 125);
            btnRFReplace.BackColor = Color.FromArgb(61, 134, 125);
            btnRMClear.BackColor = Color.FromArgb(61, 134, 125);
            btnRMReplace.BackColor = Color.FromArgb(61, 134, 125);
            btnTeamBack.BackColor = Color.FromArgb(61, 134, 125);
		}

		public void Team_Load(object sender, EventArgs e)
		{
			StreamReader readUserData = new StreamReader("useraccounts.txt");

			String line;

			while ((line = readUserData.ReadLine()) != null)
			{
				string[] accounts = line.Split(',');

				if (accounts[0].Equals(lblPersonHello.Text) == true)
				{
					username = accounts[0];
					password = accounts[1];
 
					lineNumber = count;
				}
				count++;
			}
			readUserData.Close();
		}

		private void Team_MouseMove(object sender, MouseEventArgs e)
		{}

        private void btnRFClear_Click(object sender, EventArgs e)
        {
            lblRFPlayer.Text = "Player: ";

			newString = username + "," + password + "," + lblGPlayer.Text + "," + lblRDPlayer.Text + "," +
						lblCDPlayer.Text + "," + lblLDPlayer.Text + "," + lblRMPlayer.Text + "," +
						lblCMPlayer1.Text + "," + lblCMPlayer2.Text + "," + lblLMPlayer.Text + "," +
						lblRFPlayer.Text + "," + lblCFPlayer.Text + "," + lblLFPlayer.Text;

			lineChanger(newString, "useraccounts.txt", lineNumber);
		}

		private void btnTeamBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScreen ls = new LoginScreen();
            ls.Show();
        }

        private void lblGoalie_Click(object sender, EventArgs e)
        {}

        private void btnGReplace_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerList pl = new PlayerList();
			pl.lblUsername.Text = lblPersonHello.Text;		
                      
                pl.lblChangingPosition.Text = "Goaltender";

                //Goalie 1
                pl.radioButton1.Text = "Kepa Arrizabalaga";
                pl.lblRating1.Text = "84";

                //Goalie 2
                pl.radioButton2.Text = "David De Gea";
                pl.lblRating2.Text = "91";

                //Goalie 3
                pl.radioButton3.Text = "Ederson Santana de Moraes";
                pl.lblRating3.Text = "86";
                   
            pl.Show();
        }

        private void btnCDReplace_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerList pl = new PlayerList();
			pl.lblUsername.Text = lblPersonHello.Text;


			pl.lblChangingPosition.Text = "Center Back";

            //Center Back 1
            pl.radioButton1.Text = "Virgil van Dijk";
            pl.lblRating1.Text = "88";

            //Center Back 2
            pl.radioButton2.Text = "David Luiz";
            pl.lblRating2.Text = "83";

            //Center Back 3
            pl.radioButton3.Text = "Vincent Kompany";
            pl.lblRating3.Text = "85";

            pl.Show();
        }

        private void btnLFReplace_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerList pl = new PlayerList();
            pl.lblChangingPosition.Text = "Left Wing";
			pl.lblUsername.Text = lblPersonHello.Text;


			//Left Wing 1
			pl.radioButton1.Text = "Sadio Mané";
            pl.lblRating1.Text = "86";

            //Left Wing 2
            pl.radioButton2.Text = "Leroy Sane";
            pl.lblRating2.Text = "86";

            //Left Wing 3
            pl.radioButton3.Text = "Eden Hazard";
            pl.lblRating3.Text = "91";



            pl.Show();
        }

        private void btnLMReplace_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerList pl = new PlayerList();
			pl.lblUsername.Text = lblPersonHello.Text;

			pl.lblChangingPosition.Text = "Left Mid";

            //Left Mid 1
            pl.radioButton1.Text = "Son Heung-Min";
            pl.lblRating1.Text = "85";

            //Left Mid 2
            pl.radioButton2.Text = "Felipe Anderson";
            pl.lblRating2.Text = "84";

            //Left Mid 3
            pl.radioButton3.Text = "Anthony Martial";
            pl.lblRating3.Text = "84";

            pl.Show();
        }

        private void btnLDReplace_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerList pl = new PlayerList();
			pl.lblUsername.Text = lblPersonHello.Text;

			pl.lblChangingPosition.Text = "Left Back";

            //Left Back 1
            pl.radioButton1.Text = "Andrew Robertson";
            pl.lblRating1.Text = "83";

            //Left Back 2
            pl.radioButton2.Text = "Marcos Alonso";
            pl.lblRating2.Text = "82";

            //Left Back 3
            pl.radioButton3.Text = "Benjamin Mendy";
            pl.lblRating3.Text = "81";

            pl.Show();
        }

        private void btnCFReplace_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerList pl = new PlayerList();
			pl.lblUsername.Text = lblPersonHello.Text;

			pl.lblChangingPosition.Text = "Striker";

            //Striker 1
            pl.radioButton1.Text = "Harry Kane";
            pl.lblRating1.Text = "90";

            //Striker 2
            pl.radioButton2.Text = "Sergio Agüero";
            pl.lblRating2.Text = "90";

            //Striker 3
            pl.radioButton3.Text = "Romelu Lukaku";
            pl.lblRating3.Text = "87";

            pl.Show();
        }

        private void btnRFReplace_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerList pl = new PlayerList();
			pl.lblUsername.Text = lblPersonHello.Text;

			pl.lblChangingPosition.Text = "Right Wing";

            //Right Wing 1
            pl.radioButton1.Text = "Raheem Sterling";
            pl.lblRating1.Text = "87";

            //Right Wing 2
            pl.radioButton2.Text = "Mohamed Salah";
            pl.lblRating2.Text = "88";

            //Right Wing 3
            pl.radioButton3.Text = "Willian Borges da Silva";
            pl.lblRating3.Text = "84";



            pl.Show();
        }

        private void btnRMReplace_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerList pl = new PlayerList();
			pl.lblUsername.Text = lblPersonHello.Text;

			pl.lblChangingPosition.Text = "Right Mid";

            //Right Mid 1
            pl.radioButton1.Text = "Bernardo Silva";
            pl.lblRating1.Text = "84";

            //Right Mid 2
            pl.radioButton2.Text = "Lucas Moura";
            pl.lblRating2.Text = "82";

            //Right Mid 3
            pl.radioButton3.Text = "Juan Mata";
            pl.lblRating3.Text = "83";

            pl.Show();
        }

        private void btnRDReplace_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerList pl = new PlayerList();
			pl.lblUsername.Text = lblPersonHello.Text;

			pl.lblChangingPosition.Text = "Right Back";

            //Right Back 1
            pl.radioButton1.Text = "Kyle Walker";
            pl.lblRating1.Text = "84";

            //Right Back 2
            pl.radioButton2.Text = "César Azpilicueta";
            pl.lblRating2.Text = "86";

            //Right Back 3
            pl.radioButton3.Text = "Hector Bellerin";
            pl.lblRating3.Text = "80";

            pl.Show();
        }

        private void btnCMReplace2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerList pl = new PlayerList();
			pl.lblUsername.Text = lblPersonHello.Text;

			pl.lblChangingPosition.Text = "Right Center Mid";

            //RCenter Mid 1
            pl.radioButton1.Text = "Kevin De Bruyne";
            pl.lblRating1.Text = "91";

            //RCenter Mid 2
            pl.radioButton2.Text = "N'Golo Kante";
            pl.lblRating2.Text = "89";

            //RCenter Mid 3
            pl.radioButton3.Text = "Paul Pogba";
            pl.lblRating3.Text = "88";

            pl.Show();
        }

        private void pbRightDefender_Click(object sender, EventArgs e)
        {}

        private void pbCenterDefender_Click(object sender, EventArgs e)
        {}

        private void btnCMReplace_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerList pl = new PlayerList();
			pl.lblUsername.Text = lblPersonHello.Text;

			pl.lblChangingPosition.Text = "Left Center Mid";

            //LCenter Mid 1
            pl.radioButton1.Text = "Christian Eriksen";
            pl.lblRating1.Text = "88";

            //LCenter Mid 2
            pl.radioButton2.Text = "David Silva";
            pl.lblRating2.Text = "89";

            //LCenter Mid 3
            pl.radioButton3.Text = "Mesut Özil";
            pl.lblRating3.Text = "86";

            pl.Show();
        }

        private void Team_FormClosing(object sender, FormClosingEventArgs e)
        {}

        private void Team_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGClear_Click(object sender, EventArgs e)
        {
			lblGPlayer.Text = "Player: ";

			newString = username + "," + password + "," + lblGPlayer.Text + "," + lblRDPlayer.Text + "," +
						lblCDPlayer.Text + "," + lblLDPlayer.Text + "," + lblRMPlayer.Text + "," +
						lblCMPlayer1.Text + "," + lblCMPlayer2.Text + "," + lblLMPlayer.Text + "," +
						lblRFPlayer.Text + "," + lblCFPlayer.Text + "," + lblLFPlayer.Text;

			lineChanger(newString, "useraccounts.txt", lineNumber);
        }

        private void btnRDClear_Click(object sender, EventArgs e)
        {
			lblRDPlayer.Text = "Player: ";

			newString = username + "," + password + "," + lblGPlayer.Text + "," + lblRDPlayer.Text + "," +
						lblCDPlayer.Text + "," + lblLDPlayer.Text + "," + lblRMPlayer.Text + "," +
						lblCMPlayer1.Text + "," + lblCMPlayer2.Text + "," + lblLMPlayer.Text + "," +
						lblRFPlayer.Text + "," + lblCFPlayer.Text + "," + lblLFPlayer.Text;

			lineChanger(newString, "useraccounts.txt", lineNumber);
		}

		private void btnCDClear_Click(object sender, EventArgs e)
        {
            lblCDPlayer.Text = "Player: ";

			newString = username + "," + password + "," + lblGPlayer.Text + "," + lblRDPlayer.Text + "," +
						lblCDPlayer.Text + "," + lblLDPlayer.Text + "," + lblRMPlayer.Text + "," +
						lblCMPlayer1.Text + "," + lblCMPlayer2.Text + "," + lblLMPlayer.Text + "," +
						lblRFPlayer.Text + "," + lblCFPlayer.Text + "," + lblLFPlayer.Text;

			lineChanger(newString, "useraccounts.txt", lineNumber);

		}

		private void btnLDClear_Click(object sender, EventArgs e)
        {
            lblLDPlayer.Text = "Player: ";

			newString = username + "," + password + "," + lblGPlayer.Text + "," + lblRDPlayer.Text + "," +
						lblCDPlayer.Text + "," + lblLDPlayer.Text + "," + lblRMPlayer.Text + "," +
						lblCMPlayer1.Text + "," + lblCMPlayer2.Text + "," + lblLMPlayer.Text + "," +
						lblRFPlayer.Text + "," + lblCFPlayer.Text + "," + lblLFPlayer.Text;

			lineChanger(newString, "useraccounts.txt", lineNumber);
		}

		private void btnRMClear_Click(object sender, EventArgs e)
        {
            lblRMPlayer.Text = "Player: ";

			newString = username + "," + password + "," + lblGPlayer.Text + "," + lblRDPlayer.Text + "," +
						lblCDPlayer.Text + "," + lblLDPlayer.Text + "," + lblRMPlayer.Text + "," +
						lblCMPlayer1.Text + "," + lblCMPlayer2.Text + "," + lblLMPlayer.Text + "," +
						lblRFPlayer.Text + "," + lblCFPlayer.Text + "," + lblLFPlayer.Text;

			lineChanger(newString, "useraccounts.txt", lineNumber);
		}

		private void btnCMCLear1_Click(object sender, EventArgs e)
        {
            lblCMPlayer1.Text = "Player: ";

			newString = username + "," + password + "," + lblGPlayer.Text + "," + lblRDPlayer.Text + "," +
						lblCDPlayer.Text + "," + lblLDPlayer.Text + "," + lblRMPlayer.Text + "," +
						lblCMPlayer1.Text + "," + lblCMPlayer2.Text + "," + lblLMPlayer.Text + "," +
						lblRFPlayer.Text + "," + lblCFPlayer.Text + "," + lblLFPlayer.Text;

			lineChanger(newString, "useraccounts.txt", lineNumber);
		}

		private void btnCMClear2_Click(object sender, EventArgs e)
        {
            lblCMPlayer2.Text = "Player: ";

			newString = username + "," + password + "," + lblGPlayer.Text + "," + lblRDPlayer.Text + "," +
						lblCDPlayer.Text + "," + lblLDPlayer.Text + "," + lblRMPlayer.Text + "," +
						lblCMPlayer1.Text + "," + lblCMPlayer2.Text + "," + lblLMPlayer.Text + "," +
						lblRFPlayer.Text + "," + lblCFPlayer.Text + "," + lblLFPlayer.Text;

			lineChanger(newString, "useraccounts.txt", lineNumber);
		}

		private void btnLMClear_Click(object sender, EventArgs e)
        {
            lblLMPlayer.Text = "Player: ";

			newString = username + "," + password + "," + lblGPlayer.Text + "," + lblRDPlayer.Text + "," +
						lblCDPlayer.Text + "," + lblLDPlayer.Text + "," + lblRMPlayer.Text + "," +
						lblCMPlayer1.Text + "," + lblCMPlayer2.Text + "," + lblLMPlayer.Text + "," +
						lblRFPlayer.Text + "," + lblCFPlayer.Text + "," + lblLFPlayer.Text;

			lineChanger(newString, "useraccounts.txt", lineNumber);
		}

		private void btnCFClear_Click(object sender, EventArgs e)
        {
            lblCFPlayer.Text = "Player: ";

			newString = username + "," + password + "," + lblGPlayer.Text + "," + lblRDPlayer.Text + "," +
						lblCDPlayer.Text + "," + lblLDPlayer.Text + "," + lblRMPlayer.Text + "," +
						lblCMPlayer1.Text + "," + lblCMPlayer2.Text + "," + lblLMPlayer.Text + "," +
						lblRFPlayer.Text + "," + lblCFPlayer.Text + "," + lblLFPlayer.Text;

			lineChanger(newString, "useraccounts.txt", lineNumber);
		}

		private void btnLFClear_Click(object sender, EventArgs e)
        {
            lblLFPlayer.Text = "Player: ";

			newString = username + "," + password + "," + lblGPlayer.Text + "," + lblRDPlayer.Text + "," +
						lblCDPlayer.Text + "," + lblLDPlayer.Text + "," + lblRMPlayer.Text + "," +
						lblCMPlayer1.Text + "," + lblCMPlayer2.Text + "," + lblLMPlayer.Text + "," +
						lblRFPlayer.Text + "," + lblCFPlayer.Text + "," + lblLFPlayer.Text;

			lineChanger(newString, "useraccounts.txt", lineNumber);
		}

		private void btnSaveTeam_Click(object sender, EventArgs e)
		{}

		private void lblSignOut_Click(object sender, EventArgs e)
		{
			this.Hide();
			LoginScreen ls = new LoginScreen();
			ls.Show();
		}
	}
}
