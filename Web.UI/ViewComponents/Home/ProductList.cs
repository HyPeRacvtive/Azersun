using Business.Concrete;
using DataAccess.Concrete.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.ViewComponents.Home
{
    public class ProductList : ViewComponent
    {
        ProductManager pm = new ProductManager(new EFProductRepository());
        public IViewComponentResult Invoke()
        {
            var values = pm.GetList().OrderByDescending(x => x.Id).Take(6);
            return View(values);
        }
    }
}
