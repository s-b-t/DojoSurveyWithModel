using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithModel.Models;

namespace DojoSurveyWithModel.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    // Post method
    [HttpPost("process")]
    public IActionResult Survey(Survey survey)
    {    
        // Show form input in console
        Console.WriteLine($"My name was: {survey.name}");
        Console.WriteLine($"My dojoLocation was: {survey.dojoLocation}");
        Console.WriteLine($"My favLanguage was: {survey.favLanguage}");
        Console.WriteLine($"My comment was: {survey.comment}");
        return RedirectToAction("Results", survey);
    }

    [HttpGet("results")]
    public IActionResult Results(Survey survey)
    {
        return View(survey);
    }

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
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
