using Business.Concrete;
using DataAccess.Concrete.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.ViewComponents.Slider
{
    public class SliderList : ViewComponent
    {
        SliderManager sm = new SliderManager(new EFSliderRepository());
        public IViewComponentResult Invoke()
        {
            var values = sm.GetList().Where(x => x.Statu == true);
            return View(values);
        }
    }
}
