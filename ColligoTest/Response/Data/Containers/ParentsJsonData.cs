using System.Collections.Generic;
using System.Text;

namespace ColligoTest
{
	public static class ParentsJsonData
	{
		public static string Id = "id";
		public static string Title = "title";

		public static Dictionary<string, object> ParentsData = new Dictionary<string, object>()
		{
			{ Id, "ID-TEST-001" },
			{ Title, "Parent Title" }
		};
	}
}
