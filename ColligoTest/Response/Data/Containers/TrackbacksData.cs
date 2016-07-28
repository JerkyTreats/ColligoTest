using System.Collections.Generic;

namespace ColligoTest
{
	public static class TrackbacksData
	{
		public static string Id = "id";
		public static string BlogName = "blog_name";
		public static string Excerpt = "excerpt";
		public static string TrackbackUrl = "trackback_url";
		public static string Time = "time";

		public static Dictionary<string, object> Trackbacks = new Dictionary<string, object>()
		{
			{Id, 123456789 },
			{BlogName, "JerkyTreats Fabulous Blog Of Cats And Interesting Postulations On The Intracacies Of Interpersonal Conflict Resolution"},
			{Excerpt, "...the key, of course, is to get the opponent off balance. The physical mechanics of this manifests itself in the ability to turn the opponents limbs against their center-line..." },
			{TrackbackUrl, "https://github.com/jerkytreats" },
			{Time, "2015-01-13 14:08:55" }
		};
	}
}