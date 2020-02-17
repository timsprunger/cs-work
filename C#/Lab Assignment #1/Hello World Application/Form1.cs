/*
 * CS286 Spring 2019
 * Tim Sprunger
 * Lab Assignment #1
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

namespace Hello_World_Application
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			String name = txtName.Text;

			if (radioBlack.Checked)
			{
				lblResult.ForeColor = System.Drawing.Color.Black;
			}
			else if (radioBlue.Checked)
			{
				lblResult.ForeColor = System.Drawing.Color.Blue;
			}
			else
			{
				lblResult.ForeColor = System.Drawing.Color.Red;
			}

			lblResult.Text = "Hello, " + name + "!";
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			lblResult.Text = "";
			txtName.Text = "";
			radioBlack.Checked = true;
		}

		private void radioBlue_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
