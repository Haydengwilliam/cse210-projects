public class Resume
{
    public string _name;
    public List<Job> _jobList = new List<Job>();
        public static void Display(Resume resumeObject)
    {
        Console.WriteLine("Name: " + resumeObject._name + "\nJobs:");
        foreach (Job item in resumeObject._jobList)
        {
            Job.Display(item);
        }
    }
}