using NUnit.Framework;
using Colligo.REST;

namespace ColligoTest
{
	[TestFixture]
	public class Test_Get
	{
		[Test]
		public void Get_GetIdWithEmptyParameterReturnsNull()
		{
			string nullString = Get.GetId(null);
			Assert.IsNull(nullString);
		}

		[Test]
		public void Get_GetIdWithValidParametersReturnsExpectedResult()
		{
			string appender = "test,wow";
			string validString = Get.GetId(appender);
			Assert.AreEqual("id=" + appender, validString);
		}

		[Test]
		public void Get_GetIdWithWhitespaceParametersAutomaticallyRemoved()
		{
			string whitespace = "   Bad Input   ";
			string formedId = Get.GetId(whitespace);
			Assert.AreEqual("id=BadInput", formedId);
		}
	}
}
