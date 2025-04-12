using System;

public class Products
{
    // private List<string, int, double, int> _products;
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
        double price = _price * _quantity;
        return price;
    }

    public string GetPackingLabel()
    {
        string items = _pName + _productID + _price + _quantity; 
        return items;
    }

}
