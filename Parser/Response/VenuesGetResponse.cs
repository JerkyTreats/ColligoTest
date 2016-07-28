using Newtonsoft.Json;

namespace Colligo.REST.Response
{
	public class VenuesGetResponse
	{
		[JsonProperty(PropertyName = "id")]
		public string Id;

		[JsonProperty(PropertyName = "url")]
		public string Url;

		[JsonProperty(PropertyName = "name")]
		public string Name;

		[JsonProperty(PropertyName = "description")]
		public string Description;

		[JsonProperty(PropertyName = "venue_type")]
		public string VenueType;

		[JsonProperty(PropertyName = "venue_display")]
		public int VenueDisplay;

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

		[JsonProperty(PropertyName = "owner")]
		public string Owner;

		[JsonProperty(PropertyName = "free")]
		public string Free; //0 = true, 1 = false, blank = unknown

		[JsonProperty(PropertyName = "price")]
		public string Price;

		[JsonProperty(PropertyName = "withdrawn")]
		public int Withdrawn;

		[JsonProperty(PropertyName = "withdrawn_note")]
		public string WithdrawnNote;

		[JsonProperty(PropertyName = "parents")]
		public ParentContainer Parents;

		[JsonProperty(PropertyName = "children")]
		public ChildrenContainer Children;

		[JsonProperty(PropertyName = "events")]
		public EventCollection Events;

		[JsonProperty(PropertyName = "links")]
		public LinkContainer LinkContainer;

		[JsonProperty(PropertyName = "comments")]
		public CommentContainer CommentContainer;

		[JsonProperty(PropertyName = "trackbacks")]
		public TrackbackContainer Trackbacks;

		[JsonProperty(PropertyName = "images")]
		public ImageContainer Images;

		[JsonProperty(PropertyName = "tags")]
		public TagContainer Tags;

		[JsonProperty(PropertyName = "properties")]
		public PropertyContainer PropertyContainer;
	}
}
