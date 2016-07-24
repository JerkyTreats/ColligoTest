using NUnit.Framework;
using Colligo.REST;

namespace ColligoTest
{
	[TestFixture]
	class Test_Search
	{
		[Test]
		public void Search_GetKeyWordsReturnsValidString()
		{
			string expected = "keywords=test";
			string formedString = Search.GetKeyWords("test");
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_GetKeyWordsNullValueReturnsNull()
		{
			Assert.IsNull(Search.GetKeyWords(null));
		}

		[Test]
		public void Search_GetLocationseturnsValidString()
		{
			string expected = "location=test";
			string formedString = Search.GetLocation("test");
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_GetLocationsNullValueReturnsNull()
		{
			Assert.IsNull(Search.GetLocation(null));
		}

		[Test]
		public void Search_GetWithinReturnsValidString()
		{
			string expected = "within=test";
			string formedString = Search.GetWithin("test");
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_GetWithinNullValueReturnsNull()
		{
			Assert.IsNull(Search.GetWithin(null));
		}

		[Test]
		public void Search_GetUnitsReturnsValidString()
		{
			string expected = "units=test";
			string formedString = Search.GetUnits("test");
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_GetUnitsNullValueReturnsNull()
		{
			Assert.IsNull(Search.GetUnits(null));
		}

		[Test]
		public void Search_GetDateReturnsValidString()
		{
			string expected = "date=test";
			string formedString = Search.GetUnits("test");
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_GetDateNullValueReturnsNull()
		{
			Assert.IsNull(Search.GetUnits(null));
		}
	}
}
