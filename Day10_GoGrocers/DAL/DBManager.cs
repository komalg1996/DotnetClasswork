namespace DAL;
using BOL;
using System.Text.Json;

public class DBManager
{
    public static List<Product> GetAllProduct(){
        allProducts.Add(new Product { ProductId = 1, Title = "Biscuit", Description = "Sweet and Salty", UnitPrice = 10, Category = "Snacks", Balance = 100 });
        allProducts.Add(new Product { ProductId = 2, Title = "Milk", Description = "Healthy", UnitPrice = 50, Category = "Dairy", Balance = 100 });

        return allProducts;
    }
}
