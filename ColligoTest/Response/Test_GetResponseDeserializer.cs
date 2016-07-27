using NUnit.Framework;
using Colligo.REST.Response;

namespace ColligoTest.Response
{
	[TestFixture]
	public class Test_GetResponseDeserializer
	{
		GetResponse response;

		[SetUp]
		public void SetUp()
		{
			string json = GetResponseJsonData.GetJson();
			response = ResponseFactory.DeserializeJson<GetResponse>(json);
		}


		[Test]
		public void GetResponseDeserializer_IdPopulatedCorrectly()
		{
			Assert.AreEqual(data[GetResponseJsonData.totalItems], response.TotalItems);
		}
	}
}
