using Newtonsoft.Json;

namespace Colligo.REST.Response
{
	public class Parent
	{
		[JsonProperty(PropertyName ="id")]
		public string Id;

		[JsonProperty(PropertyName = "title")]
		public string Title;
	}
}
