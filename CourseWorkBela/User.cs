using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkBela
{
	public class User
	{
		public static int ID { get; private set; }
		public static string Name { get; private set; }
		public static string Lastname { get; private set; }

		public static void SignIn(int id, string name, string lastname)
		{
			ID = id;
			Name = name;
			Lastname = lastname;
		}

		public static void Exit()
		{
			ID = 0;
			Name = null;
			Lastname = null;
		}
	}
}
