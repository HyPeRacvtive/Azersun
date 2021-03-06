using Business.Concrete;
using DataAccess.Concrete.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.ViewComponents.Home
{
    public class VideoList : ViewComponent
    {
        VideosManager vm = new VideosManager(new EFVideoRepository());
        public IViewComponentResult Invoke()
        {
            var values = vm.GetList();
            return View(values);
        }
    }
}
