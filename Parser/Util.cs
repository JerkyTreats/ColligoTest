using System.Text.RegularExpressions;

namespace Colligo.REST
{
	public static class Util
	{
		public static string RemoveWhitespace(string value)
		{
			if (value == null)
				return null;
			return Regex.Replace(value, @"\s+", "");
		}
	}
}
