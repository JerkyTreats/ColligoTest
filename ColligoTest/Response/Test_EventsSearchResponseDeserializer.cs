using NUnit.Framework;
using Colligo.REST;
using Colligo.REST.Query;
using Colligo.REST.Response;
using System;
using System.Collections.Generic;

namespace ColligoTest.Response
{
	[TestFixture]
	public class Test_EventsEventsSearchResponseDeserializer
	{
		EventsSearchResponse response;
		static int numberOfEvents = 3;
		Dictionary<string, object> data = SearchResponseJsonData.SearchResponseData;

		[SetUp]
		public void SetUp()
		{
			string json = SearchResponseJsonData.GetSearchResponseJson(numberOfEvents);
			response = ResponseFactory.DeserializeJson<EventsSearchResponse>(json);
		}

		[Test]
		public void EventsSearchResponseDeserializer_TotalItemsPopulatedCorrectly()
		{
			Assert.AreEqual(data[SearchResponseJsonData.totalItems], response.TotalItems);
		}

		[Test]
		public void EventsSearchResponseDeserializer_PageSizePopulatedCorrectly()
		{
			Assert.AreEqual(data[SearchResponseJsonData.pageSize], response.PageSize);
		}

		[Test]
		public void EventsSearchResponseDeserializer_PageCountPopulatedCorrectly()
		{
			Assert.AreEqual(data[SearchResponseJsonData.pageCount], response.PageCount);
		}

		[Test]
		public void EventsSearchResponseDeserializer_CurrentPageNumberPopulatedCorrectly()
		{
			Assert.AreEqual(data[SearchResponseJsonData.pageNumber], response.CurrentPageNumber);
		}

		[Test]
		public void EventsSearchResponseDeserializer_PageItemsPopulatedCorrectly()
		{
			Assert.AreEqual(data[SearchResponseJsonData.pageItems], response.PageItems);
		}

		[Test]
		public void EventsSearchResponseDeserializer_FirstItemPopulatedCorrectly()
		{
			Assert.AreEqual(data[SearchResponseJsonData.firstItem], response.FirstItem);
		}

		[Test]
		public void EventsSearchResponseDeserializer_LastItemPopulatedCorrectly()
		{
			Assert.AreEqual(data[SearchResponseJsonData.lastItem], response.LastItem);
		}
		
		[Test]
		public void EventsSearchResponseDeserializer_SearchTimePopulatedCorrectly()
		{
			Assert.AreEqual(data[SearchResponseJsonData.searchTime], response.SearchTime);
		}

		[Test]
		public void EventsSearchResponseDeserializer_EventsCollectionPopulatedCorrectly()
		{
			Assert.IsNotNull(response.Events);
			Assert.AreEqual(numberOfEvents, response.Events.Events.Length);
		}
	}
}
