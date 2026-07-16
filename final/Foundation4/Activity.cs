public abstract class Activity
{
    private string _date;
    private int _length;

    public Activity(string Date, int Length)
    {
        _date = Date;
        _length = Length;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string Date)
    {
        _date = Date;
    }

    public int GetLength()
    {
        return _length;
    }

    public void SetLength(int Length)
    {
        _length = Length;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType()} - ";
    }

    public virtual int GetDistance()
    {
        return 0;
    }

    public virtual int GetSpeed()
    {
        return 0;
    }

    public virtual int GetPace()
    {
        return 0;
    }
}