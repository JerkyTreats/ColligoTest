using NUnit.Framework;
using Colligo.REST;

namespace ColligoTest
{
	[TestFixture]
	public class Test_Get
	{
		Get get;

		[SetUp]
		public void SetUp()
		{
			get = new Get();
		}

		[Test]
		public void Get_GetQueryWithNoSetOptionsReturnsBaseQueryString()
		{
			string expected = Data.QueryBase;
			string actual = get.GetQuery();
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Get_GetQueryWithMulitpleValuesSetReturnsCorrectString()
		{
			string expected = Data.QueryBase + "&id=E0-001-000278174-6&image_sizes=small,thumb";
			get.Id.AddValue("E0-001-000278174-6");
			get.Image.AddValues(Image.Types.Small, Image.Types.Thumb);

			string actual = get.GetQuery();
			Assert.AreEqual(expected, actual);
		}
	}
}
