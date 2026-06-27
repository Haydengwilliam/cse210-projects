public class Checklist : Goal
{
    private int _PointsPossible;
    private int _RepetitionCount;

    public Checklist(string objective, int PointsEarned, int PointsPossible, int RepetitionCount) : base(objective, PointsEarned)
    {
        _PointsPossible = PointsPossible;
        _RepetitionCount = RepetitionCount;
    }

    public override string ToString()
    {
        return base.ToString() + $":{_PointsPossible}:{_RepetitionCount}";
    }

    public int GetPointsPossible()
    {
        return _PointsPossible;
    }

    public void SetPointsPossible(int points)
    {
        _PointsPossible = points;
    }

    public int GetRepetitionCount()
    {
        return _RepetitionCount;
    }

    public void SetRepetitionCount(int count)
    {
        _RepetitionCount = count;
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
                if (goalType == "Checklist" && iterCount == goalIndex)
                {
                    this.SetObjective(data[0]);
                    this.SetPointsEarned(int.Parse(data[1]));
                    this.SetPointsPossible(int.Parse(data[2]));
                    this.SetRepetitionCount(int.Parse(data[3]));
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