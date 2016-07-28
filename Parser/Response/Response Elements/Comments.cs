using Newtonsoft.Json;
using System.Collections.Generic;

namespace Colligo.REST.Response
{
	public class CommentContainer
	{
		[JsonProperty(PropertyName = "comment")]
		public List<Comment> Comments;
	}
}
