using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CourseWorkBela.Type;

namespace CourseWorkBela
{
	public class Simulation
	{
		private bool _isWorking = false;
		private bool _skip = false;
		private Form _formParent;
		private List<Date> _listDates = new List<Date>();
		private int _countOfMonth;

		public int CountUser { get; private set; }

		public Simulation(Form formParent)
		{
			_formParent = formParent;

			GeneratorUsers.FillFull();
			_listDates = Date.GetListOfMonth();
			_countOfMonth = Date.GetCountOfMonth();
			CountUser = 1;
		}

		private void Loop()
		{
			while (_isWorking)
			{
				string name = GeneratorUsers.GetRandomName();
				string lastname = GeneratorUsers.GetRandomLastname();

				if (!_skip)
				{
					if (Submit(name, lastname))
						CountUser++;
					else
						Stop();
				}

				Thread.Sleep(1000);
			}
		}

		public void Start()
		{
			if (!_isWorking)
			{
				_isWorking = true;
				Task.Run(() => Loop());
			}
		}

		public void Stop()
		{
			if (_isWorking)
				_isWorking = false;
		}

		private bool Submit(string name, string lastname)
		{
			Random rand = new Random();

			if (_formParent is FormAnimals)
			{
				FormAnimals form = (FormAnimals)_formParent;
				DateTime date = _listDates[rand.Next(0, _countOfMonth)].DateTime;
				decimal price = 250.00m;
				int randType = rand.Next(0, 4);
				TypeTicket ticket;

				if (randType == 0)
				{
					ticket = TypeTicket.FreeVisit;
					price += 75.00m;
				}
				else if (randType == 1)
				{
					ticket = TypeTicket.Excursion;
					price += 50.00m;
				}
				else if (randType == 2)
				{
					ticket = TypeTicket.ForAdults;
					price += 100.00m;
				}
				else
					ticket = TypeTicket.ForChildrens;

				DB db = new DB();

				if (!db.Connect("museum_amnh"))
					return false;

				MySqlCommand cmd = new MySqlCommand("INSERT INTO `tickets`(`name`, `lastname`, `type`, `where`, `when`, `price`) VALUES(@name, @lastname, @type, @where, @when, @price)");
				cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
				cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
				cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = ticket;
				cmd.Parameters.Add("@where", MySqlDbType.VarChar).Value = TypeMuseum.Animal;
				cmd.Parameters.Add("@when", MySqlDbType.Date).Value = date.Date;
				cmd.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;

				if (!CheckTableTickets(db))
				{
					db.Disconnect();
					return false;
				}

				db.ExecuteCommand(cmd);
				db.Disconnect();

				string type;

				if (ticket == TypeTicket.FreeVisit)
					type = "на свободное посещение";
				else if (ticket == TypeTicket.Excursion)
					type = "на экскурсию по конкретным залам";
				else if (ticket == TypeTicket.ForAdults)
					type = "для взрослых";
				else if (ticket == TypeTicket.ForChildrens)
					type = "для детей";
				else
					type = "???";

				Label info = form.lblSimulationInfo;
				info.Invoke(new Action(() => info.Text = $"{CountUser}: {name} {lastname} купил(а) билет {type} в животный мир на {date.ToString("D")}. Стоимость: {price}"));
			} 
			else if (_formParent is FormArtifacts)
			{
				FormArtifacts form = (FormArtifacts)_formParent;
				DateTime date = _listDates[rand.Next(0, _countOfMonth)].DateTime;
				decimal price = 300.00m;
				int randType = rand.Next(0, 4);
				TypeTicket ticket;

				if (randType == 0)
				{
					ticket = TypeTicket.FreeVisit;
					price += 75.00m;
				}
				else if (randType == 1)
				{
					ticket = TypeTicket.Excursion;
					price += 50.00m;
				}
				else if (randType == 2)
				{
					ticket = TypeTicket.ForAdults;
					price += 100.00m;
				}
				else
					ticket = TypeTicket.ForChildrens;

				DB db = new DB();

				if (!db.Connect("museum_amnh"))
					return false;

				MySqlCommand cmd = new MySqlCommand("INSERT INTO `tickets`(`name`, `lastname`, `type`, `where`, `when`, `price`) VALUES(@name, @lastname, @type, @where, @when, @price)");
				cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
				cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
				cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = ticket;
				cmd.Parameters.Add("@where", MySqlDbType.VarChar).Value = TypeMuseum.Artifacts;
				cmd.Parameters.Add("@when", MySqlDbType.Date).Value = date.Date;
				cmd.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;

				if (!CheckTableTickets(db))
				{
					db.Disconnect();
					return false;
				}

				db.ExecuteCommand(cmd);
				db.Disconnect();

				string type;

				if (ticket == TypeTicket.FreeVisit)
					type = "на свободное посещение";
				else if (ticket == TypeTicket.Excursion)
					type = "на экскурсию по конкретным залам";
				else if (ticket == TypeTicket.ForAdults)
					type = "для взрослых";
				else if (ticket == TypeTicket.ForChildrens)
					type = "для детей";
				else
					type = "???";

				Label info = form.lblSimulationInfo;
				info.Invoke(new Action(() => info.Text = $"{CountUser}: {name} {lastname} купил(а) билет {type} для просмотра окаменелости и артефактов на {date.ToString("D")}. Стоимость: {price}"));
			}
			else if (_formParent is FormHistory)
			{
				FormHistory form = (FormHistory)_formParent;
				DateTime date = _listDates[rand.Next(0, _countOfMonth)].DateTime;
				decimal price = 200.00m;
				int randType = rand.Next(0, 4);
				TypeTicket ticket;

				if (randType == 0)
				{
					ticket = TypeTicket.FreeVisit;
					price += 75.00m;
				}
				else if (randType == 1)
				{
					ticket = TypeTicket.Excursion;
					price += 50.00m;
				}
				else if (randType == 2)
				{
					ticket = TypeTicket.ForAdults;
					price += 100.00m;
				}
				else
					ticket = TypeTicket.ForChildrens;

				DB db = new DB();

				if (!db.Connect("museum_amnh"))
					return false;

				MySqlCommand cmd = new MySqlCommand("INSERT INTO `tickets`(`name`, `lastname`, `type`, `where`, `when`, `price`) VALUES(@name, @lastname, @type, @where, @when, @price)");
				cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
				cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
				cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = ticket;
				cmd.Parameters.Add("@where", MySqlDbType.VarChar).Value = TypeMuseum.History;
				cmd.Parameters.Add("@when", MySqlDbType.Date).Value = date.Date;
				cmd.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;

				if (!CheckTableTickets(db))
				{
					db.Disconnect();
					return false;
				}

				db.ExecuteCommand(cmd);
				db.Disconnect();

				string type;

				if (ticket == TypeTicket.FreeVisit)
					type = "на свободное посещение";
				else if (ticket == TypeTicket.Excursion)
					type = "на экскурсию по конкретным залам";
				else if (ticket == TypeTicket.ForAdults)
					type = "для взрослых";
				else if (ticket == TypeTicket.ForChildrens)
					type = "для детей";
				else
					type = "???";

				Label info = form.lblSimulationInfo;
				info.Invoke(new Action(() => info.Text = $"{CountUser}: {name} {lastname} купил(а) билет {type} в историю культуры на {date.ToString("D")}. Стоимость: {price}"));
			}
			else
			{
				FormMain form = (FormMain)_formParent;
				DateTime date = _listDates[rand.Next(0, _countOfMonth)].DateTime;
				decimal price;
				int randType = rand.Next(0, 4);
				int randMuseum = rand.Next(0, 3);
				TypeTicket ticket;
				TypeMuseum museum;

				if (randMuseum == 0)
				{
					museum = TypeMuseum.Animal;
					price = 250.00m;
				}
				else if (randMuseum == 1)
				{
					museum = TypeMuseum.Artifacts;
					price = 300.00m;
				}
				else
				{
					museum = TypeMuseum.History;
					price = 200.00m;
				}

				if (randType == 0)
				{
					ticket = TypeTicket.FreeVisit;
					price += 75.00m;
				}
				else if (randType == 1)
				{
					ticket = TypeTicket.Excursion;
					price += 50.00m;
				}
				else if (randType == 2)
				{
					ticket = TypeTicket.ForAdults;
					price += 100.00m;
				}
				else
					ticket = TypeTicket.ForChildrens;

				DB db = new DB();

				if (!db.Connect("museum_amnh"))
					return false;

				MySqlCommand cmd = new MySqlCommand("INSERT INTO `tickets`(`name`, `lastname`, `type`, `where`, `when`, `price`) VALUES(@name, @lastname, @type, @where, @when, @price)");
				cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
				cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname;
				cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = ticket;
				cmd.Parameters.Add("@where", MySqlDbType.VarChar).Value = museum;
				cmd.Parameters.Add("@when", MySqlDbType.Date).Value = date.Date;
				cmd.Parameters.Add("@price", MySqlDbType.Decimal).Value = price;

				if (!CheckTableTickets(db))
				{
					db.Disconnect();
					return false;
				}

				db.ExecuteCommand(cmd);
				db.Disconnect();

				string type, smuseum;

				if (ticket == TypeTicket.FreeVisit)
					type = "на свободное посещение";
				else if (ticket == TypeTicket.Excursion)
					type = "на экскурсию по конкретным залам";
				else if (ticket == TypeTicket.ForAdults)
					type = "для взрослых";
				else if (ticket == TypeTicket.ForChildrens)
					type = "для детей";
				else
					type = "???";

				if (museum == TypeMuseum.Animal)
					smuseum = "в животный мир";
				else if (museum == TypeMuseum.Artifacts)
					smuseum = "для просмотра окаменелости и артефактов";
				else if (museum == TypeMuseum.History)
					smuseum = "в историю культуры";
				else
					smuseum = "???";

				Label info = form.lblSimulationInfo;
				info.Invoke(new Action(() => info.Text = $"{CountUser}: {name} {lastname} купил(а) билет {type} {smuseum} на {date.ToString("D")}. Стоимость: {price}"));
			}

			return true;
		}

		private bool CheckTableTickets(DB db)
		{
			MySqlCommand cmd = new MySqlCommand("SELECT `id` FROM `tickets` WHERE `id` = 1");
			DataTable table;

			try
			{
				table = db.Select(cmd);
			}
			catch (MySqlException e)
			{
				if (e.Message == "Table 'museum_amnh.tickets' doesn't exist")
				{
					_skip = true;

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

					_skip = false;
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
	}
}
