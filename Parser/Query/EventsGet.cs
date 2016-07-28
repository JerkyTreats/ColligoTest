using System.Collections.Generic;

namespace Colligo.REST.Query
{
	/// <summary>
	/// Forms the query string for the Get API Call.
	/// </summary>
	public class EventsGet : IQuery
	{
		static string QUERY_TYPE = @"events/get";

		public Id Id = new Id();
		public Image Image = new Image();

		List<IQueryParameter> QueryParameters = new List<IQueryParameter>();

		public EventsGet()
		{
			QueryParameters.Add(Id);
			QueryParameters.Add(Image);
		}

		public string BuildQuery()
		{
			return QueryTools.GetQuery(QUERY_TYPE, QueryParameters);
		}
	}
}
