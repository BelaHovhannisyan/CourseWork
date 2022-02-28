namespace CourseWorkBela
{
	partial class FormReg
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReg));
			this.pnlMain = new System.Windows.Forms.Panel();
			this.pnlForm = new System.Windows.Forms.Panel();
			this.tbPasswordRepeat = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.tbLastname = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.lbllkAuth = new System.Windows.Forms.LinkLabel();
			this.btnRegister = new System.Windows.Forms.Button();
			this.tbPasswordRepeatFake = new System.Windows.Forms.TextBox();
			this.tbPasswordFake = new System.Windows.Forms.TextBox();
			this.tbLoginFake = new System.Windows.Forms.TextBox();
			this.tbLastnameFake = new System.Windows.Forms.TextBox();
			this.tbNameFake = new System.Windows.Forms.TextBox();
			this.pnlTitle = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlMain.SuspendLayout();
			this.pnlForm.SuspendLayout();
			this.pnlTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlMain
			// 
			this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlMain.Controls.Add(this.pnlForm);
			this.pnlMain.Controls.Add(this.pnlTitle);
			this.pnlMain.Location = new System.Drawing.Point(0, 0);
			this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(314, 505);
			this.pnlMain.TabIndex = 0;
			// 
			// pnlForm
			// 
			this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlForm.Controls.Add(this.tbPasswordRepeat);
			this.pnlForm.Controls.Add(this.tbPassword);
			this.pnlForm.Controls.Add(this.tbLogin);
			this.pnlForm.Controls.Add(this.tbLastname);
			this.pnlForm.Controls.Add(this.tbName);
			this.pnlForm.Controls.Add(this.lbllkAuth);
			this.pnlForm.Controls.Add(this.btnRegister);
			this.pnlForm.Controls.Add(this.tbPasswordRepeatFake);
			this.pnlForm.Controls.Add(this.tbPasswordFake);
			this.pnlForm.Controls.Add(this.tbLoginFake);
			this.pnlForm.Controls.Add(this.tbLastnameFake);
			this.pnlForm.Controls.Add(this.tbNameFake);
			this.pnlForm.Location = new System.Drawing.Point(0, 50);
			this.pnlForm.Margin = new System.Windows.Forms.Padding(0);
			this.pnlForm.Name = "pnlForm";
			this.pnlForm.Size = new System.Drawing.Size(314, 455);
			this.pnlForm.TabIndex = 1;
			// 
			// tbPasswordRepeat
			// 
			this.tbPasswordRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPasswordRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.tbPasswordRepeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbPasswordRepeat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbPasswordRepeat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.tbPasswordRepeat.Location = new System.Drawing.Point(55, 295);
			this.tbPasswordRepeat.Margin = new System.Windows.Forms.Padding(0);
			this.tbPasswordRepeat.Name = "tbPasswordRepeat";
			this.tbPasswordRepeat.Size = new System.Drawing.Size(204, 19);
			this.tbPasswordRepeat.TabIndex = 12;
			this.tbPasswordRepeat.Text = "Повторный пароль";
			this.tbPasswordRepeat.Enter += new System.EventHandler(this.tbPasswordRepeat_Enter);
			this.tbPasswordRepeat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPasswordRepeat_KeyDown);
			this.tbPasswordRepeat.Leave += new System.EventHandler(this.tbPasswordRepeat_Leave);
			// 
			// tbPassword
			// 
			this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.tbPassword.Location = new System.Drawing.Point(55, 230);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(0);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(204, 19);
			this.tbPassword.TabIndex = 11;
			this.tbPassword.Text = "Пароль";
			this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
			this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
			this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
			// 
			// tbLogin
			// 
			this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.tbLogin.Location = new System.Drawing.Point(55, 165);
			this.tbLogin.Margin = new System.Windows.Forms.Padding(0);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(204, 19);
			this.tbLogin.TabIndex = 10;
			this.tbLogin.Text = "Логин";
			this.tbLogin.Enter += new System.EventHandler(this.tbLogin_Enter);
			this.tbLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLogin_KeyDown);
			this.tbLogin.Leave += new System.EventHandler(this.tbLogin_Leave);
			// 
			// tbLastname
			// 
			this.tbLastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.tbLastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbLastname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.tbLastname.Location = new System.Drawing.Point(55, 100);
			this.tbLastname.Margin = new System.Windows.Forms.Padding(0);
			this.tbLastname.Name = "tbLastname";
			this.tbLastname.Size = new System.Drawing.Size(204, 19);
			this.tbLastname.TabIndex = 9;
			this.tbLastname.Text = "Фамилия";
			this.tbLastname.Enter += new System.EventHandler(this.tbLastname_Enter);
			this.tbLastname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLastname_KeyDown);
			this.tbLastname.Leave += new System.EventHandler(this.tbLastname_Leave);
			// 
			// tbName
			// 
			this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.tbName.Location = new System.Drawing.Point(55, 35);
			this.tbName.Margin = new System.Windows.Forms.Padding(0);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(204, 19);
			this.tbName.TabIndex = 8;
			this.tbName.Text = "Имя";
			this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
			this.tbName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbName_KeyDown);
			this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
			// 
			// lbllkAuth
			// 
			this.lbllkAuth.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.lbllkAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lbllkAuth.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbllkAuth.LinkColor = System.Drawing.Color.Black;
			this.lbllkAuth.Location = new System.Drawing.Point(50, 400);
			this.lbllkAuth.Margin = new System.Windows.Forms.Padding(0);
			this.lbllkAuth.Name = "lbllkAuth";
			this.lbllkAuth.Size = new System.Drawing.Size(214, 40);
			this.lbllkAuth.TabIndex = 7;
			this.lbllkAuth.TabStop = true;
			this.lbllkAuth.Text = "Авторизоваться";
			this.lbllkAuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbllkAuth.VisitedLinkColor = System.Drawing.Color.Black;
			this.lbllkAuth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllkAuth_LinkClicked);
			// 
			// btnRegister
			// 
			this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRegister.BackColor = System.Drawing.Color.Black;
			this.btnRegister.FlatAppearance.BorderSize = 0;
			this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegister.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnRegister.ForeColor = System.Drawing.Color.White;
			this.btnRegister.Location = new System.Drawing.Point(50, 350);
			this.btnRegister.Margin = new System.Windows.Forms.Padding(0);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(214, 40);
			this.btnRegister.TabIndex = 6;
			this.btnRegister.Text = "Зарегистрироваться";
			this.btnRegister.UseVisualStyleBackColor = false;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// tbPasswordRepeatFake
			// 
			this.tbPasswordRepeatFake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPasswordRepeatFake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.tbPasswordRepeatFake.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbPasswordRepeatFake.Location = new System.Drawing.Point(50, 285);
			this.tbPasswordRepeatFake.Margin = new System.Windows.Forms.Padding(0);
			this.tbPasswordRepeatFake.Multiline = true;
			this.tbPasswordRepeatFake.Name = "tbPasswordRepeatFake";
			this.tbPasswordRepeatFake.ReadOnly = true;
			this.tbPasswordRepeatFake.Size = new System.Drawing.Size(214, 40);
			this.tbPasswordRepeatFake.TabIndex = 5;
			this.tbPasswordRepeatFake.Enter += new System.EventHandler(this.tbPasswordRepeatFake_Enter);
			// 
			// tbPasswordFake
			// 
			this.tbPasswordFake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPasswordFake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.tbPasswordFake.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbPasswordFake.Location = new System.Drawing.Point(50, 220);
			this.tbPasswordFake.Margin = new System.Windows.Forms.Padding(0);
			this.tbPasswordFake.Multiline = true;
			this.tbPasswordFake.Name = "tbPasswordFake";
			this.tbPasswordFake.ReadOnly = true;
			this.tbPasswordFake.Size = new System.Drawing.Size(214, 40);
			this.tbPasswordFake.TabIndex = 4;
			this.tbPasswordFake.Enter += new System.EventHandler(this.tbPasswordFake_Enter);
			// 
			// tbLoginFake
			// 
			this.tbLoginFake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLoginFake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.tbLoginFake.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbLoginFake.Location = new System.Drawing.Point(50, 155);
			this.tbLoginFake.Margin = new System.Windows.Forms.Padding(0);
			this.tbLoginFake.Multiline = true;
			this.tbLoginFake.Name = "tbLoginFake";
			this.tbLoginFake.ReadOnly = true;
			this.tbLoginFake.Size = new System.Drawing.Size(214, 40);
			this.tbLoginFake.TabIndex = 3;
			this.tbLoginFake.Enter += new System.EventHandler(this.tbLoginFake_Enter);
			// 
			// tbLastnameFake
			// 
			this.tbLastnameFake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLastnameFake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.tbLastnameFake.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbLastnameFake.Location = new System.Drawing.Point(50, 90);
			this.tbLastnameFake.Margin = new System.Windows.Forms.Padding(0);
			this.tbLastnameFake.Multiline = true;
			this.tbLastnameFake.Name = "tbLastnameFake";
			this.tbLastnameFake.ReadOnly = true;
			this.tbLastnameFake.Size = new System.Drawing.Size(214, 40);
			this.tbLastnameFake.TabIndex = 2;
			this.tbLastnameFake.Enter += new System.EventHandler(this.tbLastnameFake_Enter);
			// 
			// tbNameFake
			// 
			this.tbNameFake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbNameFake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.tbNameFake.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbNameFake.Location = new System.Drawing.Point(50, 25);
			this.tbNameFake.Margin = new System.Windows.Forms.Padding(0);
			this.tbNameFake.Multiline = true;
			this.tbNameFake.Name = "tbNameFake";
			this.tbNameFake.ReadOnly = true;
			this.tbNameFake.Size = new System.Drawing.Size(214, 40);
			this.tbNameFake.TabIndex = 1;
			this.tbNameFake.Enter += new System.EventHandler(this.tbNameFake_Enter);
			// 
			// pnlTitle
			// 
			this.pnlTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlTitle.BackColor = System.Drawing.Color.Black;
			this.pnlTitle.Controls.Add(this.label1);
			this.pnlTitle.Location = new System.Drawing.Point(0, 0);
			this.pnlTitle.Margin = new System.Windows.Forms.Padding(0);
			this.pnlTitle.Name = "pnlTitle";
			this.pnlTitle.Size = new System.Drawing.Size(314, 50);
			this.pnlTitle.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(314, 50);
			this.label1.TabIndex = 0;
			this.label1.Text = "Регистрация";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormReg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 506);
			this.Controls.Add(this.pnlMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormReg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Регистрация";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReg_FormClosing);
			this.pnlMain.ResumeLayout(false);
			this.pnlForm.ResumeLayout(false);
			this.pnlForm.PerformLayout();
			this.pnlTitle.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel pnlForm;
		private System.Windows.Forms.TextBox tbNameFake;
		private System.Windows.Forms.TextBox tbPasswordRepeatFake;
		private System.Windows.Forms.TextBox tbPasswordFake;
		private System.Windows.Forms.TextBox tbLoginFake;
		private System.Windows.Forms.TextBox tbLastnameFake;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.LinkLabel lbllkAuth;
		private System.Windows.Forms.TextBox tbPasswordRepeat;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.TextBox tbLastname;
		private System.Windows.Forms.TextBox tbName;
	}
}