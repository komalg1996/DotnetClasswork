namespace HR;
public abstract class Employee
{
    //employee dataMembers
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string ContactNo { get; set; }
    public string Location { get; set; }
    public DateTime BirthDate { get; set; }
    public float DA { get; set; }
    public float HRA { get; set; }
    public float BasicSalary { get; set; }

    //default constructor
    //constructor chaining
    public Employee() : this(1, "Komal", "G", "koko@gmail.com", "9358412360", "Pune", new DateTime(1998, 06, 27), 1000, 1000, 500000)
    {

    }
    //parametrised constructor
    public Employee(int id, string firstName, string lastName, string email, string contactNo, String location, DateTime BirthDate, float DA, float HRA, float BasicSalary)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Email = email;
        this.ContactNo = contactNo;
        this.Location = location;
        this.BirthDate = BirthDate;
        this.DA = DA;
        this.HRA = HRA;
        this.BasicSalary = BasicSalary; 
    }
    public abstract void DoWork();

    public virtual float ComputePay()
    {
        float pay = (DA * 30) + BasicSalary + HRA;
        return pay;
    }
    public override string ToString()
    {
        //return base.ToString(); 
        string str = string.Format("{0},{1},{2},{3},{4},{5}", Id, FirstName, LastName, Email, ContactNo, Location);
        return str;
    }
}