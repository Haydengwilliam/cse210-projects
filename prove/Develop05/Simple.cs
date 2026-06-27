public class Simple : Goal
{
    private int _PointsPossible;

    public Simple(string objective, int PointsPossible, int PointsEarned) : base(objective, PointsEarned)
    {
        _PointsPossible = PointsPossible;
    }

    public int GetPointsPossible()
    {
        return _PointsPossible;
    }

    public void SetPointsPossible(int points)
    {
        _PointsPossible = points;
    }
    public override string ToString()
    {
        return base.ToString() + $":{_PointsPossible}";
    }

    public void ImportGoal(string filepath, int goalIndex = 1) //Whatever twisted individual saw fit to impose a demand that this insignificant little program that we are just making for homework needs to have save/load functionality is the one responsible for bringing this inane nuiscence of code into the world, not me. (Also, I hope they do not delude themself into thinking that I ever plan to use this program once I submit it. I never want to see it again.)
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
                if (goalType == "Simple" && iterCount == goalIndex)
                {
                    this.SetObjective(data[0]);
                    this.SetPointsEarned(int.Parse(data[1]));
                    this.SetPointsPossible(int.Parse(data[2]));
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