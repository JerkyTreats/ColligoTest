using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colligo.REST
{
	public class SortOrder : IQueryParameter
	{
		static string _key = "sort_order";
		string _value;

		public enum Types { Popularity, Date, Relevance }

		public Dictionary<Types, string> Orders = new Dictionary<Types, string>()
		{
			{ Types.Popularity, "popularity" },
			{ Types.Date, "date" },
			{ Types.Relevance, "relevance" }
		};

		public void SetValue(Types order)
		{
			_value = Orders[order];
		}

		public string GetQueryParameter()
		{
			return QueryTools.GetQueryParameter(_key, _value);
		}
	}
}
