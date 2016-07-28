using NUnit.Framework;
using Colligo.REST.Response;
using System.Collections.Generic;

namespace ColligoTest.Response
{
	[TestFixture]
	public class Test_GetResponseDeserializer
	{
		GetResponse response;
		Dictionary<string, object> data = GetResponseJsonData.GetResponseData;

		[SetUp]
		public void SetUp()
		{
			string json = GetResponseJsonData.GetJson();
			response = ResponseFactory.DeserializeJson<GetResponse>(json);
		}

		[Test]
		public void GetResponseDeserializer_IdPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Id], response.Id);
		}

		[Test]
		public void GetResponseDeserializer_UrlPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Url], response.Url);
		}

		[Test]
		public void GetResponseDeserializer_TitlePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Title], response.Title);
		}

		[Test]
		public void GetResponseDeserializer_DescriptionPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Description], response.Description);
		}

		[Test]
		public void GetResponseDeserializer_StartTimePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.StartTime], response.StartTime);
		}

		[Test]
		public void GetResponseDeserializer_StopTimePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.StopTime], response.StopTime);
		}

		[Test]
		public void GetResponseDeserializer_AllDayPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.AllDay], response.AllDay);
		}

		[Test]
		public void GetResponseDeserializer_TzIdPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.TzId], response.TzId);
		}

		[Test]
		public void GetResponseDeserializer_TzOlsenPathPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.TzOlsenPath], response.TzOlsenPath);
		}

		[Test]
		public void GetResponseDeserializer_TzCityPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.TzCity], response.TzCity);
		}

		[Test]
		public void GetResponseDeserializer_TzCountryPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.TzCountry], response.TzCountry);
		}

		[Test]
		public void GetResponseDeserializer_VenueIdPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.VenueId], response.VenueId);
		}

		[Test]
		public void GetResponseDeserializer_VenueNamePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.VenueName], response.VenueName);
		}

		[Test]
		public void GetResponseDeserializer_VenueTypePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.VenueType], response.VenueType);
		}

		[Test]
		public void GetResponseDeserializer_VenueDisplayPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.VenueDisplay], response.VenueDisplay);
		}

		[Test]
		public void GetResponseDeserializer_AddressPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Address], response.Address);
		}

		[Test]
		public void GetResponseDeserializer_CityPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.City], response.City);
		}

		[Test]
		public void GetResponseDeserializer_RegionPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Region], response.Region);
		}

		[Test]
		public void GetResponseDeserializer_PostalCodePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.PostalCode], response.PostalCode);
		}

		[Test]
		public void GetResponseDeserializer_CountryPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Country], response.Country);
		}

		[Test]
		public void GetResponseDeserializer_LatitudePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Latitude], response.Latitude);
		}

		[Test]
		public void GetResponseDeserializer_LongitudePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Longitute], response.Longitute);
		}

		[Test]
		public void GetResponseDeserializer_GeoCodeTypePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.GeocodeType], response.GeocodeType);
		}

		[Test]
		public void GetResponseDeserializer_CreatedPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Created], response.Created);
		}

		[Test]
		public void GetResponseDeserializer_ModifiedPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Modified], response.Modified);
		}

		[Test]
		public void GetResponseDeserializer_OwnerPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Owner], response.Owner);
		}

		[Test]
		public void GetResponseDeserializer_PrivacyPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Privacy], response.Privacy);
		}

		[Test]
		public void GetResponseDeserializer_FreePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Free], response.Free);
		}

		[Test]
		public void GetResponseDeserializer_PricePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Price], response.Price);
		}

		[Test]
		public void GetResponseDeserializer_WithdrawnPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.Withdrawn], response.Withdrawn);
		}

		[Test]
		public void GetResponseDeserializer_WithdrawnNotePopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.WithdrawnNote], response.WithdrawnNote);
		}

		[Test]
		public void GetResponseDeserializer_LinkContainerPopulatedCorrectly()
		{
			Assert.IsNotNull(response.LinkContainer);
		}

		[Test]
		public void GetResponseDeserializer_CommentContainerPopulatedCorrectly()
		{
			Assert.IsNotNull(response.CommentContainer);
		}

		[Test]
		public void GetResponseDeserializer_PropertyContainerPopulatedCorrectly()
		{
			Assert.IsNotNull(response.PropertyContainer);
		}

		//[Test]
		//public void GetResponseDeserializer_ParentsPopulatedCorrectly()
		//{
		//	Assert.IsNotNull(response.Parents);
		//}

		//[Test]
		//public void GetResponseDeserializer_ChildrenPopulatedCorrectly()
		//{
		//	Assert.IsNotNull(response.Children);
		//}

		//[Test]
		//public void GetResponseDeserializer_TrackbacksPopulatedCorrectly()
		//{
		//	Assert.IsNotNull(response.Trackbacks);
		//}

		//[Test]
		//public void GetResponseDeserializer_ImagesPopulatedCorrectly()
		//{
		//	Assert.IsNotNull(response.Images);
		//}

		//[Test]
		//public void GetResponseDeserializer_TagsPopulatedCorrectly()
		//{
		//	Assert.IsNotNull(response.Tags);
		//}

		//[Test]
		//public void GetResponseDeserializer_CalendarPopulatedCorrectly()
		//{
		//	Assert.IsNotNull(response.Calendars);
		//}

		//[Test]
		//public void GetResponseDeserializer_GoingPopulatedCorrectly()
		//{
		//	Assert.IsNotNull(response.Going);
		//}
	}
}
