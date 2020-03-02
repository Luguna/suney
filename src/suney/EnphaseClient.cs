using System;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;

namespace suney
{
    class EnphaseClient
    {
        private const string DEMO_SYSTEM_ID = "67";
        private const string DEMO_USER_ID = "4d7a45774e6a41320a";
        private const string DEMO_API_KEY = "96a7de32fabc1dd8ff68ec43eca21c06";
        private const string BASE_URL = "https://api.enphaseenergy.com/api/v2";
        private readonly RestClient Client;
        private string SystemId { get; set; }
        private string UserId { get; set; }
        private string ApiKey { get; set; }

        public EnphaseClient()
        {
            SystemId = Environment.GetEnvironmentVariable("ENPHASE_SYSTEM_ID") ?? DEMO_SYSTEM_ID;
            UserId = Environment.GetEnvironmentVariable("ENPHASE_USER_ID") ?? DEMO_USER_ID;
            ApiKey = Environment.GetEnvironmentVariable("ENPHASE_API_KEY") ?? DEMO_API_KEY;
            Client = new RestClient
            {
                BaseUrl = new Uri(BASE_URL),
                Authenticator = new SimpleAuthenticator("user_id", UserId, "key", ApiKey)
            };
            Client.UseNewtonsoftJson();
            Client.AddDefaultQueryParameter("datetime_format","iso8601");
        }

        public Summary GetSystemSummary()
        {
            var request = new RestRequest($"systems/{SystemId}/summary", DataFormat.Json);
            // var temp = Client.Get(request).Content;
            // Summary response = Client.Get<Summary>(request).Data;
            // Console.WriteLine(response.LastReportAt);
            return Client.Get<Summary>(request).Data;
        }

        public ProductionStats GetStats()
        {
            var request = new RestRequest($"systems/{SystemId}/stats", DataFormat.Json);
            //request.AddQueryParameter("start_at", "blah");
            return Client.Get<ProductionStats>(request).Data;
        }

        public void GetConsumptionStats()
        {
             
        }
    }
}