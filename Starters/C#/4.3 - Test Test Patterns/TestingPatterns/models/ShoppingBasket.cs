using System;
using System.Collections.Generic;
using System.Text;

public class ShoppingBasket
{
    private List<Product> items = new List<Product>();

    public void add(Product product)
    {
        items.Add(product);
    }

    public double totalWithTax(double taxRate)
    {
        double total = 0;
        foreach (Product p in items)
        {
            total += p.getPrice();
        }
        return total * (1 + taxRate);
    }

    public int itemCount()
    {
        return items.Count;
    }
}
