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

		//Move this into a SortOrder class that Search will reference
		public enum SortOrder { popularity, date, relevance  }
		static Dictionary<SortOrder, string> SortOrders = new Dictionary<SortOrder, string>()
		{
			{ SortOrder.popularity, "popularity" },
			{ SortOrder.date, "date" },
			{ SortOrder.relevance, "relevance" }
		};

		/// <summary>
		/// Forms the keywords parameter
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string GetKeyWords(string value)
		{
			return GetQueryElement(_keywords, value);
		}

		/// <summary>
		/// Forms the Location parameter
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string GetLocation(string value)
		{
			return GetQueryElement(_location, value);
		}

		/// <summary>
		/// Forms the Within parameter
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string GetWithin(int value)
		{
			if (value == 0)
				return null;
			return GetQueryElement(_within, value.ToString());
		}

		/// <summary>
		/// Forms the Units parameter
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string GetUnits(string value)
		{
			return GetQueryElement(_units, value);
		}

		/// <summary>
		/// Forms the Data parameter
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string GetDate(string value)
		{
			return GetQueryElement(_date, value);
		}

		/// <summary>
		/// Forms the Category parameter
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string GetCategory(string value)
		{
			return GetQueryElement(_category, value);
		}

		/// <summary>
		/// Forms the "Exclude Category" parameter
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string GetExCategory(string value)
		{
			return GetQueryElement(_exCategory, value);
		}

		/// <summary>
		/// Forms the Count_Only parameter
		/// </summary>
		/// <returns></returns>
		public static string GetCountOnly()
		{
			return _countOnly;
		}

		/// <summary>
		/// Forms the Sort_Order parameter
		/// </summary>
		/// <param name="order"></param>
		/// <returns></returns>
		public static string GetSortOrder(SortOrder order)
		{
			return string.Format("{0}{1}{2}", _sortOrder, _appender, SortOrders[order]);
		}




		//Common function to form the actual query
		static string GetQueryElement(string key, string value)
		{
			if (value == null)
				return null;
			return string.Format("{0}{1}{2}", key, _appender, value);
		}
	}
}
