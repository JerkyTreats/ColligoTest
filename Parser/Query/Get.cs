﻿using System.Collections.Generic;

namespace Colligo.REST
{
	/// <summary>
	/// Forms the query string for the Get API Call.
	/// </summary>
	public class Get : IQuery
	{
		public Id Id = new Id();
		public Image Image = new Image();

		List<IQueryParameter> QueryParameters = new List<IQueryParameter>();

		public Get()
		{
			QueryParameters.Add(Id);
			QueryParameters.Add(Image);
		}

		public string GetQuery()
		{
			return QueryTools.GetQuery(QueryParameters);
		}
	}
}
