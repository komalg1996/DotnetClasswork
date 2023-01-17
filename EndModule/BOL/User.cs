namespace BOL;

public class User{
    public string? Name{get;set;}
    public string? Email{get;set;}
    public string? password{get;set;}

    public User(){

    }

    public User(string name, string email, string password){
        this.Name=name;
        this.Email=email;
        this.password=password;
    }
}