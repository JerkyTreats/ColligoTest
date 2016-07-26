using Newtonsoft.Json;

namespace Colligo.REST.Response
{
	public class Category
	{
		[JsonProperty(PropertyName = "id")]
		public string Id;

		[JsonProperty(PropertyName = "name")]
		public string Name;
	}
}