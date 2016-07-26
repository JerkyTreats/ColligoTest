using Newtonsoft.Json;

namespace Colligo.REST.Response
{
	public class Tag
	{
		[JsonProperty(PropertyName = "id")]
		public string Id;

		[JsonProperty(PropertyName = "title")]
		public string Title;

		[JsonProperty(PropertyName = "owner")]
		public string Owner;

	}
}