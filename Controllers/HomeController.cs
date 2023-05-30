using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<string> cities = new List<string>{
            "Bishkek","Osh","Batken"
        };
        return View(cities);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }
    
    public IActionResult Student(){
        var studentlist = new List<Student>{
            new Student{Id = 1 , NameSurname = "Asan Usernov", Age= 23},
            new Student{Id = 2 , NameSurname = "Bek Usenov", Age = 33},
            new Student{Id = 3 , NameSurname = "Sultan Usenov", Age = 34}
        };
        return View(studentlist);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
