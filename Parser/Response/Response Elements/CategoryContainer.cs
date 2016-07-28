using System.Collections.Generic;
using Newtonsoft.Json;

namespace Colligo.REST.Response
{
	public class CategoryContainer
	{
		[JsonProperty(PropertyName = "category")]
		public List<Category> Categories;
	}
}