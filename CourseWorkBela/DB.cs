using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkBela
{
	public class DB
	{
		private MySqlConnection _connection;

		public bool Connect(string database)
		{
			_connection = new MySqlConnection($"server=localhost;port=3306;username=root;password=root;database={database}");

            if (_connection.State == ConnectionState.Closed)
            {
                try
                {
                    _connection.Open();
                }
                catch (MySqlException e)
                {
                    if (e.Message == "Unable to connect to any of the specified MySQL hosts")
                    {
                        MessageBox.Show("Подключение невозможно. Пожалуйста, запустите сервер для работы с базой данных", "Отключённый сервер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    else if (e.Message == $"Authentication to host 'localhost' for user 'root' using method 'mysql_native_password' failed with message: Unknown database '{database}'" && database == "museum_amnh")
                    {
			            _connection = new MySqlConnection($"server=localhost;port=3306;username=root;password=root;database=mysql");
                        _connection.Open();
                        MySqlCommand cmd = new MySqlCommand("CREATE DATABASE `museum_amnh`");
                        ExecuteCommand(cmd);
                        _connection.Close();
                        _connection = new MySqlConnection($"server=localhost;port=3306;username=root;password=root;database={database}");
                        
                        try
						{
                            _connection.Open();
                        }
                        catch (MySqlException)
						{
                            MessageBox.Show("Не удаётся подключиться к базе данных", "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
						}

                        return true;					
                    }
                    else
                    {
                        MessageBox.Show($"База данных была названа неверно или она не существует\n\nБД: {database}", "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
		}

        public void Disconnect()
        {
            if (_connection.State == ConnectionState.Open)
                _connection.Close();
        }

        public void ExecuteCommand(MySqlCommand cmd)
        {
            cmd.Connection = _connection;
            cmd.ExecuteNonQuery();
        }

        public DataTable Select(MySqlCommand cmd)
        {
            cmd.Connection = _connection;

            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            return dt;
        }
    }
}
