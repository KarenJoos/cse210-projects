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

    public void GetCustomerInformation()
    {
        Console.WriteLine($"{_name}\n{_address}");
    }

    public void GetCountry(Address address)
    {
        int country = address.GetCountry();
    }
}