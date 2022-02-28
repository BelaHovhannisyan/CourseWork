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
	public partial class FormAnimals : Form
	{
		private Simulation _simulation;

		public FormAnimals()
		{
			InitializeComponent();

			_simulation = new Simulation(this);
		}

		private void FormAnimals_Resize(object sender, EventArgs e)
		{
			int totalH = pnlContainer.Height;
			int hHalf = totalH / 2 - 10;

			pnlPictures.Height = hHalf;
			pnlFullDesc.Height = hHalf;
			pnlFullDesc.Top = hHalf + 20;

			int totalWImg = imgAnim1.Image.Width;
			int totalHImg = imgAnim1.Image.Height;
			int imgHNow = imgAnim1.Height;

			if (imgHNow > 70)
			{
				int percH = imgHNow * 100 / totalHImg;
				int imgWNow = percH * totalWImg / 100;

				imgAnim1.Width = imgWNow;
				imgAnim2.Left = imgAnim1.Left + imgWNow + 20;
				imgAnim2.Width = imgWNow;
				imgAnim3.Left = imgAnim2.Left + imgWNow + 20;
				imgAnim3.Width = imgWNow;
				imgAnim4.Left = imgAnim3.Left + imgWNow + 20;
				imgAnim4.Width = imgWNow;
				imgAnim5.Left = imgAnim4.Left + imgWNow + 20;
				imgAnim5.Width = imgWNow;
				imgAnim6.Left = imgAnim5.Left + imgWNow + 20;
				imgAnim6.Width = imgWNow;
				pnlPicturesEnd.Left = imgAnim6.Left + imgWNow;
			}
		}

		private void btnBuyTicket_Click(object sender, EventArgs e)
		{
			FormOrder form = new FormOrder(TypeMuseum.Animal);
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
