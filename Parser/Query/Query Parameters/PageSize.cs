namespace Colligo.REST
{
	/// <summary>
	/// Forms the parameter specifying the number of results per page. Only integers great than zero sent as a string allowed
	/// </summary>
	public class PageSize : IQueryParameter
	{
		static string _key = "page_size";
		string _value;

		public void AddValue(int value)
		{
			if (value > 100)
				value = 100;
			if (value >= 1)
				_value = value.ToString();
		}

		public string GetQuery()
		{
			return QueryTools.GetQuery(_key, _value);
		}
	}
}