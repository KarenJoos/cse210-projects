using System;

public class Products
{
    private List<string, int, double, int> _products;
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

        public void GetTotalCost()
    {
        _price = _price * _quantity;
    }

    public string GetProducts()
    {
        _products.Add(new List<string> { _pName,  _productID,  _price,  _quantity });
        // string items = _pName + _productID;
        // return items;
    }

}
