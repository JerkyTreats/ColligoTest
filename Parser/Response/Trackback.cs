using Newtonsoft.Json;

namespace Colligo.REST.Response
{
	public class Trackback
	{
		[JsonProperty(PropertyName = "id")]
		public int Id;

		[JsonProperty(PropertyName = "blog_name")]
		public string BlogName;

		[JsonProperty(PropertyName = "excerpt")]
		public string Excerpt;

		[JsonProperty(PropertyName = "trackback_url")]
		public string TrackbackUrl;

		[JsonProperty(PropertyName = "time")]
		public string Time;
	}
}