using Business.Concrete;
using DataAccess.Concrete.EFCore;
using Microsoft.AspNetCore.Mvc;

namespace Web.UI.ViewComponents.Admin
{
    public class AdminProfile : ViewComponent
    {
        AdminManager am = new AdminManager(new EFAdminRepository());
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
