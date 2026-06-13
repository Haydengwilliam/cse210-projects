public class Breathing : Activity
{
    public Breathing(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    public void PromptUserBreathing()
    {
        int workingDuration = _duration;
        Console.WriteLine("Get Ready...\n");
        int DurationRemainder = _duration % 12;
        DisplayLoading(DurationRemainder);
        while (workingDuration > 0)
        {
            Console.WriteLine("Breathe in... 3");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Breathe in... 2");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Breathe in... 1");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Breathe in... 0");
            Thread.Sleep(1500);
            Console.Clear();

            Console.WriteLine("Now breathe out... 3");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Now breathe out... 2");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Now breathe out... 1");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("Now breathe out... 0");
            Thread.Sleep(1500);
            Console.Clear();

            workingDuration -= 12;
        }
    }
}