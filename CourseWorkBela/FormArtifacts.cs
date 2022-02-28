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
	public partial class FormArtifacts : Form
	{
		private Simulation _simulation;

		public FormArtifacts()
		{
			InitializeComponent();

			_simulation = new Simulation(this);
		}

		private void FormArtifacts_Resize(object sender, EventArgs e)
		{
			int totalH = pnlContainer.Height;
			int hHalf = totalH / 2 - 10;

			pnlPictures.Height = hHalf;
			pnlFullDesc.Height = hHalf;
			pnlFullDesc.Top = hHalf + 20;

			int totalWImg = imgArtifact1.Image.Width;
			int totalHImg = imgArtifact1.Image.Height;
			int imgHNow = imgArtifact1.Height;

			if (imgHNow > 70)
			{
				int percH = imgHNow * 100 / totalHImg;
				int imgWNow = percH * totalWImg / 100;

				imgArtifact1.Width = imgWNow;
				imgArtifact2.Left = imgArtifact1.Left + imgWNow + 20;
				imgArtifact2.Width = imgWNow;
				imgArtifact3.Left = imgArtifact2.Left + imgWNow + 20;
				imgArtifact3.Width = imgWNow;
				imgArtifact4.Left = imgArtifact3.Left + imgWNow + 20;
				imgArtifact4.Width = imgWNow;
				imgArtifact5.Left = imgArtifact4.Left + imgWNow + 20;
				imgArtifact5.Width = imgWNow;
				imgArtifact6.Left = imgArtifact5.Left + imgWNow + 20;
				imgArtifact6.Width = imgWNow;
				pnlPicturesEnd.Left = imgArtifact6.Left + imgWNow;
			}
		}

		private void btnBuyTicket_Click(object sender, EventArgs e)
		{
			FormOrder form = new FormOrder(TypeMuseum.Artifacts);
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
