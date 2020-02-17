using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMN_Fantasy_Application
{
	public partial class About : Form
	{
		public About()
		{
			InitializeComponent();

			this.BackColor = Color.FromArgb(2, 59, 86);
			btnAboutBack.BackColor = Color.FromArgb(61, 134, 125);
			btnDone.BackColor= Color.FromArgb(61, 134, 125);
		}

		private void btnHelpBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			LoginScreen newLogin = new LoginScreen();
			newLogin.ShowDialog();
		}

		private void btnDone_Click(object sender, EventArgs e)
		{
			this.Hide();
			LoginScreen newLoginScreen2 = new LoginScreen();
			newLoginScreen2.ShowDialog();
		}

		private void About_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
