﻿
namespace Colligo.REST
{
	public class BasicQueryParameter : IQueryParameter
	{
		string _key;
		string _value;

		public BasicQueryParameter(string key)
		{
			_key = key;
		}

		public virtual void AddValue(string value)
		{
			_value = value;
		}

		public virtual string GetQuery()
		{
			return QueryTools.GetQuery(_key, _value);
		}
	}
}