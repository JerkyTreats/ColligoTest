using NUnit.Framework;
using Colligo.REST;

namespace ColligoTest
{
	[TestFixture]
	public class Test_PageNumber
	{
		PageNumber page;

		[SetUp]
		public void SetUp()
		{
			page = new PageNumber();
		}

		[Test]
		public void PageNumber_ReturnsValidString()
		{
			string expected = "page_number=25";
			page.AddValue(25);
			string formedString = page.GetQuery();
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void PageNumber_NullValueReturnsNullString()
		{
			Assert.IsNull(page.GetQuery());
		}

		[Test]
		public void PageNumber_ZeroValueIgnored()
		{
			page.AddValue(0);
			Assert.IsNull(page.GetQuery());
		}
	}
}
