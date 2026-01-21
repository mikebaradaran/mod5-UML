using System;

namespace ConsoleApp40
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBasket = new ShoppingBasket();

            var item1 = new Item(1, "Baked Beans", 0.85, 0.2);
            myBasket.createBasketRow(item1);

            var item2 = new Item(2, "Battenburg Cake", 1, 0.2);
            myBasket.createBasketRow(item2);

            var item3 = new Item(3, "Granary Loaf", 1.45, 0);
            myBasket.createBasketRow(item3);

            var item4 = new Item(4, "Bottle of Red Wine", 11, 0.2);
            myBasket.createBasketRow(item4);

            myBasket.printBasket();
        }
    }
}
