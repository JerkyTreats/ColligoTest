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

		[Test]
		public void VenueGetDeserializer_ParentsPopulatedCorrectly()
		{
			var parentData = ParentsJsonData.ParentsData;
			var result = response.Parents.Parents;
			Assert.IsTrue(response.Parents.Parents.Count > 0);
			Assert.AreEqual(parentData[ParentsJsonData.Id], result[0].Id);
			Assert.AreEqual(parentData[ParentsJsonData.Title], result[0].Title);
		}

		[Test]
		public void VenueGetDeserializer_ChildrenPopulatedCorrectly()
		{
			var childrenData = ChildrenData.Children;
			var result = response.Children.Children;
			Assert.IsTrue(response.Children.Children.Count > 0);
			Assert.AreEqual(childrenData[ChildrenData.Id], result[0].Id);
			Assert.AreEqual(childrenData[ChildrenData.Title], result[0].Title);
		}

		[Test]
		public void VenueGetDeserializer_EventsPopulatedCorrectly()
		{
			Assert.IsTrue(response.Events.Events.Length > 0);
		}

		[Test]
		public void VenueGetDeserializer_LinksPopulatedCorrectly()
		{
			var linksData = LinksData.Links;
			var result = response.LinkContainer.Links;
			Assert.IsTrue(result.Count > 0);
			Assert.AreEqual(linksData[LinksData.Id], result[0].Id);
			Assert.AreEqual(linksData[LinksData.Url], result[0].Url);
			Assert.AreEqual(linksData[LinksData.Description], result[0].Description);
			Assert.AreEqual(linksData[LinksData.Time], result[0].Time);
			Assert.AreEqual(linksData[LinksData.Type], result[0].Type);
			Assert.AreEqual(linksData[LinksData.Username], result[0].Username);
		}

		[Test]
		public void VenueGetDeserializer_CommentsPopulatedCorrectly()
		{
			var commentsData = CommentsData.Comments;
			var result = response.CommentContainer.Comments;
			Assert.IsTrue(result.Count > 0);
			Assert.AreEqual(commentsData[CommentsData.Id], result[0].Id);
			Assert.AreEqual(commentsData[CommentsData.Text], result[0].Text);
			Assert.AreEqual(commentsData[CommentsData.Time], result[0].Time);
			Assert.AreEqual(commentsData[CommentsData.Username], result[0].Username);
		}

		[Test]
		public void VenueGetDeserializer_TrackbacksPopulatedCorrectly()
		{
			var trackbackData = TrackbacksData.Trackbacks;
			var result = response.Trackbacks.Trackbacks;
			Assert.IsTrue(result.Count > 0);
			Assert.AreEqual(trackbackData[TrackbacksData.Id], result[0].Id);
			Assert.AreEqual(trackbackData[TrackbacksData.BlogName], result[0].BlogName);
			Assert.AreEqual(trackbackData[TrackbacksData.Excerpt], result[0].Excerpt);
			Assert.AreEqual(trackbackData[TrackbacksData.Time], result[0].Time);
			Assert.AreEqual(trackbackData[TrackbacksData.TrackbackUrl], result[0].TrackbackUrl);
		}

		[Test]
		public void VenueGetDeserializer_ImagesPopulatedCorrectly()
		{
			var imagesData = ImageData.Images;
			var result = response.Images.Images;
			Assert.IsTrue(result.Count > 0);
			Assert.AreEqual(imagesData[ImageData.Id], result[0].Id);
			Assert.AreEqual(imagesData[ImageData.Caption], result[0].Caption);
			Assert.AreEqual(imagesData[ImageData.Height], result[0].Height);
			Assert.AreEqual(imagesData[ImageData.Width], result[0].Width);
			Assert.AreEqual(imagesData[ImageData.Url], result[0].Url);
		}

		[Test]
		public void VenueGetDeserializer_TagsPopulatedCorrectly()
		{
			var tagsData = TagData.Tags;
			var result = response.Tags.Tags;
			Assert.IsTrue(result.Count > 0);
			Assert.AreEqual(tagsData[TagData.Id], result[0].Id);
			Assert.AreEqual(tagsData[TagData.Owner], result[0].Owner);
			Assert.AreEqual(tagsData[TagData.Title], result[0].Title);
		}

		[Test]
		public void VenueGetDeserializer_PropertyPopulatedCorrectly()
		{
			var propData = PropertyData.Properties;
			var result = response.PropertyContainer.Properties;
			Assert.IsTrue(result.Count > 0);
			Assert.AreEqual(propData[PropertyData.Id], result[0].Id);
			Assert.AreEqual(propData[PropertyData.Name], result[0].Name);
			Assert.AreEqual(propData[PropertyData.Value], result[0].Value);
		}
	}
}
