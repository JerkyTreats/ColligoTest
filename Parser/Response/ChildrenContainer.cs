using Newtonsoft.Json;
using System.Collections.Generic;

namespace Colligo.REST.Response
{
	public class ChildrenContainer
	{
		[JsonProperty(PropertyName = "child")]
		public List<Children> Children;

	}
}