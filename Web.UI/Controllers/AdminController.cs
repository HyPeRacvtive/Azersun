using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EFCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using Web.UI.Models;

namespace Web.UI.Controllers
{
    [AdminFilter]
    public class AdminController : Controller
    {
        AdminManager am = new AdminManager(new EFAdminRepository());
        SettingManager sm = new SettingManager(new EFSettingRepository());
        AboutManager abm = new AboutManager(new EFAboutRepository());
        DataContext context = new DataContext();
        public IActionResult Index()
        {
            ViewBag.ProductCount = context.Products.Count().ToString();
            ViewBag.SliderCount = context.Sliders.Count().ToString();
            ViewBag.VideoCount = context.Videos.Count().ToString();
            ViewBag.MessageCount = context.Messages.Count().ToString();
            return View();
        }
        public IActionResult Profile(int id)
        {
            var values = am.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Profile(UpdateAdminImage pImg)
        {
            var getAdmin = am.GetById(pImg.Id);
            if (pImg.Image != null)
            {
                var extension = Path.GetExtension(pImg.Image.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AdminStyle/img/AdminProfile", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                pImg.Image.CopyTo(stream);
                getAdmin.Image = newImageName;
            }
            getAdmin.Mail = pImg.Mail;
            getAdmin.Address = pImg.Address;
            getAdmin.NameSurname = pImg.NameSurname;
            getAdmin.Password = pImg.Password;
            getAdmin.Phone = pImg.Phone;
            getAdmin.UserName = pImg.UserName;
            am.Update(getAdmin);
            return RedirectToAction("Index");
        }
        /*ÜRÜNLER*/
        public IActionResult ProductList()
        {
            return View();
        }
        public IActionResult Setting(int id)
        {
            var values = sm.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Setting(UpdateSetting pImg)
        {
            var getSetting = sm.GetById(pImg.Id);
            if (pImg.Logo != null)
            {
                var extension = Path.GetExtension(pImg.Logo.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Logo", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                pImg.Logo.CopyTo(stream);
                getSetting.Logo = newImageName;
            }
            getSetting.Adress = pImg.Adress;
            getSetting.Mail = pImg.Mail;
            getSetting.Map = pImg.Map;
            getSetting.Phone = pImg.Phone;
            getSetting.ProjectText = pImg.ProjectText;
            sm.Update(getSetting);
            return RedirectToAction("Index");
        }



        public IActionResult About(int id)
        {
            var values = abm.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult About(UpdateAbout pImg)
        {
            var getAbout = abm.GetById(pImg.Id);
            if (pImg.Image != null)
            {
                var extension = Path.GetExtension(pImg.Image.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/About", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                pImg.Image.CopyTo(stream);
                getAbout.Image = newImageName;
            }
            getAbout.Text = pImg.Text;
            abm.Update(getAbout);
            return RedirectToAction("Index");
        }

        /*Partial Views*/

        public PartialViewResult _LeftSideBar()
        {
            return PartialView();
        }
    }
}
