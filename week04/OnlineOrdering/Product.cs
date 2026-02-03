using System;
using System.Security.Cryptography.X509Certificates;

class Product
{
   private string _productName;
   private int _productId;
   private decimal _pricePerUnit;
   private int _quantity;

   public Product(string productName, int productId, decimal pricePerUnit, int quantity)
   {
        _productName = productName;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity; 
    }
    public string GetProductName()
    {
        return _productName;
    }
    public int GetProductId()
    {
        return _productId;
    }
    public decimal GetTotalPrice()
    {
        return _pricePerUnit * _quantity;
    }

}