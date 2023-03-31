using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            crono1.Start();
            Thread.Sleep(500);
            Stopwatch crono2 = new Stopwatch();
            crono2.Start();
            Thread.Sleep(300);
            crono1.Stop();
            crono2.Stop();

            TimeSpan ts1 = crono1.Elapsed;
            TimeSpan ts2 = crono2.Elapsed;

            string elapsedTime1 = String.Format("{0:}.{1:00}",
                ts1.Seconds, ts1.Milliseconds / 10);

            string elapsedTime2 = String.Format("{0:}.{1:00}",
                ts2.Seconds, ts2.Milliseconds / 10);

            Console.WriteLine("RunTime of crono 1: " + elapsedTime1+"s");
            Console.WriteLine("RunTime of crono 2: " + elapsedTime2+"s");
        }
    }
}
