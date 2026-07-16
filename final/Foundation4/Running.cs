public class Running : Activity
{
    private int _distance;

    public Running(int Distance, string Date, int Length) : base(Date, Length)
    {
        _distance = Distance;
    }

    public override int GetDistance()
    {
        return _distance;
    }

    public void SetDistance(int Distance)
    {
        _distance = Distance;
    }

    public override int GetSpeed()
    {
        return this.GetLength() / _distance * 60;
    }

    public override int GetPace()
    {
        return this.GetLength() / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}Distance: {_distance} miles, Speed: {this.GetSpeed()} mph, Pace: {this.GetPace()} min per mile";
    }
}