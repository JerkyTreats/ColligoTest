
namespace Colligo.REST.Query
{
	public class BasicQueryParameter : IQueryParameter
	{
		string _key;
		string _value;

		public BasicQueryParameter(string key)
		{
			_key = key;
		}

		public virtual void AddValue(string value)
		{
			_value = value;
		}

		public virtual string GetQueryParameter()
		{
			return QueryTools.GetQueryParameter(_key, _value);
		}
	}
}
