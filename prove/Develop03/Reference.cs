public class Reference
{
    string _ref;
    public string ToString()
    {
        return $"{_ref}";
    }

    public Reference(string reference)
    {
        _ref = reference;
    }
}