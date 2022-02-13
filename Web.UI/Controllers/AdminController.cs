using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.UI.Controllers
{
    //[AllowAnonymous]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
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
