using Newtonsoft.Json;

namespace Colligo.REST.Response
{
	public class Link
	{
		[JsonProperty(PropertyName = "id")]
		public int Id;

		[JsonProperty(PropertyName = "url")]
		public string Url;

		[JsonProperty(PropertyName = "type")]
		public string Type;

		[JsonProperty(PropertyName = "description")]
		public string Description;

		[JsonProperty(PropertyName = "username")]
		public string Username;

		[JsonProperty(PropertyName = "time")]
		public string Time;

	}
}