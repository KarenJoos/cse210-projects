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

    public void GetCountry(Address address)
    {
        int country = _address.GetCountry();
    }
}