namespace CourseWorkBela
{
	partial class FormMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.pnlMain = new System.Windows.Forms.Panel();
			this.pnlSimulation = new System.Windows.Forms.Panel();
			this.lblSimulationInfo = new System.Windows.Forms.Label();
			this.btnSimulationStart = new System.Windows.Forms.Button();
			this.btnSimulationStop = new System.Windows.Forms.Button();
			this.pnlSelects = new System.Windows.Forms.Panel();
			this.pnlSelect3 = new System.Windows.Forms.Panel();
			this.pnlSelectDesc3 = new System.Windows.Forms.Panel();
			this.lblSelectDesc3 = new System.Windows.Forms.Label();
			this.pnlSelectEnter3 = new System.Windows.Forms.Panel();
			this.btnSelectEnter3 = new System.Windows.Forms.Button();
			this.pnlSelectTitle3 = new System.Windows.Forms.Panel();
			this.lblSelectTitle3 = new System.Windows.Forms.Label();
			this.pnlSelect2 = new System.Windows.Forms.Panel();
			this.pnlSelectDesc2 = new System.Windows.Forms.Panel();
			this.lblSelectDesc2 = new System.Windows.Forms.Label();
			this.pnlSelectTitle2 = new System.Windows.Forms.Panel();
			this.lblSelectTitle2 = new System.Windows.Forms.Label();
			this.pnlSelectEnter2 = new System.Windows.Forms.Panel();
			this.btnSelectEnter2 = new System.Windows.Forms.Button();
			this.pnlSelect1 = new System.Windows.Forms.Panel();
			this.pnlSelectDesc1 = new System.Windows.Forms.Panel();
			this.lblSelectDesc1 = new System.Windows.Forms.Label();
			this.pnlSelectEnter1 = new System.Windows.Forms.Panel();
			this.btnSelectEnter1 = new System.Windows.Forms.Button();
			this.pnlSelectTitle1 = new System.Windows.Forms.Panel();
			this.lblSelectTitle1 = new System.Windows.Forms.Label();
			this.pnlTitle = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlMain.SuspendLayout();
			this.pnlSimulation.SuspendLayout();
			this.pnlSelects.SuspendLayout();
			this.pnlSelect3.SuspendLayout();
			this.pnlSelectDesc3.SuspendLayout();
			this.pnlSelectEnter3.SuspendLayout();
			this.pnlSelectTitle3.SuspendLayout();
			this.pnlSelect2.SuspendLayout();
			this.pnlSelectDesc2.SuspendLayout();
			this.pnlSelectTitle2.SuspendLayout();
			this.pnlSelectEnter2.SuspendLayout();
			this.pnlSelect1.SuspendLayout();
			this.pnlSelectDesc1.SuspendLayout();
			this.pnlSelectEnter1.SuspendLayout();
			this.pnlSelectTitle1.SuspendLayout();
			this.pnlTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlMain.Controls.Add(this.pnlSimulation);
			this.pnlMain.Controls.Add(this.pnlSelects);
			this.pnlMain.Controls.Add(this.pnlTitle);
			this.pnlMain.Location = new System.Drawing.Point(0, 0);
			this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(784, 411);
			this.pnlMain.TabIndex = 0;
			// 
			// pnlSimulation
			// 
			this.pnlSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSimulation.BackColor = System.Drawing.Color.Black;
			this.pnlSimulation.Controls.Add(this.lblSimulationInfo);
			this.pnlSimulation.Controls.Add(this.btnSimulationStart);
			this.pnlSimulation.Controls.Add(this.btnSimulationStop);
			this.pnlSimulation.Location = new System.Drawing.Point(0, 361);
			this.pnlSimulation.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSimulation.Name = "pnlSimulation";
			this.pnlSimulation.Size = new System.Drawing.Size(784, 51);
			this.pnlSimulation.TabIndex = 2;
			// 
			// lblSimulationInfo
			// 
			this.lblSimulationInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSimulationInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSimulationInfo.ForeColor = System.Drawing.Color.White;
			this.lblSimulationInfo.Location = new System.Drawing.Point(25, 0);
			this.lblSimulationInfo.Margin = new System.Windows.Forms.Padding(0);
			this.lblSimulationInfo.Name = "lblSimulationInfo";
			this.lblSimulationInfo.Size = new System.Drawing.Size(485, 50);
			this.lblSimulationInfo.TabIndex = 2;
			this.lblSimulationInfo.Text = "Симуляция отключена";
			this.lblSimulationInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnSimulationStart
			// 
			this.btnSimulationStart.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnSimulationStart.BackColor = System.Drawing.Color.White;
			this.btnSimulationStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSimulationStart.FlatAppearance.BorderSize = 0;
			this.btnSimulationStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.btnSimulationStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.btnSimulationStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSimulationStart.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSimulationStart.ForeColor = System.Drawing.Color.Black;
			this.btnSimulationStart.Location = new System.Drawing.Point(534, 10);
			this.btnSimulationStart.Margin = new System.Windows.Forms.Padding(0);
			this.btnSimulationStart.Name = "btnSimulationStart";
			this.btnSimulationStart.Size = new System.Drawing.Size(100, 30);
			this.btnSimulationStart.TabIndex = 1;
			this.btnSimulationStart.Text = "Старт";
			this.btnSimulationStart.UseVisualStyleBackColor = false;
			this.btnSimulationStart.Click += new System.EventHandler(this.btnSimulationStart_Click);
			// 
			// btnSimulationStop
			// 
			this.btnSimulationStop.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnSimulationStop.BackColor = System.Drawing.Color.White;
			this.btnSimulationStop.Enabled = false;
			this.btnSimulationStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSimulationStop.FlatAppearance.BorderSize = 0;
			this.btnSimulationStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.btnSimulationStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.btnSimulationStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSimulationStop.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSimulationStop.ForeColor = System.Drawing.Color.Black;
			this.btnSimulationStop.Location = new System.Drawing.Point(659, 10);
			this.btnSimulationStop.Margin = new System.Windows.Forms.Padding(0);
			this.btnSimulationStop.Name = "btnSimulationStop";
			this.btnSimulationStop.Size = new System.Drawing.Size(100, 30);
			this.btnSimulationStop.TabIndex = 0;
			this.btnSimulationStop.Text = "Стоп";
			this.btnSimulationStop.UseVisualStyleBackColor = false;
			this.btnSimulationStop.Click += new System.EventHandler(this.btnSimulationStop_Click);
			// 
			// pnlSelects
			// 
			this.pnlSelects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSelects.BackColor = System.Drawing.Color.White;
			this.pnlSelects.Controls.Add(this.pnlSelect3);
			this.pnlSelects.Controls.Add(this.pnlSelect2);
			this.pnlSelects.Controls.Add(this.pnlSelect1);
			this.pnlSelects.Location = new System.Drawing.Point(0, 50);
			this.pnlSelects.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSelects.Name = "pnlSelects";
			this.pnlSelects.Size = new System.Drawing.Size(784, 311);
			this.pnlSelects.TabIndex = 1;
			// 
			// pnlSelect3
			// 
			this.pnlSelect3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSelect3.BackColor = System.Drawing.Color.Black;
			this.pnlSelect3.Controls.Add(this.pnlSelectDesc3);
			this.pnlSelect3.Controls.Add(this.pnlSelectEnter3);
			this.pnlSelect3.Controls.Add(this.pnlSelectTitle3);
			this.pnlSelect3.Location = new System.Drawing.Point(531, 25);
			this.pnlSelect3.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSelect3.Name = "pnlSelect3";
			this.pnlSelect3.Size = new System.Drawing.Size(228, 261);
			this.pnlSelect3.TabIndex = 2;
			// 
			// pnlSelectDesc3
			// 
			this.pnlSelectDesc3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSelectDesc3.Controls.Add(this.lblSelectDesc3);
			this.pnlSelectDesc3.Location = new System.Drawing.Point(0, 30);
			this.pnlSelectDesc3.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSelectDesc3.Name = "pnlSelectDesc3";
			this.pnlSelectDesc3.Size = new System.Drawing.Size(228, 180);
			this.pnlSelectDesc3.TabIndex = 4;
			// 
			// lblSelectDesc3
			// 
			this.lblSelectDesc3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSelectDesc3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSelectDesc3.ForeColor = System.Drawing.Color.White;
			this.lblSelectDesc3.Location = new System.Drawing.Point(0, 0);
			this.lblSelectDesc3.Margin = new System.Windows.Forms.Padding(0);
			this.lblSelectDesc3.Name = "lblSelectDesc3";
			this.lblSelectDesc3.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.lblSelectDesc3.Size = new System.Drawing.Size(228, 180);
			this.lblSelectDesc3.TabIndex = 2;
			this.lblSelectDesc3.Text = "*Тут какое-то описание*";
			// 
			// pnlSelectEnter3
			// 
			this.pnlSelectEnter3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSelectEnter3.Controls.Add(this.btnSelectEnter3);
			this.pnlSelectEnter3.Location = new System.Drawing.Point(0, 211);
			this.pnlSelectEnter3.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSelectEnter3.Name = "pnlSelectEnter3";
			this.pnlSelectEnter3.Size = new System.Drawing.Size(228, 50);
			this.pnlSelectEnter3.TabIndex = 3;
			// 
			// btnSelectEnter3
			// 
			this.btnSelectEnter3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelectEnter3.BackColor = System.Drawing.Color.White;
			this.btnSelectEnter3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSelectEnter3.FlatAppearance.BorderSize = 0;
			this.btnSelectEnter3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.btnSelectEnter3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.btnSelectEnter3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSelectEnter3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSelectEnter3.ForeColor = System.Drawing.Color.Black;
			this.btnSelectEnter3.Location = new System.Drawing.Point(113, 5);
			this.btnSelectEnter3.Margin = new System.Windows.Forms.Padding(0);
			this.btnSelectEnter3.Name = "btnSelectEnter3";
			this.btnSelectEnter3.Size = new System.Drawing.Size(100, 30);
			this.btnSelectEnter3.TabIndex = 2;
			this.btnSelectEnter3.Text = "Перейти";
			this.btnSelectEnter3.UseVisualStyleBackColor = false;
			this.btnSelectEnter3.Click += new System.EventHandler(this.btnSelectEnter3_Click);
			// 
			// pnlSelectTitle3
			// 
			this.pnlSelectTitle3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSelectTitle3.Controls.Add(this.lblSelectTitle3);
			this.pnlSelectTitle3.Location = new System.Drawing.Point(0, 0);
			this.pnlSelectTitle3.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSelectTitle3.Name = "pnlSelectTitle3";
			this.pnlSelectTitle3.Size = new System.Drawing.Size(228, 30);
			this.pnlSelectTitle3.TabIndex = 2;
			// 
			// lblSelectTitle3
			// 
			this.lblSelectTitle3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSelectTitle3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSelectTitle3.ForeColor = System.Drawing.Color.White;
			this.lblSelectTitle3.Location = new System.Drawing.Point(0, 0);
			this.lblSelectTitle3.Margin = new System.Windows.Forms.Padding(0);
			this.lblSelectTitle3.Name = "lblSelectTitle3";
			this.lblSelectTitle3.Size = new System.Drawing.Size(228, 30);
			this.lblSelectTitle3.TabIndex = 0;
			this.lblSelectTitle3.Text = "История культуры";
			this.lblSelectTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlSelect2
			// 
			this.pnlSelect2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.pnlSelect2.BackColor = System.Drawing.Color.Black;
			this.pnlSelect2.Controls.Add(this.pnlSelectDesc2);
			this.pnlSelect2.Controls.Add(this.pnlSelectTitle2);
			this.pnlSelect2.Controls.Add(this.pnlSelectEnter2);
			this.pnlSelect2.Location = new System.Drawing.Point(278, 25);
			this.pnlSelect2.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSelect2.Name = "pnlSelect2";
			this.pnlSelect2.Size = new System.Drawing.Size(228, 261);
			this.pnlSelect2.TabIndex = 1;
			// 
			// pnlSelectDesc2
			// 
			this.pnlSelectDesc2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSelectDesc2.Controls.Add(this.lblSelectDesc2);
			this.pnlSelectDesc2.Location = new System.Drawing.Point(0, 30);
			this.pnlSelectDesc2.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSelectDesc2.Name = "pnlSelectDesc2";
			this.pnlSelectDesc2.Size = new System.Drawing.Size(228, 180);
			this.pnlSelectDesc2.TabIndex = 3;
			// 
			// lblSelectDesc2
			// 
			this.lblSelectDesc2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSelectDesc2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSelectDesc2.ForeColor = System.Drawing.Color.White;
			this.lblSelectDesc2.Location = new System.Drawing.Point(0, 0);
			this.lblSelectDesc2.Margin = new System.Windows.Forms.Padding(0);
			this.lblSelectDesc2.Name = "lblSelectDesc2";
			this.lblSelectDesc2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.lblSelectDesc2.Size = new System.Drawing.Size(228, 180);
			this.lblSelectDesc2.TabIndex = 1;
			this.lblSelectDesc2.Text = "*Тут какое-то описание*";
			// 
			// pnlSelectTitle2
			// 
			this.pnlSelectTitle2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSelectTitle2.Controls.Add(this.lblSelectTitle2);
			this.pnlSelectTitle2.Location = new System.Drawing.Point(0, 0);
			this.pnlSelectTitle2.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSelectTitle2.Name = "pnlSelectTitle2";
			this.pnlSelectTitle2.Size = new System.Drawing.Size(228, 30);
			this.pnlSelectTitle2.TabIndex = 1;
			// 
			// lblSelectTitle2
			// 
			this.lblSelectTitle2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSelectTitle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSelectTitle2.ForeColor = System.Drawing.Color.White;
			this.lblSelectTitle2.Location = new System.Drawing.Point(0, 0);
			this.lblSelectTitle2.Margin = new System.Windows.Forms.Padding(0);
			this.lblSelectTitle2.Name = "lblSelectTitle2";
			this.lblSelectTitle2.Size = new System.Drawing.Size(228, 30);
			this.lblSelectTitle2.TabIndex = 0;
			this.lblSelectTitle2.Text = "Окаменелости и артефакты";
			this.lblSelectTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlSelectEnter2
			// 
			this.pnlSelectEnter2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSelectEnter2.Controls.Add(this.btnSelectEnter2);
			this.pnlSelectEnter2.Location = new System.Drawing.Point(0, 211);
			this.pnlSelectEnter2.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSelectEnter2.Name = "pnlSelectEnter2";
			this.pnlSelectEnter2.Size = new System.Drawing.Size(228, 50);
			this.pnlSelectEnter2.TabIndex = 2;
			// 
			// btnSelectEnter2
			// 
			this.btnSelectEnter2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelectEnter2.BackColor = System.Drawing.Color.White;
			this.btnSelectEnter2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSelectEnter2.FlatAppearance.BorderSize = 0;
			this.btnSelectEnter2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.btnSelectEnter2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.btnSelectEnter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSelectEnter2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSelectEnter2.ForeColor = System.Drawing.Color.Black;
			this.btnSelectEnter2.Location = new System.Drawing.Point(113, 5);
			this.btnSelectEnter2.Margin = new System.Windows.Forms.Padding(0);
			this.btnSelectEnter2.Name = "btnSelectEnter2";
			this.btnSelectEnter2.Size = new System.Drawing.Size(100, 30);
			this.btnSelectEnter2.TabIndex = 1;
			this.btnSelectEnter2.Text = "Перейти";
			this.btnSelectEnter2.UseVisualStyleBackColor = false;
			this.btnSelectEnter2.Click += new System.EventHandler(this.btnSelectEnter2_Click);
			// 
			// pnlSelect1
			// 
			this.pnlSelect1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlSelect1.BackColor = System.Drawing.Color.Black;
			this.pnlSelect1.Controls.Add(this.pnlSelectDesc1);
			this.pnlSelect1.Controls.Add(this.pnlSelectEnter1);
			this.pnlSelect1.Controls.Add(this.pnlSelectTitle1);
			this.pnlSelect1.Location = new System.Drawing.Point(25, 25);
			this.pnlSelect1.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSelect1.Name = "pnlSelect1";
			this.pnlSelect1.Size = new System.Drawing.Size(228, 261);
			this.pnlSelect1.TabIndex = 0;
			// 
			// pnlSelectDesc1
			// 
			this.pnlSelectDesc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSelectDesc1.Controls.Add(this.lblSelectDesc1);
			this.pnlSelectDesc1.Location = new System.Drawing.Point(0, 30);
			this.pnlSelectDesc1.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSelectDesc1.Name = "pnlSelectDesc1";
			this.pnlSelectDesc1.Size = new System.Drawing.Size(228, 180);
			this.pnlSelectDesc1.TabIndex = 2;
			// 
			// lblSelectDesc1
			// 
			this.lblSelectDesc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSelectDesc1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSelectDesc1.ForeColor = System.Drawing.Color.White;
			this.lblSelectDesc1.Location = new System.Drawing.Point(0, 0);
			this.lblSelectDesc1.Margin = new System.Windows.Forms.Padding(0);
			this.lblSelectDesc1.Name = "lblSelectDesc1";
			this.lblSelectDesc1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
			this.lblSelectDesc1.Size = new System.Drawing.Size(228, 180);
			this.lblSelectDesc1.TabIndex = 0;
			this.lblSelectDesc1.Text = "*Тут какое-то описание*";
			// 
			// pnlSelectEnter1
			// 
			this.pnlSelectEnter1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSelectEnter1.Controls.Add(this.btnSelectEnter1);
			this.pnlSelectEnter1.Location = new System.Drawing.Point(0, 211);
			this.pnlSelectEnter1.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSelectEnter1.Name = "pnlSelectEnter1";
			this.pnlSelectEnter1.Size = new System.Drawing.Size(228, 50);
			this.pnlSelectEnter1.TabIndex = 1;
			// 
			// btnSelectEnter1
			// 
			this.btnSelectEnter1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelectEnter1.BackColor = System.Drawing.Color.White;
			this.btnSelectEnter1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSelectEnter1.FlatAppearance.BorderSize = 0;
			this.btnSelectEnter1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.btnSelectEnter1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.btnSelectEnter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSelectEnter1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSelectEnter1.ForeColor = System.Drawing.Color.Black;
			this.btnSelectEnter1.Location = new System.Drawing.Point(113, 5);
			this.btnSelectEnter1.Margin = new System.Windows.Forms.Padding(0);
			this.btnSelectEnter1.Name = "btnSelectEnter1";
			this.btnSelectEnter1.Size = new System.Drawing.Size(100, 30);
			this.btnSelectEnter1.TabIndex = 0;
			this.btnSelectEnter1.Text = "Перейти";
			this.btnSelectEnter1.UseVisualStyleBackColor = false;
			this.btnSelectEnter1.Click += new System.EventHandler(this.btnSelectEnter1_Click);
			// 
			// pnlSelectTitle1
			// 
			this.pnlSelectTitle1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSelectTitle1.Controls.Add(this.lblSelectTitle1);
			this.pnlSelectTitle1.Location = new System.Drawing.Point(0, 0);
			this.pnlSelectTitle1.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSelectTitle1.Name = "pnlSelectTitle1";
			this.pnlSelectTitle1.Size = new System.Drawing.Size(228, 30);
			this.pnlSelectTitle1.TabIndex = 0;
			// 
			// lblSelectTitle1
			// 
			this.lblSelectTitle1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblSelectTitle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSelectTitle1.ForeColor = System.Drawing.Color.White;
			this.lblSelectTitle1.Location = new System.Drawing.Point(0, 0);
			this.lblSelectTitle1.Margin = new System.Windows.Forms.Padding(0);
			this.lblSelectTitle1.Name = "lblSelectTitle1";
			this.lblSelectTitle1.Size = new System.Drawing.Size(228, 30);
			this.lblSelectTitle1.TabIndex = 0;
			this.lblSelectTitle1.Text = "Животный мир";
			this.lblSelectTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlTitle
			// 
			this.pnlTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(65)))), ((int)(((byte)(171)))));
			this.pnlTitle.Controls.Add(this.lblTitle);
			this.pnlTitle.Location = new System.Drawing.Point(0, 0);
			this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new System.Drawing.Size(784, 50);
			this.pnlTitle.TabIndex = 0;
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle.BackColor = System.Drawing.Color.Black;
			this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(784, 50);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Добро пожаловать в музей AMNH";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 411);
			this.Controls.Add(this.pnlMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(800, 450);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Музей AMNH";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Resize += new System.EventHandler(this.FormMain_Resize);
			this.pnlMain.ResumeLayout(false);
			this.pnlSimulation.ResumeLayout(false);
			this.pnlSelects.ResumeLayout(false);
			this.pnlSelect3.ResumeLayout(false);
			this.pnlSelectDesc3.ResumeLayout(false);
			this.pnlSelectEnter3.ResumeLayout(false);
			this.pnlSelectTitle3.ResumeLayout(false);
			this.pnlSelect2.ResumeLayout(false);
			this.pnlSelectDesc2.ResumeLayout(false);
			this.pnlSelectTitle2.ResumeLayout(false);
			this.pnlSelectEnter2.ResumeLayout(false);
			this.pnlSelect1.ResumeLayout(false);
			this.pnlSelectDesc1.ResumeLayout(false);
			this.pnlSelectEnter1.ResumeLayout(false);
			this.pnlSelectTitle1.ResumeLayout(false);
			this.pnlTitle.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.Panel pnlSelects;
		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlSelect3;
		private System.Windows.Forms.Panel pnlSelect2;
		private System.Windows.Forms.Panel pnlSelect1;
		private System.Windows.Forms.Panel pnlSelectTitle1;
		private System.Windows.Forms.Label lblSelectTitle1;
		private System.Windows.Forms.Panel pnlSelectEnter2;
		private System.Windows.Forms.Panel pnlSelectEnter1;
		private System.Windows.Forms.Panel pnlSelectEnter3;
		private System.Windows.Forms.Panel pnlSelectTitle3;
		private System.Windows.Forms.Label lblSelectTitle3;
		private System.Windows.Forms.Panel pnlSelectTitle2;
		private System.Windows.Forms.Label lblSelectTitle2;
		private System.Windows.Forms.Button btnSelectEnter1;
		private System.Windows.Forms.Button btnSelectEnter3;
		private System.Windows.Forms.Panel pnlSelectDesc2;
		private System.Windows.Forms.Button btnSelectEnter2;
		private System.Windows.Forms.Panel pnlSelectDesc1;
		private System.Windows.Forms.Panel pnlSelectDesc3;
		private System.Windows.Forms.Panel pnlSimulation;
		private System.Windows.Forms.Label lblSelectDesc3;
		private System.Windows.Forms.Label lblSelectDesc2;
		private System.Windows.Forms.Label lblSelectDesc1;
		private System.Windows.Forms.Button btnSimulationStart;
		private System.Windows.Forms.Button btnSimulationStop;
		public System.Windows.Forms.Label lblSimulationInfo;
	}
}

