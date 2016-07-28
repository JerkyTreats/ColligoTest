using Newtonsoft.Json;
using System.Collections.Generic;

namespace Colligo.REST.Response
{
	public class PropertyContainer
	{
		[JsonProperty(PropertyName ="property")]
		public List<Property> Properties;
	}
}