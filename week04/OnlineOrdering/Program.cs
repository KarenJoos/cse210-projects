using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("12345 N 9876 E", "SLC", "Utah", "USA");
        string text = a1.GetAddress();
        Console.WriteLine(text);
        string name = "A-A-Ron Juice";
        Customer c1 = new Customer(name, text);
        Console.WriteLine(name + "\n" + text);

    }
}