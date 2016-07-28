using Newtonsoft.Json;
using System.Collections.Generic;

namespace Colligo.REST.Response
{
	public class TagContainer
	{
		[JsonProperty(PropertyName = "tag")]
		public List<Tag> Tags;
	}
}