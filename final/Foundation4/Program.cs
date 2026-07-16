using System;

class Program
{
    static void Main(string[] args)
    {
        Running newRunning = new Running(5, "7-16-26", 60);
        Cycling newCycling = new Cycling(15, "7-16-25", 30);
        Swimming newSwimming = new Swimming(3, "7-16-26", 25);

        Console.WriteLine($"{newRunning.GetSummary()}\n{newCycling.GetSummary()}\n{newSwimming.GetSummary()}");
    }
}