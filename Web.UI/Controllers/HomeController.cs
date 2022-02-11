using Microsoft.AspNetCore.Mvc;

namespace Web.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Lahiyeler()
        {
            return View();
        }
        public IActionResult Alaqa()
        {
            return View();
        }
    }
}
