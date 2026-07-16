public class Address{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string Street, string City, string State, string Country){
        _street = Street;
        _city = City;
        _state = State;
        _country = Country;
    }

    public string GetStreet()
    {
        return _street;
    }

    public void SetStreet(string Street)
    {
        _street = Street;
    }

    public string GetCity(){
        return _city;
    }

    public void SetCity(string City)
    {
        _city = City;
    }

    public string GetState(){
        return _state;
    }

    public void SetState(string State)
    {
        _state = State;
    }

    public string GetCountry(){
        return _country;
    }

    public void SetCountry(string Country)
    {
        _country = Country;
    }
}