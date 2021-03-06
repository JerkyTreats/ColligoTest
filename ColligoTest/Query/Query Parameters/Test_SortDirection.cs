﻿using NUnit.Framework;
using Colligo.REST.Query;

namespace ColligoTest
{
	[TestFixture]
	class Test_SortDirection
	{
		SortDirection sd;

		[SetUp]
		public void SetUp()
		{
			sd = new SortDirection();
		}

		[Test]
		public void SortDirection_AscendingReturnsCorrectStringValue()
		{
			Assert.AreEqual("ascending", sd.Directions[SortDirection.Types.Ascending]);
		}

		[Test]
		public void SortDirection_DescendingReturnsCorrectStringValue()
		{
			Assert.AreEqual("descending", sd.Directions[SortDirection.Types.Descending]);
		}

		[Test]
		public void SortDirection_UnsetValueReturnsNullString()
		{
			Assert.IsNull(sd.GetQueryParameter());
		}

		[Test]
		public void SortDirection_ReturnsDescendingString()
		{
			string expected = "sort_direction=descending";

			sd.SetValue(SortDirection.Types.Descending);
			string formedString = sd.GetQueryParameter();

			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void SortDirection_ReturnsAscendingString()
		{
			string expected = "sort_direction=ascending";

			sd.SetValue(SortDirection.Types.Ascending);
			string formedString = sd.GetQueryParameter();
			Assert.AreEqual(expected, formedString);
		}
	}
}
