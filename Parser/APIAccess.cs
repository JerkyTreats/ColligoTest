using System.Net;
using Newtonsoft.Json;
using Colligo.REST.Query;
using Colligo.REST.Response;
using System.Collections.Generic;
using System;

namespace Colligo.REST
{
	/// <summary>
	/// Makes an API call to the server 
	/// </summary>
	public static class APIAccess
	{

		/// <summary>
		/// Get the data from the server as a string
		/// </summary>
		/// <param name="uri"></param>
		/// <returns></returns>
		public static string GetStringResponseFromAPI(Uri uri)
		{
			WebClient webClient = new WebClient();
			return webClient.DownloadString(uri);
		}

		//	if (data.Contains("\"status\" :") && data.Contains("\"error\" :") && data.Contains("\"description\" :"))
		//throw new ApplicationException(string.Format("API Returned an exception : [{0}]", data));
	}
}
