using NUnit.Framework;
using Colligo.REST.Query;

namespace ColligoTest
{
	[TestFixture]
	class Test_Units
	{
		Units units;

		[SetUp]
		public void SetUp()
		{
			units = new Units();
		}

		[Test]
		public void Units_GetUnitsReturnsValidString()
		{
			string expected = "units=km";
			units.AddValue(Units.Types.Kilometers);

			string formedString = units.GetQueryParameter();

			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void Units_GetUnitsNullValueReturnsNull()
		{
			Assert.IsNull(units.GetQueryParameter());
		}

	}
}
