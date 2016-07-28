using System.Collections.Generic;

namespace ColligoTest
{
	public static class ImageData
	{
		public static string Id = "id";
		public static string Url = "url";
		public static string Width = "width";
		public static string Height = "height";
		public static string Caption = "caption";

		public static Dictionary<string, object> Images = new Dictionary<string, object>()
		{
			{Id, 123456789 },
			{Url, "https://github.com/jerkytreats" },
			{Width, 50 },
			{Height, 50 },
			{Caption, @"Sensei Gichin Funakoshi performing Migari Kiagi, or front snap kick " }
		};

	}
}