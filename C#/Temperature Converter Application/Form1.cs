/*
 * Tim Sprunger
 * CS286--Spring 2019
 * February 13, 2019
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

namespace Lab_Assignment_2
{
	public partial class Thermometer : Form
	{
		public Thermometer()
		{
			this.BackgroundImage = Properties.Resources.transition_blue;
			this.BackgroundImageLayout = ImageLayout.Stretch;
			InitializeComponent();
		}

		private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
		{
			int fTemp = 200 - scrollTemp.Value;
			double cTemp = (5.0 / 9.0) * (fTemp - 32.0);

			lblFahrenheitValue.Text = fTemp.ToString();
			lblCentigradeValue.Text = Convert.ToInt16(cTemp).ToString();
		}


		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnFreezing_Click(object sender, EventArgs e)
		{
			scrollTemp.Value = 200 - 32;

			int fTemp = 32;
			double cTemp = (5.0 / 9.0) * (fTemp - 32.0);

			lblFahrenheitValue.Text = fTemp.ToString();
			lblCentigradeValue.Text = Convert.ToInt16(cTemp).ToString();
		}

		private void btnBoiling_Click(object sender, EventArgs e)
		{
			scrollTemp.Value = 200 - 212;

			int fTemp = 212;
			double cTemp = (5.0 / 9.0) * (fTemp - 32.0);

			lblFahrenheitValue.Text = fTemp.ToString();
			lblCentigradeValue.Text = Convert.ToInt16(cTemp).ToString();
		}

		private void Thermometer_Load(object sender, EventArgs e)
		{
			scrollTemp.Value = 200 - 50;

			int fTemp = 50;
			double cTemp = (5.0 / 9.0) * (fTemp - 32.0);

			lblFahrenheitValue.Text = fTemp.ToString();
			lblCentigradeValue.Text = Convert.ToInt16(cTemp).ToString();
		}
	}
}
