using Business.Concrete;
using DataAccess.Concrete.EFCore;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Web.UI.Controllers
{
    public class HomeController : Controller
    {
        MessageManager mm = new MessageManager(new EFMessageRepository());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Lahiyeler()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Alaqa()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Alaqa(Messages m)
        {
            m.IpAdress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            m.IsRead = false;
            mm.MessageAdd(m);
            return RedirectToAction("Alaqa", "Home");
        }
    }
}
