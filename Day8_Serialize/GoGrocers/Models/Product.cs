namespace GoGrocers.Models;

public class Product
{
    int ID { get; set; }
    public string Name { get; set; }
    string Type { get; set; }
    string Desc { get; set; }
    double Price { get; set; }

    public Product(int id, string name, string type, string desc, double price)
    {
        this.ID = id;
        this.Name = name;
        this.Type = type;
        this.Desc = desc;
        this.Price = price;
    }

}
