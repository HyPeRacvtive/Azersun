using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EFCore;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Web.UI.ViewComponents.Admin
{
    public class AdminProfile : ViewComponent
    {
        AdminManager am = new AdminManager(new EFAdminRepository());
        DataContext context = new DataContext();
        public IViewComponentResult Invoke(int id)
        {
            ViewBag.AdminName = context.Admins.Where(x => x.Id == 1).Select(y => y.NameSurname).FirstOrDefault();
            ViewBag.AdminImage = context.Admins.Where(x => x.Id == 1).Select(y => y.Image).FirstOrDefault();
            return View();
        }
    }
}
