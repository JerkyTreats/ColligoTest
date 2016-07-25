using NUnit.Framework;
using Colligo.REST;

namespace ColligoTest
{
	[TestFixture]
	class Test_BasicQueryParameter
	{
		BasicQueryParameter basic;
		[SetUp]
		public void SetUp()
		{
			basic = new BasicQueryParameter("test");
		}

		[Test]
		public void BasicQueryParameter_ReturnsValidString()
		{
			string expected = "test=test";
			basic.AddValue("test");

			string formedString = basic.GetQueryParameter();

			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void BasicQueryParameter_NullValueReturnsNull()
		{
			Assert.IsNull(basic.GetQueryParameter());
		}
	}
}
