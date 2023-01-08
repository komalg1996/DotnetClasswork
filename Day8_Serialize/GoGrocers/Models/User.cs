namespace USERNAME;

public class User
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public int ContactNum { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public User(string firstname, string lastname, int contact, string email, string password)
    {
        this.Firstname = firstname;
        this.Lastname = lastname;
        this.ContactNum = contact;
        this.Email = email;
        this.Password = password;
    }
}
