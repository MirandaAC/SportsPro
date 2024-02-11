using SportsPro.Models;
using Microsoft.AspNetCore.Mvc;

namespace SportsPro.Controllers
{
    public class HomeController : Controller
    {
        private SportsProContext context { get; set; }

        public HomeController(SportsProContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
