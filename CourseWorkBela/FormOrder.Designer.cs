namespace CourseWorkBela
{
	partial class FormOrder
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
			this.pnlMain = new System.Windows.Forms.Panel();
			this.cbWhen = new System.Windows.Forms.ComboBox();
			this.cbTypeTicket = new System.Windows.Forms.ComboBox();
			this.lblUser = new System.Windows.Forms.Label();
			this.pnlOrder = new System.Windows.Forms.Panel();
			this.btnOrder = new System.Windows.Forms.Button();
			this.pnlTitle = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlMain.SuspendLayout();
			this.pnlOrder.SuspendLayout();
			this.pnlTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlMain.BackColor = System.Drawing.SystemColors.Control;
			this.pnlMain.Controls.Add(this.cbWhen);
			this.pnlMain.Controls.Add(this.cbTypeTicket);
			this.pnlMain.Controls.Add(this.lblUser);
			this.pnlMain.Controls.Add(this.pnlOrder);
			this.pnlMain.Controls.Add(this.pnlTitle);
			this.pnlMain.Location = new System.Drawing.Point(0, 0);
			this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(384, 261);
			this.pnlMain.TabIndex = 0;
			// 
			// cbWhen
			// 
			this.cbWhen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbWhen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbWhen.FormattingEnabled = true;
			this.cbWhen.Items.AddRange(new object[] {
            "Выберите дату"});
			this.cbWhen.Location = new System.Drawing.Point(29, 166);
			this.cbWhen.Margin = new System.Windows.Forms.Padding(0);
			this.cbWhen.Name = "cbWhen";
			this.cbWhen.Size = new System.Drawing.Size(330, 21);
			this.cbWhen.TabIndex = 4;
			// 
			// cbTypeTicket
			// 
			this.cbTypeTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.cbTypeTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTypeTicket.FormattingEnabled = true;
			this.cbTypeTicket.Items.AddRange(new object[] {
            "Выберите вид билета",
            "Свободное посещение (+75 руб)",
            "Экскурсия по конкретным залам (+50 руб)",
            "Для взрослых (+100 руб)",
            "Для детей (бесплатно)"});
			this.cbTypeTicket.Location = new System.Drawing.Point(29, 120);
			this.cbTypeTicket.Margin = new System.Windows.Forms.Padding(0);
			this.cbTypeTicket.Name = "cbTypeTicket";
			this.cbTypeTicket.Size = new System.Drawing.Size(330, 21);
			this.cbTypeTicket.TabIndex = 3;
			this.cbTypeTicket.SelectedIndexChanged += new System.EventHandler(this.cbTypeTicket_SelectedIndexChanged);
			// 
			// lblUser
			// 
			this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblUser.Font = new System.Drawing.Font("Arial Narrow", 12F);
			this.lblUser.Location = new System.Drawing.Point(25, 75);
			this.lblUser.Margin = new System.Windows.Forms.Padding(0);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(334, 20);
			this.lblUser.TabIndex = 2;
			this.lblUser.Text = "Вы: <Имя> <Фамилия>";
			// 
			// pnlOrder
			// 
			this.pnlOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlOrder.Controls.Add(this.btnOrder);
			this.pnlOrder.Location = new System.Drawing.Point(0, 211);
			this.pnlOrder.Margin = new System.Windows.Forms.Padding(0);
			this.pnlOrder.Name = "pnlOrder";
			this.pnlOrder.Size = new System.Drawing.Size(384, 50);
			this.pnlOrder.TabIndex = 1;
			// 
			// btnOrder
			// 
			this.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnOrder.BackColor = System.Drawing.Color.Black;
			this.btnOrder.FlatAppearance.BorderSize = 0;
			this.btnOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOrder.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOrder.ForeColor = System.Drawing.Color.White;
			this.btnOrder.Location = new System.Drawing.Point(259, 0);
			this.btnOrder.Margin = new System.Windows.Forms.Padding(0);
			this.btnOrder.Name = "btnOrder";
			this.btnOrder.Size = new System.Drawing.Size(100, 30);
			this.btnOrder.TabIndex = 0;
			this.btnOrder.Text = "Купить";
			this.btnOrder.UseVisualStyleBackColor = false;
			this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
			// 
			// pnlTitle
			// 
			this.pnlTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlTitle.BackColor = System.Drawing.Color.Black;
			this.pnlTitle.Controls.Add(this.lblTitle);
			this.pnlTitle.Location = new System.Drawing.Point(0, 0);
			this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new System.Drawing.Size(384, 50);
			this.pnlTitle.TabIndex = 0;
			// 
			// lblTitle
			// 
			this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTitle.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(0, 0);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(384, 50);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Оформление заказа";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 261);
			this.Controls.Add(this.pnlMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormOrder";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Оформление заказа";
			this.Shown += new System.EventHandler(this.FormOrder_Shown);
			this.pnlMain.ResumeLayout(false);
			this.pnlOrder.ResumeLayout(false);
			this.pnlTitle.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlOrder;
		private System.Windows.Forms.Button btnOrder;
		private System.Windows.Forms.Label lblUser;
		private System.Windows.Forms.ComboBox cbTypeTicket;
		private System.Windows.Forms.ComboBox cbWhen;
	}
}