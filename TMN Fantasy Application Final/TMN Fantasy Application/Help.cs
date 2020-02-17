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
	public partial class Help : Form
	{
		public Help()
		{
			InitializeComponent();
		}

		private void Help_Load(object sender, EventArgs e)
		{
			this.BackColor = Color.FromArgb(2, 59, 86);
			btnHelpBack.BackColor = Color.FromArgb(61, 134, 125);

		}

		private void Help_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void btnHelpBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			LoginScreen login = new LoginScreen();
			login.ShowDialog();
		}
	}
}
