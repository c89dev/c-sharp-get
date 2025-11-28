namespace Scratchpad;
using System;
using System.Timers;

class Program
{
    private static Timer aTimer;
    static void Main(string[] args)
    {
        aTimer = new System.Timers.Timer();
        aTimer.Interval = 2000;
        aTimer.Elapsed += TestMethod;
        aTimer.Enabled = true;
        Console.WriteLine("Hello, World!");
        Console.ReadKey();
    }
    static void TestMethod(Object source, System.Timers.ElapsedEventArgs e)
    {
        Console.WriteLine("Timed Event fires... {0}", e.SignalTime);
        Console.Beep();
    }
}
