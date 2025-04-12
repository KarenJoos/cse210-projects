using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("12345 N 9876 E", "SLC", "Utah", "USA");
        Console.WriteLine(a1.GetAddress());
        
        Customer c1 = new Customer("Karen Joos", a1);
        Console.WriteLine(c1.GetCustomerInformation);

    }
}