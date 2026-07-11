public class Product
{
    private string _name;
    private string _id;
    private int _price;
    private int _quantity;

    public Product(string Name, string Id, int Price, int Quantity){
        _name = Name;
        _id = Id;
        _price = Price;
        _quantity = Quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string Name)
    {
        _name = Name;
    }

    public string GetId()
    {
        return _id;
    }

    public void SetId(string ID)
    {
        _id = ID;
    }

    public int GetPrice()
    {
        return _price;
    }

    public void SetPrice(int Price)
    {
        _price = Price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int Quantity)
    {
        _quantity = Quantity;
    }

    public int GetTotalPrice()
    {
        return _quantity * _price;
    }
}