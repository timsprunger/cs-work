/*
 * Tim Sprunger
 * CS286--Spring 2019
 * Lab Assignment 3
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Assignment_3
{
	public partial class GuessingGame : Form
	{
		public GuessingGame()
		{
			InitializeComponent();
		}

		//create new random object
		Random rnd = new Random();

		//initialize public random number
		public int numAnswer = 0;

		//intitial public variable for number of guesses
		public int numGuesses = 0;


		private void btnExit_Click(object sender, EventArgs e)
		{
			//close the form
			this.Close();
		}

		private void btnNewGame_Click(object sender, EventArgs e)
		{
			//reset counter for number of guesses
			numGuesses = 0;
			txtNumTries.Text = Convert.ToString(numGuesses);
			
			//clear out message and text box
			txtNumber.Clear();
			lblMessage.Text = "";

			//generate new random number for the answer
			numAnswer = rnd.Next(1, 101);
		}

		private void btnCheckGuess_Click(object sender, EventArgs e)
		{
			//remove whitespace
			txtNumber.Text.Trim();

			//check if textbox value can be converted to an int
			int guess;
			if (int.TryParse(txtNumber.Text, out guess) == false)
			{
				MessageBox.Show("Only Integers Are Allowed. Please enter an integer between 1 and 100"); ;
				txtNumber.Focus();
				txtNumber.SelectAll();
				lblMessage.Text = "";
				return;
			}

			//convert text box to an integer
			int numGuess = Convert.ToInt32(txtNumber.Text);

			//if text box value is empty
			if (txtNumber.Text.Length == 0)
			{
				MessageBox.Show("Text Box Empty. Please enter integer between 1 and 100");
				txtNumber.Focus();
				txtNumber.SelectAll();
				return;
			}

			//if text box value is greater than 100 or less than 1
			if (numGuess < 1 || numGuess > 100)
			{
				MessageBox.Show("Please enter valid integer between 1 and 100");
				txtNumber.Focus();
				txtNumber.SelectAll();
				return;
			}

			//increase counter for number of guesses by 1
			numGuesses++;
			txtNumTries.Text = Convert.ToString(numGuesses);

			if (numGuesses > 7)
			{
				txtNumber.Text = Convert.ToString(numAnswer);
				txtNumTries.Text = Convert.ToString(numGuesses);

				if (numGuess == numAnswer)
				{
					lblMessage.ForeColor = System.Drawing.Color.Green;
					lblMessage.Text = "Congratulations! You correctly guessed the correct number.";
				}
				else
				{
					lblMessage.Text = "Out of Tries. Correct Answer is Shown Above. To Verify Correct Answer, Press Check Answer Button";
				}
			}
			else
			{
				//Hints for guesses
				if (numGuess < numAnswer)
				{
					lblMessage.Text = "Number is higher than your guess.";
				}
				else if (numGuess > numAnswer)
				{
					lblMessage.Text = "Number is lower than your guess.";
				}
				else
				{
					lblMessage.ForeColor = System.Drawing.Color.Green;
					lblMessage.Text = "Congratulations! You correctly guessed the correct number.";
				}
			}
		}

		private void GuessingGame_Load(object sender, EventArgs e)
		{
			//generate random value for the answer when the form loads
			numAnswer = rnd.Next(1,101);
			txtNumTries.Text = Convert.ToString(numGuesses);
		}
	}
}
