public class Reception : Event{
    private string _email;

    public Reception(string Email, string Title, string Description, string Date, string Time, Address newAddress) : base(Title, Description, Date, Time, newAddress)
    {
        _email = Email;
    }

    public string GetFull()
    {
        return $"{base.GetDescription()}\n{_email}";
    }

    public string GetEmail()
    {
        return _email;
    }

    public void SetEmail(string Email)
    {
        _email = Email;
    }
}