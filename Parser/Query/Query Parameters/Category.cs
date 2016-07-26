using System.Collections.Generic;

namespace Colligo.REST.Query
{
	/// <summary>
	/// Forms the parameter specifying the categories to exclude from the search results. 
	/// </summary>
	public class Category : IQueryParameter
	{
		static string _key = "category";
		List<string> _values = new List<string>();

		public void AddValue(params string[] categories)
		{
			foreach (string category in categories)
			{
				_values.Add(category);
			}
		}

		public string GetQueryParameter()
		{
			return QueryTools.GetQueryParameter(_key, ValuesToString());
		}

		string ValuesToString()
		{
			if (_values.Count < 1)
				return null;
			string value = _values[0];
			for (int i = 1; i < _values.Count; i++)
			{
				value += "," + _values[i];
			}
			return value;
		}

	}
}