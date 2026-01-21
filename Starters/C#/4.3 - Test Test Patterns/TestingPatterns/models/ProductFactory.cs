using System;
using System.Collections.Generic;
using System.Text;

public class ProductFactory
{
    public static Product randomProduct()
    {
        Random rand = new Random();

        double price = 1.0 + rand.NextDouble() * 99;
        return new Product("Product" + rand.Next(1,100), price);
    }
}