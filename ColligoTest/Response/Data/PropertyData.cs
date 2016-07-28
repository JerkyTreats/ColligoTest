using System.Collections.Generic;

namespace ColligoTest
{
	public static class PropertyData
	{
		public static string Id = "id";
		public static string Name = "name";
		public static string Value = "value";

		public static Dictionary<string, object> Properties = new Dictionary<string, object>()
		{
			{Id, 123456789 },
			{Name, "PROPERTY-NAME-TEST-001" },
			{Value, "PROPERTY-VALUE-TEST-001" }
		};

	}
}