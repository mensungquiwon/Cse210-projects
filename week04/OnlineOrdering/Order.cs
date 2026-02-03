using System;
using System.Collections.Generic;

class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    

    public decimal GetSubTotal()
    {
        
        decimal subtotal = 0;
        foreach (Product product in _products)
        {
            subtotal += product.GetTotalPrice();
        }
        return subtotal;

    }
    public decimal GetShippingCost()
    {
        bool isDomestic = _customer.LivesInUSA();
        if (isDomestic)
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    public decimal GetTotalPrice()
    {
        return GetSubTotal() + GetShippingCost();
    }
    public string GetPackingLabel()
    {
        
        string label = "Packing Label\n-------------\n";

        foreach (Product product in _products)
        {
            label += $"{product.GetProductName()} (ID: {product.GetProductId()})\n";
        }

        return label.TrimEnd();

    }
    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }
    
    

}