using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PMS.Models;
using register;
namespace PMS.Controllers;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

     public IActionResult Login()
    {
        return View();
    }
    public IActionResult Validate(string email, string password){

         Console.WriteLine("Validating User credentials.... ");
       
List<Customer> cus=new List<Customer>(10);



var options=new JsonSerializerOptions{IncludeFields=true};
var customerJson=JsonSerializer.Serialize<List<Customer>>(cus,options);
string fileName=@"G:\myfile\project.json";

System.IO.File.WriteAllText(fileName,customerJson);
    //     if(email =="komalg@g.com" &&  password=="koko"){
    //         if(email==Console.ReadLine() &&  password == Console.ReadLine()){
    //          Console.WriteLine("successfull validation of user..... ");
    //          Console.WriteLine("Redirecting to welcome..... ");   
    //         return Redirect("/home/Welcome");
    //        }
        return View();
    }

    public IActionResult Welcome()
    {
        Console.WriteLine("invoking welcome page....");
        return View();
    }

     public IActionResult Register()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
