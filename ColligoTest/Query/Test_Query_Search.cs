using NUnit.Framework;
using Colligo.REST;
using Colligo.REST.Query;

namespace ColligoTest
{
	[TestFixture]
	class Test_Search
	{
		SearchQuery search;
		static string BASE = Data.URL + "/search?" + Data.Key;

		[SetUp]
		public void SetUp()
		{
			search = new SearchQuery();
		}

		[Test]
		public void Search_GetQueryWithNoSetOptionsReturnsBaseQueryString()
		{
			string expected = BASE;
			string actual = search.BuildQuery();
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Search_GetQueryWithMulitpleValuesSetReturnsCorrectString()
		{
			string expected = BASE + "&keywords=test&image_sizes=small,thumb";
			search.KeyWords.AddValue("test");
			search.Image.AddValues(Image.Types.Small, Image.Types.Thumb);

			string actual = search.BuildQuery();
			Assert.AreEqual(expected, actual);
		}
	}
}
