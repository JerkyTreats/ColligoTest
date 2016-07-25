using NUnit.Framework;
using Colligo.REST;

namespace ColligoTest
{
	[TestFixture]
	class Test_ExCategory
	{
		ExCategory exCategory;
		[SetUp]
		public void SetUp()
		{
			exCategory = new ExCategory();
		}

		[Test]
		public void ExCategory_ReturnsValidString()
		{
			string expected = "ex_category=test";
			exCategory.AddValue("test");
			string formedString = exCategory.GetQueryParameter();
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void ExCategory_NullValueReturnsNull()
		{
			Assert.IsNull(exCategory.GetQueryParameter());
		}

		[Test]
		public void ExCategory_FormsMulitpleValues()
		{
			string expected = "ex_category=test,shoe";
			exCategory.AddValue("test", "shoe");
			string formedString = exCategory.GetQueryParameter();
			Assert.AreEqual(expected, formedString);
		}
	}
}
