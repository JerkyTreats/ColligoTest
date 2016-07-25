namespace Colligo.REST
{
	public class Id : IQueryParameter
	{
		static string _key = "id";
		string _value;

		public void AddValue(string id)
		{
			id = id.Trim();
			if (ValidId(id))
				_value = id;
		}

		public string GetQueryParameter()
		{
			return QueryTools.GetQueryParameter(_key, _value);
		}

		bool ValidId(string id)
		{
			//ex. "E0-001-000278174-6"
			bool valid = true;
			string[] split = id.Split('-');

			if (
			split.Length != 4 
			|| split[0].Length != 2
			|| split[1].Length != 3
			|| split[2].Length != 9
			|| split[3].Length != 1
			)
				valid = false;
			return valid;
		}

	}
}