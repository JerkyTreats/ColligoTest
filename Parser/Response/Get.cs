using Newtonsoft.Json;

namespace Colligo.REST.Response
{
	/// <summary>
	/// Response object deserialized from the GET API call;
	/// </summary>
	public class Get : ResponseData
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

		[JsonProperty(PropertyName = "all_day")]
		public bool AllDay;

		[JsonProperty(PropertyName = "tz_id")]
		public int TzId;

		[JsonProperty(PropertyName = "tz_olsen_path")]
		public string TzOlsenPath;

		[JsonProperty(PropertyName = "tz_city")]
		public string TzCity;

		[JsonProperty(PropertyName = "tz_country")]
		public string TzCountry;

		[JsonProperty(PropertyName = "venue_name")]
		public string VenueName;

		[JsonProperty(PropertyName = "venue_id")]
		public string VenueId;

		[JsonProperty(PropertyName = "venue_type")]
		public string VenueType;

		[JsonProperty(PropertyName = "venue_display")]
		public bool VenueDisplay;

		[JsonProperty(PropertyName = "address")]
		public string Address;

		[JsonProperty(PropertyName = "city")]
		public string City;

		[JsonProperty(PropertyName = "region")]
		public string Region;

		[JsonProperty(PropertyName = "postal_code")]
		public string PostalCode;

		[JsonProperty(PropertyName = "country")]
		public string Country;

		[JsonProperty(PropertyName = "latitude")]
		public float Latitude;

		[JsonProperty(PropertyName = "longitude")]
		public float Longitute;

		[JsonProperty(PropertyName = "geocode_type")]
		public string GeocodeType;

		[JsonProperty(PropertyName = "created")]
		public string Created;

		[JsonProperty(PropertyName = "modified")]
		public string Modified;

		[JsonProperty(PropertyName = "owner")]
		public string Owner;

		[JsonProperty(PropertyName = "privacy")]
		public int Privacy;

		[JsonProperty(PropertyName = "free")]
		public bool Free;

		[JsonProperty(PropertyName = "price")]
		public string Price;

		[JsonProperty(PropertyName = "withdrawn")]
		public bool Withdrawn;

		[JsonProperty(PropertyName = "withdrawn_note")]
		public string WithdrawnNote;

	}
}
