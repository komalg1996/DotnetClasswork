namespace BOL;
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string password { get; set; }
    public int Contact { get; set; }

    public User(int id, string name, string email, string password, int contact){
        this.Id=id;
        this.Name=name;
        this.Email=email;
        this.password=password;
        this.Contact=contact;
    }
}
