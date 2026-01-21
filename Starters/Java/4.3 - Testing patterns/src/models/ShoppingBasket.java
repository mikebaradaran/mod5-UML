package models;

import java.util.ArrayList;
import java.util.List;

public class ShoppingBasket {
	private List<Product> items = new ArrayList<Product>();

	public void add(Product product) {
		items.add(product);
	}

	public double totalWithTax(double taxRate) {
		double total = 0;
		for (Product p : items) {
			total += p.getPrice();
		}
		return total * (1 + taxRate);
	}

	public int itemCount() {
		return items.size();
	}
}
