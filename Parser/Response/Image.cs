using Newtonsoft.Json;

namespace Colligo.REST.Response
{
	public class Image
	{
		[JsonProperty(PropertyName = "id")]
		public int Id;

		[JsonProperty(PropertyName = "url")]
		public string Url;

		[JsonProperty(PropertyName = "width")]
		public int Width;

		[JsonProperty(PropertyName = "height")]
		public int Height;

		[JsonProperty(PropertyName = "caption")]
		public string Caption;
	}
}