namespace BLL;
using BOL;
using DAL;
public class CatalogManager
{
<<<<<<< HEAD
    public List<Product> GetAllProducts(){
        List<Product> allProducts=new List<Product>();
        allProducts= ProductsManager.GetAllProducts();
        return allProducts;
    }
    public Product GetProductByID(int id){
        Product product=ProductsManager.GetProductByID(id);
        return product;
    }
    public List<Product> GetProductFromFile(){
        List<Product> allproducts= new List<Product>();
        allproducts = ProductsManager.GetProductFromFile();
=======
    public static List<Product> GetAllProduct(){
        List<Product> allproducts=new List<Product>();
        allproducts=DBManager.GetAllProduct();
>>>>>>> 338b987d52780397c467c9b43ab55b9d2c9debd0
        return allproducts;
    }
}
