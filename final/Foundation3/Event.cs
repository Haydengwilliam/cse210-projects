public class Event{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string Title, string Description, string Date, string Time, Address newAddress)
    {
        _title = Title;
        _description = Description;
        _date = Date;
        _time = Time;
        _address = newAddress;
    }

    public string GetStandard()
    {
        return $"{_title}\n{_description}\n{_date}, {_time}\n{_address}";
    }

    public string GetShortDescription()
    {
        return $"{this.GetType()}: {_title}, {_date}";
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string Title)
    {
        _title = Title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string Description)
    {
        _description = Description;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string Date)
    {
        _date = Date;
    }

    public string GetTime()
    {
        return _time;
    }

    public void SetTime(string Time)
    {
        _time = Time;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(Address newAddress)
    {
        _address = newAddress;
    }    
}