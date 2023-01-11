using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GoGrocersApp.Models;

namespace GoGrocersApp.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public AuthController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

[HttpGet]
public IActionResult Login(){
    return View();
}
 [HttpPost]
    public IActionResult Login(string email, string password){
        Console.WriteLine("Login POST method is invoked at server side");
       if(email=="komalg@gmail.com" && password=="komal"){
        return RedirectToAction("index", "departments");
       }
        return View();
    }

}