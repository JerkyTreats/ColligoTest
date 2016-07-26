using System.Collections.Generic;
using Newtonsoft.Json;

namespace Colligo.REST.Response
{
	public class CategoryContainer
	{
		[JsonProperty(PropertyName = "categories")]
		public List<Category> Categories;
	}
}