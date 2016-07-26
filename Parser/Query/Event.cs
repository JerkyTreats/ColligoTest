using Newtonsoft.Json;

namespace Colligo.REST
{
	public class Event
	{
		[JsonProperty(PropertyName = "id")]
		public string Id;

		[JsonProperty(PropertyName = "url")]
		public string Url;

		[JsonProperty(PropertyName = "title")]
		public string Title;

		[JsonProperty(PropertyName = "description")]
		public string Description;

		[JsonProperty(PropertyName = "start_time")]
		public string StartTime;

		[JsonProperty(PropertyName = "stop_time")]
		public string StopTime;

		[JsonProperty(PropertyName = "venue_id")]
		public string VenueId;

		[JsonProperty(PropertyName = "venue_url")]
		public string VenueUrl;

		[JsonProperty(PropertyName = "venue_name")]
		public string VenueName;

		[JsonProperty(PropertyName = "venue_display")]
		public string VenueDisplay;

		[JsonProperty(PropertyName = "venue_address")]
		public string VenueAddress;

		[JsonProperty(PropertyName = "city_name")]
		public string CityName;

		[JsonProperty(PropertyName = "region_name")]
		public string RegionName;

		[JsonProperty(PropertyName = "region_abbr")]
		public string RegionAbbreviation;

		[JsonProperty(PropertyName = "postal_code")]
		public string PostalCode;

		[JsonProperty(PropertyName = "country_name")]
		public string CountryName;

		[JsonProperty(PropertyName = "all_day")]
		public int AllDay;

		[JsonProperty(PropertyName = "latitude")]
		public float Latitude;

		[JsonProperty(PropertyName = "longitude")]
		public float Longitude;

		[JsonProperty(PropertyName = "geocode_type")]
		public string GeocodeType;

		[JsonProperty(PropertyName = "trackback_count")]
		public int TrackbackCount;

		[JsonProperty(PropertyName = "calendar_count")]
		public int CalendarCount;

		[JsonProperty(PropertyName = "comment_count")]
		public int CommentCount;

		[JsonProperty(PropertyName = "link_count")]
		public int LinkCount;

		[JsonProperty(PropertyName = "created")]
		public string Created;

		[JsonProperty(PropertyName = "owner")]
		public string Owner;

		[JsonProperty(PropertyName = "modified")]
		public string Modified;


	}
}
