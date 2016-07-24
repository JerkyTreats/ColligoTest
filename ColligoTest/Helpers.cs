using System;
using System.Net;

namespace ColligoTest
{
	/// <summary>
	/// Static class that holds the data to successfully connect to the API. 
	/// </summary>
	public static class Data
	{
		static string _url = "http://bad.eventful.com/rest/events/search";
		static string _key = "2SZRKGrNmCMGT6PS";
	
		/// <summary>
		/// API key for Eventful. ***POTENTIALLY INSECURE***
		/// </summary>
		public static string Key { get { return string.Format("app_key={0}", _key); } }
		
		/// <summary>
		/// Root URL for Eventful
		/// </summary>
		public static string URL { get { return _url; } }

	}
}
