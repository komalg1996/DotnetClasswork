using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GoGrocersApp.Models;
using BOL;
using BLL;
namespace GoGrocersApp.Controllers;

public class DepartmentsController : Controller
{
    private readonly ILogger<DepartmentsController> _logger;

    public DepartmentsController(ILogger<DepartmentsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        HRManager mgr=new HRManager();
        List<Department> departments=mgr.GetAllDepartments();
        this.ViewData["departments"]=departments;
        return View();
    }

     
}
