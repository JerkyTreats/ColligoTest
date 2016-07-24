
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
		public static string GetCategory(params string[] values)
		{
			if (values == null)
				return null;
			string value = FormCommaSeperatedString(values);
			return GetQueryElement(_category, value);
		}

		/// <summary>
		/// Forms the "Exclude Category" parameter
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static string GetExCategory(params string[] values)
		{
			if (values == null)
				return null;
			string value = FormCommaSeperatedString(values);
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
		public static string GetSortOrder(Sort.SortOrder order)
		{
			return FormQuery(_sortOrder, Sort.SortOrders[order]);
		}

		/// <summary>
		/// Forms the Sort Direction parameter
		/// </summary>
		/// <param name="direction"></param>
		/// <returns></returns>
		public static string GetSortDirection(Sort.SortDirection direction)
		{
			return FormQuery(_sortDirection, Sort.SortDirections[direction]);
		}

		/// <summary>
		/// Forms the parameter noting the number of results per page
		/// </summary>
		/// <param name="resultsPerPage"></param>
		/// <returns></returns>
		public static string GetPageSize(int resultsPerPage)
		{
			if (resultsPerPage == 0)
				return null;
			if (resultsPerPage > 100)
				resultsPerPage = 100;
			return GetQueryElement(_pageSize, resultsPerPage.ToString());
		}

		/// <summary>
		/// Forms the parameter to specify which page to return
		/// </summary>
		/// <param name="pageNumber"></param>
		/// <returns></returns>
		public static string GetPageNumber(int pageNumber)
		{
			if (pageNumber == 0)
				return null;
			return GetQueryElement(_pageNumber, pageNumber.ToString());
		}

		/// <summary>
		/// Forms the parameter to specify the languages to return
		/// </summary>
		/// <param name="language"></param>
		/// <returns></returns>
		public static string GetLanguages(string language)
		{
			return GetQueryElement(_languages, language);
		}

		/// <summary>
		/// Forms the parameter specifying safety filter level
		/// </summary>
		/// <param name="option"></param>
		/// <returns></returns>
		public static string GetMature(Mature.Types option)
		{
			return GetQueryElement(_mature, Mature.Options[option]);
		}
		
		/// <summary>
		/// Forms the parameter specifying additional optional sections should be included in the returned XML
		/// </summary>
		/// <param name="option"></param>
		/// <returns></returns>
		public static string GetInclude(params Include.Types[] options)
		{
			if (options == null)
				return null;

			string value = Include.Options[options[0]];
			for (int i = 1; i < options.Length; i++)
			{
				value += "," + Include.Options[options[i]];
			}
			return GetQueryElement(_include, value);
		}

		/// <summary>
		/// Forms the parameter specifying if the start_date of long duration events should be changed to ensure they are within search date parameter
		/// </summary>
		/// <returns></returns>
		public static string GetChangeMultiDayStart()
		{
			return _changeMultiDayStart;
		}

		//Common function to check the values of the query
		static string GetQueryElement(string key, string value)
		{
			if (value == null)
				return null;
			return FormQuery(key, value);
		}

		static string FormCommaSeperatedString(params string[] values)
		{
			string commaSeperatedValue = values[0];
			for(int i = 1; i<values.Length; i++)
			{
				commaSeperatedValue += "," + values[i];
			}
			return commaSeperatedValue;
		}

	//Forms the acutal query parameter string
	static string FormQuery(string key, string value)
		{
			return string.Format("{0}{1}{2}", key, _appender, value);
		}
	}
}
