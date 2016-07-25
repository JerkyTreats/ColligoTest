using System.Net;

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

		/// <summary>
		/// Forms the URL with the API options requested. With no params returns URL with authentication appended
		/// </summary>
		/// <param name="options"></param>
		/// <returns></returns>
		public string FormUrl(params string[] options)
		{
			string formed = Data.QueryBase;

			foreach(string option in options)
			{
				formed = string.Format("{0}&{1}",formed,option);
			}

			return formed;
		}
    }
}
