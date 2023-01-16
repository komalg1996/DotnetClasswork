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
    public IActionResult Insert(int id,string name, string Category, double Price, string Date)
    {
        ProductManager mgr = new ProductManager();
        bool ans = mgr.insert(id,name, Category, Price, Date);
        if (ans)
            return Redirect("/Home");
        return View();
    }

public IActionResult Update(int id)
{
    return View();
}

    [HttpPost]
    public IActionResult Update(int id,string name, string category, double Price, string expdate){
        ProductManager mgr=new ProductManager();
        mgr.Update(id,name,category,Price,expdate);
       return Redirect("Catalog");
       
    }

    public IActionResult Delete(int id){
        ProductManager mgr=new ProductManager();
        mgr.Delete(id);
        // return Redirect("Product/Catalog");
        return RedirectToAction("Catalog");
    }

}