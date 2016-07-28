using Newtonsoft.Json;

namespace Colligo.REST.Response
{
	public static class ResponseFactory
	{

		public static T DeserializeJson<T>(string json)
		{
			return JsonConvert.DeserializeObject<T>(json, Data.DefaultJSONSerializerSettings);
		}
	}
}
