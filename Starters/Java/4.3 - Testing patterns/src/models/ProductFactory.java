package models;

import java.util.Random;

public class ProductFactory {
    private static final Random rand = new Random();

    public static Product randomProduct() {
        double price = 1.0 + rand.nextDouble() * 99;
        return new Product("Product" + rand.nextInt(1000), price);
    }
}
