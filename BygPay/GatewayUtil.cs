using System;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace BygPay
{
    public class GatewayUtil
    {
		private readonly Configuration _config;

		public GatewayUtil(Configuration config)
        {
            _config = config;
        }

        public bool Post(string Endpoint, string Payload)
        {
            WebClient client = new WebClient();
            client.Headers.Add(HttpRequestHeader.UserAgent, "BygPay .NET SDK Client version " + Configuration.SDK_VERSION);
            client.Headers.Add(HttpRequestHeader.Authorization, _config.ApiKey);
            client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            string response = client.UploadData(Payload);
            return false;
        }
    }
}
