using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colligo.REST
{
	public static class QueryTools
	{
		static string _appender = "=";

		//Common function to check the values of the query
		public static string GetQuery(string key, string value)
		{
			if (value == null)
				return null;
			return FormQuery(key, value);
		}

		public static string FormCommaSeperatedString(params string[] values)
		{
			string commaSeperatedValue = values[0];
			for (int i = 1; i < values.Length; i++)
			{
				commaSeperatedValue += "," + values[i];
			}
			return commaSeperatedValue;
		}

		//Forms the acutal query parameter string
		public static string FormQuery(string key, string value)
		{
			return string.Format("{0}{1}{2}", key, _appender, value);
		}
	}
}
