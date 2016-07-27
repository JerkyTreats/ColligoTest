using System.Collections.Generic;

namespace ColligoTest.Response
{
	public static class ChildrenData
	{
		public static string Id = "id";
		public static string Title = "title";

		public static Dictionary<string, object> Children = new Dictionary<string, object>()
		{
			{Id, "CHILD-ID-TEST-001" },
			{Title, "CHILD-TITLE-TEST-001" }
		};
	}
}