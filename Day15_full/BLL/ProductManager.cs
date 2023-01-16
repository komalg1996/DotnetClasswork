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

    public bool insert(int id,string name,string category,double unitprice,string expdate){
        return ProductManagerDAL.insert(id,name,category,unitprice,expdate);

    }

    public void Update(int id,string name, string category, double Price, string Date){
        ProductManagerDAL.Update(id,name,category,Price,Date);
    }

    public void Delete(int id){
        ProductManagerDAL.Delete(id);
    }

}