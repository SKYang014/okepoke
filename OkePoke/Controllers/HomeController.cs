using Microsoft.AspNetCore.Mvc;
using OkePoke.Models;
using System.Diagnostics;

namespace OkePoke.Controllers
{
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
        async public Task<IActionResult> PokeDetails(int id)
        {
            Poke pokes = await PokemonAPI.FindPoke(id);
            return View(pokes);
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
}