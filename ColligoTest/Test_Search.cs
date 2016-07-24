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
		public void Search_GetCategoryFormsMulitpleValues()
		{
			string expected = "category=test,shoe";
			string formedString = Search.GetCategory("test", "shoe");
			Assert.AreEqual(expected, formedString);
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
		public void Search_GetExCategoryFormsMulitpleValues()
		{
			string expected = "ex_category=test,shoe";
			string formedString = Search.GetExCategory("test", "shoe");
			Assert.AreEqual(expected, formedString);
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
			string formedString = Search.GetSortOrder(Sort.SortOrder.Popularity);
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_SortOrderReturnsDateString()
		{
			string expected = "sort_order=date";
			string formedString = Search.GetSortOrder(Sort.SortOrder.Date);
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_SortOrderReturnsRelevanceString()
		{
			string expected = "sort_order=relevance";
			string formedString = Search.GetSortOrder(Sort.SortOrder.Relevance);
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_SortDirectionReturnsDescendingString()
		{
			string expected = "sort_direction=descending";
			string formedString = Search.GetSortDirection(Sort.SortDirection.Descending);
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_SortDirectionReturnsAscendingString()
		{
			string expected = "sort_direction=ascending";
			string formedString = Search.GetSortDirection(Sort.SortDirection.Ascending);
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_PageSizeReturnsValidString()
		{
			string expected = "page_size=25";
			string formedString = Search.GetPageSize(25);
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_PageSizeNullValueReturnsNullString()
		{
			Assert.IsNull(Search.GetPageSize(0));
		}

		[Test]
		public void Search_PageSizeMaximumAt100()
		{
			string expected = "page_size=100";
			string formedString = Search.GetPageSize(1000);
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_PageNumberReturnsValidString()
		{
			string expected = "page_number=25";
			string formedString = Search.GetPageNumber(25);
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_PageNumberNullValueReturnsNullString()
		{
			Assert.IsNull(Search.GetPageNumber(0));
		}

		[Test]
		public void Search_GetLanguagesReturnsValidString()
		{
			string expected = "languages=French";
			string formedString = Search.GetLanguages("French");
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_GetLangaugesReturnsNullStringForNullInput()
		{
			Assert.IsNull(Search.GetLanguages(null));
		}

		[Test]
		public void Search_GetMatureReturnsValidString()
		{
			string expected = "mature=all";
			string formedString = Search.GetMature(Mature.Types.All);
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_GetIncludeReturnsValidString()
		{
			string expected = "include=categories";
			string formedString = Search.GetInclude(Include.Types.Categories);
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_GetIncludeAllowsMulitpleValues()
		{
			string expected = "include=categories,subcategories";
			string formedString = Search.GetInclude(Include.Types.Categories, Include.Types.Subcategories);
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Search_GetIncludeReturnsNullForNullParameters()
		{
			Assert.IsNull(Search.GetInclude(null));
		}

		[Test]
		public void Search_ChangeMultiDateStartReturnsValidString()
		{
			Assert.AreEqual("change_multi_day_start",Search.GetChangeMultiDayStart());
		}

		[Test]
		public void Search_GetImageWithSingleValueReturnsValidString()
		{
			string expected = "image_sizes=small";
			string actual = Search.GetImage(Image.Types.Small);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Search_GetImageWithMulitpleValueReturnsValidString()
		{
			string expected = "image_sizes=small,medium,large";
			string actual = Search.GetImage(Image.Types.Small, Image.Types.Medium, Image.Types.Large);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Search_GetIMageWithNullValueReturnsNullString()
		{
			Assert.IsNull(Search.GetImage(null));
		}
	}
}
