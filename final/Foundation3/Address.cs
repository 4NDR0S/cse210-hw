class Address
{
    private string _streetAdress;
    private string _city;

    public Address (string street, string city)
    {
        _streetAdress = street;
        _city = city;
    }

    public string DisplayAddress()
    {
        return ($"{_streetAdress}, {_city}");
    }
}