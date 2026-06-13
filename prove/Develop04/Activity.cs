public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string StartMessage()
    {
        return $"Welcome to the {_name}\n\n{_description}\nYou will do this for {_duration} seconds.";
    }

    public string EndMessage()
    {
        return $"Well done\n\nYou have completed {_duration} seconds of the {_name}";
    }

    public string GetString()
    {
        return $"{_name}-{_description}-{_duration}";
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayLoading(int duration)
    {
        while (duration != 0)
        {
            Console.Write(".");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("..");
            Thread.Sleep(250);
            Console.Write("\b\b  \b\b");
            Console.Write("...");
            Thread.Sleep(250);
            Console.Write("\b\b\b   \b\b\b");
            Thread.Sleep(250);
            duration--;
        }
    }
}