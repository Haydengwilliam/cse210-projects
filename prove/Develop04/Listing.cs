public class Listing : Activity
{
    private List<string> _PromptList;

    public Listing(string name, string description, int duration, List<string> PromptList) : base(name, description, duration)
    {
        _PromptList = PromptList;
    }

    public string GivePrompt(List<string> prompts)
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        return prompt;
    }

    public void ListThings()
    {
        int ListedItemCount = 0;
        int workingDuration = _duration - 3;
        Console.WriteLine("Get Ready...\n");
        DisplayLoading(3);
        while (workingDuration > 0)
        {
            string NewPrompt = GivePrompt(_PromptList);
            Console.Write($"{NewPrompt}\nPress Enter when you have finished typing.\n\n");
            Console.ReadLine();
            ListedItemCount++;
            workingDuration -= 10;
        }
        Console.WriteLine($"Good Work. You listed {ListedItemCount} things.");
    }
}