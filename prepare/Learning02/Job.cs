public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public static void Display(Job jobObject)
    {
        Console.WriteLine(jobObject._jobTitle + " (" + jobObject._company + ") " + jobObject._startYear + "-" + jobObject._endYear);
    }
}