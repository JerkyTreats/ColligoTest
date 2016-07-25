using NUnit.Framework;
using Colligo.REST;

namespace ColligoTest
{
	[TestFixture]
	class Test_Search
	{
		Search search;

		[SetUp]
		public void SetUp()
		{
			search = new Search();
		}

		[Test]
		public void Search_GetQueryWithNoSetOptionsReturnsBaseQueryString()
		{
			string expected = Data.QueryBase;
			string actual = search.GetQuery();
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Search_GetQueryWithMulitpleValuesSetReturnsCorrectString()
		{
			string expected = Data.QueryBase + "&keywords=test&image_sizes=small,thumb";
			search.KeyWords.AddValue("test");
			search.Image.AddValues(Image.Types.Small, Image.Types.Thumb);

			string actual = search.GetQuery();
			Assert.AreEqual(expected, actual);
		}
	}
}
