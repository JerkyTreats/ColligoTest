using System.Collections.Generic;

namespace ColligoTest
{
	public static class CalendarData
	{
		public static string Id = "id";
		public static string Name = "name";
		public static string Privacy = "privacy";
		public static string Smart = "smart";

		public static Dictionary<string, object> Calendars = new Dictionary<string, object>()
		{
			{Id, "CALENDAR-ID-TEST-001" },
			{Name, "CALENDAR-NAME-TEST-001" },
			{Privacy, 3 },
			{Smart, true }
		};
	}
}