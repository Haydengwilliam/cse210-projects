public class Screaming : Activity
{
    public Screaming(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    public void PromptUserScreaming()
    {
        Console.WriteLine("Get Ready...\n");
        DisplayLoading(3);
        Console.WriteLine("Now scream at the top of your lungs.");
        Thread.Sleep((_duration - 3) * 1000);
    }
}