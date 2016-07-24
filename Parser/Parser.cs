using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Colligo.REST
{
	public class Parser
	{
		static string BASE = string.Format("{0}?app_key={1}", Data.URL, Data.Key);

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
			string formed = BASE;

			foreach(string option in options)
			{
				formed = string.Format("{0}&{1}",formed,option);
			}

			return formed;
		}
    }
}
