using Business.Concrete;
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
    public class VideoController : Controller
    {
        VideosManager vm = new VideosManager(new EFVideoRepository());
        public IActionResult Index()
        {
            var values = vm.GetList().OrderByDescending(x => x.Id);
            return View(values);
        }
        public IActionResult Create() { return View(); }
        [HttpPost]
        public IActionResult Create(AddVideoImage pImg)
        {
            Videos s = new Videos();
            if (pImg.Image != null)
            {
                var extension = Path.GetExtension(pImg.Image.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Lahiye/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                pImg.Image.CopyTo(stream);
                s.Image = newImageName;
            }
            s.Link = pImg.Link;
            vm.Add(s);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var values = vm.GetById(id);
            vm.Delete(values);
            return RedirectToAction("Index");
        }

    }
}

