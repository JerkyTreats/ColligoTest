using System.Collections.Generic;
using System.Text;

namespace ColligoTest
{
	public static class SearchResponseJsonData
	{


		public static string totalItems = "total_items";
		public static string pageSize = "page_size";
		public static string pageCount = "page_count";
		public static string pageNumber = "page_number";
		public static string pageItems = "page_items";
		public static string firstItem = "first_item";
		public static string lastItem = "last_item";
		public static string searchTime = "search_time";

		public static Dictionary<string, object> SearchResponseData = new Dictionary<string, object>()
		{
			{totalItems, 10 },
			{pageSize, 10 },
			{pageCount, 10 },
			{pageNumber, 10 },
			{pageItems, 10 },
			{firstItem, 10 },
			{lastItem, 10 },
			{searchTime, 10.6f }
		};

		static string eventsPrefix = @"""events"" : { ""event"" : [";
		static string eventsSuffix = @"]}";

		public static string GetSearchResponseJson(int numberOfEvents)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append('{');
			foreach(KeyValuePair<string,object> KVP in SearchResponseData)
			{
				builder.Append(@"""" + KVP.Key + @""":""" + KVP.Value.ToString() + @""",");
			}
			builder.Append(GetEventJson(numberOfEvents));
			builder.Append('}');
			return builder.ToString();
		}

		public static string GetEventJson(int numberOfEvents)
		{
			StringBuilder builder = new StringBuilder(eventsPrefix);
			for (int i = 1; i<=numberOfEvents; i++)
			{
				builder.Append(EventJsonData.GetEventJson());
				if (i != numberOfEvents)
					builder.Append(',');
			}
			builder.Append(eventsSuffix);
			return builder.ToString();
		}
	}
}
