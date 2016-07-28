using NUnit.Framework;
using Colligo.REST;
using Colligo.REST.Response;

namespace ColligoTest.Response
{
	[TestFixture]
	public class Test_EventsSearchDeserializer
	{
		string json;
		Event firstEvent;
		static int numberOfEvents = 1;

		[SetUp]
		public void SetUp()
		{
			json = SearchResponseJsonData.GetSearchResponseJson(numberOfEvents);
			EventsSearchResponse response = ResponseFactory.DeserializeJson<EventsSearchResponse>(json);
			firstEvent = response.Events.Events[0];
		}

		[Test]
		public void EventsSearchDeserializer_IdPopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.Id];
			Assert.AreEqual(expected, firstEvent.Id);
		}

		[Test]
		public void EventsSearchDeserializer_UrlPopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.Url];
			Assert.AreEqual(expected, firstEvent.Url);
		}

		[Test]
		public void EventsSearchDeserializer_TitlePopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.Title];
			Assert.AreEqual(expected, firstEvent.Title);
		}

		[Test]
		public void EventsSearchDeserializer_DescriptionPopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.Description];
			Assert.AreEqual(expected, firstEvent.Description);
		}

		[Test]
		public void EventsSearchDeserializer_StartTimePopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.StartTime];
			Assert.AreEqual(expected, firstEvent.StartTime);
		}

		[Test]
		public void EventsSearchDeserializer_StopTimePopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.StopTime];
			Assert.AreEqual(expected, firstEvent.StopTime);
		}

		[Test]
		public void EventsSearchDeserializer_VenueIdPopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.VenueId];
			Assert.AreEqual(expected, firstEvent.VenueId);
		}

		[Test]
		public void EventsSearchDeserializer_VenueUrlPopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.VenueUrl];
			Assert.AreEqual(expected, firstEvent.VenueUrl);
		}

		[Test]
		public void EventsSearchDeserializer_VenueNamePopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.VenueName];
			Assert.AreEqual(expected, firstEvent.VenueName);
		}

		[Test]
		public void EventsSearchDeserializer_VenueAddressPopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.VenueAddress];
			Assert.AreEqual(expected, firstEvent.VenueAddress);
		}

		[Test]
		public void EventsSearchDeserializer_CityNamePopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.CityName];
			Assert.AreEqual(expected, firstEvent.CityName);
		}

		[Test]
		public void EventsSearchDeserializer_RegionNamePopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.RegionName];
			Assert.AreEqual(expected, firstEvent.RegionName);
		}

		[Test]
		public void EventsSearchDeserializer_RegionAbbreviationPopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.RegionAbbreviation];
			Assert.AreEqual(expected, firstEvent.RegionAbbreviation);
		}

		[Test]
		public void EventsSearchDeserializer_PostalCodePopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.PostalCode];
			Assert.AreEqual(expected, firstEvent.PostalCode);
		}

		[Test]
		public void EventsSearchDeserializer_CountryNamePopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.CountryName];
			Assert.AreEqual(expected, firstEvent.CountryName);
		}

		[Test]
		public void EventsSearchDeserializer_AllDayPopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.AllDay];
			Assert.AreEqual(expected, firstEvent.AllDay);
		}

		[Test]
		public void EventsSearchDeserializer_LatitudePopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.Latitude];
			Assert.AreEqual(expected, firstEvent.Latitude);
		}

		[Test]
		public void EventsSearchDeserializer_LongitudePopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.Longitude];
			Assert.AreEqual(expected, firstEvent.Longitude);
		}

		[Test]
		public void EventsSearchDeserializer_GeocodeTypePopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.GeocodeType];
			Assert.AreEqual(expected, firstEvent.GeocodeType);
		}

		[Test]
		public void EventsSearchDeserializer_TrackbackCountPopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.TrackbackCount];
			Assert.AreEqual(expected, firstEvent.TrackbackCount);
		}

		[Test]
		public void EventsSearchDeserializer_CalendarCountPopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.CalendarCount];
			Assert.AreEqual(expected, firstEvent.CalendarCount);
		}

		[Test]
		public void EventsSearchDeserializer_CommentCountPopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.CommentCount];
			Assert.AreEqual(expected, firstEvent.CommentCount);
		}

		[Test]
		public void EventsSearchDeserializer_LinkCountPopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.LinkCount];
			Assert.AreEqual(expected, firstEvent.LinkCount);
		}

		[Test]
		public void EventsSearchDeserializer_CreatedPopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.Created];
			Assert.AreEqual(expected, firstEvent.Created);
		}

		[Test]
		public void EventsSearchDeserializer_OwnerPopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.Owner];
			Assert.AreEqual(expected, firstEvent.Owner);
		}

		[Test]
		public void EventsSearchDeserializer_ModifiedPopulatedCorrectly()
		{
			var expected = EventJsonData.EventData[EventJsonData.Modified];
			Assert.AreEqual(expected, firstEvent.Modified);
		}
	}
}
