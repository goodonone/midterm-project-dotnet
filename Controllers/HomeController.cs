using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using midterm_project.Models;
using midterm_project.Repositories;

namespace midterm_project.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IPetRepository _petRepository;
    

    public HomeController(ILogger<HomeController> logger, IPetRepository repository)
    {
        _logger = logger;
        _petRepository = repository;
    }
    public IActionResult Index()
    {
        return View(_petRepository.GetAllPets());
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
