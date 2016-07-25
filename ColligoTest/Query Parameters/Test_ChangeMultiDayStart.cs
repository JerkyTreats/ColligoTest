using NUnit.Framework;
using Colligo.REST;

namespace ColligoTest
{
	[TestFixture]
	public class Test_ChangeMultiDayStart
	{
		ChangeMultiDayStart change; 

		[SetUp]
		public void SetUp()
		{
			change = new ChangeMultiDayStart();
		}

		[Test]
		public void ChangeMultiDateStart_ReturnsValidString()
		{
			string expected = "change_multi_day_start";
			change.AddValue(true);

			string actual = change.GetQueryParameter();
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void ChangeMultiDateStart_NullValueReturnedIfNotToBeIncluded()
		{
			Assert.IsNull(change.GetQueryParameter());
		}

	}
}
