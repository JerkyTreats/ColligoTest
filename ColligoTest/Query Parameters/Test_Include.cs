using NUnit.Framework;
using Colligo.REST;

namespace ColligoTest
{
	[TestFixture]
	class Test_Include
	{
		Include include;

		[SetUp]
		public void SetUp()
		{
			include = new Include();
		}

		[Test]
		public void Include_CategoriesReturnsCorrectStringValue()
		{
			Assert.AreEqual("categories", include.Options[Include.Types.Categories]);
		}

		[Test]
		public void Include_SubCategoriesReturnsCorrectStringValue()
		{
			Assert.AreEqual("subcategories", include.Options[Include.Types.Subcategories]);
		}

		[Test]
		public void Include_PopularityReturnsCorrectStringValue()
		{
			Assert.AreEqual("popularity", include.Options[Include.Types.Popularity]);
		}

		[Test]
		public void Include_PriceReturnsCorrectStringValue()
		{
			Assert.AreEqual("price", include.Options[Include.Types.Price]);
		}

		[Test]
		public void Include_TicketsReturnsCorrectStringValue()
		{
			Assert.AreEqual("tickets", include.Options[Include.Types.Tickets]);
		}

		[Test]
		public void Include_LinksReturnsCorrectStringValue()
		{
			Assert.AreEqual("links", include.Options[Include.Types.Links]);
		}

		[Test]
		public void Include_ReturnsValidString()
		{
			string expected = "include=categories";
			include.AddValues(Include.Types.Categories);

			string formedString = include.GetQuery();

			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Include_AllowsMulitpleValues()
		{
			string expected = "include=categories,subcategories";
			include.AddValues(Include.Types.Categories, Include.Types.Subcategories);

			string formedString = include.GetQuery();

			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Include_ReturnsNullForNullParameters()
		{
			Assert.IsNull(include.GetQuery());
		}
	}
}
