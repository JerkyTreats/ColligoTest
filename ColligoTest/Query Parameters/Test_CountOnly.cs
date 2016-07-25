using NUnit.Framework;
using Colligo.REST;

namespace ColligoTest
{
	[TestFixture]
	class Test_CountOnly
	{
		CountOnly count;

		[SetUp]
		public void SetUp()
		{
			count = new CountOnly();
		}

		[Test]
		public void CountOnly_ReturnsValidString()
		{
			string expected = "count_only";
			count.AddValue(true);

			string formedString = count.GetQueryParameter();
			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void CountOnly_DefaultReturnsNullString()
		{
			Assert.IsNull(count.GetQueryParameter());
		}

	}
}
