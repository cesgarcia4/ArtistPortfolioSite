using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ArtistPortfolioSite.Models;

namespace ArtistPortfolioSite.Controllers;

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
    public IActionResult Bio()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Contact(string Name, string Email, string Message)
    {
        // Here you can process the form input:
        // - Validate the inputs.
        // - Save the message to a database.
        // - Send an email using an email service (e.g., SendGrid, SMTP).

        // For now, we can simply redirect back to the home page or display a "Thank You" view.
        TempData["MessageSent"] = "Thank you for contacting us!";
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
