using System;

public class Products
{
    private string _pName;
    private int _productID;
    private double _price;
    private int _quantity;

    public Products(string pName, int productID, double price, int quantity)
    {
        _pName = pName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        double total = _price * _quantity;
        return total;
    }

    public void GetProducts()
    {
        Console.Write(_pName + _productID);
        return;
    }
}