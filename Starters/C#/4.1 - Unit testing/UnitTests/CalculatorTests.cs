using NUnit.Framework;
using QACalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void When_new_item_is_added_the_count_of_items_in_the_basket_is_increased_by_one()
        {
            ShoppingBasket shoppingBasket = new ShoppingBasket();
            shoppingBasket.add(new ShoppingBasketItem("Book",5));

        }

        [Test]
        public void When_the_same_item_is_added_the_count_of_items_in_the_basket_remains_the_same_and_the_added_item_quantity_is_increased_by_1()
        {

        }
    }
}

2.	

