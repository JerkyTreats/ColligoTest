using Newtonsoft.Json;
using System.Collections.Generic;

namespace Colligo.REST.Response
{
	public class ParentContainer
	{
		[JsonProperty(PropertyName = "parent")]
		public List<Parent> Parents;

	}
}