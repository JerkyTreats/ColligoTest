using Newtonsoft.Json;
using System.Collections.Generic;

namespace Colligo.REST.Response
{
	public class TrackbackContainer
	{
		[JsonProperty(PropertyName = "trackback")]
		public List<Trackback> Trackbacks;

	}
}