using Newtonsoft.Json;

namespace Colligo.REST.Response
{
	public class Comment
	{
		[JsonProperty(PropertyName = "id")]
		public int Id;

		[JsonProperty(PropertyName = "text")]
		public string Text;

		[JsonProperty(PropertyName = "username")]
		public string Username;

		[JsonProperty(PropertyName = "time")]
		public string Time;
	}
}