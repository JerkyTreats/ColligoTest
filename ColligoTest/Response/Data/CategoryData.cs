using System.Collections.Generic;

namespace ColligoTest
{
	public static class CategoryData
	{
		public static string Id = "id";
		public static string Name = "name";

		public static Dictionary<string, object> Categories = new Dictionary<string, object>()
		{
			{Id, "CATEGORY-ID-TEST-001" },
			{Name, "CATEGORY-NAME-TEST-001" }
		};
	}
}