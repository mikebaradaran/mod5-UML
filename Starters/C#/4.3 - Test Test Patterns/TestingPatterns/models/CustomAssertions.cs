using Microsoft.VisualStudio.TestTools.UnitTesting;

public class CustomAssertions
{
    public static void assertItemCount(ShoppingBasket cart, int expected)
    {
        if (cart.itemCount() != expected)
        {
            Assert.Fail("Expected " + expected + " items, but found " + cart.itemCount());
        }
    }
}