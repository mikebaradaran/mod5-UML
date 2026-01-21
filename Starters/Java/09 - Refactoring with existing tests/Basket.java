import java.lang.reflect.Field;
import java.util.List;

class Basket {

    public static String printBasket(List<Object> basket) {
        StringBuilder basketOutput = new StringBuilder("Item Name\t\t\tPrice\n");
        double total = 0;

        for (Object item : basket) {
            try {
                Class<?> itemClass = item.getClass();
                Field[] fields = itemClass.getDeclaredFields();
                String name = "";
                double price = 0;
                boolean vat = false;

                for (Field field : fields) {
                    field.setAccessible(true); // needed to access private fields
                    switch (field.getName()) {
                        case "_name":
                            name = (String) field.get(item);
                            break;
                        case "_price":
                            price = (Double) field.get(item);
                            break;
                        case "_vat":
                            vat = (Boolean) field.get(item);
                            break;
                        default:
                            break;
                    }
                }

                basketOutput.append(name);
                basketOutput.append(name.length() < 16 ? "\t\t\t" : "\t\t");

                double priceToAdd = vat ? Math.round(price * 1.2 * 100.0) / 100.0 : price;
                basketOutput.append(String.format("%.2f%n", priceToAdd));
                total += priceToAdd;

            } catch (IllegalAccessException e) {
                e.printStackTrace();
            }
        }

        basketOutput.append(String.format("%n\t\t\tTotal\t£%.2f", total));
        return basketOutput.toString();
    }
}

class Item {
    public int _id;
    public String _name;
    public double _price;
    public boolean _vat;

    public Item(int id, String name, double price, boolean vat) {
        this._id = id;
        this._name = name;
        this._price = price;
        this._vat = vat;
    }
}