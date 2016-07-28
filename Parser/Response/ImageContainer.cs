using Newtonsoft.Json;
using System.Collections.Generic;

namespace Colligo.REST.Response
{
	public class ImageContainer
	{
		[JsonProperty(PropertyName = "image")]
		public List<Image> Images;
	}
}