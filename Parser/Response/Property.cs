using Newtonsoft.Json;

namespace Colligo.REST.Response
{
	public class Property
	{
		[JsonProperty(PropertyName = "id")]
		public int Id;

		[JsonProperty(PropertyName = "name")]
		public string Name;

		[JsonProperty(PropertyName = "value")]
		public string Value;
	}
}