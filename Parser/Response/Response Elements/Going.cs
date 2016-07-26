using Newtonsoft.Json;

namespace Colligo.REST.Response
{
	public class Going
	{
		[JsonProperty(PropertyName = "username")]
		public string Username;
	}
}