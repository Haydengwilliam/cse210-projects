using System.Runtime.CompilerServices;

public class Eternal : Goal
{
    public Eternal(string objective, int PointsEarned) : base(objective, PointsEarned){}

    public void ImportGoal(string filepath, int goalIndex = 1)
    {
        try
        {
            int iterCount = 1;
            string newGoal = File.ReadAllText(filepath);
            string[] newGoalList = newGoal.Split(",")[..^1];
            foreach (string goalString in newGoalList)
            {
                string goalType = goalString.Split("|")[0];
                string newGoalString = goalString.Split("|")[1];
                string[] data = newGoalString.Split(":");
                if (goalType == "Eternal" && iterCount == goalIndex)
                {
                    this.SetObjective(data[0]);
                    this.SetPointsEarned(int.Parse(data[1]));
                    iterCount++;
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Invalid Path");
        }
    }
}