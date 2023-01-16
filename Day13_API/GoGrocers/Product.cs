namespace GoGrocers;

public class Product{
    private int Id{get;set;}
    private string? Name{get;set;}
    private string? Category{get;set;}
    private double? Price{get;set;}

public Product(int id,string name,string category,double price){
    this.Id=id;
    this.Name=name;
    this.Category=category;
    this.Price=price;

}

}