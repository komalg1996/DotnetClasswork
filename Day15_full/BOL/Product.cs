namespace BOL;


public class Product{
public int Id{get;set;}
public string? Name{get;set;}
public string? Category{get;set;}
public double? UnitPrice{get;set;}
public string ExpDate{get;set;}

public Product(int id, string name, string Category,double unitprice,string expdate){
    this.Id=id;
    this.Name=name;
    this.Category=Category;
    this.UnitPrice=unitprice;
    this.ExpDate=expdate;
}

}