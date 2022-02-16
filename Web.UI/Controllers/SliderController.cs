using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EFCore;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using Web.UI.Models;

namespace Web.UI.Controllers
{
    [AdminFilter]
    public class SliderController : Controller
    {
        SliderManager sm = new SliderManager(new EFSliderRepository());
        public IActionResult Index()
        {
            var values = sm.GetList().OrderByDescending(x => x.Id);
            return View(values);
        }
        public IActionResult Create() { return View(); }
        [HttpPost]
        public IActionResult Create(AddSliderImage pImg)
        {
            Sliders s = new Sliders();
            if (pImg.Image != null)
            {
                var extension = Path.GetExtension(pImg.Image.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Slider/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                pImg.Image.CopyTo(stream);
                s.Image = newImageName;
            }
            s.Header = pImg.Header;
            s.Statu = pImg.Statu;
            s.Content = pImg.Content;
            sm.Add(s);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var values = sm.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(AddSliderImage pImg)
        {
            var getSlider = sm.GetById(pImg.Id);
            if (pImg.Image != null)
            {
                var extension = Path.GetExtension(pImg.Image.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Slider/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                pImg.Image.CopyTo(stream);
                getSlider.Image = newImageName;
            }
            getSlider.Header = pImg.Header;
            getSlider.Statu = pImg.Statu;
            getSlider.Content = pImg.Content;
            sm.Update(getSlider);
            return RedirectToAction("Index");
        }
        public IActionResult SliderStatuChange(int id)
        {
            DataContext context = new DataContext();
            Sliders slider = context.Sliders.Find(id);
            if (!slider.Statu)
            {
                slider.Statu = true;
            }
            else
            {
                slider.Statu = false;
            }
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var values = sm.GetById(id);
            sm.Delete(values);
            return RedirectToAction("Index");
        }
    }
}
