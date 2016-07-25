using System;
using System.Net;

namespace Colligo.REST
{
	/// <summary>
	/// Class that holds the data to successfully connect to the API. 
	/// </summary>
	public class Data
	{
		static string _url = "http://api.eventful.com/rest/events/search";
		static string _key = "2SZRKGrNmCMGT6PS";

		/// <summary>
		/// API key for Eventful. ***POTENTIALLY INSECURE***
		/// </summary>
		public static string Key { get { return string.Format("app_key={0}", _key); } }
		
		/// <summary>
		/// Root URL for Eventful
		/// </summary>
		public static string URL { get { return _url; } }

		public static string QueryBase { get { return string.Format("{0}?{1}", URL, Key); } }

	}


}
