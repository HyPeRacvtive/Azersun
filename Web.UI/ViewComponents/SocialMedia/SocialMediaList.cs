using Business.Concrete;
using DataAccess.Concrete.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.ViewComponents.SocialMedia
{
    public class SocialMediaList : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        SocialMediaManager sm = new SocialMediaManager(new EFSocialMediaRepository());
        public IViewComponentResult Invoke()
        {
            var values = sm.GetList();
            return View(values);
        }
    }
}
