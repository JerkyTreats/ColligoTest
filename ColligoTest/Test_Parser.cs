using NUnit.Framework;
using Colligo.REST;
using Colligo.REST.Response;
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
			REST.Query.Search query = new REST.Query.Search();
			query.KeyWords.AddValue("Test");
			query.Image.AddValues(REST.Query.Image.Types.Small, REST.Query.Image.Types.Medium);

			var data = _parser.MakeQuery(query);
			Assert.IsNotNull(data);
		}


	}
}
