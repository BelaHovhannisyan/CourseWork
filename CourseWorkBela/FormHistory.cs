using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CourseWorkBela.Type;

namespace CourseWorkBela
{
	public partial class FormHistory : Form
	{
		private Simulation _simulation;

		public FormHistory()
		{
			InitializeComponent();

			_simulation = new Simulation(this);
		}

		private void FormHistory_Resize(object sender, EventArgs e)
		{
			int totalH = pnlContainer.Height;
			int hHalf = totalH / 2 - 10;

			pnlPictures.Height = hHalf;
			pnlFullDesc.Height = hHalf;
			pnlFullDesc.Top = hHalf + 20;

			int totalWImg = imgHistory1.Image.Width;
			int totalHImg = imgHistory1.Image.Height;
			int imgHNow = imgHistory1.Height;

			if (imgHNow > 70)
			{
				int percH = imgHNow * 100 / totalHImg;
				int imgWNow = percH * totalWImg / 100;

				imgHistory1.Width = imgWNow;
				imgHistory2.Left = imgHistory1.Left + imgWNow + 20;
				imgHistory2.Width = imgWNow;
				imgHistory3.Left = imgHistory2.Left + imgWNow + 20;
				imgHistory3.Width = imgWNow;
				imgHistory4.Left = imgHistory3.Left + imgWNow + 20;
				imgHistory4.Width = imgWNow;
				imgHistory5.Left = imgHistory4.Left + imgWNow + 20;
				imgHistory5.Width = imgWNow;
				imgHistory6.Left = imgHistory5.Left + imgWNow + 20;
				imgHistory6.Width = imgWNow;
				pnlPicturesEnd.Left = imgHistory6.Left + imgWNow;
			}
		}

		private void btnBuyTicket_Click(object sender, EventArgs e)
		{
			FormOrder form = new FormOrder(TypeMuseum.History);
			form.ShowDialog();
		}

		private void btnSimulationStart_Click(object sender, EventArgs e)
		{
			btnSimulationStart.Enabled = false;
			btnSimulationStop.Enabled = true;

			_simulation.Start();
		}

		private void btnSimulationStop_Click(object sender, EventArgs e)
		{
			btnSimulationStart.Enabled = true;
			btnSimulationStop.Enabled = false;

			_simulation.Stop();
		}
	}
}
