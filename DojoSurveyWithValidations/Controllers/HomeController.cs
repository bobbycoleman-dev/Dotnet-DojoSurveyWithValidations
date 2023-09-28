using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWithValidations.Models;

namespace DojoSurveyWithValidations.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public static Survey DisplaySurvey = new();

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("process")]
    public IActionResult Process(Survey newSurvey)
    {
        DisplaySurvey = newSurvey;

        if(ModelState.IsValid)
        {

        return RedirectToAction("Results");
        }

        return View("Index");

    }

    [HttpGet("results")]
    public IActionResult Results()
    {
        return View(DisplaySurvey);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
