using Newtonsoft.Json;


namespace Colligo.REST
{
	/// <summary>
	/// This is a convenience class to hold miscellanious data. 
	/// </summary>
	public static class Data
	{
		static string _url = "http://api.eventful.com/json/";
		static string _key = "2SZRKGrNmCMGT6PS";

		/// <summary>
		/// API key for Eventful. ***POTENTIALLY INSECURE***
		/// </summary>
		public static string Key { get { return string.Format("app_key={0}", _key); } }

		/// <summary>
		/// Root URL for Eventful
		/// </summary>
		public static string URL { get { return _url; } }

		public static JsonSerializerSettings DefaultJSONSerializerSettings
		{
			get
			{
				return new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
			}
		}
	}
}