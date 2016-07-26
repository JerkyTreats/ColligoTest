using NUnit.Framework;
using Colligo.REST;
using Colligo.REST.Query;

namespace Colligo.Test
{
	[TestFixture]
	public class Test_Parser
	{
		Parser _parser;

		[SetUp]
		public void Setup()
		{
			_parser = new Parser();
		}

		[Test]
		public void Parser_NonNullSearchResponseGeneratedBySendQuery()
		{
			SearchQuery query = new SearchQuery();
			query.KeyWords.AddValue("Test");
			query.Image.AddValues(REST.Query.Image.Types.Small, REST.Query.Image.Types.Medium);

			var data = _parser.Search(query);
			Assert.IsNotNull(data);
		}

		[Test]
		public void Parser_NonNullSearchResponseGeneratedByGetQuery()
		{
			GetQuery query = new GetQuery();
			query.Id.AddValue("E0-001-000278174-6");
		
			var data = _parser.Get(query);
			Assert.IsNotNull(data);
		}
	}
}
