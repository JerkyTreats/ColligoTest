using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colligo.REST
{
	public static class Get
	{
		static string _appender = "=";
		static string _id = "id";
		static string _imageSizes = "image_sizes";

		public static string GetId(string value)
		{
			if (value == null)
				return null;
			return string.Format("{0}{1}{2}", _id, _appender, value);
		}
	}
}
