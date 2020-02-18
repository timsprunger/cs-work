/*
 * Tim Sprunger
 * CS286--Spring 2019
 * Lab Assignment 4
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

namespace Lab_Assignment_4
{
	public partial class Changemaker : Form
	{
		public Changemaker()
		{
			InitializeComponent();
		}

		public int numQuarters = 0;
		public int numDimes = 0;
		public int numNickels = 0;
		public int numPennies = 0;
		public int num100 = 0;
		public int num50 = 0;
		public int num20 = 0;
		public int num10 = 0;
		public int num5 = 0;
		public int num1 = 0;


		private void btnMakeChange_Click(object sender, EventArgs e)
		{
			calculateDisplayChange();
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			txtTotalCost.Clear();
			txtMoneyPresented.Clear();
			lsbChange.Items.Clear();

			numQuarters = 0;
			numDimes = 0;
			numNickels = 0;
			numPennies = 0;
			num100 = 0;
			num50 = 0;
			num20 = 0;
			num10 = 0;
			num5 = 0;
			num1 = 0;
		}

		private void calculateDisplayChange()
		{
			//***START txtTotalCost VALIDATING***
			txtMoneyPresented.Text.Trim();
			txtTotalCost.Text.Trim();

			//if value in total cost text box cannot be converted to a double
			decimal totalCost;
			if (decimal.TryParse(txtTotalCost.Text, out totalCost) == false)
			{
				MessageBox.Show("Please enter a valid number for Total Cost.");
				txtTotalCost.Focus();
				txtTotalCost.SelectAll();
				lsbChange.Items.Clear();
				return;
			}

			//if total cost text box is empty
			if (txtTotalCost.Text.Length == 0)
			{
				MessageBox.Show("Please enter value for Total Cost.");
				txtTotalCost.Focus();
				txtTotalCost.SelectAll();
				lsbChange.Items.Clear();
				return;
			}

			//if value i total cost text box is less than $.01
			decimal numtotalCost = Convert.ToDecimal(txtTotalCost.Text);

			if (numtotalCost < .01M)
			{
				MessageBox.Show("Please enter a valid number for Total Cost.  Total Cost must be greater than $.01.");
				txtTotalCost.Focus();
				txtTotalCost.SelectAll();
				lsbChange.Items.Clear();
				return;
			}

			if (numtotalCost > 1000M)
			{
				MessageBox.Show("Please enter a valid number for Total Cost. Total Cost must be less than $1,000");
				txtTotalCost.Focus();
				txtTotalCost.SelectAll();
				lsbChange.Items.Clear();
				return;
			}

			//***END txtTotalCost VALIDATING***


			//***START moneyPresented VALIDATING***

			//if value in money presented text box cannot be converted to a double
			decimal moneyPresented;
			if (decimal.TryParse(txtMoneyPresented.Text, out moneyPresented) == false)
			{
				MessageBox.Show("Please enter a valid number for Money Presented.");
				txtMoneyPresented.Focus();
				txtMoneyPresented.SelectAll();
				lsbChange.Items.Clear();
				return;
			}

			//if money presented text box is empty
			if (txtMoneyPresented.Text.Length == 0)
			{
				MessageBox.Show("Please enter value for Money Presented.");
				txtMoneyPresented.Focus();
				txtMoneyPresented.SelectAll();
				lsbChange.Items.Clear();
				return;
			}

			//if money presented is less than $.01
			decimal numMoneyPresented = Convert.ToDecimal(txtMoneyPresented.Text);

			if (numMoneyPresented < .01M)
			{
				MessageBox.Show("Please enter a valid number for Money Presented. Money Presented must be greater than $.01.");
				txtMoneyPresented.Focus();
				txtMoneyPresented.SelectAll();
				lsbChange.Items.Clear();
				return;
			}

			if (numMoneyPresented > 1000M)
			{
				MessageBox.Show("Please enter a valid number for Money Presented. Money Presented must be less than $1,000");
				txtMoneyPresented.Focus();
				txtMoneyPresented.SelectAll();
				lsbChange.Items.Clear();
				return;
			}


			//***END moneyPresented VALIDATING***

			lsbChange.Items.Clear();

			numQuarters = 0;
			numDimes = 0;
			numNickels = 0;
			numPennies = 0;

			num100 = 0;
			num50 = 0;
			num20 = 0;
			num10 = 0;
			num5 = 0;
			num1 = 0;

			if (numMoneyPresented < numtotalCost)
			{
				decimal remainder1 = numtotalCost - numMoneyPresented;
				string remainder1String = remainder1.ToString("#.00");
				MessageBox.Show("You are still short $" + remainder1String);
				txtMoneyPresented.Focus();
				txtMoneyPresented.SelectAll();
			}

			decimal remainder = moneyPresented - numtotalCost;
			remainder = Decimal.Round(remainder, 2, MidpointRounding.AwayFromZero);

			//if total cost is equal to money presented
			if (remainder == 0)
			{
				MessageBox.Show("You have given the exact value that is due. Thank You!");
			}


			//if the money presented is more than the amount that is due
			if (remainder > 0)
			{
				string stringRemainder = remainder.ToString("#.00");

				string stringCents = stringRemainder.Substring(stringRemainder.IndexOf('.') + 1);
				string afterPeriod = stringRemainder.Substring(stringRemainder.IndexOf('.'));
				string stringDollars = stringRemainder.Substring(0, (stringRemainder.Length - afterPeriod.Length));


				int numDollars;
				if (stringDollars == "")
				{
					numDollars = 0;
				}
				else
				{
					numDollars = Convert.ToInt32(stringDollars);
				}


				int numCents;
				if (stringCents == "")
				{
					numCents = 0;
				}
				else
				{
					numCents = Convert.ToInt32(stringCents);
				}


				//*** Start Counting Change***
				while (numCents >= 25)
				{
					numQuarters++;
					numCents -= 25;
				}

				while (numCents >= 10)
				{
					numDimes++;
					numCents -= 10;
				}

				while (numCents >= 5)
				{
					numNickels++;
					numCents -= 5;
				}

				while (numCents >= 1)
				{
					numPennies++;
					numCents -= 1;
				}
				//***End Counting Change***


				//***Start Counting Dollars***
				while (numDollars >= 100)
				{
					num100++;
					numDollars -= 100;
				}

				while (numDollars >= 50)
				{
					num50++;
					numDollars -= 50;
				}

				while (numDollars >= 20)
				{
					num20++;
					numDollars -= 20;
				}

				while (numDollars >= 10)
				{
					num10++;
					numDollars -= 10;
				}

				while (numDollars >= 5)
				{
					num5++;
					numDollars -= 5;
				}

				while (numDollars >= 1)
				{
					num1++;
					numDollars -= 1;
				}
				//***End Counting Dollars


				//******Displaying Change to List Boxes******

				//***Dollars***
				if (num100 == 1)
					lsbChange.Items.Add(num100 + " Hundred");
				else if (num100 > 1)
				{
					lsbChange.Items.Add(num100 + " Hundreds");
				}

				if (num50 == 1)
					lsbChange.Items.Add(num50 + " Fifty");
				else if (num50 > 1)
				{
					lsbChange.Items.Add(num50 + " Fifties");
				}

				if (num20 == 1)
					lsbChange.Items.Add(num20 + " Twenty");
				else if (num20 > 1)
				{
					lsbChange.Items.Add(num20 + " Twenties");
				}

				if (num10 == 1)
					lsbChange.Items.Add(num10 + " Ten");
				else if (num10 > 1)
				{
					lsbChange.Items.Add(num10 + " Tens");
				}

				if (num5 == 1)
					lsbChange.Items.Add(num5 + " Five");
				else if (num5 > 1)
				{
					lsbChange.Items.Add(num5 + " Fives");
				}

				if (num1 == 1)
					lsbChange.Items.Add(num1 + " One");
				else if (num1 > 1)
				{
					lsbChange.Items.Add(num1 + " Ones");
				}
				//***End Dollars***


				//***Change***
				if (numQuarters == 1)
					lsbChange.Items.Add(numQuarters + " Quarter");
				else if (numQuarters > 1)
				{
					lsbChange.Items.Add(numQuarters + " Quarters");
				}

				if (numDimes == 1)
					lsbChange.Items.Add(numDimes + " Dime");
				else if (numDimes > 1)
				{
					lsbChange.Items.Add(numDimes + " Dimes");
				}

				if (numNickels == 1)
					lsbChange.Items.Add(numNickels + " Nickel");
				else if (numNickels > 1)
				{
					lsbChange.Items.Add(numNickels + " Nickels");
				}

				if (numPennies == 1)
					lsbChange.Items.Add(numPennies + " Penny");
				else if (numPennies > 1)
				{
					lsbChange.Items.Add(numPennies + " Pennies");
				}
			}
			//***End Change***
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}

