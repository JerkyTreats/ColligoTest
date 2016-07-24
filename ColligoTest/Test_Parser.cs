using NUnit.Framework;
using Colligo.REST;
using System.Diagnostics;
using System.IO;
using System.Net;
using System;

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
		public void Parser_FormURLIsNotNull()
		{
			Assert.IsNotNull(_parser.FormUrl());
		}

		[Test]
		public void Parser_FormURLPassedParametersAppendedToUrl()
		{
			string a = "test1";
			string b = "test2";

			string url = _parser.FormUrl(a, b);

			Assert.IsTrue(url.Contains(string.Format("{0}&{1}",a,b)));
		}

	}
}
