using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GoGrocers.Models;
using BOL;
using BLL;

namespace GoGrocers.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ProductController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Catalog()
    {
        ProductManager mgr = new ProductManager();
        List<Product> list = mgr.GetAllProducts();
        ViewData["products"] = list;
        return View();
    }

    public IActionResult Details(int id)
    {
        ProductManager mgr = new ProductManager();
        Product product = mgr.GetProduct(id);
        ViewData["prod"] = product;
        return View();
    }

    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(string name, string Category, double Price, string Date)
    {
        ProductManager mgr = new ProductManager();
        bool ans = mgr.insert(name, Category, Price, Date);
        if (ans)
            return Redirect("/Home");
        return View();
    }


    public IActionResult Update(int id){
        ProductManager mgr=new ProductManager();
        bool ans = mgr.Update(id);
        if(ans)
        return Redirect("/Auth/Catalog");
        return RedirectToAction("Index");
    }
}