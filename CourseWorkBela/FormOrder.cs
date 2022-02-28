using MySql.Data.MySqlClient;
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
	public partial class FormOrder : Form
	{
		private List<Date> _listDates = new List<Date>();
		private decimal _price;

		public TypeMuseum Museum { get; private set; }
		public TypeTicket Ticket { get; private set; }

		public FormOrder(TypeMuseum type)
		{
			InitializeComponent();

			Museum = type;
			Ticket = TypeTicket.Null;
		}

		private void FormOrder_Shown(object sender, EventArgs e)
		{
			cbTypeTicket.SelectedIndex = 0;
			cbWhen.SelectedIndex = 0;
			Ticket = TypeTicket.Null;

			lblUser.Text = $"Вы: {User.Name} {User.Lastname}";

			_listDates = Date.GetListOfMonth();

			for (int i = 1; i <= Date.GetCountOfMonth(); i++)
			{
				Date date = _listDates[i - 1];
				string sDateForUser = date.DateTime.ToString("D");
				cbWhen.Items.Add(sDateForUser);
			}

			Recalc();
		}

		private void cbTypeTicket_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbTypeTicket.SelectedIndex == 0)
				Ticket = TypeTicket.Null;
			else if (cbTypeTicket.SelectedIndex == 1)
				Ticket = TypeTicket.FreeVisit;
			else if (cbTypeTicket.SelectedIndex == 2)
				Ticket = TypeTicket.Excursion;
			else if (cbTypeTicket.SelectedIndex == 3)
				Ticket = TypeTicket.ForAdults;
			else
				Ticket = TypeTicket.ForChildrens;

			Recalc();
		}

		private void btnOrder_Click(object sender, EventArgs e)
		{
			if (cbTypeTicket.SelectedIndex == 0)
			{
				MessageBox.Show("Выберите вид билета", "Не выбран вид билета", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			else if (cbWhen.SelectedIndex == 0)
			{
				MessageBox.Show("Выберите дату посещения", "Не выбрана дата", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			DB db = new DB();

			if (!db.Connect("museum_amnh"))
				return;

			if (!CheckTableTickets(db))
			{
				db.Disconnect();
				return;
			}

			int numberWhen = cbWhen.SelectedIndex;
			DateTime date = _listDates[numberWhen - 1].DateTime.Date;
			
			MySqlCommand cmd = new MySqlCommand("INSERT INTO `tickets`(`name`, `lastname`, `type`, `where`, `when`, `price`) VALUES(@name, @lastname, @type, @where, @when, @price)");
			cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = User.Name;
			cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = User.Lastname;
			cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = Ticket;
			cmd.Parameters.Add("@where", MySqlDbType.VarChar).Value = Museum;
			cmd.Parameters.Add("@when", MySqlDbType.Date).Value = date;
			cmd.Parameters.Add("@price", MySqlDbType.Decimal).Value = _price;

			db.ExecuteCommand(cmd);
			db.Disconnect();

			string type, museum;

			if (Ticket == TypeTicket.FreeVisit)
				type = "на свободное посещение";
			else if (Ticket == TypeTicket.Excursion)
				type = "на экскурсию по конкретным залам";
			else if (Ticket == TypeTicket.ForAdults)
				type = "для взрослых";
			else if (Ticket == TypeTicket.ForChildrens)
				type = "для детей";
			else
				type = "???";

			if (Museum == TypeMuseum.Animal)
				museum = "в животный мир";
			else if (Museum == TypeMuseum.Artifacts)
				museum = "для просмотра окаменелости и артефактов";
			else if (Museum == TypeMuseum.History)
				museum = "в историю культуры";
			else
				museum = "???";

			MessageBox.Show($"Вы успешно купили билет {type} {museum} на {date.ToString("D")}\n\nСтоимость билета: {_price} руб.", "Покупка билета", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private bool CheckTableTickets(DB db)
		{
			MySqlCommand cmd = new MySqlCommand("SELECT * FROM `tickets`");
			DataTable table;

			try
			{
				table = db.Select(cmd);
			}
			catch (MySqlException e)
			{
				if (e.Message == "Table 'museum_amnh.tickets' doesn't exist")
				{
					MySqlCommand cmdCreate = new MySqlCommand("CREATE TABLE `tickets` (" +
						"`id` int(6) PRIMARY KEY AUTO_INCREMENT," +
						"`name` varchar(32)," +
						"`lastname` varchar(32)," +
						"`type` varchar(16)," +
						"`where` varchar(16)," +
						"`when` date," +
						"`price` decimal(10, 2)" +
						")"
					);
					db.ExecuteCommand(cmdCreate);
					return true;
				}
				else
				{
					MessageBox.Show("Произошла ошибка над созданием таблицы базы данных", "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}

			return true;
		}

		private void Recalc()
		{
			decimal temp;
			if (Museum == TypeMuseum.Animal)
				temp = 250.00m;
			else if (Museum == TypeMuseum.Artifacts)
				temp = 300.00m;
			else if (Museum == TypeMuseum.History)
				temp = 200.00m;
			else
				temp = 0.00m;

			if (Ticket == TypeTicket.FreeVisit)
				temp += 75.00m;
			else if (Ticket == TypeTicket.Excursion)
				temp += 50.00m;
			else if (Ticket == TypeTicket.ForAdults)
				temp += 100.00m;
			else
				temp += 0.00m;

			_price = temp;

			btnOrder.Text = $"{_price} руб.";
		}
	}
}
