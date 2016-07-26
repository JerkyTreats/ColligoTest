namespace Colligo.REST.Query
{ 
	/// <summary>
	/// Forms the parameter specifying if the start_date of long duration events should be changed to ensure they are within search date parameter
	/// </summary>
	public class ChangeMultiDayStart : IQueryParameter
	{
		static string _key = "change_multi_day_start";
		bool _value = false;

		public void AddValue(bool value)
		{
			_value = value;
		}

		public string GetQueryParameter()
		{
			if (!_value)
				return null;
			return _key;
		}
	}
}