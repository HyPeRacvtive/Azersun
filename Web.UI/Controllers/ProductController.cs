using Business.Concrete;
using DataAccess.Concrete.EFCore;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using Web.UI.Models;
using X.PagedList;

namespace Web.UI.Controllers
{
    public class ProductController : Controller
    {


        ProductManager pm = new ProductManager(new EFProductRepository());
        public IActionResult Index(int page = 1)
        {
            var values = pm.GetList().ToPagedList(page, 5);
            return View(values);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AddProductImage pImg)
        {
            Product p = new Product();
            if (pImg.ProductImage != null)
            {
                var extension = Path.GetExtension(pImg.ProductImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Product/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                pImg.ProductImage.CopyTo(stream);
                p.ProductImage = newImageName;
            }
            p.ProductName = pImg.ProductName;
            p.Stock = pImg.Stock;
            p.Width = pImg.Width;
            p.Height = pImg.Height;
            p.Stock = pImg.Stock;
            p.Statu = pImg.Statu;
            pm.Add(p);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var values = pm.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(AddProductImage pImg)
        {
            Product p = new Product();
            if (pImg.ProductImage != null)
            {
                var extension = Path.GetExtension(pImg.ProductImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Product/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                pImg.ProductImage.CopyTo(stream);
                p.ProductImage = newImageName;
            }
            p.ProductName = pImg.ProductName;
            p.Stock = pImg.Stock;
            p.Width = pImg.Width;
            p.Height = pImg.Height;
            p.Stock = pImg.Stock;
            p.Statu = pImg.Statu;
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
