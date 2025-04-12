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
        string info = _name + _address;
        return info;
    }

    public void GetCountry(Address address)
    {
        int country = address.GetCountry();
    }
}