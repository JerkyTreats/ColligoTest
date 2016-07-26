using Newtonsoft.Json;
using System.Collections.Generic;

namespace Colligo.REST.Response
{
	public class CommentContainer
	{
		[JsonProperty(PropertyName = "comments")]
		public List<Comment> Comments;
	}
}
