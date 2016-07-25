using NUnit.Framework;
using Colligo.REST;

namespace ColligoTest
{
	[TestFixture]
	class Test_Mature
	{
		Mature mature;

		[SetUp]
		public void SetUp()
		{
			mature = new Mature();
		}

		[Test]
		public void Mature_AllReturnsCorrectStringValue()
		{
			Assert.AreEqual("all", mature.Options[Mature.Types.All]);
		}

		[Test]
		public void Mature_NormalReturnsCorrectStringValue()
		{
			Assert.AreEqual("normal", mature.Options[Mature.Types.Normal]);
		}

		[Test]
		public void Mature_SafeReturnsCorrectStringValue()
		{
			Assert.AreEqual("safe", mature.Options[Mature.Types.Safe]);
		}

		[Test]
		public void Mature_ReturnsValidString()
		{
			string expected = "mature=all";

			mature.SetValue(Mature.Types.All);
			string formedString = mature.GetQuery();

			Assert.AreEqual(expected, formedString);
		}
	}
}
