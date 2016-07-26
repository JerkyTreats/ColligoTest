using System.Net;
using Newtonsoft.Json;

namespace Colligo.REST
{
	public class Parser
	{
		WebClient _webClient;

		/// <summary>
		/// WebClient to manage requests to target 
		/// </summary>
		public WebClient WebClient
		{
			get
			{
				if (_webClient == null)
					_webClient = new WebClient();
				return _webClient;
			}
		}

		public SearchResponse SendQuery(IQuery query)
		{
			string response = GetResponse(query);
			SearchResponse searchResponse = JsonConvert.DeserializeObject<SearchResponse>(response, Data.DefaultJSONSerializerSettings);
			return searchResponse;
		}

		string GetResponse(IQuery query)
		{
			var uri = new System.Uri(query.GetQuery());
			string data = WebClient.DownloadString(uri);
			return data;
		}

    }
}
