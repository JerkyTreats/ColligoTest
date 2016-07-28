using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colligo.REST.Query
{
	public class VenuesGet : IQuery
	{
		static string QUERY_TYPE = "venues/get";

		public Id Id = new Id();
		public Mature Mature = new Mature();

		public List<IQueryParameter> QueryParameters = new List<IQueryParameter>();

		public VenuesGet()
		{
			QueryParameters.Add(Id);
			QueryParameters.Add(Mature);
		}

		public string BuildQuery()
		{
			return QueryTools.GetQuery(QUERY_TYPE, QueryParameters);
		}
	}
}
