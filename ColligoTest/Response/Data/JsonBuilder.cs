using System.Collections.Generic;
using System.Text;

namespace ColligoTest
{
	public class JsonBuilder
	{
		public static string GetJson(string containerId, string listId, Dictionary<string,object> data)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append(@"""" + containerId + @""" : { """ + listId + @""" : [{");
			int counter = 0;
			foreach (KeyValuePair<string, object> KVP in data)
			{
				builder.Append(@"""" + KVP.Key + @""" : """ + KVP.Value.ToString() + @"""");
				if (counter != data.Count)
					builder.Append(',');
				counter++;
			}
			builder.Append("}]}"); 
			return builder.ToString();
		}
	}
}