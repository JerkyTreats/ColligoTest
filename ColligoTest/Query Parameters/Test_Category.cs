using NUnit.Framework;
using Colligo.REST.Query;

namespace ColligoTest
{
	[TestFixture]
	class Test_Category
	{
		Category category;

		[SetUp]
		public void SetUp()
		{
			category = new Category();
		}

		[Test]
		public void Category_ReturnsValidString()
		{
			string expected = "category=test";
			category.AddValue("test");
			string formedString = category.GetQueryParameter();
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Category_NullValueReturnsNull()
		{
			Assert.IsNull(category.GetQueryParameter());
		}

		[Test]
		public void Category_FormsMulitpleValues()
		{
			string expected = "category=test,shoe";
			category.AddValue("test", "shoe");
			string formedString = category.GetQueryParameter();
			Assert.AreEqual(expected, formedString);
		}
	}
}
