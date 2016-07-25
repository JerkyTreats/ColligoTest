namespace Colligo.REST
{
	/// <summary>
	/// Specifies whether to limit the results to only total_items and search_time elements. 
	/// </summary>
	public class CountOnly : IQueryParameter
	{
		static string _key = "count_only";
		bool _value = false;

		public void AddValue(bool value)
		{
			_value = value;
		}

		public string GetQuery()
		{
			if (!_value)
				return null;
			return _key;
		}
	}
}