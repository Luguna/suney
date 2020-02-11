using System;
using System.Timers;

namespace suney
{
    class Program
    {
        private static System.Timers.Timer LoopTimer;
        private static EnphaseClient Client { get; set; }

        static void Main(string[] args)
        {
            Client = new EnphaseClient();

            SetTimer();

            Console.WriteLine("\nPress the Enter key to exit the application...\n");
            Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
            Console.ReadLine();
            LoopTimer.Stop();
            LoopTimer.Dispose();
            
            Console.WriteLine("Terminating the application...");
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
            Client.GetSystemSummary();
        }
    }
}
