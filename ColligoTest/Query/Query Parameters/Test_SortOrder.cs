﻿using NUnit.Framework;
using Colligo.REST.Query;

namespace ColligoTest
{
	[TestFixture]
	class Test_SortOrders
	{
		SortOrder so;

		[SetUp]
		public void SetUp()
		{
			so = new SortOrder();
		}

		[Test]
		public void SortOrders_PopularityReturnsCorrectStringValue()
		{
			Assert.AreEqual("popularity", so.Orders[SortOrder.Types.Popularity]);
		}

		[Test]
		public void SortOrders_RelevanceReturnsCorrectStringValue()
		{
			Assert.AreEqual("relevance", so.Orders[SortOrder.Types.Relevance]);
		}

		[Test]
		public void SortOrders_DateReturnsCorrectStringValue()
		{
			Assert.AreEqual("date", so.Orders[SortOrder.Types.Date]);
		}

		[Test]
		public void SortOrder_ReturnsPopularityString()
		{
			string expected = "sort_order=popularity";
			so.SetValue(SortOrder.Types.Popularity);

			string formedString = so.GetQueryParameter();

			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void SortOrder_ReturnsDateString()
		{
			string expected = "sort_order=date";
			so.SetValue(SortOrder.Types.Date);

			string formedString = so.GetQueryParameter();

			Assert.AreEqual(expected, formedString);
		}

		[Test]
		public void SortOrder_ReturnsRelevanceString()
		{
			string expected = "sort_order=relevance";
			so.SetValue(SortOrder.Types.Relevance);
			string formedString = so.GetQueryParameter();
			Assert.AreEqual(expected, formedString);
		}
	}
}
