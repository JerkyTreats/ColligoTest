using System.Net;
using Newtonsoft.Json;
using Colligo.REST.Query;
using System.Collections.Generic;

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
		/// Sends data to the URI, deserializes and returns the response as a usable object
		/// </summary>
		/// <param name="query"></param>
		/// <returns></returns>
		public Response.ResponseData MakeQuery(IQuery query)
		{
			string response = GetResponse(query.GetQuery());
			Response.ResponseData deserializedObject; 
			switch (query.GetQueryType())
			{
				case QueryTypes.Get:
					deserializedObject = DeserializeResponse<Response.Get>(response);
					break;
				case QueryTypes.Search:
					deserializedObject = DeserializeResponse<Response.Search>(response);
					break;
				default:
					return null;
			}
			return deserializedObject;
		}

		// Convert the string data into the appropriate Response object. 
		T DeserializeResponse<T>(string data)
		{
			T deserializedObject = JsonConvert.DeserializeObject<T>(data, Data.DefaultJSONSerializerSettings);
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
