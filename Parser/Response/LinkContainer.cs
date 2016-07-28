using Newtonsoft.Json;
using System.Collections.Generic;

namespace Colligo.REST.Response
{
	public class LinkContainer
	{
		[JsonProperty(PropertyName = "link")]
		public List<Link> Links;
	}
}