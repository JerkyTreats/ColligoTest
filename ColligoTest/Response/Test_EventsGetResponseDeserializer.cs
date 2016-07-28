using NUnit.Framework;
using Colligo.REST.Response;
using System.Collections.Generic;

namespace ColligoTest.Response
{
	[TestFixture]
	public class Test_EventsGetResponseDeserializer
	{
		EventsGetResponse response;
		Dictionary<string, object> data = GetResponseJsonData.GetResponseData;

		[SetUp]
		public void SetUp()
		{
			string json = GetResponseJsonData.GetJson();
			response = ResponseFactory.DeserializeJson<EventsGetResponse>(json);
		}

		[Test]
		public void EventsGetResponseDeserializer_IdPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Id], response.Id);
		}

		[Test]
		public void EventsGetResponseDeserializer_UrlPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Url], response.Url);
		}

		[Test]
		public void EventsGetResponseDeserializer_TitlePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Title], response.Title);
		}

		[Test]
		public void EventsGetResponseDeserializer_DescriptionPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Description], response.Description);
		}

		[Test]
		public void EventsGetResponseDeserializer_StartTimePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.StartTime], response.StartTime);
		}

		[Test]
		public void EventsGetResponseDeserializer_StopTimePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.StopTime], response.StopTime);
		}

		[Test]
		public void EventsGetResponseDeserializer_AllDayPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.AllDay], response.AllDay);
		}

		[Test]
		public void EventsGetResponseDeserializer_TzIdPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.TzId], response.TzId);
		}

		[Test]
		public void EventsGetResponseDeserializer_TzOlsenPathPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.TzOlsenPath], response.TzOlsenPath);
		}

		[Test]
		public void EventsGetResponseDeserializer_TzCityPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.TzCity], response.TzCity);
		}

		[Test]
		public void EventsGetResponseDeserializer_TzCountryPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.TzCountry], response.TzCountry);
		}

		[Test]
		public void EventsGetResponseDeserializer_VenueIdPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.VenueId], response.VenueId);
		}

		[Test]
		public void EventsGetResponseDeserializer_VenueNamePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.VenueName], response.VenueName);
		}

		[Test]
		public void EventsGetResponseDeserializer_VenueTypePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.VenueType], response.VenueType);
		}

		[Test]
		public void EventsGetResponseDeserializer_VenueDisplayPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.VenueDisplay], response.VenueDisplay);
		}

		[Test]
		public void EventsGetResponseDeserializer_AddressPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Address], response.Address);
		}

		[Test]
		public void EventsGetResponseDeserializer_CityPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.City], response.City);
		}

		[Test]
		public void EventsGetResponseDeserializer_RegionPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Region], response.Region);
		}

		[Test]
		public void EventsGetResponseDeserializer_PostalCodePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.PostalCode], response.PostalCode);
		}

		[Test]
		public void EventsGetResponseDeserializer_CountryPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Country], response.Country);
		}

		[Test]
		public void EventsGetResponseDeserializer_LatitudePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Latitude], response.Latitude);
		}

		[Test]
		public void EventsGetResponseDeserializer_LongitudePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Longitute], response.Longitute);
		}

		[Test]
		public void EventsGetResponseDeserializer_GeoCodeTypePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.GeocodeType], response.GeocodeType);
		}

		[Test]
		public void EventsGetResponseDeserializer_CreatedPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Created], response.Created);
		}

		[Test]
		public void EventsGetResponseDeserializer_ModifiedPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Modified], response.Modified);
		}

		[Test]
		public void EventsGetResponseDeserializer_OwnerPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Owner], response.Owner);
		}

		[Test]
		public void EventsGetResponseDeserializer_PrivacyPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Privacy], response.Privacy);
		}

		[Test]
		public void EventsGetResponseDeserializer_FreePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Free], response.Free);
		}

		[Test]
		public void EventsGetResponseDeserializer_PricePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Price], response.Price);
		}

		[Test]
		public void EventsGetResponseDeserializer_WithdrawnPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Withdrawn], response.Withdrawn);
		}

		[Test]
		public void EventsGetResponseDeserializer_WithdrawnNotePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.WithdrawnNote], response.WithdrawnNote);
		}

		[Test]
		public void EventsGetResponseDeserializer_LinkContainerPopulatedCorrectly()
		{
			Assert.IsTrue(response.LinkContainer.Links.Count > 0);
		}

		[Test]
		public void EventsGetResponseDeserializer_CommentContainerPopulatedCorrectly()
		{
			Assert.IsTrue(response.CommentContainer.Comments.Count > 0);

		}

		[Test]
		public void EventsGetResponseDeserializer_PropertyContainerPopulatedCorrectly()
		{
			Assert.IsTrue(response.PropertyContainer.Properties.Count > 0);
		}

		[Test]
		public void EventsGetResponseDeserializer_ParentsPopulatedCorrectly()
		{
			Assert.IsTrue(response.ParentsContainer.Parents.Count > 0);
		}

		[Test]
		public void EventsGetResponseDeserializer_ChildrenPopulatedCorrectly()
		{
			Assert.IsTrue(response.ChildrenContainer.Children.Count > 0);
		}

		[Test]
		public void EventsGetResponseDeserializer_TrackbacksPopulatedCorrectly()
		{
			Assert.IsTrue(response.TrackbackContainer.Trackbacks.Count > 0);
		}

		[Test]
		public void EventsGetResponseDeserializer_ImagesPopulatedCorrectly()
		{
			Assert.IsTrue(response.ImageContainer.Images.Count > 0);
		}

		[Test]
		public void EventsGetResponseDeserializer_TagsPopulatedCorrectly()
		{
			Assert.IsTrue(response.TagContainer.Tags.Count > 0);
		}

		//[Test]
		//public void EventsGetResponseDeserializer_CalendarPopulatedCorrectly()
		//{
		//	Assert.IsNotNull(response.Calendars);
		//}

		//[Test]
		//public void EventsGetResponseDeserializer_GoingPopulatedCorrectly()
		//{
		//	Assert.IsNotNull(response.Going);
		//}
	}
}
