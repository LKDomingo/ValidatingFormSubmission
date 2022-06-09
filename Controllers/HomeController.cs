using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ValidatingFormSubmission.Models;

namespace ValidatingFormSubmission.Controllers;

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

    [HttpPost("process")]
    public IActionResult Success(User NewUser)
    {   
        if(ModelState.IsValid) {
        System.Console.WriteLine($"First Name: {NewUser.FirstName}");
        System.Console.WriteLine($"Last Name: {NewUser.LastName}");
        System.Console.WriteLine($"Age: {NewUser.Age}");
        System.Console.WriteLine($"Email Address: {NewUser.Email}");
        System.Console.WriteLine($"Password: {NewUser.Password}");
        return View();
        } else {
            return View("Index");
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
