using DataAccess.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.UI.Controllers
{
    //[AllowAnonymous]
    public class AdminController : Controller
    {
        DataContext context = new DataContext();
        public IActionResult Index()
        {

            ViewBag.ProductCount = context.Products.Count().ToString();
            ViewBag.SliderCount = context.Sliders.Count().ToString();
            ViewBag.VideoCount = context.Videos.Count().ToString();
            ViewBag.MessageCount = context.Messages.Count().ToString();
            return View();
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
