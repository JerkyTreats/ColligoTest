namespace Colligo.REST.Query
{
	/// <summary>
	/// Forms the parameter specifying the specific page number to include in the search results. 
	/// </summary>
	public class PageNumber: IQueryParameter
	{
		static string _key = "page_number";
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