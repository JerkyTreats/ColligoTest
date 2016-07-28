using NUnit.Framework;
using Colligo.REST;
using Colligo.REST.Response;
using System.Collections.Generic;

namespace ColligoTest
{
	[TestFixture]
	public class Test_VenueGetDeserializer
	{
		VenuesGetResponse response;
		Dictionary<string, object> data = VenuesGetResponseJsonData.ResponseData;
		string json = VenuesGetResponseJsonData.GetJson();

		[SetUp]
		public void SetUp()
		{
			response = ResponseFactory.DeserializeJson<VenuesGetResponse>(json);
		}

		[Test]
		public void VenueGetDeserializer_IdPopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.Id], response.Id);
		}

		[Test]
		public void VenueGetDeserializer_UrlPopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.Url], response.Url);
		}

		[Test]
		public void VenueGetDeserializer_NamePopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.Name], response.Name);
		}

		[Test]
		public void VenueGetDeserializer_DescriptionPopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.Description], response.Description);
		}

		[Test]
		public void VenueGetDeserializer_VenueTypePopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.VenueType], response.VenueType);
		}

		[Test]
		public void VenueGetDeserializer_VenueDisplayPopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.VenueDisplay], response.VenueDisplay);
		}

		[Test]
		public void VenueGetDeserializer_AddressPopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.Address], response.Address);
		}

		[Test]
		public void VenueGetDeserializer_CityPopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.City], response.City);
		}

		[Test]
		public void VenueGetDeserializer_RegionPopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.Region], response.Region);
		}

		[Test]
		public void VenueGetDeserializer_PostalCodePopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.PostalCode], response.PostalCode);
		}

		[Test]
		public void VenueGetDeserializer_CountryPopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.Country], response.Country);
		}

		[Test]
		public void VenueGetDeserializer_LatitudePopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.Latitude], response.Latitude);
		}

		[Test]
		public void VenueGetDeserializer_LongitudePopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.Longitute], response.Longitute);
		}

		[Test]
		public void VenueGetDeserializer_GeocodeTypePopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.GeocodeType], response.GeocodeType);
		}

		[Test]
		public void VenueGetDeserializer_CreatedPopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.Created], response.Created);
		}

		[Test]
		public void VenueGetDeserializer_OwnerPopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.Owner], response.Owner);
		}

		[Test]
		public void VenueGetDeserializer_FreePopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.Free], response.Free);
		}

		[Test]
		public void VenueGetDeserializer_PricePopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.Price], response.Price);
		}

		[Test]
		public void VenueGetDeserializer_WithdrawnPopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.Withdrawn], response.Withdrawn);
		}

		[Test]
		public void VenueGetDeserializer_WithdrawnNotePopulatedCorrectly()
		{
			Assert.AreEqual(data[VenuesGetResponseJsonData.WithdrawnNote], response.WithdrawnNote);
		}
	}
}
