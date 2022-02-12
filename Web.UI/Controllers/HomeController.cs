using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Concrete.EFCore;
using Entity.Concrete;
using FluentValidation.Results;
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
            MessageValidator mv = new MessageValidator();
            ValidationResult results = mv.Validate(m);
            if (results.IsValid)
            {
                m.IpAdress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
                m.IsRead = false;
                mm.MessageAdd(m);
                return RedirectToAction("Alaqa", "Home");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }


        /*Partial Views*/

    
    }
}
