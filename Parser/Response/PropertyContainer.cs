using Newtonsoft.Json;
using System.Collections.Generic;

namespace Colligo.REST.Response
{
	public class PropertyContainer
	{
		[JsonProperty(PropertyName ="properties")]
		public List<Property> Properties;
	}
}