using System.Text;
using System.Collections.Generic;
using System;

public class Item
{
    const double vatRate = 1.2;

    int _id;
    string _name;
    double _price;
    double _vat;
    public override string ToString()
    {
        return $"ID:{_id}, Name:{_name}, Price:{_price}, VAT:{_vat}";
    }

    public Item(int id, string name, double price, double vat)
    {
        this._id = id;
        this._name = name;
        this._price = price;
        this._vat = vat;
    }

    public string getName()
    {
        return this._name;
    }

    public double getPrice()
    {
        return this._price * (1 + getVat());
    }

    public double getVat()
    {
        return this._vat;
    }
}

class ShoppingBasket
{
    List<Item> _basket = null;
    public ShoppingBasket()
    {
        this._basket = new List<Item>();
    }

    public List<Item> getBasket()
    {
        return this._basket;
    }

    public void setBasket(List<Item> basket)
    {
        this._basket = basket;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var item in this.getBasket())
        {
            sb.Append(item.ToString() + "\n");
        }
        return sb.ToString();
    }

    public double totalPrice()
    {
        double total = 0;
        foreach (var item in this.getBasket())
        {
            total += item.getPrice();
        }
        return total;
    }

    public void createBasketRow(Item item)
    {
        getBasket().Add(item);
    }

    public void printBasket()
    {
        Console.WriteLine(this.ToString());
        Console.WriteLine("£" + this.totalPrice());

    }
}
