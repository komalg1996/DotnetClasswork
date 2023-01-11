namespace BLL;

public class CatalogManager
{
    public static List<Product> GetAllProduct(){
        List<Product> allproducts=new List<Product>();
        allproducts=DBManager.GetAllProduct();
        return allproducts;
    }
    // public Product GetProduct(int  id){
    //   List<Product> allProducts=GetAllProducts();
    //   /*var product=from  p in allProducts
    //                where p.ProductId ==id
    //                 select p  ;     
    // */
    //    Product foundProduct=allProducts.Find((product)=>product.ProductId == id);
    //   return foundProduct ;
//Product findproduct=allproduct.find(product)=>product.productId==id);
//return foundProduct; 

    //  }
}
