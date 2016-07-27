
using System.Collections.Generic;
using System.Text;

namespace ColligoTest
{
	public static class EventJsonData
	{
		public static string Id = "id";
		public static string Url = "url";
		public static string Title = "title";
		public static string Description = "description";
		public static string StartTime = "start_time";
		public static string StopTime = "stop_time";
		public static string VenueId = "venue_id";
		public static string VenueUrl = "venue_url";
		public static string VenueName = "venue_name";
		public static string VenueDisplay = "venue_display";
		public static string VenueAddress = "venue_address";
		public static string CityName = "city_name";
		public static string RegionName = "region_name";
		public static string RegionAbbreviation = "region_abbr";
		public static string PostalCode = "postal_code";
		public static string CountryName = "country_name";
		public static string AllDay = "all_day";
		public static string Latitude = "latitude";
		public static string Longitude = "longitude";
		public static string GeocodeType = "geocode_type";
		public static string TrackbackCount = "trackback_count";
		public static string CalendarCount = "calendar_count";
		public static string CommentCount = "comment_count";
		public static string LinkCount = "link_count";
		public static string Created = "created";
		public static string Owner = "owner";
		public static string Modified = "modified";

		public static Dictionary<string, object> EventData = new Dictionary<string, object>()
			{
				{ Id,  "E0-001-031956170-7"},
				{ Url,  "https://github.com/jerkytreats/"},
				{ Title,  "Test Title"},
				{ Description,  "This is a fairly short description; Really I should find a min/max character count and boundary test around those values"},
				{ StartTime,  "2010-07-13 19:00:00"},
				{ StopTime,  "2010-07-13 23:59:59"},
				{ VenueId,  "V0-001-004375074-9"},
				{ VenueUrl,  "https://github.com/jerkytreats/"},
				{ VenueName,  "The Code Hole"},
				{ VenueAddress,  "123 Fake St."},
				{ CityName,  "Fakesville"},
				{ RegionName,  "New Fakesville"},
				{ RegionAbbreviation,  "NFV"},
				{ PostalCode,  "F4K3R5"},
				{ CountryName,  "Fakeland"},
				{ AllDay, 1},
				{ Latitude,  32.2217f},
				{ Longitude,  -110.926f},
				{ GeocodeType,  "City Based GeoCodes"},
				{ TrackbackCount,  17},
				{ CalendarCount,  13},
				{ CommentCount,  546},
				{ LinkCount,  5},
				{ Created,  "2010-07-03 17:42:27"},
				{ Owner,  "Dr. Jackson Katabatak, PhD"},
				{ Modified,  "2010-07-03 17:42:28"}
			};

		public static string GetEventJson()
		{
			StringBuilder builder = new StringBuilder(@"{");
			int count = 0;

			foreach (KeyValuePair<string,object> KVP in EventData)
			{
				builder.Append(@"""" + KVP.Key + @""":""" +KVP.Value.ToString() + @"""");
				if (count != (EventData.Count - 1))
					builder.Append(',');
				count++;
			}

			builder.Append('}');
			return builder.ToString();
		}
	}
}
