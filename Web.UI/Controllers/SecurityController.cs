using DataAccess.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Web.UI.Controllers
{
    [AllowAnonymous]
    public class SecurityController : Controller
    {
        DataContext context = new DataContext();
        public IActionResult Login() { return View(); }
        [HttpPost]
        public async Task<IActionResult> Login(Admin a)
        {
            DataContext context = new DataContext();
            var dataValue = context.Admins.FirstOrDefault(x => x.UserName == a.UserName && x.Password == a.Password);
            if (dataValue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, a.UserName)
                };
                HttpContext.Session.SetInt32("Id", dataValue.Id);
                HttpContext.Session.SetString("NameSurname", dataValue.NameSurname);
                HttpContext.Session.SetString("Image", dataValue.Image);
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

    }
}
