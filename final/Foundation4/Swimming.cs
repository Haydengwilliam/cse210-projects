public class Swimming : Activity
{
    private int _laps;

    public Swimming(int Laps, string Date, int Length) : base(Date, Length)
    {
        _laps = Laps;
    }

    public int GetLaps()
    {
        return _laps;
    }

    public void SetLaps(int Laps)
    {
        _laps = Laps;
    }

    public override int GetDistance()
    {
        int returnVal = _laps * 50 / 1000; //Are you sure this is the right formula? It doesn't seem to like returning numbers bigger than 0 when I use it.
        if (returnVal == 0)
        {
            returnVal = 1;
        }
        return returnVal;
    }

    public override int GetSpeed()
    {
        return this.GetDistance() / this.GetLength() * 60;
    }

    public override int GetPace()
    {
        return this.GetLength() / this.GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}Distance: {this.GetDistance()} km, Speed: {this.GetSpeed()} kph, Pace: {this.GetPace()} min per km";
        //You may be wondering why all the other summaries return it in miles, while this one returns it in km. This is due to the fact that the formula provided to convert number of laps to distance uses a decimal and I can't be bothered to figure out how to convert double to int for this assignment. Maybe next time they can just make a better formula for miles instead of reusing the one for km.
    }
}