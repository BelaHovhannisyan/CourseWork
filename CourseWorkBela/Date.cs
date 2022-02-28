using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkBela
{
	public class Date
	{
		public int Number { get; set; }
		public string StringDate { get; set; }
		public DateTime DateTime { get; set; }

		public Date(int number, string sDate, DateTime dtDate)
		{
			Number = number;
			StringDate = sDate;
			DateTime = dtDate;
		}

		public static List<Date> GetListOfMonth()
		{
			List<Date> list = new List<Date>();
			DateTime dateTime = new DateTime(DateTime.Today.Ticks);
			int year = dateTime.Year;
			int month = dateTime.Month;
			int countOfMonth = DateTime.DaysInMonth(year, month);

			for (int i = 1; i <= countOfMonth; i++)
			{
				string sDate = dateTime.ToString("yyyy-MM-dd");
				Date date = new Date(i, sDate, dateTime);
				list.Add(date);

				dateTime = dateTime.AddDays(1);
			}

			return list;
		}

		public static int GetCountOfMonth()
		{
			DateTime dateTime = new DateTime(DateTime.Today.Ticks);
			int year = dateTime.Year;
			int month = dateTime.Month;
			int countOfMonth = DateTime.DaysInMonth(year, month);

			return countOfMonth;
		}
	}
}
