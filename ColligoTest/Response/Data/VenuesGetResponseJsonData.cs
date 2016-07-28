using System.Collections.Generic;
using System.Text;

namespace ColligoTest
{
	public static class VenuesGetResponseJsonData
	{
		public static string Id = "id";
		public static string Url = "url";
		public static string Name = "name";
		public static string Description = "description";
		public static string VenueType = "venue_type";
		public static string VenueDisplay = "venue_display";
		public static string Address = "address";
		public static string City = "city";
		public static string Region = "region";
		public static string PostalCode = "postal_code";
		public static string Country = "country";
		public static string Latitude = "latitude";
		public static string Longitute = "longitude";
		public static string GeocodeType = "geocode_type";
		public static string Created = "created";
		public static string Owner = "owner";
		public static string Free = "free"; //0 = true, 1 = false, blank = unknown
		public static string Price = "price";
		public static string Withdrawn = "withdrawn";
		public static string WithdrawnNote = "withdrawn_note";

		public static Dictionary<string, object> ResponseData = new Dictionary<string, object>()
		{
			{Id, "VENUESGET-ID-TEST-001" },
			{Url, "VENUESGET-URL-TEST-001" },
			{Name, "VENUESGET-NAME-TEST-001" },
			{Description, "VENUESGET-DESCRIPTION-TEST-001" },
			{VenueType, "VENUESGET-VENUE_TYPE-TEST-001" },
			{VenueDisplay, 1 },
			{Address, "VENUESGET-ADDRESS-TEST-001" },
			{City, "VENUESGET-CITY-TEST-001" },
			{Region, "VENUESGET-REGION-TEST-001" },
			{PostalCode, "VENUESGET-POSTAL_CODE-TEST-001" },
			{Country, "VENUESGET-COUNTRY-TEST-001" },
			{Latitude, 35.345f },
			{Longitute, -110.567f },
			{GeocodeType, "VENUESGET-GEOCODE_TYPE-TEST-001" },
			{Created, "VENUESGET-CREATED-TEST-001" },
			{Owner, "VENUESGET-OWNER-TEST-001" },
			{Free, "VENUESGET-FREE-TEST-001" },
			{Price, "VENUESGET-PRICE-TEST-001" },
			{Withdrawn, 1 },
			{WithdrawnNote, "VENUESGET-WITHDRAWN_NOTE-TEST-001" }
		};

		public static string GetJson()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append('{');

			foreach (KeyValuePair<string, object> KVP in ResponseData)
			{
				builder.Append(@"""" + KVP.Key + @""" : """ + KVP.Value + @""",");
			}
			builder.Append(JsonBuilder.GetJson("parents", "parent", ParentsJsonData.ParentsData) + ',');
			builder.Append(JsonBuilder.GetJson("children", "child", ChildrenData.Children) + ',');
			builder.Append(JsonBuilder.GetJson("events", "event", EventJsonData.EventData) + ',');
			builder.Append(JsonBuilder.GetJson("links","link", LinksData.Links) + ',');
			builder.Append(JsonBuilder.GetJson("comments", "comment", CommentsData.Comments) + ',');
			builder.Append(JsonBuilder.GetJson("trackbacks", "trackback", TrackbacksData.Trackbacks) + ',');
			builder.Append(JsonBuilder.GetJson("images", "image", ImageData.Images) + ',');
			builder.Append(JsonBuilder.GetJson("tags", "tag", TagData.Tags) + ',');
			builder.Append(JsonBuilder.GetJson("properties", "property", PropertyData.Properties));
			builder.Append('}');
			return builder.ToString();
		}
	}
}