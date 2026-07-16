public class Outdoor : Event {
    private string _weather;

    public Outdoor(string Weather, string Title, string Description, string Date, string Time, Address newAddress) : base(Title, Description, Date, Time, newAddress)
    {
        _weather = Weather;
    }

    public string GetFull()
    {
        return $"{base.GetDescription()}\n{_weather}";
    }

    public string GetWeather()
    {
        return _weather;
    }

    public void SetWeather(string Weather)
    {
        _weather = Weather;
    }
}