using System;
class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order (Customer customer, List<Product> products) 
    {
        _customer = customer;
        _products = products;
    }
    public int GetPriceTotal()
    {
        int total = 0;
        foreach (Product p in _products)
        {
            total = total + p.GetPrice();
        }
        if (_customer.InUSA())
            total = total + 5;
        else 
            total = total + 35;
        return total;
    }
    public string GetPackingLabel()
    {
        string prolabel = "";
        foreach (Product p in _products)
        {
            prolabel = prolabel + $"{p.GetID().ToString()} - {p.GetName()} \n";
        }
        return prolabel;
    }
    public string GetShipingLabel()
    {
        return $"{_customer.GetName()}, {_customer.GetAddress().GetAddress()}";
    }
}