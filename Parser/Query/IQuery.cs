using Colligo.REST.Response;

namespace Colligo.REST.Query
{
	public interface IQuery
	{
		string GetQuery();
		Parser.QueryTypes GetQueryType();
	}
}