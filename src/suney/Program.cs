using System;
using System.Timers;

namespace suney
{
    class Program
    {
        private const int INTERVAL_IN_SECONDS = 300; // 5 Minutes
        private static System.Timers.Timer LoopTimer;
        private static EnphaseClient Client { get; set; }

        static void Main(string[] args)
        {
            Client = new EnphaseClient();

            Update();

            // SetTimer();

            // Console.WriteLine("\nPress the Enter key to exit the application...\n");
            // Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.ReadLine();
            LoopTimer.Stop();
            LoopTimer.Dispose();
            
            Console.WriteLine("Terminating the application...");
        }

        private static void SetTimer()
        {
            LoopTimer = new System.Timers.Timer(INTERVAL_IN_SECONDS * 1000);
            LoopTimer.Elapsed += OnTimedEvent;
            LoopTimer.AutoReset = true;
            LoopTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}", e.SignalTime);
            Update();
        }

        private static void Update()
        {
            long startTime = CalculateStartTimeForInterval();
            var productionStats = Client.GetProductionStats(startTime);
            var consumptionStats = Client.GetConsumptionStats(startTime);

            if(productionStats.Intervals != null && consumptionStats.Intervals != null)
            {

            }
        }

        private static long CalculateStartTimeForInterval()
        {
            long currentTime = new DateTimeOffset(new DateTime(2020,3,9,12,0,0)).ToUnixTimeSeconds();
            //long currentTime = new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds();
            long timeMinusInterval = currentTime - INTERVAL_IN_SECONDS;
            return timeMinusInterval;
        }
    }
}
