using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkBela
{
	public partial class FormLogin : Form
	{
		public static FormLogin SelfForm { get; set; }

		public FormLogin()
		{
			InitializeComponent();
			SelfForm = this;
		}

		private void tbLoginFake_Enter(object sender, EventArgs e)
		{
			tbLogin.Focus();
		}

		private void tbPasswordFake_Enter(object sender, EventArgs e)
		{
			tbPassword.Focus();
		}

		private void tbLogin_Enter(object sender, EventArgs e)
		{
			if (tbLogin.ForeColor == Color.FromArgb(60, 60, 60))
			{
				tbLogin.ForeColor = Color.Black;
				tbLogin.Text = "";
			}
		}

		private void tbLogin_Leave(object sender, EventArgs e)
		{
			if (tbLogin.Text == "")
			{
				tbLogin.Text = "Логин";
				tbLogin.ForeColor = Color.FromArgb(60, 60, 60);
			}
		}

		private void tbPassword_Enter(object sender, EventArgs e)
		{
			if (tbPassword.ForeColor == Color.FromArgb(60, 60, 60))
			{
				tbPassword.ForeColor = Color.Black;
				tbPassword.Text = "";
				tbPassword.UseSystemPasswordChar = true;
			}
		}

		private void tbPassword_Leave(object sender, EventArgs e)
		{
			if (tbPassword.Text == "")
			{
				tbPassword.ForeColor = Color.FromArgb(60, 60, 60);
				tbPassword.Text = "Пароль";
				tbPassword.UseSystemPasswordChar = false;
			}
		}

		private void tbLogin_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				tbPassword.Focus();
		}

		private void tbPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				Auth();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Auth();
		}

		private void Auth()
		{
#if !DEBUG
			DB db = new DB();

			if (!db.Connect("museum_amnh"))
				return;

			MySqlCommand cmd = new MySqlCommand("SELECT `id`, `name`, `lastname` FROM `accounts` WHERE `login` = @login AND `password` = @password");
			cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = EncodeString(tbLogin.Text);
			cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = EncodeString(tbPassword.Text);
			DataTable table = db.Select(cmd);

			if (table.Rows.Count <= 0)
			{
				MessageBox.Show("Вы ввели неверный логин или пароль", "Неверный логин или пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
				db.Disconnect();
				return;
			}

			MySqlDataReader reader = cmd.ExecuteReader();

			while (reader.Read())
			{
				int id = int.Parse(reader[0].ToString());
				string name = reader[1].ToString();
				string lastname = reader[2].ToString();

				User.SignIn(id, name, lastname);
			}
			reader.Close();

			db.Disconnect();
#else
			User.SignIn(0, "*Имя*", "*Фамилия*");
#endif

			Hide();
			FormMain.SelfForm.Show();
		}

		private string EncodeString(string original)
		{
			using (SHA256 hash = SHA256.Create())
			{
				byte[] bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(original));

				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < bytes.Length; i++)
					sb.Append(bytes[i].ToString("x2"));

				return sb.ToString();
			}
		}

		private void lbllkRegister_Click(object sender, EventArgs e)
		{
			FormReg.SelfForm.Show();
			Hide();
		}

		private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
