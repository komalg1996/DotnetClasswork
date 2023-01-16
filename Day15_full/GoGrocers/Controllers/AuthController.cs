using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GoGrocers.Models;
using BLL;

namespace GoGrocers.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public AuthController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult PostLogin(string email, string password)
    {
        Manager mgr = new Manager();
        if (mgr.validateBL(email, password))
            return Redirect("/Home/Welcome");
        return RedirectToAction("Register");
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult PostRegister(string name, string email, string password, int contact)
    {
        Manager mgr = new Manager();
        if (mgr.RegisterBL(name, email, password, contact))
            return Redirect("/Auth/Login");
        return RedirectToAction("Register");

    }

}