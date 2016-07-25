using NUnit.Framework;
using Colligo.REST;

namespace ColligoTest
{
	[TestFixture]
	public class Test_Id
	{
		Id id;
		string goodId = "E0-001-000278174-6";

		[SetUp]
		public void SetUp()
		{
			id = new Id();

		}

		[Test]
		public void Id_ValidValueReturnsWellFormedString()
		{
			string expected = "id=" + goodId;

			id.AddValue(goodId);

			string actual = id.GetQueryParameter();

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Id_AddingInvalidIdIgnored()
		{
			string expected = "id=" + goodId;

			id.AddValue(goodId);
			id.AddValue("banana test id");

			string actual = id.GetQueryParameter();

			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void Id_NullIdReturnsNullParameterString()
		{
			Assert.IsNull(id.GetQueryParameter());
		}
	}
}
