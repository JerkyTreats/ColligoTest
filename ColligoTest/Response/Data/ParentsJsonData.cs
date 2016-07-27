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

		public static string GetParentsJson()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append(@"""parents"" : [{");

			int counter = 1;
			foreach (KeyValuePair<string, object> KVP in ParentsData)
			{
				builder.Append(@"""" + KVP.Key + @""" : """ + KVP.Value + @"""");
				if (counter != ParentsData.Count)
					builder.Append(",");
				counter++;
			}
			builder.Append("}]");
			return builder.ToString();
		}
	}
}
