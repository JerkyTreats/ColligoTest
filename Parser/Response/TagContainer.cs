using Newtonsoft.Json;
using System.Collections.Generic;

namespace Colligo.REST.Response
{
	public class TagContainer
	{
		[JsonProperty(PropertyName = "tags")]
		public List<Tag> Tags;
	}
}