//Tim Sprunger
//CS286
//Professor Partin
//Spring 2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Assignment_7_and_8
{
	public partial class PirateTranslator : Form
	{
		public PirateTranslator()
		{
			InitializeComponent();
		}

		private void btnPardon_Click(object sender, EventArgs e)
		{
			lsbPirateWords.Items.Add("avast");
		}

		private void btnExcuse_Click(object sender, EventArgs e)
		{
			lsbPirateWords.Items.Add("arr");
		}

		private void btnSir_Click(object sender, EventArgs e)
		{
			lsbPirateWords.Items.Add("matey");
		}

		private void btnMadam_Click(object sender, EventArgs e)
		{
			lsbPirateWords.Items.Add("proud beauty");
		}

		private void btnOfficer_Click(object sender, EventArgs e)
		{
			lsbPirateWords.Items.Add("foul blaggart");
		}

		private void btnWhere_Click(object sender, EventArgs e)
		{
			lsbPirateWords.Items.Add("whar be");
		}

		private void btnCan_Click(object sender, EventArgs e)
		{
			lsbPirateWords.Items.Add("know ye");
		}

		private void btnIs_Click(object sender, EventArgs e)
		{
			lsbPirateWords.Items.Add("be that");
		}

		private void btnThe_Click(object sender, EventArgs e)
		{
			lsbPirateWords.Items.Add("th'");
		}

		private void btnMy_Click(object sender, EventArgs e)
		{
			lsbPirateWords.Items.Add("me");

		}

		private void btnYour_Click(object sender, EventArgs e)
		{
			lsbPirateWords.Items.Add("yer");

		}

		private void btnRestroom_Click(object sender, EventArgs e)
		{
			lsbPirateWords.Items.Add("head");
		}

		private void btnRestaurant_Click(object sender, EventArgs e)
		{
			lsbPirateWords.Items.Add("galley");
		}

		private void btnHotel_Click(object sender, EventArgs e)
		{
			lsbPirateWords.Items.Add("fleabag inn");
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			lsbPirateWords.Items.Clear();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void PirateTranslator_Load(object sender, EventArgs e)
		{
			
		}
	}
}
