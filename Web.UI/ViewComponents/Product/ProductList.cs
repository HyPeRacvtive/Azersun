using Business.Concrete;
using DataAccess.Concrete.EFCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.ViewComponents.Product
{
    public class ProductList : ViewComponent
    {
        ProductManager pm = new ProductManager(new EFProductRepository());
        public IViewComponentResult Invoke()
        {
            var values = pm.ProductOrderByDescending(6).Where(x => x.Statu == true);
            return View(values);
        }
    }
}
