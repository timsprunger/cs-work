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
	public partial class PlayerList : Form
	{
		public int lineNumber = 1;
		public int count = 1;
		public string newString = "";
		public string username = "";
		public string password = "";
		//public string lineData = "";

		public string goalie;
		public string rightDefender;
		public string centerDefender;
		public string leftDefender;
		public string rightMidfielder;
		public string centerMidfielder1;
		public string centerMidfielder2;
		public string leftMidfielder;
		public string rightForward;
		public string centerForward;
		public string leftForward;


		public void lineChanger(string newText, string fileName, int line_to_edit)
		{
			string[] arrLine = File.ReadAllLines("useraccounts.txt");
			arrLine[line_to_edit-1] = newText;
			File.WriteAllLines(fileName, arrLine);
		}

		public PlayerList()
		{
			InitializeComponent();
			btnAddPlayer.BackColor = Color.FromArgb(61, 134, 125);
			this.BackColor = Color.FromArgb(2, 59, 86);
            btnPlayerListLogOut.BackColor = Color.FromArgb(61, 134, 125);
			btnPlayerDetails.BackColor = Color.FromArgb(61, 134, 125);
		}

		private void PlayerList_Load(object sender, EventArgs e)
		{

		}

		private void btnAddPlayer_Click(object sender, EventArgs e)
		{
			this.Hide();
			Team team = new Team();
			

			StreamReader readUserData = new StreamReader("useraccounts.txt");

			String line;

			while ((line = readUserData.ReadLine()) != null)
			{
				string[] accounts = line.Split(',');
				
				if (accounts[0].Equals(lblUsername.Text) == true)
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


			if (lblChangingPosition.Text == "Goaltender")
			{
				if (radioButton1.Checked == true)
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
			
				if (radioButton2.Checked == true)
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

                if (radioButton3.Checked == true)
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
            }

            if (lblChangingPosition.Text == "Right Back")
            {
                if (radioButton1.Checked == true)
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

                if (radioButton2.Checked == true)
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

                if (radioButton3.Checked == true)
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
            }

            if (lblChangingPosition.Text == "Center Back")
            {
                if (radioButton1.Checked == true)
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

                if (radioButton2.Checked == true)
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

                if (radioButton3.Checked == true)
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
            }

            if (lblChangingPosition.Text == "Left Back")
            {
                if (radioButton1.Checked == true)
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

                if (radioButton2.Checked == true)
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

                if (radioButton3.Checked == true)
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
            }

            if (lblChangingPosition.Text == "Right Mid")
            {
                if (radioButton1.Checked == true)
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

                if (radioButton2.Checked == true)
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

                if (radioButton3.Checked == true)
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
            }

            if (lblChangingPosition.Text == "Right Center Mid")
            {
                if (radioButton1.Checked == true)
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

                if (radioButton2.Checked == true)
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

                if (radioButton3.Checked == true)
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
            }

            if (lblChangingPosition.Text == "Left Center Mid")
            {
                if (radioButton1.Checked == true)
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

                if (radioButton2.Checked == true)
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

                if (radioButton3.Checked == true)
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
            }

            if (lblChangingPosition.Text == "Left Mid")
            {
                if (radioButton1.Checked == true)
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

                if (radioButton2.Checked == true)
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

                if (radioButton3.Checked == true)
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
            }

            if (lblChangingPosition.Text == "Right Wing")
            {
                if (radioButton1.Checked == true)
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

                if (radioButton2.Checked == true)
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

                if (radioButton3.Checked == true)
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
            }

            if (lblChangingPosition.Text == "Left Wing")
            {
                if (radioButton1.Checked == true)
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

                if (radioButton2.Checked == true)
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

                if (radioButton3.Checked == true)
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

            if (lblChangingPosition.Text == "Striker")
            {
                if (radioButton1.Checked == true)
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

                if (radioButton2.Checked == true)
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

                if (radioButton3.Checked == true)
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
            }

            team.Show();
		}

        private void btnPlayerListLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Team team = new Team();
			team.lblPersonHello.Text = lblUsername.Text;

			StreamReader readUserAccounts3 = new StreamReader("useraccounts.txt");

			String line2;
			while ((line2 = readUserAccounts3.ReadLine()) != null)
			{
				string[] accounts = line2.Split(',');

				if ( accounts[0].Equals(lblUsername.Text) == true )
				{
					//goalie
					team.lblGPlayer.Text = accounts[2];

					//right defender
					team.lblRDPlayer.Text = accounts[3];

					//center defender
					team.lblCDPlayer.Text = accounts[4];

					//left defender
					team.lblLDPlayer.Text = accounts[5];

					//right midfield
					team.lblRMPlayer.Text = accounts[6];

					//center midfield 1
					team.lblCMPlayer1.Text = accounts[7];

					//center midfield 2
					team.lblCMPlayer2.Text = accounts[8];

					//left midfield
					team.lblLMPlayer.Text = accounts[9];

					//right forward
					team.lblRFPlayer.Text = accounts[10];

					//center forward
					team.lblCFPlayer.Text = accounts[11];

					//left forward
					team.lblLFPlayer.Text = accounts[12];

					team.lblPersonHello.Text = lblUsername.Text;
				}
			}
			readUserAccounts3.Close();
			team.Show();
        }

        private void lvPlayerList_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void btnPlayerDetails_Click(object sender, EventArgs e)
        {
            
            PlayerDetail pd = new PlayerDetail();
			pd.lblUsername2 = lblUsername;

            //if no  radio buttons are selected
            if (radioButton1.Checked != true && radioButton2.Checked != true && radioButton3.Checked != true)
            {
                MessageBox.Show("Please select a player to see their details.");
            }
            else
            {
                this.Hide();

                //Goalie Player Details
                if (lblChangingPosition.Text == "Goaltender")
                {
                    //Swap Stat trackers for goalies
                    pd.lblGoals.Text = "Clean Sheets: ";
                    pd.lblAssists.Text = "Goals Allowed: ";

                    //goalie1
                    if (radioButton1.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Kepa Arrizabalaga";
                        pd.lblPlayerDetailRating.Text = "84";
                        pd.lblPlayerCountry.Text = "Spain";

                        pd.lblPlayerGoals.Text = "13";
                        pd.lblPlayerAssists.Text = "39";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("goalie1.jpg");
                    }

                    //goalie2
                    if (radioButton2.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "David De Gea";
                        pd.lblPlayerDetailRating.Text = "91";
                        pd.lblPlayerCountry.Text = "Spain";

                        pd.lblPlayerGoals.Text = "18";
                        pd.lblPlayerAssists.Text = "28";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("goalie2.jpg");
                    }

                    //goalie3
                    if (radioButton3.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Ederson Santana de Moraes";
                        pd.lblPlayerDetailRating.Text = "86";
                        pd.lblPlayerCountry.Text = "Brazil";

                        pd.lblPlayerGoals.Text = "16";
                        pd.lblPlayerAssists.Text = "26";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("goalie3.jpg");
                    }

                }

                //Right Back Player Details
                if (lblChangingPosition.Text == "Right Back")
                {
                    //Right Back 1
                    if (radioButton1.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Kyle Walker";
                        pd.lblPlayerDetailRating.Text = "84";
                        pd.lblPlayerCountry.Text = "England";

                        pd.lblPlayerGoals.Text = "0";
                        pd.lblPlayerAssists.Text = "6";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("rightback1.jpg");
                    }

                    //Right Back 2
                    if (radioButton2.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "César Azpilicueta";
                        pd.lblPlayerDetailRating.Text = "84";
                        pd.lblPlayerCountry.Text = "Spain";

                        pd.lblPlayerGoals.Text = "2";
                        pd.lblPlayerAssists.Text = "6";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("rightback2.jpg");
                    }

                    //Right Back 3
                    if (radioButton3.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Hector Bellerin";
                        pd.lblPlayerDetailRating.Text = "80";
                        pd.lblPlayerCountry.Text = "Spain";

                        pd.lblPlayerGoals.Text = "2";
                        pd.lblPlayerAssists.Text = "3";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("rightback3.jpg");
                    }
                }

                //Center Back Player Details
                if (lblChangingPosition.Text == "Center Back")
                {
                    //Center Back 1
                    if (radioButton1.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Virgil van Dijk";
                        pd.lblPlayerDetailRating.Text = "88";
                        pd.lblPlayerCountry.Text = "Holland";

                        pd.lblPlayerGoals.Text = "4";
                        pd.lblPlayerAssists.Text = "2";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("centerback1.jpg");
                    }

                    //Center Back 2
                    if (radioButton2.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "David Luiz";
                        pd.lblPlayerDetailRating.Text = "83";
                        pd.lblPlayerCountry.Text = "Brazil";

                        pd.lblPlayerGoals.Text = "1";
                        pd.lblPlayerAssists.Text = "0";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("centerback2.jpg");
                    }

                    //Center Back 3
                    if (radioButton3.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Vincent Kompany";
                        pd.lblPlayerDetailRating.Text = "85";
                        pd.lblPlayerCountry.Text = "Belgium";

                        pd.lblPlayerGoals.Text = "1";
                        pd.lblPlayerAssists.Text = "1";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("centerback3.jpg");
                    }
                }

                //Left Back Player Details
                if (lblChangingPosition.Text == "Left Back")
                {
                    //Left Back 1
                    if (radioButton1.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Andrew Robertson";
                        pd.lblPlayerDetailRating.Text = "83";
                        pd.lblPlayerCountry.Text = "Scotland";

                        pd.lblPlayerGoals.Text = "1";
                        pd.lblPlayerAssists.Text = "5";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("leftback1.jpg");
                    }

                    //Left Back 2
                    if (radioButton2.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Marcos Alonso";
                        pd.lblPlayerDetailRating.Text = "82";
                        pd.lblPlayerCountry.Text = "Spain";

                        pd.lblPlayerGoals.Text = "7";
                        pd.lblPlayerAssists.Text = "2";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("leftback2.jpg");
                    }

                    //Left Back 3
                    if (radioButton3.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Benjamin Mendy";
                        pd.lblPlayerDetailRating.Text = "80";
                        pd.lblPlayerCountry.Text = "France";

                        pd.lblPlayerGoals.Text = "0";
                        pd.lblPlayerAssists.Text = "1";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("leftback3.jpg");
                    }
                }

                //Right Mid Player Details
                if (lblChangingPosition.Text == "Right Mid")
                {
                    //Right Mid 1
                    if (radioButton1.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Bernardo Silva";
                        pd.lblPlayerDetailRating.Text = "84";
                        pd.lblPlayerCountry.Text = "Portugal";

                        pd.lblPlayerGoals.Text = "6";
                        pd.lblPlayerAssists.Text = "4";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("rightmid1.jpg");
                    }

                    //Right Mid 2
                    if (radioButton2.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Lucas Moura";
                        pd.lblPlayerDetailRating.Text = "82";
                        pd.lblPlayerCountry.Text = "Brazil";

                        pd.lblPlayerGoals.Text = "10";
                        pd.lblPlayerAssists.Text = "0";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("rightmid2.jpg");
                    }

                    //Right Mid 3
                    if (radioButton3.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Juan Mata";
                        pd.lblPlayerDetailRating.Text = "83";
                        pd.lblPlayerCountry.Text = "Spain";

                        pd.lblPlayerGoals.Text = "3";
                        pd.lblPlayerAssists.Text = "5";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("rightmid3.jpg");
                    }
                }

                //RCenter Mid Player Details
                if (lblChangingPosition.Text == "Right Center Mid")
                {
                    //RCenter Mid 1
                    if (radioButton1.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Kevin De Bruyne";
                        pd.lblPlayerDetailRating.Text = "91";
                        pd.lblPlayerCountry.Text = "Belgium";

                        pd.lblPlayerGoals.Text = "8";
                        pd.lblPlayerAssists.Text = "16";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("centermid1.jpg");
                    }

                    //RCenter Mid 2
                    if (radioButton2.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "N'Golo Kante";
                        pd.lblPlayerDetailRating.Text = "89";
                        pd.lblPlayerCountry.Text = "France";

                        pd.lblPlayerGoals.Text = "1";
                        pd.lblPlayerAssists.Text = "1";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("centermid2.jpg");
                    }

                    //RCenter Mid 3
                    if (radioButton3.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Paul Pogba";
                        pd.lblPlayerDetailRating.Text = "88";
                        pd.lblPlayerCountry.Text = "France";

                        pd.lblPlayerGoals.Text = "6";
                        pd.lblPlayerAssists.Text = "10";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("centermid3.jpg");
                    }
                }

                //LCenter Mid Player Details
                if (lblChangingPosition.Text == "Left Center Mid")
                {
                    //LCenter Mid 1
                    if (radioButton1.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Christian Eriksen";
                        pd.lblPlayerDetailRating.Text = "88";
                        pd.lblPlayerCountry.Text = "Denmark";

                        pd.lblPlayerGoals.Text = "10";
                        pd.lblPlayerAssists.Text = "10";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("centermid4.jpg");
                    }

                    //LCenter Mid 2
                    if (radioButton2.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "David Silva";
                        pd.lblPlayerDetailRating.Text = "89";
                        pd.lblPlayerCountry.Text = "Spain";

                        pd.lblPlayerGoals.Text = "9";
                        pd.lblPlayerAssists.Text = "11";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("centermid5.jpg");
                    }

                    //LCenter Mid 3
                    if (radioButton3.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Mesut Özil";
                        pd.lblPlayerDetailRating.Text = "86";
                        pd.lblPlayerCountry.Text = "Germany";

                        pd.lblPlayerGoals.Text = "4";
                        pd.lblPlayerAssists.Text = "8";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("centermid6.jpg");
                    }
                }

                //Left Mid Player Details
                if (lblChangingPosition.Text == "Left Mid")
                {
                    //Left Mid 1
                    if (radioButton1.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Son Heung-Min";
                        pd.lblPlayerDetailRating.Text = "85";
                        pd.lblPlayerCountry.Text = "South Korea";

                        pd.lblPlayerGoals.Text = "12";
                        pd.lblPlayerAssists.Text = "6";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("leftmid1.jpg");
                    }

                    //Left Mid 2
                    if (radioButton2.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Felipe Anderson";
                        pd.lblPlayerDetailRating.Text = "84";
                        pd.lblPlayerCountry.Text = "Brazil";

                        pd.lblPlayerGoals.Text = "9";
                        pd.lblPlayerAssists.Text = "4";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("leftmid2.jpg");
                    }

                    //Left Mid 3
                    if (radioButton3.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Anthony Martial";
                        pd.lblPlayerDetailRating.Text = "84";
                        pd.lblPlayerCountry.Text = "France";

                        pd.lblPlayerGoals.Text = "9";
                        pd.lblPlayerAssists.Text = "5";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("leftmid3.jpg");
                    }
                }

                //Right Wing Player Details
                if (lblChangingPosition.Text == "Right Wing")
                {
                    //Right Wing 1
                    if (radioButton1.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Raheem Sterling";
                        pd.lblPlayerDetailRating.Text = "87";
                        pd.lblPlayerCountry.Text = "England";

                        pd.lblPlayerGoals.Text = "18";
                        pd.lblPlayerAssists.Text = "11";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("rightwing1.jpg");
                    }

                    //Right Wing 2
                    if (radioButton2.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Mohamed Salah";
                        pd.lblPlayerDetailRating.Text = "88";
                        pd.lblPlayerCountry.Text = "Egypt";

                        pd.lblPlayerGoals.Text = "32";
                        pd.lblPlayerAssists.Text = "10";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("rightwing2.jpg");
                    }

                    //Right Wing 3
                    if (radioButton3.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Willian Borges da Silva";
                        pd.lblPlayerDetailRating.Text = "84";
                        pd.lblPlayerCountry.Text = "Brazil";

                        pd.lblPlayerGoals.Text = "6";
                        pd.lblPlayerAssists.Text = "7";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("rightwing3.jpg");
                    }
                }

                //Striker Player Details
                if (lblChangingPosition.Text == "Striker")
                {
                    //Striker 1
                    if (radioButton1.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Harry Kane";
                        pd.lblPlayerDetailRating.Text = "90";
                        pd.lblPlayerCountry.Text = "England";

                        pd.lblPlayerGoals.Text = "30";
                        pd.lblPlayerAssists.Text = "2";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("striker1.jpg");
                    }

                    //Striker 2
                    if (radioButton2.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Sergio Agüero";
                        pd.lblPlayerDetailRating.Text = "90";
                        pd.lblPlayerCountry.Text = "Argentina";

                        pd.lblPlayerGoals.Text = "21";
                        pd.lblPlayerAssists.Text = "6";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("striker2.jpg");
                    }

                    //Striker 3
                    if (radioButton3.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Romelu Lukaku";
                        pd.lblPlayerDetailRating.Text = "87";
                        pd.lblPlayerCountry.Text = "Belgium";

                        pd.lblPlayerGoals.Text = "16";
                        pd.lblPlayerAssists.Text = "7";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("striker3.jpg");
                    }
                }

                //Left Wing Player Details
                if (lblChangingPosition.Text == "Left Wing")
                {
                    //Left Wing 1
                    if (radioButton1.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Sadio Mané";
                        pd.lblPlayerDetailRating.Text = "86";
                        pd.lblPlayerCountry.Text = "Senegal";

                        pd.lblPlayerGoals.Text = "10";
                        pd.lblPlayerAssists.Text = "7";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("leftwing1.jpg");
                    }

                    //Left Wing 2
                    if (radioButton2.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Leroy Sane";
                        pd.lblPlayerDetailRating.Text = "86";
                        pd.lblPlayerCountry.Text = "Germany";

                        pd.lblPlayerGoals.Text = "10";
                        pd.lblPlayerAssists.Text = "15";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("leftwing2.jpg");
                    }

                    //Left Wing 3
                    if (radioButton3.Checked == true)
                    {
                        pd.lblPlayerDetailName.Text = "Eden Hazard";
                        pd.lblPlayerDetailRating.Text = "91";
                        pd.lblPlayerCountry.Text = "Belgium";

                        pd.lblPlayerGoals.Text = "12";
                        pd.lblPlayerAssists.Text = "4";

                        pd.picBoxPlayerDetail.SizeMode = PictureBoxSizeMode.Zoom;
                        pd.picBoxPlayerDetail.Load("leftwing3.jpg");
                    }

                }

                pd.Show();
            }
            
        }

        private void PlayerList_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void PlayerList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
