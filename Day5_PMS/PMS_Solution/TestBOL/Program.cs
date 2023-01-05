using BOL;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

// Console.WriteLine("Enter Project Details: Id, Name, Type, Description,StartDate,EndDate");
// Project p1= new Project{Id=Console.ReadLine(), Name=Console.ReadLine(),Type=Console.ReadLine(),Description=Console.ReadLine(),StartDate=Console.ReadLine(),EndDate=Console.ReadLine()};
Project p1= new Project{Id=1, Name="School",Type="Management",Description="Online Education",StartDate=new DateTime(2023-01-01),EndDate=new DateTime(2023-06-01)};
Project p2= new Project{Id=2, Name="Bank",Type="Management",Description="Online Banking",StartDate=new DateTime(2023-02-01),EndDate=new DateTime(2023-07-01)};
Project p3= new Project{Id=3, Name="Hotel",Type="Management",Description="Online Booking",StartDate=new DateTime(2023-03-01),EndDate=new DateTime(2023-08-01)};
Project p4= new Project{Id=4, Name="Railway",Type="Management",Description="Online TicketBooking",StartDate=new DateTime(2023-04-01),EndDate=new DateTime(2023-09-01)};
Project p5= new Project{Id=5, Name="Timeshift",Type="Management",Description="Tracking",StartDate=new DateTime(2023-05-01),EndDate=new DateTime(2023-10-01)};

List<Project> projects=new List<Project>(10);
projects.Add(p1);
projects.Add(p2);
projects.Add(p3);
projects.Add(p4);
projects.Add(p5);

var options=new JsonSerializerOptions{IncludeFields=true};
var projectJson=JsonSerializer.Serialize<List<Project>>(projects,options);
string fileName=@"G:\myfile\project.json";

File.WriteAllText(fileName,projectJson);

