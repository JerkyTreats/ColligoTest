using NUnit.Framework;
using Colligo.REST;
using Colligo.REST.Query;
using Colligo.REST.Response;

namespace ColligoTest.Response
{
	[TestFixture]
	public class Test_Response_Search
	{
		SearchQuery Search;
		Parser Parser;

		[SetUp]
		public void SetUp()
		{
			Search = new SearchQuery();
			Parser = new Parser();
		}

		[Test]
		public void SearchResponse_TotalItemsNotNull()
		{
			Search.KeyWords.AddValue("Test");
			var obj = Parser.Search(Search);
			Assert.IsTrue(obj.TotalItems > 0);
		}
	}
}
