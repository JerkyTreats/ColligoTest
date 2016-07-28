using System.Collections.Generic;

namespace ColligoTest
{
	public static class TagData
	{
		public static string Id = "id";
		public static string Title = "title";
		public static string Owner = "owner";

		public static Dictionary<string, object> Tags = new Dictionary<string, object>()
		{
			{Id, "TAGS-ID-TEST-001" },
			{Title, "TAGS-TITLE-TEST-001" },
			{Owner, "TAGS-OWNER-TEST-001" }
		};

	}
}