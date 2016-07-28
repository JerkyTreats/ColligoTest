using System.Collections.Generic;

namespace ColligoTest
{
	public static class CommentsData
	{
		public static string Id = "id";
		public static string Text = "text" ;
		public static string Username = "username";
		public static string Time = "time";

		public static Dictionary<string, object> Comments = new Dictionary<string, object>()
		{
			{ Id, 123456789},
			{ Text, "This is a comment TEST comment"},
			{ Username, "JerkyTreats"},
			{ Time, "2015-01-13 14:08:55"}
		};
	}
}