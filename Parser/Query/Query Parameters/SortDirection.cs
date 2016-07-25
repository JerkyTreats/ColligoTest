using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colligo.REST
{
	public class SortDirection : IQueryParameter
	{
		static string _key = "sort_direction";
		string _value;

		public enum Types { Ascending, Descending }
		public Dictionary<Types, string> Directions = new Dictionary<Types, string>()
		{
			{Types.Ascending, "ascending" },
			{Types.Descending, "descending" }
		};

		public void SetValue(Types direction)
		{
			_value = Directions[direction];
		}

		public string GetQuery()
		{
			return QueryTools.GetQuery(_key, _value);
		}
	}
}
