using NUnit.Framework;
using Colligo.REST;

namespace ColligoTest
{
	[TestFixture]
	public class Test_Util
	{
		[Test]
		public void Util_ReplaceWhitespaceSuccessfullyRemovesWhitespace()
		{
			string input = "    Bad Input   ";
			Assert.AreEqual("BadInput", Util.RemoveWhitespace(input));
		}

		[Test]
		public void Util_ReplaceWhitespaceWithNullValueReturnsNull()
		{
			Assert.IsNull(Util.RemoveWhitespace(null));
		}
	}
}
