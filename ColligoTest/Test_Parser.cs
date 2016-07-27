using NUnit.Framework;
using Colligo.REST;
using Colligo.REST.Query;
using Colligo.REST.Response;
using System;

namespace Colligo.Test
{
	[TestFixture]
	public class Test_Parser
	{
		[Test]
		public void Parser_NonNullSearchResponseGeneratedBySendQuery()
		{
			SearchQuery query = new SearchQuery();
			query.KeyWords.AddValue("Test");
			query.Image.AddValues(REST.Query.Image.Types.Small, REST.Query.Image.Types.Medium);

			Uri uri = new Uri(query.BuildQuery());
			string json = APIAccess.GetStringResponseFromAPI(uri);
			SearchResponse response = ResponseFactory.DeserializeJson<SearchResponse>(json);
			Assert.IsNotNull(response);
		}

		[Test]
		public void Parser_NonNullGetResponseGeneratedByGetQuery()
		{
			GetQuery query = new GetQuery();
			query.Id.AddValue("E0-001-000278174-6");

			Uri uri = new Uri(query.BuildQuery());
			string json = APIAccess.GetStringResponseFromAPI(uri);
			GetResponse response = ResponseFactory.DeserializeJson<GetResponse>(json);

			Assert.IsNotNull(response);
		}
	}
}
