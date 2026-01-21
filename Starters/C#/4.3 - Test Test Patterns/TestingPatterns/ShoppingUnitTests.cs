using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ShoppingUnitTests
{
    [TestMethod]
    public void TestWithCustomAssertion_testItemCount()
    {
        ShoppingBasket cart = new ShoppingBasket();
        cart.add(new Product("Pen", 1.5));
        CustomAssertions.assertItemCount(cart, 1);
    }

    [TestMethod]
    public void TestWithDeltaAssertion_testTotalWithTax()
    {
        ShoppingBasket cart = new ShoppingBasket();
        cart.add(new Product("Notebook", 10.0));
        cart.add(new Product("Pencil", 2.0));

        double expected = (10.0 + 2.0) * 1.10;
        Assert.AreEqual(expected, cart.totalWithTax(0.10), 0.001); // delta of 0.001
    }

    [TestMethod]
    public void TestUsingObjectMother_testMultipleProducts()
    {
        ShoppingBasket cart = new ShoppingBasket();
        cart.add(ProductMother.cheapPen());
        cart.add(ProductMother.standardPencil());

        CustomAssertions.assertItemCount(cart, 2);
    }

    [TestMethod]
    public void TestUsingFactory_testWithProductFactory()
    {
        ShoppingBasket cart = new ShoppingBasket();
        cart.add(ProductFactory.randomProduct());

        CustomAssertions.assertItemCount(cart, 1);
    }
}
