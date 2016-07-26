using Newtonsoft.Json;
using System.Collections.Generic;

namespace Colligo.REST
{
	public class SearchResponse
	{
		[JsonProperty(PropertyName = "total_items")]
		public int TotalItems;

		[JsonProperty(PropertyName = "page_size")]
		public int PageSize;

		[JsonProperty(PropertyName = "page_count")]
		public int PageCount;

		[JsonProperty(PropertyName = "page_number")]
		public int CurrentPageNumber;

		[JsonProperty(PropertyName = "page_items")]
		public int PageItems;

		[JsonProperty(PropertyName = "first_item")]
		public int FirstItem;

		[JsonProperty(PropertyName = "last_item")]
		public int LastItem;

		[JsonProperty(PropertyName = "search_time")]
		public float SearchTime;

		[JsonProperty(PropertyName = "events")]
		public EventCollection Events;

	}
}
