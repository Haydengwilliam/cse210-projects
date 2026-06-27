public abstract class Goal
{
    private string _objective;
    private int _PointsEarned;

    public Goal(string objective, int PointsEarned){
        _objective = objective;
        _PointsEarned = PointsEarned;
    }

    public override string ToString()
    {
        return $"{_objective}:{_PointsEarned}";
    }

    public string GetObjective()
    {
        return _objective;
    }

    public int GetPointsEarned()
    {
        return _PointsEarned;
    }

    public void SetPointsEarned(int points)
    {
        _PointsEarned = points;
    }

    public void SetObjective(string objective)
    {
        _objective = objective;
    }


    public void ExportGoal(string filepath)
    {
        try
        {
            if (!File.Exists(filepath))
            {
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.Write(this.GetType() + "|" + this.ToString() + ",");
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.Write(this.GetType() + "|" + this.ToString() + ",");
                }
            }
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Invalid Path");
        }
    }
}