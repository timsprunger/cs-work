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
	public partial class PlayerDetail : Form
	{
		public int lineNumber = 1;
		public int count = 1;
		public string newString = "";
		public string username = "";
		public string password = "";
		public string goalie = "";
		public string rightDefender = "";
		public string centerDefender = "";
		public string leftDefender = "";
		public string rightMidfielder = "";
		public string centerMidfielder1 = "";
		public string centerMidfielder2 = "";
		public string leftMidfielder = "";
		public string rightForward = "";
		public string centerForward = "";
		public string leftForward = "";

		public void lineChanger(string newText, string fileName, int line_to_edit)
		{
			string[] arrLine = File.ReadAllLines("useraccounts.txt");
			arrLine[line_to_edit - 1] = newText;
			File.WriteAllLines(fileName, arrLine);
		}

		public PlayerDetail()
		{
			InitializeComponent();
			this.BackColor = Color.FromArgb(2, 59, 86);
			btnPlayerDetailBack.BackColor = Color.FromArgb(61, 134, 125);
			playerDetailAddPlayer.BackColor = Color.FromArgb(61, 134, 125);
		}

		private void PlayerDetail_Load(object sender, EventArgs e)
		{}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Hide();
			PlayerList pl2 = new PlayerList();
			pl2.Show();
		}

        private void btnPlayerDetailBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerList pl = new PlayerList();
			pl.lblUsername.Text = lblUsername2.Text;

            //If previous was goalie list page
            if (lblPlayerDetailName.Text == "Kepa Arrizabalaga" || lblPlayerDetailName.Text == "David De Gea" || lblPlayerDetailName.Text == "Ederson Santana de Moraes")
            {
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

            //if previous was right back list page
            if (lblPlayerDetailName.Text == "Kyle Walker" || lblPlayerDetailName.Text == "César Azpilicueta" || lblPlayerDetailName.Text == "Hector Bellerin")
            {
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

            //if previous was center back list page
            if (lblPlayerDetailName.Text == "Virgil van Dijk" || lblPlayerDetailName.Text == "David Luiz" || lblPlayerDetailName.Text == "Vincent Kompany")
            {
                pl.lblChangingPosition.Text = "Center Back";
                //Right Back 1
                pl.radioButton1.Text = "Virgil van Dijk";
                pl.lblRating1.Text = "88";

                //Right Back 2
                pl.radioButton2.Text = "David Luiz";
                pl.lblRating2.Text = "83";

                //Right Back 3
                pl.radioButton3.Text = "Vincent Kompany";
                pl.lblRating3.Text = "85";

                pl.Show();

            }

            //if previous was left back list page
            if (lblPlayerDetailName.Text == "Andrew Robertson" || lblPlayerDetailName.Text == "Marcos Alonso" || lblPlayerDetailName.Text == "Benjamin Mendy")
            {
                pl.lblChangingPosition.Text = "Left Back";
                //Right Back 1
                pl.radioButton1.Text = "Andrew Robertson";
                pl.lblRating1.Text = "83";

                //Right Back 2
                pl.radioButton2.Text = "Marcos Alonso";
                pl.lblRating2.Text = "82";

                //Right Back 3
                pl.radioButton3.Text = "Benjamin Mendy";
                pl.lblRating3.Text = "81";

                pl.Show();

            }

            //if previous was Right mid list page
            if (lblPlayerDetailName.Text == "Bernardo Silva" || lblPlayerDetailName.Text == "Lucas Moura" || lblPlayerDetailName.Text == "Juan Mata")
            {
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

            //if previous was Right Center mid list page
            if (lblPlayerDetailName.Text == "Kevin De Bruyne" || lblPlayerDetailName.Text == "N'Golo Kante" || lblPlayerDetailName.Text == "Paul Pogba")
            {
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

            //if previous was Left Center mid list page
            if (lblPlayerDetailName.Text == "Christian Eriksen" || lblPlayerDetailName.Text == "David Silva" || lblPlayerDetailName.Text == "Mesut Özil")
            {
                pl.lblChangingPosition.Text = "Left Center Mid";
                //RCenter Mid 1
                pl.radioButton1.Text = "Christian Eriksen";
                pl.lblRating1.Text = "88";

                //RCenter Mid 2
                pl.radioButton2.Text = "David Silva";
                pl.lblRating2.Text = "89";

                //RCenter Mid 3
                pl.radioButton3.Text = "Mesut Özil";
                pl.lblRating3.Text = "86";

                pl.Show();

            }

            //if previous was Left mid list page
            if (lblPlayerDetailName.Text == "Son Heung-Min" || lblPlayerDetailName.Text == "Felipe Anderson" || lblPlayerDetailName.Text == "Anthony Martial")
            {
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

            //if previous was Right Wing list page
            if (lblPlayerDetailName.Text == "Raheem Sterling" || lblPlayerDetailName.Text == "Willian Borges da Silva" || lblPlayerDetailName.Text == "Mohamed Salah")
            {
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

            //if previous was Striker list page
            if (lblPlayerDetailName.Text == "Harry Kane" || lblPlayerDetailName.Text == "Sergio Agüero" || lblPlayerDetailName.Text == "Romelu Lukaku")
            {
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

            //if previous was Left Wing list page
            if (lblPlayerDetailName.Text == "Sadio Mané" || lblPlayerDetailName.Text == "Leroy Sane" || lblPlayerDetailName.Text == "Eden Hazard")
            {
                pl.lblChangingPosition.Text = "Left Wing";
                //Left Wing 1
                pl.radioButton1.Text = "Sadio Mané";
                pl.lblRating1.Text = "86";

                //Left Wing 2
                pl.radioButton2.Text = "Leroy Sane";
                pl.lblRating2.Text = "86";

                //Left Wing 3
                pl.radioButton3.Text = "Eden Hazard";
                //pl.lblRating3.Text = "91";

                pl.Show();

            }
        }

        private void PlayerDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void PlayerDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void playerDetailAddPlayer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Team team = new Team();


			StreamReader readUserData = new StreamReader("useraccounts.txt");

			String line;

			while ((line = readUserData.ReadLine()) != null)
			{
				string[] accounts = line.Split(',');

				if (accounts[0].Equals(lblUsername2.Text) == true)
				{
					lineNumber = count;

					username = accounts[0];
					password = accounts[1];
					goalie = accounts[2];
					rightDefender = accounts[3];
					centerDefender = accounts[4];
					leftDefender = accounts[5];
					rightMidfielder = accounts[6];
					centerMidfielder1 = accounts[7];
					centerMidfielder2 = accounts[8];
					leftMidfielder = accounts[9];
					rightForward = accounts[10];
					centerForward = accounts[11];
					leftForward = accounts[12];
				}
				count++;
			}
			readUserData.Close();

			newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
						centerDefender + "," + leftDefender + rightMidfielder + "," +
						centerMidfielder1 + "," + centerMidfielder2 + leftMidfielder + "," +
						rightForward + centerForward + "," + leftForward;

			//Goalies
			if (lblPlayerDetailName.Text == "David De Gea")
            {
				goalie = "Player: David De Gea";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "Kepa Arrizabalaga")
            {
                goalie = "Player: Kepa Arrizabalaga";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}
		
            if (lblPlayerDetailName.Text == "Ederson Santana de Moraes")
            {
                goalie = "Player: Ederson Santana de Moraes";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            //Right Backs
            if (lblPlayerDetailName.Text == "Kyle Walker")
            {
                rightDefender = "Player: Kyle Walker";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "César Azpilicueta")
            {
                rightDefender = "Player: César Azpilicueta";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "Hector Bellerin")
            {
                rightDefender = "Player: Hector Bellerin";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            //Center Backs
            if (lblPlayerDetailName.Text == "Virgil van Dijk")
            {
                centerDefender = "Player: Virgil van Dijk";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "David Luiz")
            {
                centerDefender = "Player: David Luiz";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "Vincent Kompany")
            {
                centerDefender = "Player: Vincent Kompany";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}


			//Left Backs
			if (lblPlayerDetailName.Text == "Andrew Robertson")
			{
				leftDefender = "Player: Andrew Robertson";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "Marcos Alonso")
            {
                leftDefender = "Player: Marcos Alonso";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

			if (lblPlayerDetailName.Text == "Benjamin Mendy")
			{
				leftDefender = "Player: Benjamin Mendy";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            //Right Mid
            if (lblPlayerDetailName.Text == "Bernardo Silva")
            {
				rightMidfielder = "Player: Bernardo Silva";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

			if (lblPlayerDetailName.Text == "Lucas Moura")
			{
				rightMidfielder = "Player: Lucas Moura";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "Juan Mata")
            {
                rightMidfielder = "Player: Juan Mata";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            //Right Center Mid
            if (lblPlayerDetailName.Text == "Kevin De Bruyne")
            {
                centerMidfielder1 = "Player: Kevin De Bruyne";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "N'Golo Kante")
            {
                centerMidfielder1 = "Player: N'Golo Kante";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "Paul Pogba")
			{
				centerMidfielder1 = "Player: Paul Pogba";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            //Left Center Mid
            if (lblPlayerDetailName.Text == "Christian Eriksen")
            {
                centerMidfielder2 = "Player: Christian Eriksen";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "David Silva")
            {
                centerMidfielder2 = "Player: David Silva";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "Mesut Özil")
            {
                centerMidfielder2 = "Player: Mesut Özil";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            //Left Mid
            if (lblPlayerDetailName.Text == "Son Heung-Min")
            {
                leftMidfielder = "Player: Son Heung-Min";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "Felipe Anderson")
            {
                leftMidfielder = "Player: Felipe Anderson";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "Anthony Martial")
            {
                leftMidfielder = "Player: Anthony Martial";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

			//Right Wing
			if (lblPlayerDetailName.Text == "Raheem Sterling")
			{
				rightForward = "Player: Raheem Sterling";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "Mohamed Salah")
            {
                rightForward = "Player: Mohamed Salah";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "Willian Borges da Silva")
            {
                rightForward = "Player: Willian Borges da Silva";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

			//Striker
			if (lblPlayerDetailName.Text == "Harry Kane")
			{
				centerForward = "Player: Harry Kane";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "Sergio Agüero")
            {
				centerForward = "Player: Sergio Agüero";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "Romelu Lukaku")
            {
                centerForward = "Player: Romelu Lukaku";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            //Left Wing
            if (lblPlayerDetailName.Text == "Sadio Mané")
            {
                leftForward = "Player: Sadio Mané";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "Leroy Sane")
            {
				leftForward = "Player: Leroy Sane";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
			centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
			centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
			rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}

            if (lblPlayerDetailName.Text == "Eden Hazard")
            {
				leftForward = "Player: Eden Hazard";

				newString = username + "," + password + "," + goalie + "," + rightDefender + "," +
							centerDefender + "," + leftDefender + "," + rightMidfielder + "," +
							centerMidfielder1 + "," + centerMidfielder2 + "," + leftMidfielder + "," +
							rightForward + "," + centerForward + "," + leftForward;

				lineChanger(newString, "useraccounts.txt", lineNumber);

				team.lblPersonHello.Text = username;
				team.lblGPlayer.Text = goalie;
				team.lblRDPlayer.Text = rightDefender;
				team.lblCDPlayer.Text = centerDefender;
				team.lblLDPlayer.Text = leftDefender;
				team.lblRMPlayer.Text = rightMidfielder;
				team.lblCMPlayer1.Text = centerMidfielder1;
				team.lblCMPlayer2.Text = centerMidfielder2;
				team.lblLMPlayer.Text = leftMidfielder;
				team.lblRFPlayer.Text = rightForward;
				team.lblCFPlayer.Text = centerForward;
				team.lblLFPlayer.Text = leftForward;

				team.Show();
			}
        }
    }
}
