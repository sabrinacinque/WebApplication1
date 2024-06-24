using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
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
            var list = new List<MenuModel> {
                new MenuModel{Nome="Coca Cola 150 ml",Prezzo = 2.50},
                new MenuModel{Nome="Insalata di pollo",Prezzo = 5.20},
                new MenuModel{Nome="Pizza Margherita",Prezzo = 10.00},
                new MenuModel{Nome="Pizza 4 Formaggi",Prezzo = 12.50},
                new MenuModel{Nome="Pz patatine fritte",Prezzo = 3.50},
                new MenuModel{Nome="Insalata di riso",Prezzo = 8.00},
                new MenuModel{Nome="Frutta di stagione",Prezzo = 5.00},
                new MenuModel{Nome="Pizza Fritta",Prezzo = 5.00},
                new MenuModel{Nome="Piadina vegetariana",Prezzo = 6.00},
                new MenuModel{Nome="Panino hamburger",Prezzo = 7.90},
            };
            return View(list);
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
