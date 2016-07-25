namespace Colligo.REST
{
	/// <summary>
	/// Forms the parameter specifying the distance from the location requested. 
	/// Ignored if a Location parameter is not included in the query.
	/// </summary>
	public class Within : IQueryParameter
	{
		static string _key = "page_size";
		string _value;

		public void AddValue(int value)
		{
			if (value >= 1)
				_value = value.ToString();
		}

		public string GetQueryParameter()
		{
			return QueryTools.GetQueryParameter(_key, _value);
		}
	}
}