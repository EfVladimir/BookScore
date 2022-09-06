using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication_Mvc_1.Interfaces;
using WebApplication_Mvc_1.Models;
using WebApplication_Mvc_1.Persistence;

namespace WebApplication_Mvc_1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly DataContext _context;
    private readonly IBookService _bookservice;
    private readonly IScoringService _scoringservice;

    public HomeController(ILogger<HomeController> logger,
        DataContext context,
        IBookService bookService,
        IScoringService scoringservice)
    {
        _logger = logger;
        _context = context;
        _bookservice = bookService;
        _scoringservice = scoringservice;
    }

    public async Task<IActionResult> Index()
    {
        var books = await _bookservice.GetBooks();
        return View(books);
    }
    public JsonResult GetRating(int id)
    {
        Task<double> rating = _scoringservice.GetRating(id);
        
        return Json(rating.Result);
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
