using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkBela
{
	public partial class FormReg : Form
	{
		public static FormReg SelfForm { get; set; }

		public FormReg()
		{
			InitializeComponent();
			SelfForm = this;
		}

		private void tbNameFake_Enter(object sender, EventArgs e)
		{
			tbName.Focus();
		}

		private void tbLastnameFake_Enter(object sender, EventArgs e)
		{
			tbLastname.Focus();
		}

		private void tbLoginFake_Enter(object sender, EventArgs e)
		{
			tbLogin.Focus();
		}

		private void tbPasswordFake_Enter(object sender, EventArgs e)
		{
			tbPassword.Focus();
		}

		private void tbPasswordRepeatFake_Enter(object sender, EventArgs e)
		{
			tbPasswordRepeat.Focus();
		}

		private void tbName_Enter(object sender, EventArgs e)
		{
			if (tbName.ForeColor == Color.FromArgb(60, 60, 60))
			{
				tbName.Text = "";
				tbName.ForeColor = Color.Black;
			}
		}

		private void tbName_Leave(object sender, EventArgs e)
		{
			if (tbName.Text == "")
			{
				tbName.Text = "Имя";
				tbName.ForeColor = Color.FromArgb(60, 60, 60);
			}
		}

		private void tbLastname_Enter(object sender, EventArgs e)
		{
			if (tbLastname.ForeColor == Color.FromArgb(60, 60, 60))
			{
				tbLastname.Text = "";
				tbLastname.ForeColor = Color.Black;
			}
		}

		private void tbLastname_Leave(object sender, EventArgs e)
		{
			if (tbLastname.Text == "")
			{
				tbLastname.Text = "Фамилия";
				tbLastname.ForeColor = Color.FromArgb(60, 60, 60);
			}
		}

		private void tbLogin_Enter(object sender, EventArgs e)
		{
			if (tbLogin.ForeColor == Color.FromArgb(60, 60, 60))
			{
				tbLogin.Text = "";
				tbLogin.ForeColor = Color.Black;
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
				tbPassword.Text = "";
				tbPassword.ForeColor = Color.Black;
				tbPassword.UseSystemPasswordChar = true;
			}
		}

		private void tbPassword_Leave(object sender, EventArgs e)
		{
			if (tbPassword.Text == "")
			{
				tbPassword.Text = "Пароль";
				tbPassword.ForeColor = Color.FromArgb(60, 60, 60);
				tbPassword.UseSystemPasswordChar = false;
			}
		}

		private void tbPasswordRepeat_Enter(object sender, EventArgs e)
		{
			if (tbPasswordRepeat.ForeColor == Color.FromArgb(60, 60, 60))
			{
				tbPasswordRepeat.Text = "";
				tbPasswordRepeat.ForeColor = Color.Black;
				tbPasswordRepeat.UseSystemPasswordChar = true;
			}
		}

		private void tbPasswordRepeat_Leave(object sender, EventArgs e)
		{
			if (tbPasswordRepeat.Text == "")
			{
				tbPasswordRepeat.Text = "Повторный пароль";
				tbPasswordRepeat.ForeColor = Color.FromArgb(60, 60, 60);
				tbPasswordRepeat.UseSystemPasswordChar = false;
			}
		}

		private void tbName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				tbLastname.Focus();
		}

		private void tbLastname_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				tbLogin.Focus();
		}

		private void tbLogin_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				tbPassword.Focus();
		}

		private void tbPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				tbPasswordRepeat.Focus();
		}

		private void tbPasswordRepeat_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				Register();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			Register();
		}

		private void Register()
		{
#if !DEBUG
			if (tbName.Text.Length < 2)
			{
				MessageBox.Show("Вы ввели менее 2 символов своего имени", "Мало символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (tbName.Text.Length > 32)
			{
				MessageBox.Show("Вы ввели более 32 символов своего имени", "Много символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				string pattern = @"^[A-ЯЁ][а-яё]+$";

				if (!Regex.IsMatch(tbName.Text, pattern))
				{
					MessageBox.Show("У Вас введены не те символы своего имени. Пожалуйста, введите только русские буквы", "Неправильные символы", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			if (tbLastname.Text.Length < 2)
			{
				MessageBox.Show("Вы ввели менее 2 символов своей фамилии", "Мало символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (tbLastname.Text.Length > 32)
			{
				MessageBox.Show("Вы ввели более 32 символов своей фамилии", "Много символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				string pattern = @"^[A-ЯЁ][а-яё]+$";

				if (!Regex.IsMatch(tbLastname.Text, pattern))
				{
					MessageBox.Show("У Вас введены не те символы своей фамилии. Пожалуйста, введите только русские буквы", "Неправильные символы", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			if (tbLogin.Text.Length < 8)
			{
				MessageBox.Show("Вы ввели менее 8 символов своего логина", "Мало символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (tbLogin.Text.Length > 16)
			{
				MessageBox.Show("Вы ввели более 16 символов своего логина", "Много символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				string pattern = @"^[\w-[\d_А-Яа-я]][\w-[_]]{2,16}$";

				if (!Regex.IsMatch(tbLogin.Text, pattern))
				{
					MessageBox.Show("У Вас введены не те символы своего логина. Пожалуйста, введите только английские буквы и цифры", "Неправильные символы", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			if (tbPassword.Text.Length < 8)
			{
				MessageBox.Show("Вы ввели менее 8 символов своего пароля", "Мало символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (tbPassword.Text.Length > 64)
			{
				MessageBox.Show("Вы ввели более 64 символов своего пароля", "Много символов", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else if (tbPassword.Text != tbPasswordRepeat.Text)
			{
				MessageBox.Show("Пароли не совпадают. Пожалуйста, проверьте правильность пароля", "Пароли не совпадают", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			DB db = new DB();

			if (!db.Connect("museum_amnh"))
				return;

			if (ExistLogin(db))
			{
				MessageBox.Show("Логин уже занят, напишите другой логин", "Логин занят", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			MySqlCommand cmd = new MySqlCommand("INSERT INTO `accounts`(`login`, `password`, `name`, `lastname`) VALUES(@login, @password, @name, @lastname)");
			cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = EncodeString(tbLogin.Text);
			cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = EncodeString(tbPassword.Text);
			cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = tbName.Text;
			cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = tbLastname.Text;
			db.ExecuteCommand(cmd);

			MySqlCommand cmdId = new MySqlCommand("SELECT `id` FROM `accounts` WHERE `login` = @login");
			cmdId.Parameters.Add("@login", MySqlDbType.VarChar).Value = EncodeString(tbLogin.Text);
			int id = int.Parse(cmdId.ExecuteScalar().ToString());

			db.Disconnect();

			User.SignIn(id, tbName.Text, tbLastname.Text);
#else
			User.SignIn(0, "*Имя*", "*Фамилия*");
#endif

			Hide();
			FormMain.SelfForm.Show();
		}

		private bool ExistLogin(DB db)
		{
			MySqlCommand cmd = new MySqlCommand("SELECT * FROM `accounts` WHERE `login` = @login");
			cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = tbLogin.Text;
			DataTable table;

			try
			{
				table = db.Select(cmd);
			} 
			catch (MySqlException e)
			{
				if (e.Message == "Table 'museum_amnh.accounts' doesn't exist")
				{
					MySqlCommand cmdTable = new MySqlCommand("CREATE TABLE `accounts`(" +
						"`id` int(3) PRIMARY KEY AUTO_INCREMENT," +
						"`login` varchar(64)," +
						"`password` varchar(64)," +
						"`name` varchar(32)," +
						"`lastname` varchar(32)" +
						")"
					);
					db.ExecuteCommand(cmdTable);
					return false;
				}
				else
				{
					MessageBox.Show("Произошла ошибка над созданием таблицы базы данных", "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return true;
				}
			}

			if (table.Rows.Count > 0)
				return true;
			else
				return false;
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

		private void lbllkAuth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			FormLogin.SelfForm.Show();
			Hide();
		}

		private void FormReg_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
