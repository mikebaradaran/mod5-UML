using System;
using System.Collections.Generic;
using System.Text;

public class ProductMother
{
    public static Product cheapPen()
    {
        return new Product("Cheap Pen", 0.99);
    }

    public static Product expensiveNotebook()
    {
        return new Product("Luxury Notebook", 25.0);
    }

    public static Product standardPencil()
    {
        return new Product("Pencil", 1.0);
    }
}
