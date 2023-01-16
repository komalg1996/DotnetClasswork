namespace DAL;
using System.Text.Json;
using BOL;
public class ProductsManager
{
    //Sample data for operation
    public static List<Product> GetAllProducts(){
        List<Product> allProduct= new List<Product>();
        allProduct.Add(new Product(1,"Cookies","Snacks","Kids Special",40,"120 days"));
        allProduct.Add(new Product(2, "Milk", "Dairy", "Daily Need", 50,"2 days"));
        allProduct.Add(new Product(3, "Sunflower oil", "Oil", "Light for Heart", 100,"1 year"));
        allProduct.Add(new Product(4, "Wheat", "Cereals", "Healthy", 30," 2 years"));
        return allProduct;
    }

    public static  List<Product> GetProductFromFile(){
        List<Product> allProduct= GetAllProducts();
        //store data to file
        var o=new  JsonSerializerOptions{IncludeFields=true};
        var productlist=JsonSerializer.Serialize(allProduct,o);
        File.WriteAllText(@"D:\study1\Dotnet\dotnet_classwork\Day10_GoGrocers\GoGrocersWeb\wwwroot\database\products.json",productlist);

        //restore data from file
        string products= File.ReadAllText(@"D:\study1\Dotnet\dotnet_classwork\Day10_GoGrocers\GoGrocersWeb\wwwroot\database\products.json");
        List<Product> list=JsonSerializer.Deserialize<List<Product>>(products);
        return list; 
    }
    public static Product GetProductByID(int id){
        List<Product> list= GetProductFromFile();
        Product product=list.Find((productfind)=>productfind.Id==id);
        // foreach(Product p in list){
        //     if(p.Id==id)
        //     return p;
        // }
        return product;
    }
}
