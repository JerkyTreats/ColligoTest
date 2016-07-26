using Newtonsoft.Json;

namespace Colligo.REST.Response
{
	public class EventCollection
	{
		[JsonProperty(PropertyName = "event")]
		public Event[] Events;
	}
}