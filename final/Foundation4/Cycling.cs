public class Cycling : Activity
{
    private int _speed;

    public Cycling(int Speed, string Date, int Length) : base(Date, Length)
    {
        _speed = Speed;
    }

    public override int GetSpeed()
    {
        return _speed;
    }

    public void SetSpeed(int Speed)
    {
        _speed = Speed;
    }

    public override int GetDistance()
    {
        return this.GetLength() * _speed;
    }

    public override int GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}Distance: {this.GetDistance()} miles, Speed: {_speed} mph, Pace: {this.GetPace()} min per mile";
    }
}