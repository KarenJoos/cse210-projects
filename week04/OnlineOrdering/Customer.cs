using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetCustomerInformation()
    {
        string info = _name +"\n" + _address.GetAddress();
        return info;
    }

    public int GetCountry()
    {
        int country = _address.GetShipping();
        return country;
    }
}