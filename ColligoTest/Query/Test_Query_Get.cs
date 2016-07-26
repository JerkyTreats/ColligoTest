using NUnit.Framework;
using Colligo.REST;
using Colligo.REST.Query;

namespace ColligoTest
{
	[TestFixture]
	public class Test_Get
	{
		GetQuery get;
		static string BASE = Data.URL + "/get?" + Data.Key;

		[SetUp]
		public void SetUp()
		{
			get = new GetQuery();
		}

		[Test]
		public void Get_GetQueryWithNoSetOptionsReturnsBaseQueryString()
		{
			string actual = get.BuildQuery();
			Assert.AreEqual(BASE, actual);
		}

		[Test]
		public void Get_GetQueryWithMulitpleValuesSetReturnsCorrectString()
		{
			string expected = BASE + "&id=E0-001-000278174-6&image_sizes=small,thumb";
			get.Id.AddValue("E0-001-000278174-6");
			get.Image.AddValues(Image.Types.Small, Image.Types.Thumb);

			string actual = get.BuildQuery();
			Assert.AreEqual(expected, actual);
		}
	}
}
