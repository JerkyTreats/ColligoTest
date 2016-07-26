using System.Net;
using Newtonsoft.Json;
using Colligo.REST.Query;
using Colligo.REST.Response;
using System.Collections.Generic;
using System;

namespace Colligo.REST
{
	/// <summary>
	/// Makes API calls, deserializes the information returned into usable objects 
	/// </summary>
	public class Parser
	{
		/// <summary>
		/// Specifies the available API calls that can be made
		/// </summary>
		public enum QueryTypes { Search, Get }
		WebClient _webClient;

		public Parser()
		{
			_webClient = new WebClient();
		}

		/// <summary>
		/// Performs a search query to the API by SearchQuery
		/// </summary>
		/// <param name="query"></param>
		/// <returns></returns>
		public SearchResponse Search(SearchQuery query)
		{
			string response = GetAPIResponse(query);
			SearchResponse deserializedObject = DeserializeResponse<SearchResponse>(response);
			return deserializedObject;
		}

		public GetResponse Get(GetQuery query)
		{
			string response = GetAPIResponse(query);
			GetResponse deserializedObject = DeserializeResponse<GetResponse>(response);
			return deserializedObject;
		}

		//Get the data from the server as a string
		string GetAPIResponse(IQuery query)
		{
			string response = GetResponse(query.BuildQuery());
			if (response.Contains("\"status\" :") && response.Contains("\"error\" :") && response.Contains("\"description\" :"))
				throw new ApplicationException(string.Format("API Returned an exception : [{0}]", response));
			return response;
		}

		//Deserialzes the inputted JSON string to the specified type
		T DeserializeResponse<T>(string response)
		{
			T deserializedObject = JsonConvert.DeserializeObject<T>(response, Data.DefaultJSONSerializerSettings);
			return deserializedObject;
		}

		//get the text response from the WebClient
		string GetResponse(string uriString)
		{
			var uri = new System.Uri(uriString);
			string data = _webClient.DownloadString(uri);
			return data;
		}
	}
}
