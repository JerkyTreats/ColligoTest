using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colligo.REST
{
	/// <summary>
	/// Static tools to form queries and their parameters
	/// </summary>
	public static class QueryTools
	{
		static string _appender = "=";

		/// <summary>
		/// Returns a key=value string if value is not null
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string GetQueryParameter(string key, string value)
		{
			if (value == null)
				return null;
			return FormQueryParameter(key, value);
		}

		//Forms the acutal query parameter string
		static string FormQueryParameter(string key, string value)
		{
			return string.Format("{0}{1}{2}", key, _appender, value);
		}

		public static string GetQuery(List<IQueryParameter> parameters)
		{
			string formedString = Data.QueryBase;
			foreach (IQueryParameter parameter in parameters)
			{
				string value = parameter.GetQueryParameter();
				if (value != null)
					formedString += "&" + value;
			}
			return formedString;
		}
	}
}
