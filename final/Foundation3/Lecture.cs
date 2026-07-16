public class Lecture : Event{
    private string _speaker;
    private int _capacity;

    public Lecture(string Speaker, int Capacity, string Title, string Description, string Date, string Time, Address newAddress) : base(Title, Description, Date, Time, newAddress)
    {
        _speaker = Speaker;
        _capacity = Capacity;
    }

    public string GetFull()
    {
        return $"{base.GetDescription()}\n{_speaker}\n{_capacity}";
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public void SetSpeaker(string Speaker)
    {
        _speaker = Speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void SetCapacity(int Capacity)
    {
        _capacity = Capacity;
    }
}