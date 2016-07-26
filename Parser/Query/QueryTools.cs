using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colligo.REST.Query
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

		public static string GetQuery(string queryType, List<IQueryParameter> parameters)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append(Data.URL);
			builder.Append('/');
			builder.Append(queryType);
			builder.Append('?');
			builder.Append(Data.Key);

			foreach (IQueryParameter parameter in parameters)
			{
				string value = parameter.GetQueryParameter();
				if (value != null)
					builder.Append("&" + value);
			}
			return builder.ToString();
		}
	}
}
