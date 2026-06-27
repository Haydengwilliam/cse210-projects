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