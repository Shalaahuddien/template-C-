using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Template.Net.Datas;
using Template.Net.Models;
using Template.Net.Datas.Entities;

namespace Template.Net.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly EMarketDbContext _dbcontext;

    public HomeController(ILogger<HomeController> logger, EMarketDbContext dbContext)
    {
        _dbcontext = dbContext;
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Barang> barangs = _dbcontext.Barangs.ToList();
        return View(barangs);
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
