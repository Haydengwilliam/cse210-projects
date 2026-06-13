public class Reflection : Activity
{
    private List<string> _PromptList;
    private List<string> _QuestionList;

    public Reflection(string name, string description, int duration, List<string> PromptList, List<string> QuestionList) : base(name, description, duration)
    {
        _PromptList = PromptList;
        _QuestionList = QuestionList;
    }

    public string GivePrompt(List<string> prompts)
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        return prompt;
    }

    public string GiveQuestion(List<string> questions)
    {
        if (questions.Count == 0)
        {
            questions = _QuestionList;
        }
        Random random = new Random();
        int NewIndex = random.Next(questions.Count);
        string question = questions[NewIndex];
        questions.RemoveAt(NewIndex);
        return question;
    }

    public void MakeUserReflect()
    {
        int workingDuration = _duration;
        List<string> WorkingQuestionList = _QuestionList;
        Console.WriteLine("Get Ready...\n");
        DisplayLoading(3);            
        string NewPrompt = GivePrompt(_PromptList);
        Console.WriteLine($"{NewPrompt}\nPress any key when you are ready to continue...");
        Console.ReadKey();
        while (workingDuration > 0)
        {
            string NewQuestion = GiveQuestion(WorkingQuestionList);
            Console.WriteLine(NewQuestion);
            DisplayLoading(8);
            workingDuration -= 8;
        }
    }
}