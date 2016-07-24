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
			string expected = "within=25";
			string formedString = Search.GetWithin(25);
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_GetWithinZeroValueReturnsNull()
		{
			Assert.IsNull(Search.GetWithin(0));
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
			string formedString = Search.GetDate("test");
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_GetDateNullValueReturnsNull()
		{
			Assert.IsNull(Search.GetDate(null));
		}

		[Test]
		public void Search_GetCategoryReturnsValidString()
		{
			string expected = "category=test";
			string formedString = Search.GetCategory("test");
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_GetCategoryNullValueReturnsNull()
		{
			Assert.IsNull(Search.GetCategory(null));
		}

		[Test]
		public void Search_GetExCategoryReturnsValidString()
		{
			string expected = "ex_category=test";
			string formedString = Search.GetExCategory("test");
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_GetExCategoryNullValueReturnsNull()
		{
			Assert.IsNull(Search.GetExCategory(null));
		}

		[Test]
		public void Search_GetCountOnlyReturnsValidString()
		{
			string expected = "count_only";
			string formedString = Search.GetCountOnly();
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_SortOrderReturnsPopularityString()
		{
			string expected = "sort_order=popularity";
			string formedString = Search.GetSortOrder(Search.SortOrder.popularity);
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_SortOrderReturnsDateString()
		{
			string expected = "sort_order=date";
			string formedString = Search.GetSortOrder(Search.SortOrder.date);
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_SortOrderReturnsRelevanceString()
		{
			string expected = "sort_order=relevance";
			string formedString = Search.GetSortOrder(Search.SortOrder.relevance);
			Assert.AreEqual(expected, formedString);
		}
	}
}
