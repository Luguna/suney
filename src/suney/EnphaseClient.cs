using System;
using RestSharp;
using RestSharp.Authenticators;

namespace suney
{
    class EnphaseClient
    {
        private const string DEMO_SYSTEM_ID = "67";
        private const string DEMO_USER_ID = "4d7a45774e6a41320a";
        private const string DEMO_API_KEY = "96a7de32fabc1dd8ff68ec43eca21c06";

        private string systemId { get; set; }
        private string userId { get; set; }
        private string apiKey { get; set; }
        private RestClient client { get; set; }

        public EnphaseClient()
        {
            systemId = Environment.GetEnvironmentVariable("SYSTEM_ID") ?? DEMO_SYSTEM_ID;
            userId = Environment.GetEnvironmentVariable("USER_KEY") ?? DEMO_USER_ID;
            apiKey = Environment.GetEnvironmentVariable("API_KEY") ?? DEMO_API_KEY;
            client = new RestClient("https://api.enphaseenergy.com/api/v2");
            client.Authenticator = new SimpleAuthenticator("user_id", userId, "key", apiKey);
        }

        public void GetSystemSummary()
        {
            var request = new RestRequest($"systems/{systemId}/summary", DataFormat.Json);
            SystemSummary response = client.Get<SystemSummary>(request).Data;
            Console.WriteLine(response.last_report_at);
        }
    }
}