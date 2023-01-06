using HR;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var emp=new Employee(){Id=20, FirstName="Komal", LastName="G"};
var employees=new List<Employee>();
employees.Add(new Employee(){Id=20, FirstName="Ashwini", LastName="P"});
employees.Add(new Employee(){Id=20, FirstName="Bhavesh", LastName="V"});
employees.Add(new Employee(){Id=20, FirstName="Manish", LastName="D"});
employees.Add(new Employee(){Id=20, FirstName="Satyam", LastName="P"});
app.MapGet("/", () => "Hello World!");
app.MapGet("/api/hello", ()=> "Welcome to Go Grocers");
app.MapGet("/komal",()=> emp);
app.MapGet("/emp",()=>employees);

app.Run();
