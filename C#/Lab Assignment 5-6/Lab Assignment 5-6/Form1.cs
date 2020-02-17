/*
 * Tim Sprunger
 * CS286--Spring 2019
 * Lab Assignment 5&6
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

namespace Lab_Assignment_5_6
{
	
	public partial class Palindromes : Form
	{
		public Palindromes()
		{
			InitializeComponent();
		}

		private void btnFindPalindromes_Click(object sender, EventArgs e)
		{
			//clear list box
			lsbPalindromes.Items.Clear();

			//clear text box
			txtTotalPalindromes.Clear();

			//remove white space from both text boxes
			txtSize.Text.Trim();
			txtPalindrome.Text.Trim();

			//check if txtSize can be coverted to an integer
			int checkInt;
			if (int.TryParse(txtSize.Text, out checkInt) == false)
			{
				MessageBox.Show("Please enter a valid integer for palindrome size.");
				txtSize.Focus();
				txtSize.SelectAll();
				return;
			}

			int numPalindromes = 0;
			string numsLetters = "";
			int palindromeLength = Convert.ToInt32(txtSize.Text);


			//create new string, removing all characters besides letters and numbers
			string initialString = txtPalindrome.Text;
			char[] letters = initialString.ToCharArray();

			for (int x=0; x<initialString.Length; x++)
			{
				if (Char.IsLetterOrDigit(letters[x]) == true)
				{
					numsLetters = numsLetters + letters[x];
				}
			}

			//convert string to lowercase to make comparing easier
			numsLetters = numsLetters.ToLower();

			//if the size of the palindrome is greater than the number of letters and numbers
			if (numsLetters.Length < Convert.ToString(palindromeLength).Length)
			{
				MessageBox.Show("Size of palindrome cannot be greater than the number of letters and numbers in your string.");
				txtSize.Focus();
				txtSize.SelectAll();
				return;
			}

			//create reverse palindrome, compare with palindrome, count num of valid palindromes
			int startPos = 0;
			while ( (startPos + (palindromeLength - 1) ) < numsLetters.Length )
			{

				string palindrome = numsLetters.Substring(startPos, palindromeLength);

				char[] reverseArray = palindrome.ToCharArray();
				Array.Reverse(reverseArray);

				string reversePalindrome = "";
				for (int z = 0; z<reverseArray.Length; z++)
				{
					reversePalindrome = reversePalindrome + reverseArray[z];
				}

				if (palindrome == reversePalindrome)
				{
					lsbPalindromes.Items.Add( palindrome.ToUpper() );
					numPalindromes++;
				}
				
				startPos++;
			}

			MessageBox.Show("Your string included palindromes of length = " + txtSize.Text);
			txtTotalPalindromes.Text = Convert.ToString(numPalindromes);
		}

		private void Palindromes_Load(object sender, EventArgs e)
		{
			//create more visually appealing button and menu item
			btnFindPalindromes.BackColor = Color.Gray;
			menuStrip1.BackColor = Color.Gray;

			//set text box to not be editable
			txtTotalPalindromes.ReadOnly = true;
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//clear list box and both text boxes
			lsbPalindromes.Items.Clear();
			txtPalindrome.Clear();
			txtSize.Clear();
			txtTotalPalindromes.Clear();
		}

		private void endProgramToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//close form
			this.Close();
		}
	}
}
