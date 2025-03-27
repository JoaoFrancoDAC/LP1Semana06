using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
    
        {
            Stopwatch cron1 = new Stopwatch();
            Stopwatch cron2 = new Stopwatch();
            cron1.Start();
            Thread.Sleep(500);
            cron2.Start();
            Thread.Sleep(250);
            cron1.Stop(); 
            cron2.Stop();

            TimeSpan ts1 = cron1.Elapsed;
            TimeSpan ts2 = cron2.Elapsed;

            Console.WriteLine($"{cron1.Elapsed.TotalSeconds:F4}");
            Console.WriteLine($"{cron2.Elapsed.TotalSeconds:F4}");
        }
    }
}
