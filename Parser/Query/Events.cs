using Newtonsoft.Json;

namespace Colligo.REST
{
	public class EventCollection
	{
		[JsonProperty(PropertyName = "event")]
		public Event[] Events;
	}
}