namespace GoGrocers.Models;
using System.Collections.Generic;

public class ProductManager
{
    //sample data prodcuts
    public List<Product> sample()
    {
        Product p1 = new Product(1, "Cookies", "Snacks", "Kids Special", 40);
        Product p2 = new Product(2, "Milk", "Dairy", "Daily Need", 50);
        Product p3 = new Product(3, "Sunflower oil", "Oil", "Light for Heart", 100);
        Product p4 = new Product(4, "Wheat", "Cereals", "Healthy", 30);
        List<Product> list = new List<Product>();
        list.Add(p1);
        list.Add(p2);
        list.Add(p3);
        list.Add(p4);
        return list;
    }
}