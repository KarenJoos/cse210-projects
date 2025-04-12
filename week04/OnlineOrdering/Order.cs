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

    // public string GetOrder()
    // {
    //     // List<Products> = new <Products>();

    //     products = _products.GetProducts();
    // }

    public string GetShippingLabel()
    {
        
    }
}