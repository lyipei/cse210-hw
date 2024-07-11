class Address
{
    private string _stressAdress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string stressAdress, string city, string state, string country)
    {
        _stressAdress = stressAdress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsDomesticUSA()
    {
        return _country == "USA";
    }
    public string GetAddressLabel()
    {
        return $"{_stressAdress}\n{_city}, {_state}\n{_country}.";
    }
}