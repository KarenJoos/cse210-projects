using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("12345 N 9876 E", "SLC", "Utah", "USA");

        Customer c1 = new Customer("Karen Joos", a1);
        Console.WriteLine(c1.GetCustomerInformation());

        // Products p1 = new Products("milk", 12345, 2.99, 2);
        // Console.WriteLine(p1.GetProducts());
        // Console.WriteLine(p1.GetTotalCost());


    }
}