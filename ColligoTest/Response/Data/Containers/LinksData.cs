using System.Collections.Generic;

namespace ColligoTest
{
	public static class LinksData
	{
		public static string Id = "id";
		public static string Url = "url";
		public static string Type = "type";
		public static string Description = "description";
		public static string Username = "username";
		public static string Time = "time";

		public static Dictionary<string, object> Links = new Dictionary<string, object>()
		{
			{Id, 12345679 },
			{Url, "https://github.com/jerkytreats" },
			{Type, "LINK-TEST-TYPE" },
			{Description, "This is a test description for the Links response class" },
			{Username, "JerkyTreats" },
			{Time, "2015-01-13 14:08:55" }
		};
	}
}