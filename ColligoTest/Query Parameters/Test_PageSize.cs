using NUnit.Framework;
using Colligo.REST.Query;

namespace ColligoTest
{
	[TestFixture]
	public class Test_PageSize
	{
		PageSize page;

		[SetUp]
		public void SetUp()
		{
			page = new PageSize();
		}

		[Test]
		public void PageSize_PageSizeReturnsValidString()
		{
			string expected = "page_size=25";
			page.AddValue(25);
			string formedString = page.GetQueryParameter();
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void PageSize_NullValueReturnsNullString()
		{
			Assert.IsNull(page.GetQueryParameter());
		}

		[Test]
		public void PageSize_ZeroValueCannotBeAdded()
		{
			string expected = "page_size=1";
			page.AddValue(1);
			page.AddValue(0);

			string actual = page.GetQueryParameter();

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void PageSize_MaximumAt100()
		{
			string expected = "page_size=100";
			page.AddValue(1000);

			string actual = page.GetQueryParameter();

			Assert.AreEqual(expected, actual);
		}
	}
}
