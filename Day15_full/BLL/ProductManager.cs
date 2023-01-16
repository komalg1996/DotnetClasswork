namespace BLL;
using DAL;
using BOL;
public class ProductManager
{
    public List<Product> GetAllProducts(){
        return ProductManagerDAL.GetAllProducts();
    }

    public Product GetProduct(int id){
        return ProductManagerDAL.GetProduct(id);
    }

    public bool insert(string name,string category,double unitprice,string expdate){
        return ProductManagerDAL.insert(name,category,unitprice,expdate);

    }

    public bool Update(int id){
        return ProductManagerDAL.Update(id);
    }

}