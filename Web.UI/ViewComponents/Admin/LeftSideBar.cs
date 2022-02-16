using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.ViewComponents.Message
{
    public class LeftSideBar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            DataContext context = new DataContext();

            ViewBag.MessageCount = context.Messages.Count().ToString();
            ViewBag.MessageUnReadCount = context.Messages.Where(x => x.IsRead == false).Count();
            return View();
        }
    }
}
