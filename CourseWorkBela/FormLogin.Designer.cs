namespace CourseWorkBela
{
	partial class FormLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.pnlMain = new System.Windows.Forms.Panel();
			this.pnlTitle = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.pnlForm = new System.Windows.Forms.Panel();
			this.tbLoginFake = new System.Windows.Forms.TextBox();
			this.tbPasswordFake = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.lbllkRegister = new System.Windows.Forms.LinkLabel();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.pnlMain.SuspendLayout();
			this.pnlTitle.SuspendLayout();
			this.pnlForm.SuspendLayout();
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
			this.pnlMain.Size = new System.Drawing.Size(314, 311);
			this.pnlMain.TabIndex = 0;
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
			this.pnlTitle.Size = new System.Drawing.Size(314, 50);
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
			this.lblTitle.Size = new System.Drawing.Size(314, 50);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Авторизация";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlForm
			// 
			this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlForm.Controls.Add(this.tbPassword);
			this.pnlForm.Controls.Add(this.tbLogin);
			this.pnlForm.Controls.Add(this.lbllkRegister);
			this.pnlForm.Controls.Add(this.btnLogin);
			this.pnlForm.Controls.Add(this.tbPasswordFake);
			this.pnlForm.Controls.Add(this.tbLoginFake);
			this.pnlForm.Location = new System.Drawing.Point(0, 50);
			this.pnlForm.Margin = new System.Windows.Forms.Padding(0);
			this.pnlForm.Name = "pnlForm";
			this.pnlForm.Size = new System.Drawing.Size(314, 260);
			this.pnlForm.TabIndex = 1;
			// 
			// tbLoginFake
			// 
			this.tbLoginFake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLoginFake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.tbLoginFake.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbLoginFake.Location = new System.Drawing.Point(50, 25);
			this.tbLoginFake.Margin = new System.Windows.Forms.Padding(0);
			this.tbLoginFake.Multiline = true;
			this.tbLoginFake.Name = "tbLoginFake";
			this.tbLoginFake.ReadOnly = true;
			this.tbLoginFake.Size = new System.Drawing.Size(214, 40);
			this.tbLoginFake.TabIndex = 0;
			this.tbLoginFake.Enter += new System.EventHandler(this.tbLoginFake_Enter);
			// 
			// tbPasswordFake
			// 
			this.tbPasswordFake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPasswordFake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.tbPasswordFake.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbPasswordFake.Location = new System.Drawing.Point(50, 90);
			this.tbPasswordFake.Margin = new System.Windows.Forms.Padding(0);
			this.tbPasswordFake.Multiline = true;
			this.tbPasswordFake.Name = "tbPasswordFake";
			this.tbPasswordFake.ReadOnly = true;
			this.tbPasswordFake.Size = new System.Drawing.Size(214, 40);
			this.tbPasswordFake.TabIndex = 1;
			this.tbPasswordFake.Enter += new System.EventHandler(this.tbPasswordFake_Enter);
			// 
			// btnLogin
			// 
			this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogin.BackColor = System.Drawing.Color.Black;
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(50, 155);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(214, 40);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Войти";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lbllkRegister
			// 
			this.lbllkRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.lbllkRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lbllkRegister.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbllkRegister.LinkColor = System.Drawing.Color.Black;
			this.lbllkRegister.Location = new System.Drawing.Point(50, 205);
			this.lbllkRegister.Margin = new System.Windows.Forms.Padding(0);
			this.lbllkRegister.Name = "lbllkRegister";
			this.lbllkRegister.Size = new System.Drawing.Size(214, 40);
			this.lbllkRegister.TabIndex = 3;
			this.lbllkRegister.TabStop = true;
			this.lbllkRegister.Text = "Зарегистрироваться";
			this.lbllkRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbllkRegister.VisitedLinkColor = System.Drawing.Color.Black;
			this.lbllkRegister.Click += new System.EventHandler(this.lbllkRegister_Click);
			// 
			// tbLogin
			// 
			this.tbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.tbLogin.Location = new System.Drawing.Point(55, 35);
			this.tbLogin.Margin = new System.Windows.Forms.Padding(0);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(204, 19);
			this.tbLogin.TabIndex = 4;
			this.tbLogin.Text = "Логин";
			this.tbLogin.Enter += new System.EventHandler(this.tbLogin_Enter);
			this.tbLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLogin_KeyDown);
			this.tbLogin.Leave += new System.EventHandler(this.tbLogin_Leave);
			// 
			// tbPassword
			// 
			this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
			this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.tbPassword.Location = new System.Drawing.Point(55, 100);
			this.tbPassword.Margin = new System.Windows.Forms.Padding(0);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(204, 19);
			this.tbPassword.TabIndex = 5;
			this.tbPassword.Text = "Пароль";
			this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
			this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
			this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 311);
			this.Controls.Add(this.pnlMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
			this.pnlMain.ResumeLayout(false);
			this.pnlTitle.ResumeLayout(false);
			this.pnlForm.ResumeLayout(false);
			this.pnlForm.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.Panel pnlTitle;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Panel pnlForm;
		private System.Windows.Forms.LinkLabel lbllkRegister;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox tbPasswordFake;
		private System.Windows.Forms.TextBox tbLoginFake;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.TextBox tbLogin;
	}
}