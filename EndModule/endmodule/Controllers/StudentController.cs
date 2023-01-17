using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using endmodule.Models;
using BLL;
using BOL;
namespace endmodule.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public StudentController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Portal()
    {
        return View();
    }
    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(int rollno, string name, string email, string city)
    {
        SManager mgr = new SManager();
        mgr.Insert(rollno, name, email, city);
        return View();
        //display
    }

    public IActionResult Update()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Update(int rollno, string name, string email, string city)
    {
        SManager mgr = new SManager();
        mgr.Update(rollno, name, email, city);
        return Redirect("Display");
        //display
    }

    public IActionResult Display()
    {
        SManager mgr = new SManager();
        List<Student> student = mgr.GetAll();
        ViewData["student"] = student;
        return View();
    }

    public IActionResult Delete(int id)
    {
        SManager mgr = new SManager();
        Console.WriteLine("---------");
        Console.WriteLine(id);
        mgr.Delete(id);
        return RedirectToAction("Display");
    }
    public IActionResult StudentDetails(int id)
    {
        SManager mgr = new SManager();
        Student s = mgr.GetByRollno(id);
        ViewData["stud"]=s;
        return View();
    }
}