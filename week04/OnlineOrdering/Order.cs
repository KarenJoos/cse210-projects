using System;
using System.Numerics;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Products> _products;
    private Products _totalCost;
    private Products _packingLabel;
    private Customer _shippingLabel;

    public Order(Products totalCost, Products packingLabel, Customer shippingLabel)
    {
        _totalCost = totalCost;
        _packingLabel = packingLabel;
        _shippingLabel = shippingLabel;
    }

    public void GetOrder()
    {
        // Products p1 = 
        // string _products = _products.GetPackingLabel();
    }

    public void GetTotalPrice()
    {
        // double totalPrice = _totalCost + _totalCost;
        // return totalPrice;

    }
    public void GetPackingLabel()
    {
        // string packingLabel = _products.GetProducts();
        // return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = _shippingLabel.GetCustomerInformation();
        return shippingLabel;
    }
}