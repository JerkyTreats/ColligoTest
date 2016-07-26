using System.Collections.Generic;

namespace Colligo.REST.Query
{
	/// <summary>
	/// Forms the query parameter specifying the maturity level to be returned with the results
	/// </summary>
	public class Mature : IQueryParameter
	{
		static string _mature = "mature";
		string _value;

		public enum Types { All, Normal, Safe}

		public Dictionary<Types, string> Options = new Dictionary<Types, string>()
		{
			{ Types.All, "all" },
			{ Types.Normal, "normal"},
			{ Types.Safe, "safe" }
		};

		public void SetValue(Types option)
		{
			_value = Options[option];
		}

		public string GetQueryParameter()
		{
			return QueryTools.GetQueryParameter(_mature, _value);
		}
	}
}
