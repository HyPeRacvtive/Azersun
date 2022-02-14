using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EFCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.UI.Controllers
{
    //[AllowAnonymous]
    public class AdminController : Controller
    {
        
        AdminManager am = new AdminManager(new EFAdminRepository());
        DataContext context = new DataContext();
        public IActionResult Index()
        {
            ViewBag.ProductCount = context.Products.Count().ToString();
            ViewBag.SliderCount = context.Sliders.Count().ToString();
            ViewBag.VideoCount = context.Videos.Count().ToString();
            ViewBag.MessageCount = context.Messages.Count().ToString();
            return View();
        }

        public IActionResult Profile(int id)
        {
            var values = am.GetById(id);
            return View(values);
        }
        /*ÜRÜNLER*/
        public IActionResult ProductList()
        {
            return View();
        }

        /*Partial Views*/

        public PartialViewResult _LeftSideBar()
        {

            return PartialView();
        }
    }
}
