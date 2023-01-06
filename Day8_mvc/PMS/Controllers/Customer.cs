namespace register;

public class Customer{
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string ContactNo{get;set;}
    public string email{get;set;}
    public string password{get;set;}

    public Customer(string FirstName, string LastName, string ContactNo,string email,string password){
        this.FirstName=FirstName;
        this.LastName=LastName;
        this.ContactNo=ContactNo;
        this.email=email;
        this.password=password;
    }

}