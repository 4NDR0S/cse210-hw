class Customer
{
    private  string _nameC;
    private Address _address;

    public Customer (string nameC, Address address)
    {
        _nameC = nameC;
        _address = address;
    }
    public string GetName()
    {
        return _nameC;
    }

    public string GetAddress()
    {
        return _address.DisplayAddres();
    }
}