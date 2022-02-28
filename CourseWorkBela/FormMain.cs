using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkBela
{
	public partial class FormMain : Form
	{
		private Simulation _simulation;

		public static FormMain SelfForm { get; set; }

		public FormMain()
		{
			InitializeComponent();
			SelfForm = this;
			_simulation = new Simulation(this);
		}

		private void FormMain_Resize(object sender, EventArgs e)
		{
			int wTotal = pnlSelects.Width;
			int wPnlOne = (wTotal - 100) / 3;

			pnlSelect1.Left = 25;
			pnlSelect1.Width = wPnlOne;
			pnlSelect2.Left = 25 * 2 + wPnlOne;
			pnlSelect2.Width = wPnlOne;
			pnlSelect3.Left = 25 * 3 + wPnlOne * 2;
			pnlSelect3.Width = wPnlOne;
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void btnSelectEnter1_Click(object sender, EventArgs e)
		{
			FormAnimals form = new FormAnimals();
			form.ShowDialog();
		}

		private void btnSelectEnter2_Click(object sender, EventArgs e)
		{
			FormArtifacts form = new FormArtifacts();
			form.ShowDialog();
		}

		private void btnSelectEnter3_Click(object sender, EventArgs e)
		{
			FormHistory form = new FormHistory();
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
