using Newtonsoft.Json;
using System.Collections.Generic;

namespace Colligo.REST.Response
{
	public class LinkContainer
	{
		[JsonProperty(PropertyName = "links")]
		public List<Link> Links;
	}
}