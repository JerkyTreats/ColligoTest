
using System.Collections.Generic;

namespace Colligo.REST
{
	/// <summary>
	/// Forms the parameter specifying additional optional sections should be included in the returned XML
	/// </summary>
	public class Include : IQueryParameter
	{
		static string _include = "include";
		List<Types> _values = new List<Types>();

		public enum Types { Categories, Subcategories, Popularity, Tickets, Price, Links }

		public Dictionary<Types, string> Options = new Dictionary<Types, string>()
		{
			{Types.Categories, "categories" },
			{Types.Subcategories, "subcategories" },
			{Types.Popularity, "popularity" },
			{Types.Tickets, "tickets" },
			{Types.Price, "price" },
			{Types.Links, "links" }
		};

		public void AddValues(params Types[] options)
		{
			foreach (var option in options)
			{
				_values.Add(option);
			}
		}

		public string GetQuery()
		{
			return QueryTools.GetQuery(_include, ValuesToList());
		}

		string ValuesToList()
		{
			if (_values.Count < 1)
				return null;

			string value = Options[_values[0]];

			for (int i = 1; i < _values.Count; i++)
			{
				value += "," + Options[_values[i]];
			}

			return value;
		}
	}
}
