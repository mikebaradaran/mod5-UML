import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import java.util.Arrays;
import java.util.List;

import static org.junit.jupiter.api.Assertions.assertTrue;
import static org.junit.jupiter.api.Assertions.assertFalse;

public class PrintBasketTests {

    Item item1, item2, item3;
    List<Object> basket;
    double vatRate = 1.2;

    @BeforeEach
    public void setUp() {
        item1 = new Item(1, "Test", 123.4, false);
        item2 = new Item(2, "Test name longer than 15", 0.75, false);
        item3 = new Item(3, "Test", 1.99, true);
        basket = Arrays.asList(item1, item2, item3);
    }

    @Test
    public void shouldPrintAHeaderRowForTheBasket() {
        String actual = Basket.printBasket(basket);
        assertTrue(actual.contains("Item Name\t\t\tPrice\n"));
    }

    @Test
    public void shouldPrintTheItemName() {
        String actual = Basket.printBasket(basket);
        assertTrue(actual.contains(item1._name));
    }

    @Test
    public void shouldPrintThreeTabsAfterShortItemName() {
        String actual = Basket.printBasket(basket);
        assertTrue(actual.contains(item1._name + "\t\t\t"));
    }

    @Test
    public void shouldPrintTwoTabsAfterLongItemName() {
        String actual = Basket.printBasket(basket);
        assertTrue(actual.contains(item2._name + "\t\t"));
        assertFalse(actual.contains(item2._name + "\t\t\t"));
    }

    @Test
    public void shouldNotAddVatWhenVatIsFalse() {
        String actual = Basket.printBasket(basket);
        assertTrue(actual.contains(String.format("%.2f", item1._price)));
    }

    @Test
    public void shouldAddVatWhenVatIsTrue() {
        String actual = Basket.printBasket(basket);
        double expected = Math.round(item3._price * vatRate * 100.0) / 100.0;
        assertTrue(actual.contains(String.format("%.2f", expected)));
    }

    @Test
    public void shouldPrintPricesToTwoDecimalPlaces() {
        String actual = Basket.printBasket(basket);
        assertTrue(actual.contains("123.40"));
    }

    @Test
    public void shouldPrintNewlineAfterPrices() {
        String actual = Basket.printBasket(basket);
        assertTrue(actual.contains("123.40\n"));
    }

    @Test
    public void shouldOnlyPrintNameAndPricePerLine() {
        String actual = Basket.printBasket(basket);
        assertTrue(actual.contains("Test\t\t\t123.40\n"));
    }

    @Test
    public void shouldPrintTotalLabelWithTabs() {
        String actual = Basket.printBasket(basket);
        assertTrue(actual.contains("\n\t\t\tTotal\t"));
    }

    @Test
    public void shouldPrintTotalOfBasket() {
        double expectedTotal = item1._price + item2._price + Math.round(item3._price * vatRate * 100.0) / 100.0;
        String actual = Basket.printBasket(basket);
        assertTrue(actual.contains(String.format("£%.2f", expectedTotal)));
    }
}
