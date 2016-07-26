using Newtonsoft.Json;

namespace Colligo.REST.Response
{
	public class Calendar
	{
		[JsonProperty(PropertyName = "id")]
		public string Id;

		[JsonProperty(PropertyName = "name")]
		public string Name;

		[JsonProperty(PropertyName = "privacy")]
		public int Privacy;

		[JsonProperty(PropertyName = "smart")]
		public bool Smart;
	}
}