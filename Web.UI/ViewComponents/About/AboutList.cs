using Business.Concrete;
using DataAccess.Concrete.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutManager pm = new AboutManager(new EFAboutRepository());
        public IViewComponentResult Invoke()
        {
            var values = pm.GetListAll();
            return View(values);
        }
    }
}
