using NUnit.Framework;
using Colligo.REST;
using System.Diagnostics;
using System.IO;
using System.Net;
using System;
using System.Threading.Tasks;

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
		public void Parser_WebClientIsNotNull()
		{
			Assert.IsNotNull(_parser.WebClient);
		}

		[Test]
		public void Parser_NonNullSearchResponseGeneratedBySendQuery()
		{
			Search query = new Search();
			query.KeyWords.AddValue("Test");
			query.Image.AddValues(Image.Types.Small, Image.Types.Medium);

			SearchResponse data = _parser.SendQuery(query);
			Assert.IsNotNull(data);
		}

	}
}
