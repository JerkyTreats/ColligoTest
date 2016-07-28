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
			EventsSearch query = new EventsSearch();
			query.KeyWords.AddValue("Test");
			query.Image.AddValues(REST.Query.Image.Types.Small, REST.Query.Image.Types.Medium);

			Uri uri = new Uri(query.BuildQuery());
			string json = APIAccess.GetStringResponseFromAPI(uri);
			EventsSearchResponse response = ResponseFactory.DeserializeJson<EventsSearchResponse>(json);
			Assert.IsNotNull(response);
		}

		[Test]
		public void Parser_NonNullGetResponseGeneratedByGetQuery()
		{
			EventsGet query = new EventsGet();
			query.Id.AddValue("E0-001-000278174-6");
			query.Image.AddValues(REST.Query.Image.Types.Small);

			Uri uri = new Uri(query.BuildQuery());
			string json = APIAccess.GetStringResponseFromAPI(uri);
			EventsGetResponse response = ResponseFactory.DeserializeJson<EventsGetResponse>(json);

			Assert.IsNotNull(response);
		}

		[Test]
		public void Parser_ValidGetResponseObjectReturnedByGetQuery()
		{
			EventsGet query = new EventsGet();
			query.Id.AddValue("E0-001-000278174-6");
			query.Image.AddValues(REST.Query.Image.Types.Thumb);

			Uri uri = new Uri(query.BuildQuery());
			string json = APIAccess.GetStringResponseFromAPI(uri);
			EventsGetResponse response = ResponseFactory.DeserializeJson<EventsGetResponse>(json);

		}
	}
}
