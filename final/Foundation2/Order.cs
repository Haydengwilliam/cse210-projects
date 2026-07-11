public class Order
{
    private List<Product> _productList;
    private Customer _customer;

    public Order(List<Product> ProductList, Customer newCustomer){
        _productList = ProductList;
        _customer = newCustomer;
    }

    public int GetTotalPrice()
    {
        int returnValue = 0;
        foreach (Product item in _productList)
        {
            returnValue += item.GetTotalPrice();
        }
        if (_customer.InUS())
        {
            returnValue += 5;
        }
        else
        {
            returnValue += 35;
        }
        return returnValue;
    }

    public string GetPackingLabel()
    {
        string returnString = "";
        foreach (Product item in _productList)
        {
            returnString += $"{item.GetName()} ({item.GetId()})\n";
        }
        return returnString;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}