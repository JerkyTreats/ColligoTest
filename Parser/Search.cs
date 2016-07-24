using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colligo.REST
{
	public static class Search
	{
		static string _appender = "=";

		static string _keywords = "keywords";
		static string _location = "location";
		static string _within = "within";
		static string _units = "units";
		static string _date = "date";
		static string _category = "category";
		static string _exCategory = "ex_category";
		static string _countOnly = "count_only";
		static string _sortOrder = "sort_order";
		static string _sortDirection = "sort_direction";
		static string _pageSize = "page_size";
		static string _pageNumber = "page_number";
		static string _imageSizes = "_imageSizes";
		static string _languages = "languages";
		static string _mature = "mature";
		static string _include = "include";
		static string _changeMultiDayStart = "change_multi_day_start";

		public static string GetKeyWords(string value)
		{
			return GetQueryElement(_keywords, value);
		}

		public static string GetLocation(string value)
		{
			return GetQueryElement(_location, value);
		}

		public static string GetWithin(string value)
		{
			return GetQueryElement(_within, value);
		}

		public static string GetUnits(string value)
		{
			return GetQueryElement(_units, value);
		}

		static string GetQueryElement(string key, string value)
		{
			if (value == null)
				return null;
			return string.Format("{0}{1}{2}", key, _appender, value);
		}

	}
}
