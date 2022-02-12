using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.Controllers
{
    [AllowAnonymous]
    public class SecurityController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    
    }
}
