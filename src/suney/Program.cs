using System;
using System.Timers;
using RestSharp;
using RestSharp.Authenticators;

namespace suney
{
    class Program
    {
        // Demo
        private const string USER_KEY = "4d7a45774e6a41320a";
        private const string API_KEY = "96a7de32fabc1dd8ff68ec43eca21c06";

        private static System.Timers.Timer LoopTimer;

        static void Main(string[] args)
        {
            SetTimer();

            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.ReadLine();
            LoopTimer.Stop();
            LoopTimer.Dispose();
            
            Console.WriteLine("Terminating the application...");

            // var client = new RestClient("https://api.enphaseenergy.com/api/v2");
            // client.Authenticator = new SimpleAuthenticator("key", API_KEY, "user_id", USER_KEY);

            // var request = new RestRequest("systems/67/summary", DataFormat.Json);
            // SystemSummary response = client.Get<SystemSummary>(request).Data;
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            LoopTimer = new System.Timers.Timer(2000);
            LoopTimer.Elapsed += OnTimedEvent;
            LoopTimer.AutoReset = true;
            LoopTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
