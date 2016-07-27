using Colligo.REST.Response;
using System.Collections.Generic;
using System.Text;

namespace ColligoTest.Response
{
	public static class GetResponseJsonData
	{
		public static string Id = "id";
		public static string Url = "url";
		public static string Title = "title";
		public static string Description = "description";
		public static string StartTime = "start_time";
		public static string StopTime = "stop_time";
		public static string AllDay = "all_day";
		public static string TzId = "tz_id";
		public static string TzOlsenPath = "tz_olsen_path";
		public static string TzCity = "tz_city";
		public static string TzCountry = "tz_country";
		public static string VenueName = "venue_name";
		public static string VenueId = "venue_id";
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
		public static string Modified = "modified";
		public static string Owner = "owner";
		public static string Privacy = "privacy";
		public static string Free = "free";
		public static string Price = "price";
		public static string Withdrawn = "withdrawn";
		public static string WithdrawnNote = "withdrawn_note";
		public static string Parents = "parents";
		public static string Children = "children";
		public static string LinkContainer = "link_container";
		public static string CommentContainer = "comment_container";
		public static string Trackbacks = "trackbacks";
		public static string Images = "images";
		public static string Tags = "tags";
		public static string Calendars = "calendars";
		public static string Going = "going";
		public static string PropertyContainer = "property_container";
		public static string CategoryContainer= "category_container";

		public static Dictionary<string, object> GetResponseData = new Dictionary<string, object>()
		{
			{ Id, "E0-001-000278174-6" },
			{ Url, "https://github.com/jerkytreats" },
			{ Title, "Test Title" },
			{ Description, "This is a short description that could probably be very very long indeed." },
			{ StartTime, "2005-08-24 12:00:00" },
			{ StopTime, "2005-08-24 23:59:59" },
			{ AllDay, 1 },
			{ TzId, "TZ-001-TEST" },
			{ TzOlsenPath, "OLSEN PATH TEST" },
			{ TzCity, "Fakesville" },
			{ TzCountry, "Fakeland" },
			{ VenueName, "The Code Hole" },
			{ VenueId, "V0-001-000108360-1" },
			{ VenueType, "Venue Type Test" },
			{ VenueDisplay, 1 },
			{ Address, "123 Fake St." },
			{ City, "Fakesville" },
			{ Region, "New Fakesville" },
			{ PostalCode, "F4K3R5" },
			{ Country, "Fakeland" },
			{ Latitude, 35.234f },
			{ Longitute, -110.987f },
			{ GeocodeType, "Geocode City Type" },
			{ Created, "2005-07-28 13:09:09" },
			{ Modified, "2005-07-28 13:09:10" },
			{ Owner, "Dr. Jackson Katabatak, PhD" },
			{ Privacy, 1 },
			{ Free, 1 },
			{ Price, "19.99" },
			{ Withdrawn, 1 },
			{ WithdrawnNote, "Withdrawn due to testing requirements" }
		};

		public static string GetJson()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append('{');

			foreach(KeyValuePair<string,object> KVP in GetResponseData)
			{
				builder.Append(@"""" + KVP.Key + @""" : """ + KVP.Value + @""",");
			}
			builder.Append(JsonBuilder.GetJson("parents","parent", ParentsJsonData.ParentsData) + ',');
			builder.Append(JsonBuilder.GetJson("children", "child", ChildrenData.Children) + ',');
			builder.Append(JsonBuilder.GetJson("links","link", LinksData.Links) + ',');
			builder.Append(JsonBuilder.GetJson("comments", "comment", CommentsData.Comments) + ',');
			builder.Append(JsonBuilder.GetJson("trackbacks", "trackback", TrackbacksData.Trackbacks) + ',');
			builder.Append(JsonBuilder.GetJson("images", "image", ImageData.Images) + ',');
			builder.Append(JsonBuilder.GetJson("tags", "tag", TagData.Tags) + ',');
			builder.Append(JsonBuilder.GetJson("calendars", "calendar", CalendarData.Calendars) + ',');
			builder.Append(JsonBuilder.GetJson("going", "going", GoingData.Going) + ',');
			builder.Append(JsonBuilder.GetJson("properties", "property", PropertyData.Properties) + ',');
			builder.Append(JsonBuilder.GetJson("categories", "category", CategoryData.Categories));
			builder.Append('}');
			return builder.ToString();
		}


	}
}