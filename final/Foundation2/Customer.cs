public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string Name, Address NewAddress){
        _name = Name;
        _address = NewAddress;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string Name)
    {
        _name = Name;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }

    public void SetAddress(Address newAddress)
    {
        _address = newAddress;
    }

    public bool InUS()
    {
        return _address.InUS();
    }
}