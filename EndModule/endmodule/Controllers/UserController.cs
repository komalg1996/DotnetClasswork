using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using endmodule.Models;
using BLL;
using BOL;
namespace endmodule.Controllers;

public class UserController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public UserController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Portal()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
     public IActionResult Login(string email,string password)
    {
        UManager mgr=new UManager();
        mgr.Login(email,password);
        return Redirect("Home/Index");
    }

}