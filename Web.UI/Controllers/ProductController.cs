using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Concrete.EFCore;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Web.UI.Controllers
{
    public class ProductController : Controller
    {
        ProductManager pm = new ProductManager(new EFProductRepository());
        public IActionResult Index()
        {
            var values = pm.GetList();
            return View(values);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            ProductValidator pv = new ProductValidator();
            ValidationResult results = pv.Validate(p);
            if (results.IsValid)
            {
                p.ProductImage = "1";

                pm.Add(p);
                return RedirectToAction("Index", "Product");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            var values = pm.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(Product p)
        {
           
            pm.Update(p);   
            return RedirectToAction("Index");
        }



        public IActionResult Delete(int id)
        {
            var values = pm.GetById(id);
            pm.Delete(values);
            return RedirectToAction("Index");
        }
    }
}
