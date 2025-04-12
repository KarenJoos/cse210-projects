using System;

public class Address
{
    private string _streetAddress;
    private string _theCity;
    private string _stateProvince;
    private string _country;

    public Address(string streetAddress, string theCity, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _theCity = theCity;
        _stateProvince = stateProvince;
        _country = country;
    }

    public int GetCountry()
    {
        int shipping;
        if (_country == "USA")
        {
            shipping = 35;
            Console.WriteLine(shipping);
        }
        else
        {
            shipping = 70;
            Console.WriteLine(shipping);
        }
        return shipping;
    }

    public string GetAddress()
    {
        string text = $"{_streetAddress}\n{_theCity}, {_stateProvince}, {_country}";
        return text;
    }
}