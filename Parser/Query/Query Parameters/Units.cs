using System.Collections.Generic;

namespace Colligo.REST.Query
{
	/// <summary>
	///  Unit type to use when specifying a location range.
	///  Ignored if Location and Within parameters are null
	/// </summary>
	public class Units : IQueryParameter
	{
		static string _key = "units";
		static string _value;

		public enum Types { Kilometers, Miles }

		public Dictionary<Types, string> UnitTypes = new Dictionary<Types, string>()
		{
			{Types.Kilometers, "km" },
			{Types.Miles, "mi" }
		};

		public void AddValue(Types unit)
		{
			_value = UnitTypes[unit];
		}

		public string GetQueryParameter()
		{
			return QueryTools.GetQueryParameter(_key, _value);
		}
	}
}